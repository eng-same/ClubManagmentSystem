namespace Club_UI
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            labShowUser.Text = "Admain";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnMemberships_Click(object sender, EventArgs e)
        {
            frmMemberships frm = new frmMemberships();
            frm.ShowDialog();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            labShowTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnMembershipstype_Click(object sender, EventArgs e)
        {
            frmMembershipsType frm = new frmMembershipsType();
            frm.ShowDialog();
        }
    }
}
