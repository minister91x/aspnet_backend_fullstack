using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper
{
    public static class ApiHelper
    {
        public static string SendGet(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("postman-token", "4600c295-6f26-bddb-de64-17bbe717838d");
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
