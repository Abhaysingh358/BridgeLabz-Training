using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class Fan : Appliances, IControllable
    {
        private int speedLevel;
        private bool swingEnabled;
        private string fanMode;

        // Getters
        public int GetSpeedLevel()
        {
            return speedLevel;
        }

        public bool GetSwingEnabled()
        {
            return swingEnabled;
        }

        public string GetFanMode()
        {
            return fanMode;
        }

        // Setters
        public void SetSpeedLevel(int speedLevel)
        {
            this.speedLevel = speedLevel;
        }

        public void SetSwingEnabled(bool swingEnabled)
        {
            this.swingEnabled = swingEnabled;
        }

        public void SetFanMode(string fanMode)
        {
            this.fanMode = fanMode;
        }

        // IControllable implementation
        public void TurnOn()
        {
            SetIsOn(true);

            if (speedLevel == 0)
            {
                speedLevel = 1; // default speed
            }
        }

        public void TurnOff()
        {
            SetIsOn(false);
            speedLevel = 0;
        }
    }
}

