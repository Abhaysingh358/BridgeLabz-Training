using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class AddressBookNode
    {
        private AddressBook data;
        private AddressBookNode next;

        public AddressBookNode(AddressBook data)
        {
            this.data = data;
            this.next = null;
        }

        public AddressBook GetData()
        {
            return data;
        }

        public void SetData(AddressBook data)
        {
            this.data = data;
        }

        public AddressBookNode GetNext()
        {
            return next;
        }

        public void SetNext(AddressBookNode next)
        {
            this.next = next;
        }
    }
}
