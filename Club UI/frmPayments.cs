using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubClassLibrary.Repository;
using ClubClassLibrary.Interfaces;
using Club_UI.ViewModels;
using ClubClassLibrary.Models;
namespace Club_UI
{
    public partial class frmPayments : Form
    {
        private readonly IMembershipRepository membershiprepo = new MembershipRepository();
        private readonly IMemberRepository memberrepo = new MemberRepository();
        private readonly IPaymentRepository paymentrepo = new PaymentRepository();
        private int _paymentId;
        private int _paymentType;//0 for cash, 1 for credit card, 2 for debit card ,may not use
        private int _memberId;
        private int _membershipId;
        public string _role;
        public frmPayments(string role)
        {
            _role = role;
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            Show_payments();
            Show_membersAndThereMemberships();
            Add_mode();
        }
        private async void Show_payments()
        {
            var Data = await paymentrepo.GetAll();
            var selectedData = Data.Select(x => new PaymentVM
            {
                Id = x.Id,
                MemberId = x.MemberId,
                MembershipId = x.MembershipId,
                MemberName = x.Member.Name,
                MembershipName = x.Membership.MembershipType.Name,
                Amount = x.Membership.MembershipType.BasePrice,
                AmountPaid = x.Amount,
                PaymentMethod = x.PaymentMethod,
                PaymentDate = x.PaymentDate,
            }).ToList();
            grdPayments.DataSource = selectedData;
            grdPayments.Columns[0].Visible = false;
            grdPayments.Columns[1].Visible = false;
            grdPayments.Columns[2].Visible = false;
        }

        private async void Show_membersAndThereMemberships()
        {
            var Data = await memberrepo.GetAll();
            if (combMember != null)
            {
                combMember.DataSource = Data;
                combMember.DisplayMember = "Name";
                combMember.ValueMember = "Id";
            }

            if (_memberId != 0)
            {
                var Data2 = await membershiprepo.GetAll() ?? new List<Membership>();
                var selectedData = Data2
                    .Where(x => x.MemberId == _memberId)
                    .Select(x => new { Id = x.Id, MembershipTypeName = x.MembershipType?.Name ?? "Unknown" })
                    .ToList();

                if (combMembership != null)
                {
                    combMembership.DataSource = selectedData;
                    combMembership.DisplayMember = "MembershipTypeName";
                    combMembership.ValueMember = "Id";
                }
            }
        }



        private async void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (combMember.SelectedValue == null || combMembership.SelectedValue == null || txtbAmount.Text == "" || combMethod.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            
            Payment payment = new Payment()
            {
                PaymentMethod = combMethod.Text,
                Amount = Convert.ToDecimal(txtbAmount.Text),
                MemberId = Convert.ToInt32(combMember.SelectedValue),
                MembershipId = Convert.ToInt32(combMembership.SelectedValue),
            };
            await paymentrepo.Add(payment);
            MessageBox.Show("Payment added successfully");
            Clear();
            Show_payments();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Add_mode();
        }

        private void Clear()
        {
            combMember = null;
            combMembership = null;
            txtbAmount.Text = "";
            combMethod = null;
        }
        private void Add_mode()
        {
            btnAddPayment.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            Clear();
        }
        private void Update_mode()
        {
            btnAddPayment.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void grdPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex>=0 &&e.RowIndex>=0)
            {
                _paymentId = Convert.ToInt32(grdPayments.Rows[e.RowIndex].Cells[0].Value);
                _memberId = Convert.ToInt32(grdPayments.Rows[e.RowIndex].Cells[1].Value);
                _membershipId = Convert.ToInt32(grdPayments.Rows[e.RowIndex].Cells[2].Value);
                combMember.SelectedValue = _memberId;//
                combMembership.SelectedValue = _membershipId;//
                txtbAmount.Text = grdPayments.Rows[e.RowIndex].Cells[3].Value.ToString();
                combMethod.Text = grdPayments.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
