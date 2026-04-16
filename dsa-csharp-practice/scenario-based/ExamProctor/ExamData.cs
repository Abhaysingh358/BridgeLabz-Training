using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
        internal static class ExamData
        {
            // Returns all questions for the exam
            public static Question[] GetQuestions()
            {
                Question[] questions = new Question[5];

                questions[0] = new Question
                {
                    QuestionId = 101,
                    QuestionText = "What is the output of: Console.WriteLine(2 + 3 * 2);",
                    OptionA = "10",
                    OptionB = "8",
                    OptionC = "7",
                    OptionD = "12",
                    CorrectAnswer = 'B'
                };

                questions[1] = new Question
                {
                    QuestionId = 102,
                    QuestionText = "Which keyword is used to create object in C#?",
                    OptionA = "create",
                    OptionB = "class",
                    OptionC = "new",
                    OptionD = "object",
                    CorrectAnswer = 'C'
                };

                questions[2] = new Question
                {
                    QuestionId = 103,
                    QuestionText = "Which data structure works on LIFO?",
                    OptionA = "Queue",
                    OptionB = "Stack",
                    OptionC = "LinkedList",
                    OptionD = "Graph",
                    CorrectAnswer = 'B'
                };

                questions[3] = new Question
                {
                    QuestionId = 104,
                    QuestionText = "Which access modifier allows access only within same class?",
                    OptionA = "public",
                    OptionB = "protected",
                    OptionC = "internal",
                    OptionD = "private",
                    CorrectAnswer = 'D'
                };

                questions[4] = new Question
                {
                    QuestionId = 105,
                    QuestionText = "Which operator is used for AND condition in C#?",
                    OptionA = "&&",
                    OptionB = "||",
                    OptionC = "!",
                    OptionD = "^",
                    CorrectAnswer = 'A'
                };

                return questions;
            }
        }
    }

