using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal static class ExamUtility
    {
        // Calculate total score
        public static int CalculateScore(Question[] questions, CustomHashMapAnswers answerMap)
        {
            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                char selected = answerMap.Get(questions[i].QuestionId);

                if (selected != '\0')
                {
                    if (char.ToUpper(selected) == char.ToUpper(questions[i].CorrectAnswer))
                    {
                        score++;
                    }
                }
            }

            return score;
        }
    }
}
