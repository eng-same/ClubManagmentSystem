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

namespace Club_UI
{
    public partial class frmLoging : Form
    {
        UserRepository _userRepository = new UserRepository();
        public frmLoging()
        {
            InitializeComponent();
        }

        private void frmLoging_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbUserName.Text) || string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                MessageBox.Show("Please enter your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_userRepository.UserExists(txtbUserName.Text, txtbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;

                frmStartup frm = new frmStartup();
                frm._role = _userRepository.GetRole(txtbUserName.Text);
                this.Hide();
                Clear();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to close The program?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtbUserName.Text = "";
            txtbPassword.Text = "";
            txtbUserName.Focus();
        }
    }
}
