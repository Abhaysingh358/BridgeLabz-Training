using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.scenerio_based
{
    internal class SnakeAndLadder
    {
        static int[,] Ladder = { { 4, 87 }, { 9, 31 }, { 21, 42 }, { 28, 84 }, { 51, 67 }, { 72, 91 } };
        static int[,] Snake = { { 17, 7 }, { 89, 9 }, { 62, 19 }, { 52, 32 }, { 87, 32 }, { 64, 60 } };
        static Random r = new Random();


        private static int RollDice(string s)
        {
            return r.Next(1, 7);
        }

        private static int MovePlayer(int pos, int dice)
        {
            int newpos = pos + dice;

            return newpos > 100 ? pos : newpos;
        }

        private static int ApplySnakeOrLadder(int newpos)
        {
            for (int i = 0; i < Snake.GetLength(0); i++)
            {
                if (newpos == Snake[i, 0])
                {
                    return Snake[i, 1];
                }
            }

            for (int i = 0; i < Ladder.GetLength(0); i++)
            {
                if (newpos == Ladder[i, 0])
                {
                    return Ladder[i, 1];
                }
            }
            return newpos;
        }

        private static bool IsWin(int pos)
        {
            if (pos == 100)
            {
                return true;
            }
            return false;
        }
        public static void SinglePlayer()
        {
            Console.WriteLine("You are playing single player mode");
            int pos = 0;

            Console.WriteLine($"The Game is started , Currrent Position : {pos}");

            while (true)
            {
                Console.WriteLine("write \"roll\" to roll dice ");
                string s = Console.ReadLine();
                s = s.ToLower().Trim();

                if (!string.IsNullOrEmpty(s) && s == "roll")
                {
                    int num = RollDice(s);
                    Console.WriteLine($"you rolled : {num}");

                    int newpos = MovePlayer(pos, num);
                    newpos = ApplySnakeOrLadder(newpos);

                    Console.WriteLine($"Position moved : {pos} --> {newpos}");
                    pos = newpos;

                    if (IsWin(newpos))
                    {
                        Console.WriteLine("You Win !");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter the word \"roll\" to roll dice ");
                }

            }


        }

        public static void MultiPlayer()
        {
            Console.WriteLine("You are playing multiplayer game ");
            Console.WriteLine("Enter number of players \" only (2-4) players allowed \" in the game");
            int num = int.Parse(Console.ReadLine());

            if (num >= 2 && num <= 4)
            {

                int[] pos = new int[num];
                for (int i = 0; i < num; i++)
                {
                    pos[i] = 0;
                }

                Console.WriteLine("Game started : all positons are at 0");

                while (true)
                {
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Type \"roll\" to roll the dice ");
                        string s = Console.ReadLine();
                        s = s.ToLower().Trim();

                        if (!string.IsNullOrEmpty(s) && s == "roll")
                        {
                            int roll = RollDice(s);
                            Console.WriteLine($"Dice rolled : {roll}");
                            int newpos = MovePlayer(pos[i], roll);
                            newpos = ApplySnakeOrLadder(newpos);

                            Console.WriteLine($"Player {i + 1} : {pos[i]} -> {newpos}");
                            pos[i] = newpos;

                            if (IsWin(pos[i]))
                            {
                                Console.WriteLine($"\n player{i + 1} WINS THE GAME!");
                                return;
                            }

                        }

                        else
                        {
                            Console.WriteLine("please enter \"roll\" to roll the dice");
                            i--;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("please enter the player between 2 to 4");

            }



        }
        public static void choice()
        {
            Console.WriteLine("Press 1. to Play in single player mode");
            Console.WriteLine("Press 2 .to play in multi player mode");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SinglePlayer();
                    break;

                case 2:
                    MultiPlayer();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void Main(string[] args)
        {
            choice();
        }

    }
}
