using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Reporting.WinForms;
using Club_UI.ViewModels;

namespace Club_UI
{
    public partial class frmQuiries : Form
    {
        List<Membership> Query = new List<Membership>();
        private string _role;
        private readonly MembershipRepository _membershiprepo = new MembershipRepository();
        public frmQuiries(string role)
        {
            InitializeComponent();
            _role = role;
        }

        private async void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (rbPrice.Checked && !txtbPriceFrom.Text.IsNullOrEmpty() && !txtbPriceTo.Text.IsNullOrEmpty())
            {
                Query.AddRange(await Filter_Price(Convert.ToDecimal(txtbPriceFrom.Text), Convert.ToDecimal(txtbPriceTo.Text)));
            }
            else if (rbStartDate.Checked)
            {
                Query.AddRange(await Filter_StartDate(dtpStartDateFrom.Value, dtpStartDateTo.Value));
            }
            else if (rbEndDate.Checked)
            {
                Query.AddRange(await Filter_EndDate(dtpEndDateFrom.Value, dtpEndDateTo.Value));
            }
            else
            {
                FillDataGrid();
            }

            dgvResults.DataSource = Query;
        }

        private void FillDataGrid()
        {
            dgvResults.DataSource = _membershiprepo.GetAll();

        }

        private async Task<List<Membership>> Filter_Price(decimal price_from, decimal price_to)
        {
            if (price_from > price_to)
            {
                MessageBox.Show("Price From cannot be greater than Price To");
                return new List<Membership>();
            }
            var Query = await _membershiprepo.GetByPrice(price_from, price_to);
            return Query;
        }

        async Task<List<Membership>> Filter_StartDate(DateTime DateStart_from, DateTime DateStart_to)
        {
            if (DateStart_from > DateStart_to)
            {
                MessageBox.Show("Start Date From cannot be greater than Start Date To");
                return new List<Membership>();
            }
            var Query = await _membershiprepo.GetByStartDate(DateStart_from, DateStart_to);
            return Query;
        }
        private async Task<List<Membership>> Filter_EndDate(DateTime DateEnd_from, DateTime DateEnd_to)
        {
            if (DateEnd_from > DateEnd_to)
            {
                MessageBox.Show("End Date From cannot be greater than End Date To");
                return new List<Membership>();
            }
            var Query = await _membershiprepo.GetByEndDate(DateEnd_from, DateEnd_to);
            return Query;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var selected_data =Query.Select(m=> new MembershipVM
            {
                Id = m.Id,
                EndDate = m.EndDate,
                StartDate = m.StartDate,
                MemberName = m.Member.Name,
                MembershipTypeName = m.MembershipType.Name,
                Price = m.Price

            } ).ToList();
            frmprint frm = new frmprint();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "Club_UI.Reports.ReportMembers.rdlc";// wrong name it should be ReportMembership
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMembership", selected_data));
            frm.reportViewer1.RefreshReport();
            frm.ShowDialog();
        }
    }
}
