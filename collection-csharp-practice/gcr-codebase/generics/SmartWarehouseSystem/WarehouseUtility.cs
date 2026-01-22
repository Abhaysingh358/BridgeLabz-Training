using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class WarehouseUtility : IWarehouseUtility
    {
        private Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        private Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        private Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        public void AddElectronicsItem()
        {
            Console.Write("Enter Item ID: ");
            int itemId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Warranty (months): ");
            int warrantyMonths = Convert.ToInt32(Console.ReadLine());

            Electronics item = new Electronics(itemId, name, quantity, price, brand, warrantyMonths);
            electronicsStorage.AddItem(item);
        }

        public void AddGroceryItem()
        {
            Console.Write("Enter Item ID: ");
            int itemId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
            DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());

            Groceries item = new Groceries(itemId, name, quantity, price, expiryDate, category);
            groceriesStorage.AddItem(item);
        }

        public void AddFurnitureItem()
        {
            Console.Write("Enter Item ID: ");
            int itemId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Material: ");
            string material = Console.ReadLine();

            Console.Write("Enter Dimensions: ");
            string dimensions = Console.ReadLine();

            Furniture item = new Furniture(itemId, name, quantity, price, material, dimensions);
            furnitureStorage.AddItem(item);
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\n=====ELECTRONICS STORAGE =====");
            electronicsStorage.DisplayAllItems();

            Console.WriteLine("\n===== GROCERIES STORAGE =====");
            groceriesStorage.DisplayAllItems();

            Console.WriteLine("\n===== FURNITURE STORAGE =====");
            furnitureStorage.DisplayAllItems();
        }
    }
}
