using System;
class DivideChocolates
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter the number of chocolates:");
       int chocolates = int.Parse(Console.ReadLine());

       Console.WriteLine("Eneter the number of children :");
       int children = int.Parse(Console.ReadLine());
    //    calculating chocolates per child
    int chocolatesperchild =  chocolates / children;
    int remainingChocolates = chocolates % children;
    Console.WriteLine("The number of chocolates each child gets is " + chocolatesperchild + " and the number of remaining chocolates is " + remainingChocolates);
}
}