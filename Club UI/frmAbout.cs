﻿using System;
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
    public partial class frmAbout : Form
    {
        public string _role;
        public frmAbout(string role)
        {
            InitializeComponent();
            _role = role;
        }
    }
}
