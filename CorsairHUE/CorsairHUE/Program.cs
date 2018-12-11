using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace CorsairHUE
{
    class Program
    {

        public async void CreateBrideConnection()
        {
            var appSettings = ConfigurationManager.AppSettings;

            IBridgeLocator locator = new HttpBridgeLocator();
            //IEnumerable<string> bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            ILocalHueClient client = new LocalHueClient(appSettings["hueIP"]);
            var appkey = await client.RegisterAsync("corsairHUE", "zalmez-pc");
            Ping p1 = new Ping();
            PingReply PR = p1.Send(appSettings["hueIP"]);
            if (PR.Status.ToString().Equals("success"))
            {
                Console.WriteLine("Brigde responed");
                client.Initialize(appkey);
            }

        }



        static void Main(string[] args)
        {
            var client = GetClient();
            Console.WriteLine("AppKey: " + GetSettings("appKey"));
            Console.WriteLine("Bride IP: " + GetSettings("bridgeIP"));
            client.Initialize(GetSettings("appKey"));
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the client
        /// </summary>
        /// <returns>returns the client information</returns>
        static ILocalHueClient GetClient()
        {
            var appSettings = ConfigurationManager.AppSettings;
            ILocalHueClient client = new LocalHueClient(GetSettings("bridgeIP"));
            Console.WriteLine("Connected to Bridge");
            return client;
        }
        /// <summary>
        /// Gets configuration settings
        /// </summary>
        /// <param name="key"></param>
        /// <returns>appsettings[key]</returns>
        static string GetSettings(string key)
        {
            var appsettings = "";

            try
            {
                appsettings = ConfigurationManager.AppSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                appsettings = null;
                Console.WriteLine("Error Reading appsettings");
            }

            return appsettings;

        }

    }
}
