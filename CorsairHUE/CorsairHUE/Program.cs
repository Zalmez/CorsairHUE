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
    class Program
    {

        config info = new config();

        static void Main(string[] args)
        {
            GetRequest("http://192.168.1.147/api/gE-MPDaj7yN606rlKmva6vBpWf2r8vukskbkj04e/lights/2/");
            HUELights lightControl = new HUELights();

            async void GetRequest(string url)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync();
                            Console.WriteLine(mycontent);
                        }
                    }
                }
            }

            async void POSTRequest(string url)
            {
                IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("","")
                };
                HttpContent q = new FormUrlEncodedContent(queries);
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.PostAsync(url, q))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string mycontent = await content.ReadAsStringAsync();
                            Console.WriteLine(mycontent);
                        }
                    }
                }
            }


            //config info = new config();
            //WebClient c = new WebClient();
            //var data = c.DownloadString("http://192.168.1.147/api/gE-MPDaj7yN606rlKmva6vBpWf2r8vukskbkj04e/lights/2/");
            //JObject o = JObject.Parse(data);
            //Console.WriteLine("State: "+o["state"]);

            Console.ReadKey();
        }
    }
}
