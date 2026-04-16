
using BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor.ExamProctor;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ExamProctor
{
    internal class CustomHashMapAnswers
    {
        private AnswerRecord[] buckets;
        private int size;

        public CustomHashMapAnswers(int size)
        {
            this.size = size;
            buckets = new AnswerRecord[size];
        }

        public int Size
        {
            get { return size; }
        }

        // Hash function to calculate index
        private int GetIndex(int key)
        {
            if (key < 0) key = -key;
            return key % size;
        }

        public void Put(int questionId, char selectedAnswer)
        {
            int index = GetIndex(questionId);

            if (buckets[index] == null)
            {
                buckets[index] = new AnswerRecord(questionId, selectedAnswer);
                return;
            }

            AnswerRecord Curranswer = buckets[index];

            while (Curranswer != null)
            {
                if (Curranswer.QuestionId == questionId)
                {
                    Curranswer.SelectedAnswer = selectedAnswer;
                    return;
                }

                if (Curranswer.Next == null)
                {
                    break;
                }

                Curranswer = Curranswer.Next;
            }

            Curranswer.Next = new AnswerRecord(questionId, selectedAnswer);
        }

        // Get answer by questionId
        public char Get(int questionId)
        {
            int index = GetIndex(questionId);

            AnswerRecord current = buckets[index];

            while (current != null)
            {
                if (current.QuestionId == questionId)
                {
                    return current.SelectedAnswer;
                }
                current = current.Next;
            }

            return '\0';
        }

        // Check answer exists or not
        public bool ContainsKey(int questionId)
        {
            return Get(questionId) != '\0';
        }
    }
}

