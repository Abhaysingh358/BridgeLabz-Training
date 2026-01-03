using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.introduction_of_inheritence.AnimalHierarchy
{
    public class Bird : Animal
    {
     
            public Bird(string name, int age) : base(name, age)
            {
            }

            public override string ToString()
            {
                return $"Bird Chirps";
            }
        }
    }

