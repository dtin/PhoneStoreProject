﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmAddEmployee : Form {
        public frmAddEmployee() {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
