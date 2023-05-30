using MyShop.DB;
using MyShop.Interfaces;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    internal class ProductsController : IProductService
    {
        public IEnumerable<string> DeepSearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public string Format(Product product)
        {
            Product prod = GetDetails(product.Id);
            string result = @"
    id                  name                        price             Qty left

";
            result += @"
    "+prod.Id+"         "+prod.Name+"                    "+prod.Price+" euros              "+prod.Stock;
            return result;
        }

        public IEnumerable<string> FuzzySearch(string searchText)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Product GetDetails(int productId)
        {
            Database db = new();
            if (productId > db.Products.Count)
            {
                throw new IndexOutOfRangeException();
            }  
            Product product = db.Products.First(x => x.Id.Equals(productId));
            return product;
        }

        public IEnumerable<string> List(IEnumerable<int>? specificIds = null)
        {
            List<Product> products = new Database().Products;
            List<string> list = new()
            {
                @"
    id          name
"
            };
            foreach (Product product in products)
            {
               list.Add(@"
    " + product.Id +"    "+ product.Name+@" 
    ");
            }
            return list;
            
        }

}
}
