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
        public frmMembershipsType()
        {
            InitializeComponent();
            Show_data();
        }

        private  void frmMembershipsType_Load(object sender, EventArgs e)
        {
             Show_data();
        }

        private  void Show_data()
        {
            grdmembershipTypes.DataSource = repo.GetAAll();
        }
    }
}
