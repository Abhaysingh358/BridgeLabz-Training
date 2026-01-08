using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Inventory_Management_System
{ 
        internal class InventoryLinkedList
        {
            private InventoryItem Head;

            // Add at beginning
            public void AddAtBeginning(InventoryItem item)
            {
                item.Next = Head;
                Head = item;
            }

            // Add at end
            public void AddAtEnd(InventoryItem item)
            {
                if (Head == null)
                {
                    Head = item;
                    return;
                }

                InventoryItem temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = item;
            }

            // Add at position
            public void AddAtPosition(InventoryItem item)
            {
            Console.WriteLine("Enter the position");
            int position = int.Parse(Console.ReadLine());

                if (position <= 1)
                {
                    AddAtBeginning(item);
                    return;
                }

                InventoryItem temp = Head;
                for (int i = 1; i < position - 1 && temp != null; i++)
                    temp = temp.Next;

                if (temp == null) return;

                item.Next = temp.Next;
                temp.Next = item;
            }

            // Remove by Item ID
            public void RemoveById(int itemId)
            {
                if (Head == null) return;

                if (Head.ItemId == itemId)
                {
                    Head = Head.Next;
                    return;
                }

                InventoryItem temp = Head;
                while (temp.Next != null && temp.Next.ItemId != itemId)
                    temp = temp.Next;

                if (temp.Next != null)
                    temp.Next = temp.Next.Next;
            }

            // Update quantity
            public void UpdateQuantity(int itemId, int newQty)
            {
                InventoryItem temp = Head;
                while (temp != null)
                {
                    if (temp.ItemId == itemId)
                    {
                        temp.Quantity = newQty;
                        return;
                    }
                    temp = temp.Next;
                }
            }

            // Search by ID
            public InventoryItem SearchById(int itemId)
            {
                InventoryItem temp = Head;
                while (temp != null)
                {
                    if (temp.ItemId == itemId)
                        return temp;
                    temp = temp.Next;
                }
                return null;
            }

            // Search by Name
            public InventoryItem SearchByName(string name)
            {
                InventoryItem temp = Head;
                while (temp != null)
                {
                    if (temp.ItemName.Equals(name))
                        return temp;
                    temp = temp.Next;
                }
                return null;
            }

            // Total inventory value
            public double CalculateTotalValue()
            {
                double total = 0;
                InventoryItem temp = Head;

                while (temp != null)
                {
                    total += temp.Price * temp.Quantity;
                    temp = temp.Next;
                }

                return total;
            }

            // Sort by Name
            public void SortByName(bool ascending)
            {
                for (InventoryItem i = Head; i != null; i = i.Next)
                {
                    for (InventoryItem j = i.Next; j != null; j = j.Next)
                    {
                        if ((ascending && string.Compare(i.ItemName, j.ItemName) > 0) ||
                            (!ascending && string.Compare(i.ItemName, j.ItemName) < 0))
                        {
                            SwapData(i, j);
                        }
                    }
                }
            }

            // Sort by Price
            public void SortByPrice(bool ascending)
            {
                for (InventoryItem i = Head; i != null; i = i.Next)
                {
                    for (InventoryItem j = i.Next; j != null; j = j.Next)
                    {
                        if ((ascending && i.Price > j.Price) ||
                            (!ascending && i.Price < j.Price))
                        {
                            SwapData(i, j);
                        }
                    }
                }
            }

            private void SwapData(InventoryItem a, InventoryItem b)
            {
                int id = a.ItemId;
                string name = a.ItemName;
                int qty = a.Quantity;
                double price = a.Price;

                a.ItemId = b.ItemId;
                a.ItemName = b.ItemName;
                a.Quantity = b.Quantity;
                a.Price = b.Price;

                b.ItemId = id;
                b.ItemName = name;
                b.Quantity = qty;
                b.Price = price;
            }

            public void DisplayAll(InventoryUtility util)
            {
                InventoryItem temp = Head;
                while (temp != null)
                {
                    util.Print(temp);
                    temp = temp.Next;
                }
            }
        }
    }


