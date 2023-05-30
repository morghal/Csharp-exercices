using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using MyShop.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MyShop.DB;

namespace MyShop.Config;

public static class Configuration
{
    public const string APP_NAME = "MyShop";

    /// <summary>
    ///  The app needs to be a bit configurable without code change.<br />
    ///  To do so, we need to load the configuration from an external source<br />
    ///  Then bind it to something we can reference anywhere.<br />
    ///  The structure of settings should be as comprehensible as possible<br />
    /// </summary>
    /// <remarks> Hint: static, appsettings, file, inheritance </remarks>
    public static void LoadConfig()
    {
        Database db = new Database();
        db.LoadData();
    }

    public static void Initialize()
    {
        Console.WriteLine("Initialization...");
        LoadConfig();
        Console.WriteLine("Done !");
    }

    public static string LoadFiles()
    {
        string fileProducts = "../../../DB/Products.json";
        string jsonProducts = File.ReadAllText(fileProducts);

        return jsonProducts;

    }
}
