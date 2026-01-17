using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FlashDealz
{
    internal class ProductNode
    {
        Product product;
        ProductNode Next;

        public ProductNode(Product product)
        { 
            this.product = product;
            this.Next = null;
        }

        public Product GetProduct()
        {
            return product;
        }

        public void SetProduct(Product product)
        {
            this.product = product; 
        }

        public ProductNode GetNext()
        {
            return Next;
        }
        public void SetNext(ProductNode next)
        {
            this.Next = next; 
        }


    }
}
