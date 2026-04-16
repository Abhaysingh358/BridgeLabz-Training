using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.DynamicOnlineMarket
{
      internal class MarketplaceMenu
        {
            private ProductCatalog catalog;
            private MarketplaceUtility utility;

            public void Start()
            {
                catalog = new ProductCatalog();
                utility = new MarketplaceUtility();

                int choice;

                do
                {
                    Console.WriteLine("\n===== DYNAMIC ONLINE MARKETPLACE MENU =====");
                    Console.WriteLine("1. Add Book Product");
                    Console.WriteLine("2. Add Clothing Product");
                    Console.WriteLine("3. Display All Products");
                    Console.WriteLine("4. Apply Discount to a Book Product");
                    Console.WriteLine("5. Apply Discount to a Clothing Product");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddBookProduct();
                            break;

                        case 2:
                            AddClothingProduct();
                            break;

                        case 3:
                            catalog.DisplayAllProducts();
                            break;

                        case 4:
                            ApplyDiscountToBook();
                            break;

                        case 5:
                            ApplyDiscountToClothing();
                            break;

                        case 0:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }

                } while (choice != 0);
            }

            private void AddBookProduct()
            {
                Console.Write("Enter Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                BookCategory category = new BookCategory();
                Product<BookCategory> bookProduct = new Product<BookCategory>(id, name, price, category);

                catalog.AddProduct(bookProduct);
            }

            private void AddClothingProduct()
            {
                Console.Write("Enter Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                ClothingCategory category = new ClothingCategory();
                Product<ClothingCategory> clothingProduct = new Product<ClothingCategory>(id, name, price, category);

                catalog.AddProduct(clothingProduct);
            }

            private void ApplyDiscountToBook()
            {
                Console.Write("Enter Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Current Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Discount Percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());

                BookCategory category = new BookCategory();
                Product<BookCategory> bookProduct = new Product<BookCategory>(id, name, price, category);

                utility.ApplyDiscount(bookProduct, percentage);
            }

            private void ApplyDiscountToClothing()
            {
                Console.Write("Enter Product ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Current Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Discount Percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());

                ClothingCategory category = new ClothingCategory();
                Product<ClothingCategory> clothingProduct = new Product<ClothingCategory>(id, name, price, category);

                utility.ApplyDiscount(clothingProduct, percentage);
            }
        }
}
