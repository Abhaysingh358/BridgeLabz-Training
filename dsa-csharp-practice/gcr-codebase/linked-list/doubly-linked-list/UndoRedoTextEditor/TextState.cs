using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.UndoRedoTextEditor
{
    internal class TextState
    {
        public string Content;
        public TextState Prev;
        public TextState Next;

        public TextState(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }
}
