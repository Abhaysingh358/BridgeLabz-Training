using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
    internal class TrackingList
    {
        public CheckPointNode Head { get; set; }
        public CheckPointNode Tail { get; set; }

        // method to display tracking status of the parcel
        public void DisplayTracking()
        {
            int count = 0;
            if (Head == null)
            {
                Console.WriteLine("Currently , Tracking Is Unavailable ");
                return;
            }
            CheckPointNode temp = Head;
            while (temp != null) // checkpoint is null we will return and print till checkpoint is available
            {
                Console.WriteLine($"{++count}) {temp.StageName}");
                Console.WriteLine(temp.StageTime);
                temp = temp.Next;

            }
        }

        // Creating a method to addcheckpoint 
        public void AddCheckPoint(string stageName)
        {
            if (string.IsNullOrEmpty(stageName))
            {
                Console.WriteLine("Stage Name Can not be Empty");
                return;
            }

            stageName = stageName.Trim();

            if (string.IsNullOrEmpty(stageName))
            {
                Console.WriteLine("Stage Name Can not be Empty");
                return;
            }

            CheckPointNode newNode = new CheckPointNode(stageName);

            if (Head == null)
            {
                if (!stageName.Equals("Packed", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("First stage must be Packed");
                    return;
                }

                newNode.StageName = "Packed"; // standard format
                Head = Tail = newNode;
                return;
            }

            if (!IsValidNextStage(stageName))
            {
                return;
            }

            Tail.Next = newNode;
            Tail = newNode;
        }




        // check valid points
        private bool IsValidNextStage(string newStage)
        {
            string lastStage = Tail.StageName;

            if (lastStage.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Parcel is already Delivered. No more stages can be added.");
                return false;
            }

            // Packed should only be first stage
            if (newStage.Equals("Packed", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Packed can only be the first stage.");
                return false;
            }

            // Shipped must come after Packed
            if (newStage.Equals("Shipped", StringComparison.OrdinalIgnoreCase))
            {
                if (!lastStage.Equals("Packed", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Invalid stage order. Shipped can come only after Packed.");
                    return false;
                }
                return true;
            }

            // In Transit must come after Shipped (or custom checkpoints after Shipped)
            if (newStage.Equals("In Transit", StringComparison.OrdinalIgnoreCase))
            {
                if (!HasStage("Shipped"))
                {
                    Console.WriteLine("Invalid stage order. In Transit can come only after Shipped.");
                    return false;
                }
                return true;
            }

            // Delivered must come after In Transit (or custom checkpoints after In Transit)
            if (newStage.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
            {
                if (!HasStage("In Transit"))
                {
                    Console.WriteLine("Invalid stage order. Delivered can come only after In Transit.");
                    return false;
                }
                return true;
            }

            // Custom stages
            // allowed only after Shipped (means not directly after Packed)
            if (!HasStage("Shipped"))
            {
                Console.WriteLine("Custom checkpoint cannot come before Shipped.");
                return false;
            }

            return true;
        }



        // checking stage is present or not 
        private bool HasStage(string stageName)
        {
            CheckPointNode temp = Head;
            while (temp != null)
            {
                if (temp.StageName.Equals(stageName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }


        // insert at any intermediate checkpoints
        // pass the arguments target stage where the newnode is connected after the target stage and newstage is the 
        //which is going to  connect
        public void InsertAfter(string targetStage, string newStage)
        {
            if (string.IsNullOrEmpty(targetStage) || string.IsNullOrEmpty(newStage))
            {
                Console.WriteLine("Stage names cannot be empty.");
                return;
            }

            if (Head == null)
            {
                Console.WriteLine("Tracking is empty. Cannot insert intermediate stage.");
                return;
            }

            CheckPointNode temp = Head;
            while (temp != null)
            {
                if (temp.StageName == targetStage)
                {
                    CheckPointNode newNode = new CheckPointNode(newStage);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    if (temp == Tail)
                    {
                        Tail = newNode;
                    }

                    Console.WriteLine($"Checkpoint inserted after {targetStage}");
                    return;
                }

                temp = temp.Next;

            }

            Console.WriteLine("Target Stage is Not Found");

        }

        public string GetCurrentStatus()
        {
            if (Tail == null)
            {
                return "Tracking Unavailable";
            }

            return Tail.StageName;
        }


    }
}


