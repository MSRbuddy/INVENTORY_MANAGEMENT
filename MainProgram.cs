using JsonInventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace JsonInventoryManagement
{
    internal class JsonConvert
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***** Welcome to Inventory Data Management Program! *****")
            InventoryFactory invops = new InventoryFactory();
            string jsonData = File.ReadAllText(jsonData);
            InventoryModel jsonObjectarray = JsonConvert.< InventoryModel > (jsonData);
            Console.Write("\n Selct item to work on :  1.Rice\t 2.Wheat\t 3.Pulses\t 4.Exit \n Enter your choice number : ");

            int option = int.Parse(Console.ReadLine());
            int Operation;
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n - - Rice Inventory - - ");
                    invops.DisplayInventory(jsonObjectarray.RiceList);
                    Console.Write(" - - - - - - - - - - - - - - - - ");

                    Console.Write("\n Select Operation for Rice : 1.Add \t2.Edit \t3.Delete " +
                        "\n Provide Option number : ");
                    Operation = int.Parse(Console.ReadLine());
                    if (Operation == 1)
                    {
                        jsonObjectarray.RiceList = invops.AddToInventory(jsonObjectarray.RiceList);
                    }
                    else if (Operation == 2)
                    {
                        jsonObjectarray.RiceList = invops.EditInventory(jsonObjectarray.RiceList);
                    }
                    else if (Operation == 3)
                    {
                        jsonObjectarray.RiceList = invops.RemoveFromInventory(jsonObjectarray.RiceList);
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Option number. Please Retry.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n - - Wheat Inventory - - ");
                    invops.DisplayInventory(jsonObjectarray.WheatList);
                    Console.Write(" - - - - - - - - - - - - - - - - ");

                    Console.Write("\n Select Operation for Wheat : 1.Add \t2.Edit \t3.Delete " +
                        "\n Provide Option number : ");
                    Operation = int.Parse(Console.ReadLine());
                    if (Operation == 1)
                    {
                        jsonObjectarray.WheatList = invops.AddToInventory(jsonObjectarray.WheatList);
                    }
                    else if (Operation == 2)
                    {
                        jsonObjectarray.WheatList = invops.EditInventory(jsonObjectarray.WheatList);
                    }
                    else if (Operation == 3)
                    {
                        jsonObjectarray.WheatList = invops.RemoveFromInventory(jsonObjectarray.WheatList);
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Option number. Please Retry.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\n - - Pulses Inventory - - ");
                    invops.DisplayInventory(jsonObjectarray.PulsesList);
                    Console.Write(" - - - - - - - - - - - - - - - - ");

                    Console.Write("\n Select Operation for Pulses : 1.Add \t2.Edit \t3.Delete " +
                        "\n Provide Option number : ");
                    Operation = int.Parse(Console.ReadLine());
                    if (Operation == 1)
                    {
                        jsonObjectarray.PulsesList = invops.AddToInventory(jsonObjectarray.PulsesList);
                    }
                    else if (Operation == 2)
                    {
                        jsonObjectarray.PulsesList = invops.EditInventory(jsonObjectarray.PulsesList);
                    }
                    else if (Operation == 3)
                    {
                        jsonObjectarray.PulsesList = invops.RemoveFromInventory(jsonObjectarray.PulsesList);
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Option number. Please Retry.");
                    }
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine(" Invalid Option number. Please Retry.");
                    break;
            }
        }
    }
}

