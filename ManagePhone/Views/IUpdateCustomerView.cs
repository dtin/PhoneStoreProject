﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IUpdateCustomerView : IView
    {
        int CustomerID { get; }
        string CustomerName { get; set; }
        DateTime DOB { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
    }
}
