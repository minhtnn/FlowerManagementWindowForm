using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        List<Order> GetOrdersByCustomerID(int txtCustomerId);
        decimal GetTotalRevenue(DateTime startDate, DateTime endDate);
        int GetOrderQuantity(DateTime startDate, DateTime endDate);
        bool CreateOrder(Order order);
        Order GetOrderById(int orderId);
        bool UpdateOrder(Order order);
        bool DeleteOrder(int orderId);
    }
}
