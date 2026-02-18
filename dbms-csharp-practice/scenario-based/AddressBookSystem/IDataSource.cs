using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    // Interface created to follow Open Close Principle
    // Any new data source can be added without modifying existing code
    public interface IDataSource
    {
        Task WriteAsync(List<Contact> contacts, string addressBookName);
        Task ReadAsync(string addressBookName);
    }
}

