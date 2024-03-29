using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();
        List<OrderDetail> GetOrderDetailsByOrderId(int txtOrderId);
        void AddProductToCart(OrderDetail orderDetail);
        int GetTotalSoldProduct(DateTime startDate, DateTime endDate);
        List<OrderDetail> GetOrderDetailsInPeriodTime(DateTime startDate, DateTime endDate);
        bool CreateOrderDetail(List<OrderDetail> orderDetails);
    }
}
