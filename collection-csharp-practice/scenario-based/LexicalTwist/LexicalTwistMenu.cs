namespace LexicalTwist
{
    public class LexicalTwistMenu
    {
        private IRequirements requirements;

        public void Start()
        {
            requirements =new Requirements();
            Console.WriteLine("Lexical Twist Scenario");
            Console.WriteLine("1. Check if the second word is a reversed version of the first word:");
            Console.WriteLine("0. for exiting");

            while(true){
            Console.WriteLine("Enter the choice in int");
            int choice = int.Parse(Console.ReadLine());

            
                switch (choice)
                {
                    case 1:
                        requirements.IsSecondWordReversed();
                        break;
                    case 0:
                        Console.WriteLine("Exited from the Application");
                        return;
                    default :
                        Console.WriteLine("Invalid Choice. Choose Valid Options");
                        break;

                }
            }
        }
    }
}