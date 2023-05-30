using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyShop.Models;
using System.Threading.Tasks;
using System.Text.Json;

namespace MyShop.Config
{
    public class Database
    {
        public Database() { 
            Products = LoadData();
        }
        public List<Product> Products {get; set;}

        // Method to refresh the data
        public void RefreshData()
        {
            LoadData();
        }

        public List<Product> LoadData()
        {
            string jsonFile = Configuration.LoadFiles();
            return JsonSerializer.Deserialize<List<Product>>(jsonFile);
        }
    }
}
