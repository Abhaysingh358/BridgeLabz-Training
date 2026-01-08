using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.UndoRedoTextEditor
{
    internal class UndoRedoManager
    {
        private TextState Head;
        private TextState Tail;
        private TextState Current;

        private int MaxSize;
        private int Size;

        public UndoRedoManager(int maxSize)
        {
            MaxSize = maxSize;
            Size = 0;
        }

        // Add new state
        public void AddState(string content)
        {
            TextState newState = new TextState(content);

            // clear redo history
            if (Current != null && Current.Next != null)
            {
                Current.Next.Prev = null;
                Current.Next = null;
                Tail = Current;
                RecalculateSize();
            }

            if (Head == null)
            {
                Head = Tail = Current = newState;
                Size = 1;
                return;
            }

            Tail.Next = newState;
            newState.Prev = Tail;
            Tail = newState;
            Current = newState;
            Size++;

            if (Size > MaxSize)
                RemoveOldest();
        }

        // Undo
        public void Undo()
        {
            if (Current != null && Current.Prev != null)
                Current = Current.Prev;
        }

        // Redo
        public void Redo()
        {
            if (Current != null && Current.Next != null)
                Current = Current.Next;
        }

        // Get current text
        public string GetCurrentText()
        {
            return Current != null ? Current.Content : "";
        }

        private void RemoveOldest()
        {
            if (Head == null) return;

            Head = Head.Next;
            Head.Prev = null;
            Size--;
        }

        private void RecalculateSize()
        {
            Size = 0;
            TextState temp = Head;
            while (temp != null)
            {
                Size++;
                temp = temp.Next;
            }
        }
    }
}
