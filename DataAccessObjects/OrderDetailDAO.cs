using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static object lockOject = new object();
        public OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> GetOrderDetails()
        {
            using var db = new FStoreDBContext();
            return db.OrderDetails.ToList();
        }
        public List<OrderDetail> GetOrderDetailsDeascend()
        {
            using var db = new FStoreDBContext();
            return db.OrderDetails.OrderByDescending(f => f.OrderId).ToList();
        }
        public List <OrderDetail> GetOrderDetailsByOrderId(int txtOrderId)
        {
            using var db = new FStoreDBContext();
            return db.OrderDetails.Where(f => f.OrderId.Equals(txtOrderId)).ToList();
        }
        public Order GetOrderOfOrderDetail(int txtOrderId) 
        {
            using var db = new FStoreDBContext();
            return db.Orders.SingleOrDefault(f => f.OrderId.Equals(txtOrderId));
        }
        public int GetTotalSoldProduct(DateTime startDate, DateTime endDate)
        {
            List<OrderDetail> orderDetails = GetOrderDetails();
            int total = 0;
            foreach (var orderDetail in orderDetails) 
            {
                var order = GetOrderOfOrderDetail(orderDetail.OrderId);
                if (order.ShippedDate != null)
                {
                    if ((order.ShippedDate.Value.Date >= startDate.Date) && (order.ShippedDate.Value.Date <= endDate.Date))
                    {
                        total += orderDetail.Quantity;
                    }
                }
            }
            return total;
        }
        public List<OrderDetail> GetOrderDetailsInPeriodTime(DateTime startDate, DateTime endDate)
        {
            List<OrderDetail> orderDetails = GetOrderDetailsDeascend();
            List<OrderDetail> orderDetailsInPriodTime = new List<OrderDetail>();
            foreach (var orderDetail in orderDetails)
            {
                var order = GetOrderOfOrderDetail(orderDetail.OrderId);
                if (order.ShippedDate != null)
                {
                    if ((order.ShippedDate.Value.Date >= startDate.Date) && (order.ShippedDate.Value.Date <= endDate.Date))
                    {
                        orderDetailsInPriodTime.Add(orderDetail);
                    }
                }
            }
            return orderDetailsInPriodTime;
        }
        public List<OrderDetail> orderDetails;
        private void InitilizeOrderDetailsCart()
        {
            if (this.orderDetails == null)
            {
                this.orderDetails = new List<OrderDetail>();
            }
        }
        private bool IsProductExist(string productId)
        {
            foreach (var item in this.orderDetails)
            {
                if (item.FlowerBouquetId.Equals(productId))
                {
                    return true;
                }
            }
            return false;
        }
        private OrderDetail FindOrderDetailInCart(int productId)
        {
            foreach (var item in orderDetails)
            {
                if (item.FlowerBouquetId.Equals(productId))
                {
                    return item;
                }
            }
            return null;
        }
        public void AddProductToCart(OrderDetail orderDetail) { 
            InitilizeOrderDetailsCart();
            if (IsProductExist(orderDetail.FlowerBouquetId.ToString()))
            {
                FindOrderDetailInCart(orderDetail.FlowerBouquetId).Quantity += orderDetail.Quantity;
            }
            else
            {
                this.orderDetails.Add(orderDetail);
            }
        }
        private bool UpdateProductQuantity(int flowerBouquetId, int quantity)
        {
            using var db = new FStoreDBContext();
            FlowerBouquet flower = db.FlowerBouquets.SingleOrDefault(f => f.FlowerBouquetId.Equals(flowerBouquetId));
            flower.UnitPrice -= quantity;
            db.FlowerBouquets.Update(flower);
            var change = db.SaveChanges();
            return change > 0;
        }
        public bool CreateOrderDetail(List<OrderDetail> orderDetails)
        {
            using var db = new FStoreDBContext();
            foreach (var item in orderDetails)
            {
                if (UpdateProductQuantity(item.FlowerBouquetId, item.Quantity))
                {
                    db.OrderDetails.Add(item);
                }
            }
            var check = db.SaveChanges();
            return check > 0;
        }
        public bool DeteleOrderDetailsByOrderId(int orderId)
        {
            using var db = new FStoreDBContext();
            List<OrderDetail> orderDetails = db.OrderDetails.Where(f => f.OrderId ==  orderId).ToList();
            var index = orderDetails.Count;
            foreach (var item in orderDetails)
            {
                db.OrderDetails.Remove(item);
            }
            var change = db.SaveChanges() == index;
            return change;
        }
    }
}
