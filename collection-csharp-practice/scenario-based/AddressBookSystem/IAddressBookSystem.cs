using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBookSystem
    {
        void AddAddressBook();
        void DisplayAddressBooks();
        AddressBook SelectAddressBook();
        void SearchPersonByCity();
        void SearchPersonByState();
        void ViewPersonsByCity();
        void ViewPersonsByState();
        void CountByCity();
        void CountByState();
    }
}
