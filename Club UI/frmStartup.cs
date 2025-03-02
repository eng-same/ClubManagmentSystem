namespace Club_UI
{
    public partial class frmStartup : Form
    {
        public string _role; //set in the login form
        public frmStartup()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            //not implemented yet
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            labShowUser.Text = _role;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout(_role);
            frm.ShowDialog();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            labShowTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //completed
        }
        private void btnMemberships_Click(object sender, EventArgs e)
        {
            frmMemberships frm = new frmMemberships(_role);//done
            frm.ShowDialog();
            //completed
        }


        private void btnMembershipstype_Click(object sender, EventArgs e)
        {
            frmMembershipsType frm = new frmMembershipsType(_role);//done
            frm.ShowDialog();
            //completed
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments(_role);//still working on it
            frm.ShowDialog();
            //completed
        }
        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers(_role);//done
            frm.ShowDialog();
            //completed
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close this form?", "Close this form", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuStripMembersInfo_Click(object sender, EventArgs e)
        {
            if (_role == "Admin")
            {
                frmQuiries frm = new frmQuiries(_role);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this form" ,"Close");
            }
            
        }
    }
}
