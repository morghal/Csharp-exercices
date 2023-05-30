using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Views
{
    internal static class View
    {
        public static void HomeMenu()
        {
            Console.WriteLine(@"
    1) Gallery
");
        }

        public static void GalleryMenu()
        {
            Console.Clear();

            Console.WriteLine(@"
    1) List all items
");
        }

        public static void AllProducts(IEnumerable<string> products) 
        {
            Console.Clear();
            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine(@"
    0) Accueil
    1) See product's details
");
        }

        public static void Product(string product)
        {
            Console.Clear();
            Console.WriteLine(product);
            Console.WriteLine(@"
    0) Accueil");
        }
    }
}
