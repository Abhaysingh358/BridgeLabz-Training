using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
  
        internal interface IParcelTracker
        {
            void AddParcelDetails();
            void AddParcelCheckPoint();

            void DisplayParcelDetails();
            void DisplayParcelTracking();

            void ShowCurrentStatus();
        }
}
