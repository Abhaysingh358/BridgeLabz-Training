using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBook
    {
        void AddContact(); // UC1
        void AddMultipleContacts(); // menu use
        void DisplayContact(); // mandatory
        void EditContact(); // UC3
        void DeleteContact(); // mandatory
        void SortContactsByChoice(); // UC11

        void WriteContactsToFile();   // UC13
        void ReadContactsFromFile();  // UC13

        void WriteContactsToCsv();   // UC14
        void ReadContactsFromCsv(); // UC 14
        void WriteContactsToJson();   // UC15
        void ReadContactsFromJson();  // UC15

        Task WriteContactsToJsonServer();   // UC16
        Task ReadContactsFromJsonServer();  // UC16

        // UC17 async methods
        Task WriteContactsToCsvAsync();
        Task ReadContactsFromCsvAsync();
        Task WriteContactsToJsonAsync();
        Task ReadContactsFromJsonAsync();

        // UC18
        Task SaveToDatabase();
        Task ReadFromDatabase();
    }
}
