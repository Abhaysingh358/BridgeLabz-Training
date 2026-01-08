using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class Appliances
    {
        private int deviceId;
        private string deviceName;
        private bool isOn;
        private string location;

        // Getters
        public int GetDeviceId()
        {
            return deviceId;
        }

        public string GetDeviceName()
        {
            return deviceName;
        }

        public bool GetIsOn()
        {
            return isOn;
        }

        public string GetLocation()
        {
            return location;
        }

        // Protected setters
        public void SetDeviceId(int deviceId)
        {
            this.deviceId = deviceId;
        }

        public void SetDeviceName(string deviceName)
        {
            this.deviceName = deviceName;
        }

        public void SetIsOn(bool isOn)
        {
            this.isOn = isOn;
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }

        public override string ToString()
        {
            return "Device ID : " + deviceId +
                   ", Device Name : " + deviceName +
                   ", Device On : " + isOn +
                   ", Location : " + location;
        }
    }
}

