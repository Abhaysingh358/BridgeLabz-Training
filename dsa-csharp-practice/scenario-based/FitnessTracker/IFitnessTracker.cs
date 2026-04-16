using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FitnessTracker
{
    internal interface IFitnessTracker
    {
        void AddUser();
        void EnterDailySteps();
        void ShowLeaderboardByDay();
        void SortUsersByStepsBubbleSort();
        void ShowLeaderboard();
    }
}
