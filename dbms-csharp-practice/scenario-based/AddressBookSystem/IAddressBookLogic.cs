using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    public interface IAddressBookLogic
    {
        bool AddContactForTest(Contact contact);
        bool DeleteContactForTest(string firstName);
    }
}

