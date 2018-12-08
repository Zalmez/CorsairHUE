using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace CorsairHUE
{
    class HUELights
    {
        config info = new config();

        void getState()
        {
            WebClient c = new WebClient();
            var data = c.DownloadString("http://192.168.1.147/api/gE-MPDaj7yN606rlKmva6vBpWf2r8vukskbkj04e/lights/2/");
            JObject o = JObject.Parse(data);
            Console.WriteLine("State: " + o["state"]);
        }

        void SendJSONData(string body, string target)
        {
            var RequestWeb = (HttpWebRequest)WebRequest.Create("http://http://192.168.1.147/api/"+target);
            RequestWeb.ContentType = "application/json";
            RequestWeb.Method = "POST";
        }

        

        

        


    }
}
