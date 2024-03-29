using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static object lockOject = new object();
        private static OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        public OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public List<Order> GetOrders()
        {
            using var db = new FStoreDBContext();
            return db.Orders.ToList();
        }
        public Order GetOrderById(int orderId)
        {
            using var db = new FStoreDBContext();
            return db.Orders.SingleOrDefault(f => f.OrderId.Equals(orderId));
        }
        public List<Order> GetOrdersByCustomerID(int txtCustomerId) 
        {
            using var db = new FStoreDBContext();
            return db.Orders.Where(f => f.CustomerId.Equals(txtCustomerId)).ToList();
        }
        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = GetOrders();
            decimal total = 0;
            foreach (Order order in orders)
            {
                if (order.ShippedDate != null)
                {
                    if ((order.ShippedDate.Value.Date >= startDate.Date) && (order.ShippedDate.Value.Date <= endDate.Date))
                    {
                        total += order.Total.Value;
                    }
                }
            }
            return total;
        }
        public int GetOrderQuantity(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = GetOrders();
            int count = 0;
            foreach (Order order in orders)
            {
                if (order.ShippedDate != null)
                {
                    if ((order.ShippedDate >= startDate) && (order.ShippedDate <= endDate))
                    {
                        count += 1;
                    }
                }
                
            }
            return count;
        }
        public bool CreateOrder(Order order) 
        {
            using var db = new FStoreDBContext();
            db.Orders.Add(order);
            var check = db.SaveChanges();
            return check > 0;
        }
        public bool UpdateOrder(Order order)
        {
            using var db = new FStoreDBContext();
            if (GetOrderById(order.OrderId) != null)
            {
                db.Orders.Update(order);
                var change = db.SaveChanges();
                return change > 0;
            }
            return false;
        }
        public bool DeleteOrder(int orderId)
        {
            using var db = new FStoreDBContext();
            var order = GetOrderById(orderId);
            if (order.ShippedDate != null)
            {
                if (orderDetailDAO.DeteleOrderDetailsByOrderId(orderId))
                {
                    db.Orders.Remove(GetOrderById(orderId));
                    var check = db.SaveChanges();
                    return check > 0;
                }
            }
            return false;
        }
    }
}
