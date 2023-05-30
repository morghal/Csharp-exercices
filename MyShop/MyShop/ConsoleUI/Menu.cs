using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Models;
using MyShop.Routers;

namespace MyShop.ConsoleUI
{
    internal class Menu
    {

        public static void Show()
        {
            Router router = new Router();
            Console.WriteLine(@"
    1) Gallery
");
            string choice = ChooseAndCheckIfValid();
            router.go(choice);


        }

        private static string ChooseAndCheckIfValid() 
        {
            bool valid = false;
            string output = "";
            do
            {
                try
                {
                    string choice = Console.ReadLine();
                    if (!int.TryParse(choice, out int control) || int.Parse(choice) > 3)
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


        public static void GalleryMenu() {
            ProductsRouter router = new ProductsRouter();
            Console.WriteLine(@"
    1) List all items
");
            string choice = ChooseAndCheckIfValid();
            router.go(choice);
        }

        public static void AllProducts(IEnumerable<string> products)
        {
            ProductsRouter router = new ProductsRouter();
            foreach(string product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(@"
    0) Accueil
    Select an id to see product's details
");
            string choice = ChooseAndCheckIfValid();
            if(choice == "0")
            {
                router.go("0");
            }
            router.go("2", int.Parse(choice));
        }

        public static void Product(string product) 
        {
            ProductsRouter router = new ProductsRouter();
            Console.WriteLine(product);
            Console.WriteLine(@"
    0) Accueil");
            string choice = ChooseAndCheckIfValid();
            router.go(choice, int.Parse(choice));

        }
    }
}
