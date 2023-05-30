using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop;
using MyShop.ConsoleUI;
using MyShop.Controllers;
using MyShop.Models;

namespace MyShop.Routers
{
    public class Router
    {
        public void go(string choice)
        {
            switch (choice)
            {
                case "1":
                    Menu.GalleryMenu();
                    break;
            }
        }
    }

    public class ProductsRouter : Router 
    {
        public void go(string choice, int index = 0) 
        {
            ProductsController controller = new ProductsController();
            switch (choice)
            {
                case "0":
                    Menu.Show();
                    break;
                case "1":
                    IEnumerable<string> products = controller.List();
                    Menu.AllProducts(products);
                    break;
                case "2":
                    string product = controller.Format(controller.GetDetails(index));
                    Menu.Product(product);
                    break;
            }
        }
    }
}
