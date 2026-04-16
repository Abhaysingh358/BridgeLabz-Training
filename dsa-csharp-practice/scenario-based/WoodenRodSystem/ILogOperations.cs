using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.WoodenRodSystem
{
    internal interface ILogOperations
    {
        void Scenario1(WoodLog[] logs, int rodLength, int kerf);
        void Scenario2(WoodLog[] logs, int rodLength, int allowedWaste, int kerf);
        void Scenario3(WoodLog[] logs, int rodLength, int kerf);
    }
}
