﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagePhone.Models.Models
{
    public class OrderDetailModel
    {
        public int OrderDetailID { get; set; }
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public long ItemPrice { get; set; }
    }
}
