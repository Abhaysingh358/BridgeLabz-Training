using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.SmartHomeAutomationSystem
{
    internal class Light : Appliances, IControllable
    {
        private int brightnessLevel;
        private string color;
        private bool isDimmable;
        private string lightType;

        // Getters
        public int GetBrightnessLevel()
        {
            return brightnessLevel;
        }

        public string GetColor()
        {
            return color;
        }

        public bool GetIsDimmable()
        {
            return isDimmable;
        }

        public string GetLightType()
        {
            return lightType;
        }

        // Setters ()
        public void SetBrightnessLevel(int brightnessLevel)
        {
            this.brightnessLevel = brightnessLevel;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetIsDimmable(bool isDimmable)
        {
            this.isDimmable = isDimmable;
        }

        public void SetLightType(string lightType)
        {
            this.lightType = lightType;
        }

        // IControllable implementation
        public void TurnOn()
        {
            SetIsOn(true);

            if (isDimmable && brightnessLevel == 0)
            {
                brightnessLevel = 50; // default brightness
            }
        }

        public void TurnOff()
        {
            SetIsOn(false);
            brightnessLevel = 0;
        }
    }
}
