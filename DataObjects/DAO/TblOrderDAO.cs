﻿using BusinessObjects;
using DataObjects.AdoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DAO
{
    public class TblOrderDAO : ITblOrderDAO
    {
        static Db db = new Db();

        static Func<IDataReader, TblOrder> Make = reader =>
        new TblOrder
        {
            OrderID = reader["orderID"].ToString(),
            CustomerID = int.Parse(reader["customerID"].ToString()),
            OrderDate = DateTime.Parse(reader["orderDate"].ToString()),
            EmployeeID = reader["employeeID"].ToString(),
            TotalPrice = long.Parse(reader["totalPrice"].ToString()),
            StatusID = int.Parse(reader["statusID"].ToString())
        };

        public bool AddOrder(TblOrder Order)
        {
            string StoreProc = "spAddOrder";
            object[] parms = 
            { 
                "@CustomerID", Order.CustomerID,
                "@EmployeeID", Order.EmployeeID,
                "@TotalPrice", Order.TotalPrice
            };
            return db.Update(StoreProc, parms) > 0;
        }

        public bool DeleteOrder(string OrderID)
        {
            string StoreProc = "spDeleteOrder";
            object[] parms = { "@OrderID", OrderID };
            return db.Update(StoreProc, parms) > 0;
        }

        public TblOrder GetLastestOrder(int CustomerID)
        {
            string StoreProc = "spGetLastestOrder";
            object[] parms = { "@CustomerID", CustomerID };
            return db.Read(StoreProc, Make, parms).FirstOrDefault();
        }

        public List<TblOrder> GetListOrders()
        {
            string StoreProc = "spGetOrderList";
            return db.Read(StoreProc, Make).ToList();
        }

        public List<TblOrder> SearchOrder(string OrderID)
        {
            string StoreProc = "spSearchOrder";
            object[] parms = { "@OrderID", "%" + OrderID + "%" };
            return db.Read(StoreProc, Make, parms).ToList();
        }
    }
}
