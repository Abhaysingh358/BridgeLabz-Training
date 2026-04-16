using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
   
        internal class StackNode
        {
            public int QuestionId { get; set; }
            public StackNode Next { get; set; }

            public StackNode(int questionId)
            {
                QuestionId = questionId;
                Next = null;
            }
        }
    }
