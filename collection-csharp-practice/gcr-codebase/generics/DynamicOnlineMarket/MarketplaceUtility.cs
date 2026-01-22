using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.DynamicOnlineMarket
{
    internal class MarketplaceUtility
    {
        // Generic Method to apply discount
        public void ApplyDiscount<TCategory>(Product<TCategory> product, double percentage)
            where TCategory : ICategory
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount percentage.");
                return;
            }

            double discountAmount = product.Price * (percentage / 100);
            double newPrice = product.Price - discountAmount;

            product.UpdatePrice(newPrice);

            Console.WriteLine("Discount Applied Successfully.");
            Console.WriteLine("New Price: " + product.Price);
        }
    }
}
