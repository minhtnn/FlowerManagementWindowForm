using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<FlowerBouquet> ArrangeProductAscend()
             => ProductDAO.Instance.ArrangeProductAscend();

        public List<FlowerBouquet> ArrangeProductDecline()
             => ProductDAO.Instance.ArrangeProductDecline();

        public bool CreateProduct(FlowerBouquet f)
            => ProductDAO.Instance.CreateProduct(f);

        public bool DeleteProduct(int id)
            => ProductDAO.Instance.DeleteProduct(id);

        public FlowerBouquet GetProductById(int id)
            => ProductDAO.Instance.GetProductById(id);

        public List<FlowerBouquet> GetProductByUnitPrice(decimal lowerPrice, decimal upperPrice)
            => ProductDAO.Instance.GetProductByUnitPrice(lowerPrice, upperPrice);

        public List<FlowerBouquet> GetProducts()
            => ProductDAO.Instance.GetProducts();

        public List<FlowerBouquet> GetProductsByAmountPrice(decimal lowerPrice, decimal upperPrice)
            => ProductDAO.Instance.GetProductsByAmountPrice(lowerPrice, upperPrice);

        public List<FlowerBouquet> GetProductsByLowerPrice(decimal lowerPrice)
            => ProductDAO.Instance.GetProductsByLowerPrice(lowerPrice);

        public List<FlowerBouquet> GetProductsByName(string name)
            => ProductDAO.Instance.GetProductsByName(name);

        public List<FlowerBouquet> GetProductsByUpperPrice(decimal upperPrice)
            => ProductDAO.Instance.GetProductsByUpperPrice(upperPrice);
        public List<FlowerBouquet> GetProductUnitInStock()
            => ProductDAO.Instance.GetProductUnitInStock();

        public bool UpdateProduct(FlowerBouquet f)
            => ProductDAO.Instance.UpdateProduct(f);
    }
}
