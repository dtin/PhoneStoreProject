﻿using ManagePhone.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone
{
    public partial class frmAddOrder : Form
    {
        public frmAddOrder()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmManager frmManager = new frmManager();
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            (new frmAddCustomer()).ShowDialog();
        }
    }
}
