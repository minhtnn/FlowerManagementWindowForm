using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddProductToCart(OrderDetail orderDetail)
            => OrderDetailDAO.Instance.AddProductToCart(orderDetail);

        public List<OrderDetail> GetOrderDetailsByOrderId(int txtOrderId)
            => OrderDetailDAO.Instance.GetOrderDetailsByOrderId(txtOrderId);

        public List<OrderDetail> GetOrderDetails()
            => OrderDetailDAO.Instance.GetOrderDetails();

        public int GetTotalSoldProduct(DateTime startDate, DateTime endDate)
            => OrderDetailDAO.Instance.GetTotalSoldProduct(startDate, endDate);
        public List<OrderDetail> GetOrderDetailsInPeriodTime(DateTime startDate, DateTime endDate)
            => OrderDetailDAO.Instance.GetOrderDetailsInPeriodTime(startDate, endDate);

        public bool CreateOrderDetail(List<OrderDetail> orderDetails)
            => OrderDetailDAO.Instance.CreateOrderDetail(orderDetails);
    }
}
