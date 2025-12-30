using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based
{
    internal class EduQuiz
    {
        // This method asks the user how many questions are in the quiz
        public int GetQuestions()
        {

            Console.WriteLine("Enetr the number of questions");
            int questions = int.Parse(Console.ReadLine());

            return questions;
        }


        // This method takes the correct answers from the teacher/admin
        void InputCorrectAnsewrs(string[] correct)
        {

            for (int i = 0; i < correct.Length; i++)
            {
                Console.Write($"Correct answer for Q{i + 1}: ");
                correct[i] = Console.ReadLine().Trim();
            }
        }


        // This method takes the student's answers one by one
        void InputStudentsAnswers(string[] studentAnswers)
        {
            for (int i = 0; i < studentAnswers.Length; i++)
            {
                Console.Write($"Student answer for Q{i + 1}: ");
                studentAnswers[i] = Console.ReadLine().Trim();
            }
        }

        // This method compares correct vs student answers and returns the total score
        int CalculateScore(string[] correct, string[] student)
        {
            int score = 0;

            for (int i = 0; i < correct.Length; i++)
            {
                if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }

            return score;
        }

        // This method prints detailed feedback for each question
        void ShowDetailedFeedback(string[] correct, string[] student)
        {
            Console.WriteLine("QUESTION FEEDBACK ");

            for (int i = 0; i < correct.Length; i++)
            {
                if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Question {i + 1}: Correct");
                }
                else
                {
                    Console.WriteLine($"Question {i + 1}: Incorrect (Correct: {correct[i]})");
                }
            }
        }

        // This method shows the total score, percentage, and pass/fail result
        void ShowResult(int score, int total)
        {
            Console.WriteLine($"\nTotal Correct Answers: {score} / {total}");

            double percentage = (score * 100.0) / total;
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage >= 33)
            {
                Console.WriteLine("Result: PASS");
            }
            else
            {
                Console.WriteLine("Result: FAIL");
            }
        }

        // This method controls the whole quiz process step-by-step
        public void StartQuiz()
        {
            int totalQuestions = GetQuestions();

            string[] correctAnswers = new string[totalQuestions];
            string[] studentAnswers = new string[totalQuestions];

            InputCorrectAnsewrs(correctAnswers);
            InputStudentsAnswers(studentAnswers);

            int score = CalculateScore(correctAnswers, studentAnswers);

            ShowDetailedFeedback(correctAnswers, studentAnswers);
            ShowResult(score, totalQuestions);
        }

        // The Main method only creates an object and starts the quiz
        static void Main(string[] args)
        {
            EduQuiz obj = new EduQuiz();
            obj.StartQuiz();
        }
    }
}
