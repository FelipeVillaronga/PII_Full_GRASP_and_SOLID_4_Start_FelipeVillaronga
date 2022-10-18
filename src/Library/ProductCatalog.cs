using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    //  Principio SRP y Creator
    public class ProductCatalog
    {
        private static List<Product> productCatalog = new List<Product>();
        public static Product AddProductToCatalog(string description, double unitCost)
        {
            Product product= new Product(description, unitCost);
            productCatalog.Add(product);
            return product;
        }
        public static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }
        public static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }
    }
}