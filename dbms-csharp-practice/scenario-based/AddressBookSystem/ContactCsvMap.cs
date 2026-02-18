using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

/* Error : 
Types that inherit IEnumerable cannot be auto mapped.
Did you accidentally call GetRecord or WriteRecord which acts on a single record
instead of calling GetRecords or WriteRecords which acts on a list of records?
*/

// to avoid above error we need to create a class map for our Contact class and
// then we can use that class map to read and write csv files using CsvHelper library.

//“CsvHelper uses reflection for mapping. To avoid ambiguity and ensure reliable serialization,
//I used a ClassMap to explicitly define how Contact fields map to CSV columns.”

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    public class ContactCsvMap : ClassMap<Contact>
    {
        public ContactCsvMap()
        {
            Map(m => m.FirstName);
            Map(m => m.LastName);
            Map(m => m.Address);
            Map(m => m.City);
            Map(m => m.State);
            Map(m => m.Zip);
            Map(m => m.PhoneNumber);
            Map(m => m.Email);
        }
    }
}

