using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBook
    {
        public void AddContact(); // uc2
        public void EditContact(); //uc3
        public void DeleteContact(); //uc4

        public void AddMultipleContacts(); // uc5
    }
}
