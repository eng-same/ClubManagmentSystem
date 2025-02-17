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
using ClubClassLibrary.Data;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
namespace Club_UI
{
    public partial class frmMembershipsType : Form
    {
        MembershipTypeRepository repo = new MembershipTypeRepository();
        private int  selected_id=0;
        public frmMembershipsType()
        {
            InitializeComponent();
        }

        private void frmMembershipsType_Load(object sender, EventArgs e)
        {
            Show_data();
            labShowUser.Text = "Admain";
            Add_mode();

        }

        private async void Show_data()
        {   //show all data in gridview except id
            var data = await repo.GetAll();
            //select only the columns that we want to show
            var selectedData = data.Select(x => new { x.Id, x.Name, x.Description, x.BasePrice });
            grdmembershipTypes.DataSource = selectedData.ToList();
            //change the header text
            grdmembershipTypes.Columns[0].Visible = false;
            grdmembershipTypes.Columns[1].HeaderText = "Name";
            grdmembershipTypes.Columns[2].HeaderText = "Description";
            grdmembershipTypes.Columns[3].HeaderText = "Price";
        }

        private async void btnAddMembershipType_Click(object sender, EventArgs e)
        {
            //not implemented completey, still have to make validation
            await repo.Add(new MembershipType { Name = txtbName.Text, Description = txtbDiscription.Text, BasePrice = Convert.ToDecimal(txtbBasebrice.Text) });
            Clear();
            MessageBox.Show("MembershipType Added succfully ", "done");
            Show_data();
        }

        private async void btnDeleteMembershipType_Click(object sender, EventArgs e)
        {
            if (selected_id > 0)
            {
                await repo.Delete(selected_id);
                MessageBox.Show("MembershipType deleted successfully", "Done");
                Clear();
                Show_data();
            }


            Add_mode();
        }

        private async void btnUpdateMembershipType_Click(object sender, EventArgs e)
        {
            if (selected_id > 0)
            {
                var data = repo.GetById(selected_id).Result;
                data.Name = txtbName.Text;
                data.Description = txtbDiscription.Text;
                data.BasePrice = Convert.ToDecimal(txtbBasebrice.Text);
                await repo.Update(data);
                Clear();
                MessageBox.Show("MembershipType Updated successfully", "Done");
                Show_data();
            }
                Add_mode();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labShowTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Edit_mode()
        {
            txtbName.Focus();
            btnAddMembershipType.Enabled = false;
            btnDeleteMembershipType.Enabled = true;
            btnUpdateMembershipType.Enabled = true;
        }
        private void Add_mode()
        {
            txtbName.Focus();
            btnAddMembershipType.Enabled = true;
            btnDeleteMembershipType.Enabled = false;
            btnUpdateMembershipType.Enabled = false;
        }
        private void Clear()
        {
            txtbName.Text = "";
            txtbDiscription.Text = "";
            txtbBasebrice.Text = "";
            txtbName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Add_mode();
        }

        private void grdmembershipTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex>=0 &&e.RowIndex>=0 )
            {
                int id= selected_id = Convert.ToInt32(grdmembershipTypes.Rows[e.RowIndex].Cells[0].Value);
                var data = repo.GetById(id).Result;
                txtbName.Text = data.Name;
                txtbDiscription.Text = data.Description;
                txtbBasebrice.Text = data.BasePrice.ToString();
                Edit_mode();

            }
        }
    }
}
