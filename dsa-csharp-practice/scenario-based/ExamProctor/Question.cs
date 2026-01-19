using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal class Question
    {
     
            public int QuestionId { get; set; }
            public string QuestionText { get; set; }

            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }

            public char CorrectAnswer { get; set; }

            // Returns question details as string
            public override string ToString()
            {
            return "------------------------------------\n" +
                   "Question ID : " + QuestionId + "\n" +
                   "Question    : " + QuestionText + "\n" +
                   "A) " + OptionA + "\n" +
                   "B) " + OptionB + "\n" +
                   "C) " + OptionC + "\n" +
                   "D) " + OptionD + "\n";
            }

        }
        }


