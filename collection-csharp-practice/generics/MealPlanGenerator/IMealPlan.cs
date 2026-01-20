using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.FoodPlan
{
    public interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }
        void Display();
    }
}
