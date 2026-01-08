using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class AC : Appliances, IControllable
    {
        private int temperatureSetting;
        private string mode;
        private int fanSpeed;
        private bool energySavingEnabled;
        private int currentRoomTemperature;

        // Getters
        public int GetTemperatureSetting()
        {
            return temperatureSetting;
        }

        public string GetMode()
        {
            return mode;
        }

        public int GetFanSpeed()
        {
            return fanSpeed;
        }

        public bool GetEnergySavingEnabled()
        {
            return energySavingEnabled;
        }

        public int GetCurrentRoomTemperature()
        {
            return currentRoomTemperature;
        }

        // Setters
        public void SetTemperatureSetting(int temperatureSetting)
        {
            this.temperatureSetting = temperatureSetting;
        }

        public void SetMode(string mode)
        {
            this.mode = mode;
        }

        public void SetFanSpeed(int fanSpeed)
        {
            this.fanSpeed = fanSpeed;
        }

        public void SetEnergySavingEnabled(bool energySavingEnabled)
        {
            this.energySavingEnabled = energySavingEnabled;
        }

        public void SetCurrentRoomTemperature(int currentRoomTemperature)
        {
            this.currentRoomTemperature = currentRoomTemperature;
        }

        // IControllable implementation
        public void TurnOn()
        {
            SetIsOn(true);

            if (temperatureSetting == 0)
            {
                temperatureSetting = 24; // default temperature
            }

            if (fanSpeed == 0)
            {
                fanSpeed = 1; // default fan speed
            }
        }

        public void TurnOff()
        {
            SetIsOn(false);
            fanSpeed = 0;
        }
    }
}

