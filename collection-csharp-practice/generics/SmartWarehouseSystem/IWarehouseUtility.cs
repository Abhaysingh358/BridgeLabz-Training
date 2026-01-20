using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal interface IWarehouseUtility
    {
        void AddElectronicsItem();
        void AddGroceryItem();
        void AddFurnitureItem();

        void DisplayAllItems();
    }
}

