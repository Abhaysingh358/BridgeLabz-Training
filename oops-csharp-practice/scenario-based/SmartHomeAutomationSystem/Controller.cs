using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class Controller  
    {
        private IControllable[] devices = new IControllable[10];
        private int count = 0;

        // Add Devices 

        public void AddLight()
        {
            if (count >= devices.Length)
                return;

            Light light = new Light();
            light.SetDeviceId(count + 1);
            light.SetDeviceName("Light");
            light.SetLocation("Living Room");
            light.SetBrightnessLevel(50);
            light.SetColor("White");
            light.SetIsDimmable(true);
            light.SetLightType("LED");

            devices[count++] = light;
        }

        public void AddFan()
        {
            if (count >= devices.Length)
                return;

            Fan fan = new Fan();
            fan.SetDeviceId(count + 1);
            fan.SetDeviceName("Fan");
            fan.SetLocation("Bedroom");
            fan.SetSpeedLevel(2);
            fan.SetSwingEnabled(true);
            fan.SetFanMode("Normal");

            devices[count++] = fan;
        }

        public void AddAC()
        {
            if (count >= devices.Length)
                return;

            AC ac = new AC();
            ac.SetDeviceId(count + 1);
            ac.SetDeviceName("AC");
            ac.SetLocation("Hall");
            ac.SetTemperatureSetting(24);
            ac.SetMode("Cooling");
            ac.SetFanSpeed(2);
            ac.SetEnergySavingEnabled(true);
            ac.SetCurrentRoomTemperature(30);

            devices[count++] = ac;
        }

        // Turn ON / OFF All 

        // AC will NOT be turned ON here
        public void TurnOnAllDevices()
        {
            for (int i = 0; i < count; i++)
            {
                if (!(devices[i] is AC))
                {
                    devices[i].TurnOn();
                }
            }
        }

        public void TurnOffAllDevices()
        {
            for (int i = 0; i < count; i++)
            {
                devices[i].TurnOff();
            }
        }

        // Turn ON / OFF Only AC

        public void TurnOnAC()
        {
            for (int i = 0; i < count; i++)
            {
                if (devices[i] is AC)
                {
                    devices[i].TurnOn();
                }
            }
        }

        public void TurnOffAC()
        {
            for (int i = 0; i < count; i++)
            {
                if (devices[i] is AC)
                {
                    devices[i].TurnOff();
                }
            }
        }

        // Display 

        public void DisplayAllDevices()
        {
            for (int i = 0; i < count; i++)
            {
                Appliances appliance = (Appliances)devices[i];
                System.Console.WriteLine(appliance.ToString());
            }
        }

    }
}
