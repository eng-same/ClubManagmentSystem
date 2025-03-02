using ClubClassLibrary.Repository;
using ClubClassLibrary.Models;
using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using Club_UI.ViewModels;
namespace Club_UI
{
    public partial class frmMemberships : Form
    {
        private readonly IMembershipRepository _membershiprepo = new MembershipRepository();
        private readonly IMemberRepository _memberrepo = new MemberRepository();
        private readonly IMembershipTypeRepository _membershipTyperepo = new MembershipTypeRepository();
        private int selectedMember_id = 0;
        private int selectedMembership_id = 0;
        private int selectedMembershipType_id = 0;
        public frmMemberships()
        {
            InitializeComponent();
            labShowUser.Text = "Admin";
        }
        public frmMemberships(string role)
        {
            InitializeComponent();
            labShowUser.Text = role;
            if (role == "User")
            {
                btnDelete.Enabled = false;
            }
        }

        private void frmMemberships_Load(object sender, EventArgs e)
        {
            Show_members();
            Show_membership();
            Show_membershipType();
            Add_mode();
        }

        private async void Show_members()
        {
            var members = await _memberrepo.GetAll();
            var selectedMembers = members.Select(x => new { x.Id, x.Name, x.PhoneNumber });
            combMembers.DataSource = selectedMembers.ToList();
            combMembers.DisplayMember = "Name";
            combMembers.ValueMember = "Id";
        }

        private async void Show_membership()
        {
            var membership = await _membershiprepo.GetAll();
            var selectedMembership = membership.Select(x => new MembershipVM
            {
                Id = x.Id,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                MemberName = x.Member.Name,
                MembershipTypeName = x.MembershipType.Name,
                Price = x.Price,
            }).ToList();
            grdMemberships.DataSource = selectedMembership;
            grdMemberships.Columns[0].Visible = false;
            grdMemberships.Columns[1].HeaderText = "StartDate";
            grdMemberships.Columns[2].HeaderText = "EndDate";
            grdMemberships.Columns[3].HeaderText = "MemberName";
            grdMemberships.Columns[4].HeaderText = "MembershipTypeName";
            grdMemberships.Columns[5].HeaderText = "Price";
        }

        private async void Show_membershipType()
        {
            var membershipType = await _membershipTyperepo.GetAll();
            combMembershipTypes.DataSource = membershipType;
            combMembershipTypes.DisplayMember = "Name";
            combMembershipTypes.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMembership_id != 0)
            {
                _membershiprepo.Delete(selectedMembership_id);
                MessageBox.Show("Membership deleted successfully");
                Clear();
                Show_membership();
                Add_mode();
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (combMembers.SelectedValue != null && combMembershipTypes.SelectedValue != null)
            {
                selectedMember_id = (int)combMembers.SelectedValue;
                selectedMembershipType_id = (int)combMembershipTypes.SelectedValue;
                Membership membership = new()
                {
                    MemberId = selectedMember_id,
                    MembershipTypeId = selectedMembershipType_id,
                    Price = Convert.ToDecimal(txtbPrice.Text),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value
                };
                await _membershiprepo.Add(membership);
                MessageBox.Show("Membership added successfully");
                Clear();
                Show_membership();
                Add_mode();
            }
            else
            {
                MessageBox.Show("Please select a member and a membership type.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMembership_id != 0)
            {
                Membership membership = await _membershiprepo.GetById(selectedMembership_id);
                membership.Id = selectedMembership_id;
                membership.MemberId = selectedMember_id;
                membership.MembershipTypeId = selectedMembershipType_id;
                membership.Price = Convert.ToDecimal(txtbPrice.Text);
                membership.StartDate = dtpStartDate.Value;
                membership.EndDate = dtpEndDate.Value;
                await _membershiprepo.Update(membership);
                MessageBox.Show("Membership updated successfully");
                Clear();
                Show_membership();
                Add_mode();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clear();
            var result = MessageBox.Show("Are you sure you want to close this form?", "Close this form", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            Add_mode();
        }

        private async void grdMemberships_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.grdMemberships.Rows[e.RowIndex];
                selectedMembership_id = Convert.ToInt32(row.Cells[0].Value);
                var membership = await _membershiprepo.GetById(selectedMembership_id);
                txtbPrice.Text = membership.Price.ToString();
                dtpStartDate.Value = membership.StartDate;
                dtpEndDate.Value = membership.EndDate;
                combMembershipTypes.SelectedValue = membership.MembershipTypeId;
                combMembers.SelectedValue = membership.MemberId;
                selectedMember_id = membership.MemberId;
                Edit_mode();
            }
        }

        //private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //    {
        //        DataGridViewRow row = this.grdMembers.Rows[e.RowIndex];
        //        selectedMember_id = Convert.ToInt32(row.Cells[0].Value);
        //    }
        //}

        private void Edit_mode()
        {
            txtbPrice.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void Add_mode()
        {
            txtbPrice.Focus();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void Clear()
        {
            txtbPrice.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtbPrice.Focus();
        }//still have to review this form....
    }
}
