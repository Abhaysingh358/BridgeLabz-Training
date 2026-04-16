using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal class ExamSession : IExamSession
    {
            private Question[] questions;
            private int currentIndex;

            private NavigationStack navigationStack;
            private CustomHashMapAnswers answerMap;

            public ExamSession(Question[] questionsList)
            {
                questions = questionsList;
                currentIndex = 0;

                navigationStack = new NavigationStack();
                answerMap = new CustomHashMapAnswers(questions.Length + 5);
            }

            // Show current question
            public void ShowCurrentQuestion()
            {
                Console.Clear();

                if (questions == null || questions.Length == 0)
                {
                    Console.WriteLine("No questions found.");
                    return;
                }

                Console.WriteLine(questions[currentIndex].ToString());

                char savedAnswer = answerMap.Get(questions[currentIndex].QuestionId);
                if (savedAnswer != '\0')
                {
                    Console.WriteLine("Saved Answer : " + savedAnswer);
                }

                Console.WriteLine("Question " + (currentIndex + 1) + " / " + questions.Length);
            }

            // Move to next question
            public void NextQuestion()
            {
                if (currentIndex < questions.Length - 1)
                {
                    navigationStack.Push(currentIndex);
                    currentIndex++;
                }
            }

            // Move to previous question using stack
            public void PreviousQuestion()
            {
                int prevIndex = navigationStack.Pop();

                if (prevIndex != -1)
                {
                    currentIndex = prevIndex;
                }
            }

            // Save answer for current question
            public void SaveAnswer(char answer)
            {
                answer = char.ToUpper(answer);

                if (answer != 'A' && answer != 'B' && answer != 'C' && answer != 'D')
                {
                    Console.WriteLine("Invalid answer. Enter A/B/C/D only.");
                    return;
                }

                int qid = questions[currentIndex].QuestionId;
                answerMap.Put(qid, answer);
            }

            // Submit exam and calculate score
            public int SubmitExam()
            {
                return ExamUtility.CalculateScore(questions, answerMap);
            }

            
        }
    }



