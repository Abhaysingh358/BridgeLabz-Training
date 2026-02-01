using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBookSystem // interface for uc6
    {
        void AddAddressBook();
        void DisplayAddressBooks();
        AddressBook SelectAddressBook();
        void SearchPersonByCity(); // for uc8
        void SearchPersonByState(); // for uc8
        void ViewPersonsByCity(); // uc9
        void ViewPersonsByState(); //uc9
        void CountByCity(); //  uc10
        void CountByState(); // uc10
    }
}
