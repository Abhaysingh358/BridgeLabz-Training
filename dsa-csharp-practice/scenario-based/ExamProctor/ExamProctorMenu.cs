using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
   internal class ExamProctorMenu
        {
            private ExamSession examSession;
            private bool isRunning;

            public ExamProctorMenu()
            {
                Question[] questions = ExamData.GetQuestions();
                examSession = new ExamSession(questions);
                isRunning = true;
            }

            // Start the exam menu
            public void Start()
            {
                while (isRunning)
                {
                    examSession.ShowCurrentQuestion();
                    PrintMenu();

                    int choice = ReadInt("Enter Choice: ");
                    HandleChoice(choice);
                }
            }

            // Print menu options
            private void PrintMenu()
            {
                Console.WriteLine();
                Console.WriteLine("1. Next Question");
                Console.WriteLine("2. Previous Question");
                Console.WriteLine("3. Answer Question");
                Console.WriteLine("4. Submit Exam");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
            }

            // Handle the user choice
            private void HandleChoice(int choice)
            {
                if (choice == 1)
                {
                    examSession.NextQuestion();
                }
                else if (choice == 2)
                {
                    examSession.PreviousQuestion();
                }
                else if (choice == 3)
                {
                    char answer = ReadChar("Enter Answer (A/B/C/D): ");
                    examSession.SaveAnswer(answer);
                    Pause();
                }
                else if (choice == 4)
                {
                    int score = examSession.SubmitExam();
                    Console.WriteLine("Exam Submitted Successfully.");
                    Console.WriteLine("Your Score: " + score);
                    Pause();
                    isRunning = false;
                }
                else if (choice == 5)
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    Pause();
                }
            }

            // Read integer input safely
            private int ReadInt(string message)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                int value;

                while (!int.TryParse(input, out value))
                {
                    Console.Write("Invalid input. " + message);
                    input = Console.ReadLine();
                }

                return value;
            }

            // Read char input safely
            private char ReadChar(string message)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                while (string.IsNullOrEmpty(input))
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                }

                return input[0];
            }

            // Pause screen for user
            private void Pause()
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }



