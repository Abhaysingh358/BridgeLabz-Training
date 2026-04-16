using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FlashDealz
{
    internal class Product
    {
        private string ProductName;
        private double MarkedPrice;
        private double Discount;


        public Product(string productName, double markedPrice, double discount)
        {
            this.ProductName = productName;
            this.MarkedPrice = markedPrice;
            this.Discount = discount; // in percentage
        }

        public string GetProductName()
        {
            return ProductName;
        }
        
        public void SetProductName(string productName)
        {
            this.ProductName = productName;
        }

        public double GetMarkedPrice()
        {
            return MarkedPrice;
        }

        public void SetMarkedPrice(double markedPrice)
        {
            this.MarkedPrice= markedPrice;
        }


        public void SetDiscount(double discount)
        {
            this.Discount = discount;
        }
        public double GetDiscount()
        {
            return Discount;
        }

        public double GetDiscountAmount()
        {
            return (MarkedPrice * Discount) / 100;
        }

        public double GetFinalPrice()
        {
            return MarkedPrice - GetDiscountAmount();
        }


      
            public override string ToString()
        {
            return $"Product Name    : {ProductName}\n" +
                   $"Marked Price    : {MarkedPrice}\n" +
                   $"Discount percent    : {Discount}\n" +
                   $"Discount Amount : {GetDiscountAmount()}\n" +
                   $"Final Price     : {GetFinalPrice()}\n";
        }
    }
    
}
