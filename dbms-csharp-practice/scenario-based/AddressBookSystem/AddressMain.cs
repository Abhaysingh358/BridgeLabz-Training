using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressMain
    {
        static async Task Main(string[] args)
        {
            AddressMenu menu = new AddressMenu();
            await menu.ShowMenu();
        }

    }
}

