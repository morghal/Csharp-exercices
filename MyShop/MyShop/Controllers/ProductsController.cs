using MyShop.Config;
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
id          name                price               Qty left

";
            result += $"{prod.Id}    {prod.Name}          {prod.Price} euros           {prod.Stock}\n";
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
            Database db = new Database();
            Product product = db.Products.First(x => x.Id.Equals(productId));
            return product;
        }

        public IEnumerable<string> List(IEnumerable<int> specificIds = null)
        {
            Database db = new Database();
            List<Product> products = db.Products;
            List<string> list = new List<string>();
            list.Add(@"
id          name                price               Qty left

");
            foreach (Product product in products)
            {
               list.Add($"{product.Id}    {product.Name}          {product.Price} euros           {product.Stock}\n");
            }
            return list;
            
        }

}
}
