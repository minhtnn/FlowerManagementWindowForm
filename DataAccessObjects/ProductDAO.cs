using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static object lockOject = new object();
        public ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
        public List<FlowerBouquet> GetProducts()
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.ToList();
        }
        public FlowerBouquet GetProductById(int id)
        {
            using var db = new FStoreDBContext();
            var flowerBouquet = db.FlowerBouquets.SingleOrDefault(f => f.FlowerBouquetId.Equals(id));
            return flowerBouquet;
        }
        public List<FlowerBouquet> GetProductByUnitPrice(decimal lowerPrice, decimal upperPrice)
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => (f.UnitPrice >= lowerPrice) && (f.UnitPrice <= upperPrice)).ToList();
        }
        public List<FlowerBouquet> GetProductUnitInStock()
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => (f.UnitsInStock > 0)).ToList();
        }
        public List<FlowerBouquet> GetProductsByName(string name)
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => f.FlowerBouquetName.Contains(name)).ToList();
        }
        public List<FlowerBouquet> GetProductsByLowerPrice(decimal lowerPrice)
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => f.UnitPrice >= lowerPrice).ToList();
        }
        public List<FlowerBouquet> GetProductsByUpperPrice(decimal upperPrice)
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => f.UnitPrice <= upperPrice).ToList();
        }
        public List<FlowerBouquet> GetProductsByAmountPrice(decimal lowerPrice, decimal upperPrice)
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.Where(f => f.UnitPrice <= upperPrice && f.UnitPrice >= lowerPrice).ToList();
        }
        public List<FlowerBouquet> ArrangeProductDecline()
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.OrderByDescending(f => f.FlowerBouquetName).ToList();
        }
        public List<FlowerBouquet> ArrangeProductAscend()
        {
            using var db = new FStoreDBContext();
            return db.FlowerBouquets.OrderBy(f => f.FlowerBouquetName).ToList();
        }
        public bool IsFlowerBouquetExist(int id)
        {
            using var db = new FStoreDBContext();
            var flower = db.FlowerBouquets.SingleOrDefault(f => f.FlowerBouquetId == (id));
            return flower != null;
        }
        public bool CreateProduct(FlowerBouquet f)
        {
            using var db = new FStoreDBContext();
            if (f != null)
            {
                if (!IsFlowerBouquetExist(f.FlowerBouquetId))
                {
                    db.FlowerBouquets.Add(f);
                    var change = db.SaveChanges();
                    return change > 0;
                }
            }
            return true;
        }
        public bool DeleteProduct(int id)
        {
            using var db = new FStoreDBContext();
            if (IsFlowerBouquetExist(id))
            {
                var flower = GetProductById(id);
                db.FlowerBouquets.Remove(flower);
                var change = db.SaveChanges();
                return change > 0;
            }
            return false;
        }
        public bool UpdateProduct(FlowerBouquet f)
        {
            using var db = new FStoreDBContext();
            if (IsFlowerBouquetExist(f.FlowerBouquetId))
            {
                var flower = GetProductById(f.FlowerBouquetId);
                db.FlowerBouquets.Update(f);
                var change = db.SaveChanges();
                return change > 0;
            }
            return false;
        }
    }
}
