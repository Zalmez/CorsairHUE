using System;
using System.ServiceProcess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Q42.HueApi;

namespace CorsairHUE
{
    class HUELights
    {
        

        
        

        //TODO: Control lights
        private void windowsLogin(string color)
        {
            var command = new LightCommand();
            command.On = true;
            
        }

        private void windowsLock()
        {
            var command = new LightCommand();
            command.TurnOff();
        }

        public void changeLightState()
        {
            
            
        }

    }
}
