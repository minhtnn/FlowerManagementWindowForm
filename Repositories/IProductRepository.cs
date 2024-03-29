using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        List<FlowerBouquet> GetProducts();
        FlowerBouquet GetProductById(int id);
        List<FlowerBouquet> GetProductByUnitPrice(decimal lowerPrice, decimal upperPrice);
        List<FlowerBouquet> GetProductUnitInStock();
        List<FlowerBouquet> GetProductsByName(string name);
        List<FlowerBouquet> GetProductsByLowerPrice(decimal lowerPrice);
        List<FlowerBouquet> GetProductsByUpperPrice(decimal upperPrice);
        List<FlowerBouquet> GetProductsByAmountPrice(decimal lowerPrice, decimal upperPrice);
        List<FlowerBouquet> ArrangeProductDecline();
        List<FlowerBouquet> ArrangeProductAscend();
        bool CreateProduct(FlowerBouquet f);
        bool DeleteProduct(int id);
        bool UpdateProduct(FlowerBouquet f);
    }
}
