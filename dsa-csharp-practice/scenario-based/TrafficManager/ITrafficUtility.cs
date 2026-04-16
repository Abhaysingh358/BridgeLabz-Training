using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal interface ITrafficUtility
    {
        void EnterVehicle();
        void ExitVehicle();
        void DisplayRoundAbout();
        void DisplayWaitingQueue();
        void DisplayAllState();
    }
}
