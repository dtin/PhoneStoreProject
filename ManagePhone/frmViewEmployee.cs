﻿using ManagePhone.Models.Models;
using ManagePhone.Presenters;
using ManagePhone.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmViewEmployee : Form, IEmployeesView {
        public string EmployeeID { get; set; }

        public string EmployeeName
        {
            get => txtSearchEmployeeName.Text;
        }

        public IList<EmployeeModel> EmployeeList
        {
            set
            {
                var EmployeeList = value;
                BindingData(EmployeeList);
            }
        }

        //The presenter
        ViewEmployeePresenter _viewEmployeePresenter;

        public frmViewEmployee() {
            InitializeComponent();
            _viewEmployeePresenter = new ViewEmployeePresenter(this);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e) {
            frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
            this.Hide();
            updateEmployee.ShowDialog();
            this.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e) {
            _viewEmployeePresenter.DeleteEmployee();
            _viewEmployeePresenter.LoadEmployees();
        }

        private void btnCancelEmployee_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BindingData(IList<EmployeeModel> EmployeeList)
        {
            dgvListEmployee.DataSource = EmployeeList;

            //Clear Binding data textbox
            txtSearchEmployeeName.DataBindings.Clear();

            //Binding data to textbox
            txtSearchEmployeeName.DataBindings.Add("Text", EmployeeList, "Name");
        }
    }
}
