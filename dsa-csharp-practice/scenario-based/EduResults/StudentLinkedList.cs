using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class StudentLinkedList
    {
        StudentNode head;
        StudentNode tail;

        public StudentNode GetHead()
        {
            return head;
        }

        public void SetHead(StudentNode newHead)
        {
            head = newHead;
            UpdateTail();
        }

        public void AddStudent(Student student)
        {
            StudentNode newNode = new StudentNode(student);
            if(head== null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

        }


        // method to remove students
        public void RemoveStudent(int rollnumber)
        {
          
            if(head== null)
            {
                Console.WriteLine("no Student is available");
                return;
            }

            //case1: remove head
            if(head.data._rollNumber == rollnumber)
            {
                head = head.next;
                if (head == null) // list became empty
                    tail = null;

                Console.WriteLine("Student removed successfully");
                return;
            }

            // remove from middle

            StudentNode temp = head;
            while(temp.next != null)
            {
                if(temp.next.data._rollNumber == rollnumber)
                {
                    if(temp.next==tail)
                    {
                        tail= temp;
                    }

                    temp.next = temp.next.next;

                    Console.WriteLine("Student removed successfully");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
        }

        public void SortList()
        {
            if (head == null || head.next == null)
                return;

            head = MergeSort(head);
            UpdateTail();
        }

        private StudentNode MergeSort(StudentNode h)
        {
            if (h == null || h.next == null)
                return h;

            StudentNode mid = GetMiddle(h);
            StudentNode rightHead = mid.next;
            mid.next = null; // split into two halves

            StudentNode leftSorted = MergeSort(h);
            StudentNode rightSorted = MergeSort(rightHead);

            return Merge(leftSorted, rightSorted);
        }

        private StudentNode GetMiddle(StudentNode h)
        {
            StudentNode slow = h;
            StudentNode fast = h;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow; // middle node
        }

        private StudentNode Merge(StudentNode a, StudentNode b)
        {
            if (a == null) return b;
            if (b == null) return a;

            StudentNode resultHead = null;
            StudentNode resultTail = null;

            while (a != null && b != null)
            {
                StudentNode pick;

                // Descending marks: higher marks first
                // Stability: if marks equal, pick from left list 'a' first
                if (a.data._marks > b.data._marks ||
                    (a.data._marks == b.data._marks && a.data._rollNumber <= b.data._rollNumber))
                {
                    pick = a;
                    a = a.next;
                }
                else
                {
                    pick = b;
                    b = b.next;
                }

                pick.next = null;

                if (resultHead == null)
                {
                    resultHead = pick;
                    resultTail = pick;
                }
                else
                {
                    resultTail.next = pick;
                    resultTail = pick;
                }
            }

            // Attach remaining nodes
            if (a != null) resultTail.next = a;
            else resultTail.next = b;

            return resultHead;
        }

        private void UpdateTail()
        {
            tail = head;
            while (tail != null && tail.next != null)
                tail = tail.next;
        }

        // merge with function
        public void MergeWith(StudentLinkedList otherList)
        {
            if (otherList == null || otherList.head == null)
                return;

            head = Merge(head, otherList.head);
            UpdateTail();
        }


        //method to display sstudents
        public void DisplayStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No students available.");
                return;
            }

            StudentNode temp = head;
            int rank = 1;

            Console.WriteLine("\n===== STATE WISE RANK LIST =====\n");

            while (temp != null)
            {
                Console.WriteLine(
                    $"Rank: {rank} | RollNo: {temp.data._rollNumber} | Name: {temp.data._name} | Marks: {temp.data._marks}"
                );

                temp = temp.next;
                rank++;
            }
        }

    }
}
