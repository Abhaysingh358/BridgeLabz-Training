using FlipKey_Logical;
namespace FlipKey_Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr the String to utilise");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Invalid Input");
            }

            Utility u = new Utility();
            string result =u.CleanseAndInvert(s);
            Console.WriteLine($"Generated Key is - <{result}>");
        }
    }
}