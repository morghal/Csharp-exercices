/**
 * This is just a stub, you will surely want to split existing code into many more class/methods.
 * Best would be to add a 'Class library' (https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0)
 * project so that you can switch to a GUI version without changing anything in the "domain" project
 * 
 * You are not obliged to keep the existing code. Feel free to use your own classes instead.
 */
using System.Text.Json;
using System.Text.Json.Serialization;
using MyShop.Config;
using MyShop.ConsoleUI;
//using MyShop.Models;

#region Main

Console.WriteLine("Initialization...");
Configuration.LoadConfig();
Menu.Show();

Environment.Exit(0);

#endregion