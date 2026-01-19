using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class Node
    {
        private Contact contact;
        private Node next;

        public Node(Contact contact)
        {
            this.contact = contact;
            this.next = null;
        }

        public Contact GetContact()
        {
            return contact;
        }

        public void SetContact(Contact contact)
        {
            this.contact = contact;
        }

        public Node GetNext()
        {
            return next;
        }

        public void SetNext(Node next)
        {
            this.next = next;
        }
    }
}
