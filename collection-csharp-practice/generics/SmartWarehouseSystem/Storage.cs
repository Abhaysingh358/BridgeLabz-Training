using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        // Add an item into storage
        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        // Display all items in storage
        public void DisplayAllItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Storage is empty.");
                return;
            }

            Console.WriteLine("\n===== Items in Storage =====");
            foreach (T item in items)
            {
                item.DisplayInfo();
                Console.WriteLine("----------------------------");
            }
        }

        // Optional: return all items (if utility class needs list)
        public List<T> GetAllItems()
        {
            return items;
        }
    }
}

