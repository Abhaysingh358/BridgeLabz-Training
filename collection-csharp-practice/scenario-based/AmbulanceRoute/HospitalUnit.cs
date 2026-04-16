using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class HospitalUnit
    {
        private string unitId;
        private string unitName;
        private bool isAvailable;
        private HospitalUnit nextUnit;

        public HospitalUnit(string unitId, string unitName)
        {
            this.unitId = unitId;
            this.unitName = unitName;
            this.isAvailable = true;
            this.nextUnit = null;
        }

        public string GetUnitId()
        {
            return unitId;
        }

        public string GetUnitName()
        {
            return unitName;
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }

        public void MarkAvailable()
        {
            isAvailable = true;
        }

        public void MarkUnderMaintenance()
        {
            isAvailable = false;
        }

        public HospitalUnit GetNextUnit()
        {
            return nextUnit;
        }

        public void SetNextUnit(HospitalUnit next)
        {
            nextUnit = next;
        }
    }
}
