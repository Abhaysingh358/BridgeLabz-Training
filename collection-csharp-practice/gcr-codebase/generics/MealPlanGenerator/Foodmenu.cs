using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.FoodPlan
{
    internal class Foodmenu
    {
        public void start()
        {
            Meal<IMealPlan> planner = new Meal<IMealPlan>();

            Console.WriteLine("Choose Meal Type:");
            Console.WriteLine("1. Vegetarian");
            Console.WriteLine("2. Vegan");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter calories: ");
            int calories = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                planner.GenerateMeal(new VegetarianMeal(calories));
            }
            else if (choice == 2)
            {
                planner.GenerateMeal(new VeganMeal(calories));
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
