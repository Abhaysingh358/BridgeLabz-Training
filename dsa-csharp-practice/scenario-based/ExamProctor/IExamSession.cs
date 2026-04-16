using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal interface IExamSession
    {
        void ShowCurrentQuestion();
        void NextQuestion();
        void PreviousQuestion();
        void SaveAnswer(char answer);
        int SubmitExam();
    }
}
