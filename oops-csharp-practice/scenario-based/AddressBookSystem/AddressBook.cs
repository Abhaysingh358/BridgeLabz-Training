using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
    {
        internal class AddressBook
        {
            private Contact[] contacts;
            private int Count;

            public Contact[] GetContacts()
            {
                return contacts;
            }

            public void SetContacts(Contact[] contacts)
            {
            this.contacts = contacts;
            }

            public int GetCount()
            {
            return Count; 
            }

            public void SetCount(int count)
            {
            this.Count = count; 
            }

        public override string ToString()
        {
            return $"Contact : {contacts}";
        }
        }
    }


