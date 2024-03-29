using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(Order order)
            => OrderDAO.Instance.CreateOrder(order);

        public bool DeleteOrder(int orderId)
            => OrderDAO.Instance.DeleteOrder(orderId);

        public Order GetOrderById(int orderId)
            => OrderDAO.Instance.GetOrderById(orderId);

        public int GetOrderQuantity(DateTime startDate, DateTime endDate)
            => OrderDAO.Instance.GetOrderQuantity(startDate, endDate);

        public List<Order> GetOrders()
            => OrderDAO.Instance.GetOrders();

        public List<Order> GetOrdersByCustomerID(int txtCustomerId)
            => OrderDAO.Instance.GetOrdersByCustomerID(txtCustomerId);

        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
            => OrderDAO.Instance.GetTotalRevenue(startDate, endDate);

        public bool UpdateOrder(Order order)
            => OrderDAO.Instance.UpdateOrder(order);
    }
}
