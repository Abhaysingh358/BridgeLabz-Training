
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.DynamicOnlineMarket
{
    internal class ProductCatalog
    {
        private List<ICatalogItem> products = new List<ICatalogItem>();

        public void AddProduct<TCategory>(Product<TCategory> product) where TCategory : ICategory
        {
            products.Add(product);
            Console.WriteLine("Product added to catalog.");
        }

        public void DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Catalog is empty.");
                return;
            }

            Console.WriteLine("\n===== PRODUCT CATALOG =====");
            foreach (ICatalogItem item in products)
            {
                item.Display();
                Console.WriteLine("<<-------------------------->>");
            }
        }
    }
}

