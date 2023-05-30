using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Models;
using System.Threading.Tasks;
using System.Text.Json;
using MyShop.Config;

namespace MyShop.DB
{
    public class Database
    {
        public Database()
        {
            Products = LoadData();
        }
        public List<Product> Products { get; set; }

        // Method to refresh the data
        public void RefreshData()
        {
            LoadData();
        }

        public List<Product> LoadData()
        {
            string jsonFile = Configuration.LoadFiles();
            List<Product>? products = JsonSerializer.Deserialize<List<Product>>(jsonFile);
            if(products is null) 
            { Console.WriteLine("Failure loading data");
              Environment.Exit(1); 
            }
            return products;
        }
    }
}
