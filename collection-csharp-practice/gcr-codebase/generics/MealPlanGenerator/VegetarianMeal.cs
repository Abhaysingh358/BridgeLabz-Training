using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.FoodPlan
{
    internal class VegetarianMeal : IMealPlan
    {
        public string MealName => "Vegetarian Meal";
        public int Calories { get; }

        public VegetarianMeal(int calories)
        {
            Calories = calories;
        }

        public void Display()
        {
            Console.WriteLine($"{MealName} | Calories: {Calories}");
        }
    }
}
