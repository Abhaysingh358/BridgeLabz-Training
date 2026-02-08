using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    // this interface is only created for testing purpose to test the methods of AddressBook class
    // for MSTest testing , if methods will be void then
    // we can't test them because of void return type so we are returning bool to test the methods.
    public interface IAddressBookLogic
    {
        bool AddContactForTest(Contact contact);
        bool DeleteContactForTest(string firstName);
    }
}
