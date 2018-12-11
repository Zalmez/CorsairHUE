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
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class jsonHandler
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string postJSON { get; set; }

        public jsonHandler()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

    //    public string PostRequest()
    //    {
    //        string strResponseValue = string.Empty;
    //        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
    //        request.Method = httpMethod.ToString();   

    //        HttpWebRequest response = null;

    //        try
    //        {
    //            response = (HttpWebResponse)request.GetResponse();

    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }

    }
}
