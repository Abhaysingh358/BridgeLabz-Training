using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact(); // UC1
        void AddMultipleContacts(); // menu use
        void DisplayContact(); // mandatory
        void EditContact(); // UC3
        void DeleteContact(); // mandatory
        void SortContactsByChoice(); // UC11
    }
}

