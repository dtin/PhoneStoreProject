﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface ITblOrderDetailDAO
    {
        //Add Items to Order by OrderID
        bool AddItemsToOrder(string OrderID, int ProductID, int Quantity, long Price);

        //Get all Items in an Order by OrderID
        List<TblOrderDetail> GetItemsByOrderID(string OrderID);

        //Delete all Items by OrderID
        bool DeleteOrderDetails(string OrderID);
    }
}
