﻿using ManagePhone.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Views
{
    public interface IOrderView : IView
    {
        string OrderID { get; }
        IList<OrderModel> OrderList { set; }
    }
}
