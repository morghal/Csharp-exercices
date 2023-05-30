using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop;
using MyShop.ConsoleUI;
using MyShop.Interfaces;
using MyShop.Controllers;
using MyShop.Models;

namespace MyShop.Routers
{
    public class Router
    {
        public virtual void Go(string choice)
        {
            switch (choice)
            {
                case "home":
                    UI.Show();
                    break;
                case "1":
                case "gallery":
                    UI.GalleryMenu();
                    break;
            }
        }
    }

    public class ProductsRouter : Router 
    {
        public override void Go(string choice) 
        {
            IProductService controller = new ProductsController();
            switch (choice)
            {
                case "0":
                    UI.Show();
                    break;
                case "1":
                    IEnumerable<string> products = controller.List();
                    UI.AllProducts(products);
                    break;
                case "2":
                case "seeProduct":
                    string product = GetProductIfValidId();
                    UI.Product(product);
                    break;
            }
        }

        public static string GetProductIfValidId()
        {
            string product = "";
            bool formatOk = false;
            do
            {
                try
                {   
                    Console.WriteLine("Specify product's index");
                    string index = UI.ChooseAndCheckIfValid();
                    IProductService controller = new ProductsController();
                    product += controller.Format(controller.GetDetails(int.Parse(index)));
                    formatOk = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid index, please try again !");
                }

            } while (!formatOk);
            return product;
        }
    }
}
