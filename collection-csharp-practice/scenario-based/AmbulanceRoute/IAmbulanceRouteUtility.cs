using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AmbulanceRoute
{
    internal interface IAmbulanceRouteUtility
    {
        void AddHospitalUnit();
        void RedirectPatient();
        void MarkUnderMaintenance();
        void RemoveHospitalUnit();
        void DisplayRoute();
    }
}

