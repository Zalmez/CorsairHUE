using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsairHUE
{
    class config
    {
        string HUEName()
        {
            return "MPDaj7yN606rlKmva6vBpWf2r8vukskbkj04e";
        }

        public string JSONURL()
        {
            var _url = "http://192.168.1.147/api/" + HUEName() + "/";
            return _url;
        }

        public string JSONURL(string IP)
        {
            string _url = "http://" + IP + "/api/" + HUEName() + "/";
            return _url;
        }
    }
}
