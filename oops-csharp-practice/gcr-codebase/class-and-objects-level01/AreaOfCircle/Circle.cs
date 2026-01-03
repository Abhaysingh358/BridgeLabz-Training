using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.class_and_objects_level01.AreaOfCircle
{
   internal class Circle
   {
       double radius;

       // default constructor
       public Circle()
       {
            
       }

       // method for calculating area
       public double Area(double radius)
       {
           return radius*radius*Math.PI; 
       }

       // method for taking input
       public double Input()
       {
           Console.WriteLine("Enter the Radius");
           double radius = double.Parse(Console.ReadLine());
           return radius;
       }

       // method to display
       public void Display()
       {
           double radius = Input();
           Console.WriteLine($"The area of circle : {Area(radius)} of radius : {radius}");
       }

      
   }
}
