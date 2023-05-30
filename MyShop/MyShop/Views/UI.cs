using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Models;
using MyShop.Routers;
using MyShop.Views;

namespace MyShop.ConsoleUI
{
    internal class UI
    {
        #region Views and route redirection
        public static void Show()
        {
            View.HomeMenu();
            GoToRoute(ChooseAndCheckIfValid(1), new Router());
        }

        public static void GalleryMenu() {
            View.GalleryMenu();
            GoToRoute(ChooseAndCheckIfValid(1), new ProductsRouter());
        }

        public static void AllProducts(IEnumerable<string> products)
        {
            View.AllProducts(products);
            string choice = ChooseAndCheckIfValid(1);
            if(choice == "1")
            {
                GoToRoute("seeProduct", new ProductsRouter());
            }
            else if(choice == "0")
            {
                GoToRoute("home", new Router());
            }
        }

        public static void Product(string product) 
        {
            View.Product(product);
            GoToRoute(ChooseAndCheckIfValid(0), new ProductsRouter());

        }
        #endregion

        #region Helpers views and routes
        private static void GoToRoute(string route, Router router)
        {
            router.go(route);
        }

        public static string ChooseAndCheckIfValid(int lastIndex = 999)
        {
            bool valid = false;
            string output = "";
            do
            {
                try
                {
                    string choice = Console.ReadLine();
                    if (!int.TryParse(choice, out int control) || int.Parse(choice) > lastIndex)
                    {
                        throw new FormatException();
                    }
                    valid = true;
                    output += choice;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You didn't choose a valid option, try again.");
                }
            } while (!valid);
            return output;
        }
#endregion
    }
}
