using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact();
        void AddMultipleContacts();
        void DisplayContact();
        void EditContact();
        void DeleteContact();
        void SortContactsByChoice();
    }
}

