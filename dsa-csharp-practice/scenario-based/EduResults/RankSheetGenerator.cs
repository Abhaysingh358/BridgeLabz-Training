using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class RankSheetGenerator
    {
        public StudentLinkedList GenerateStateRankList(District[] districts)
        {
            if (districts == null || districts.Length == 0)
                return null;

            // Step 1: sort every district list
            for (int i = 0; i < districts.Length; i++)
            {
                districts[i].SortDistrictList();
            }

            // Step 2: merge into one state list
            StudentLinkedList stateList = null;

            for (int i = 0; i < districts.Length; i++)
            {
                StudentLinkedList districtList = districts[i].GetDistrictList();

                if (districtList == null)
                    continue;

                if (stateList == null)
                {
                    stateList = districtList;
                }
                else
                {
                    // Merge district list into state list
                    stateList.MergeWith(districtList);
                }
            }

            return stateList;
        }
    }
}
