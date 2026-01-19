using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    namespace ExamProctor
    {
        internal class AnswerRecord
        {
            public int QuestionId { get; set; }        // Key
            public char SelectedAnswer { get; set; }   // Value
            public AnswerRecord Next { get; set; }     // For chaining

            public AnswerRecord(int questionId, char selectedAnswer)
            {
                QuestionId = questionId;
                SelectedAnswer = selectedAnswer;
                Next = null;
            }
        }
    }

}
