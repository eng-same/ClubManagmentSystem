using ClubClassLibrary.Models;
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

namespace Club_UI
{
    public partial class frmMembers : Form
    {
        MemberRepository repo = new MemberRepository();
        private int selected_id = 0;
        public string _role;
        public frmMembers(string role)
        {
            InitializeComponent();
            _role = role;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            //set the data source of the grid view to the list of members
            Show_data();
            labShowUser.Text = _role;
            Add_mode();
        }

        private async void Show_data()
        {   //show all data in gridview except id
            var data = await repo.GetAll();
            //select only the columns that we want to show
            var selectedData = data.Select(x => new { x.Id, x.Name, x.PhoneNumber,x.Address ,x.BirthDate ,x.JoinDate });
            grdMembers.DataSource = selectedData.ToList();
            //change the header text
            grdMembers.Columns[0].Visible = false;
            grdMembers.Columns[1].HeaderText = "Name";
            grdMembers.Columns[2].HeaderText = "PhoneNumber";
            grdMembers.Columns[3].HeaderText = "Address";
            grdMembers.Columns[4].HeaderText = "BirthDate";
            grdMembers.Columns[5].HeaderText = "JoinDate";
        }

        private async void btnAddMembers_Click(object sender, EventArgs e)
        {
            //not implemented completey, still have to make validation
            //join date is set in the model to the current date
            await repo.Add(new Member { Name = txtbName.Text, PhoneNumber = txtbPhoneNumber.Text, Address=txtbAddress.Text ,BirthDate=dtpBirthDate.Value });
            Clear();
            MessageBox.Show("Member Added succfully ", "done");
            Show_data();
        }

        private async void btnUpdateMembers_Click(object sender, EventArgs e)
        {
            if (selected_id > 0)
            {
                var member = await repo.GetById(selected_id);
                member.Name = txtbName.Text;
                member.PhoneNumber = txtbPhoneNumber.Text;
                member.Address = txtbAddress.Text;
                member.BirthDate = dtpBirthDate.Value;
                await repo.Update(member);
                MessageBox.Show("MembershipType deleted successfully", "Done");
                Clear();
                Show_data();
            }


            Add_mode();
        }

        private async void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (selected_id > 0)
            {
                await repo.Delete(selected_id);
                MessageBox.Show("MembershipType updated successfully", "Done");
                Clear();
                Show_data();
            }

            Add_mode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close this form?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Add_mode();
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                selected_id = Convert.ToInt32(grdMembers.Rows[e.RowIndex].Cells[0].Value);
                var data = repo.GetById(selected_id).Result;
                txtbName.Text = data.Name;
                txtbPhoneNumber.Text = data.PhoneNumber;
                txtbAddress.Text = data.Address;
                dtpBirthDate.Value = data.BirthDate;
                Edit_mode();

            }
        }

        private void Edit_mode()
        {
            txtbName.Focus();
            btnAddMembers.Enabled = false;
            btnDeleteMember.Enabled = true;
            btnUpdateMembers.Enabled = true;
        }
        private void Add_mode()
        {
            txtbName.Focus();
            btnAddMembers.Enabled = true;
            btnDeleteMember.Enabled = false;
            btnUpdateMembers.Enabled = false;
        }
        private void Clear()
        {
            txtbName.Text = "";
            txtbAddress.Text = "";
            txtbPhoneNumber.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtbName.Focus();
        }
    }
}
