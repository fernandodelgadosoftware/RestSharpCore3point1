using RestSharp;
using System;

namespace RestSharpCore3point1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://arest.me");
            //client.Timeout = -1;
            //RestRequest request;
            RestRequest request = new RestRequest("http://arest.me",Method.Get);
            request.AddHeader("Authorization", "Basic YWVUcmFpbmluZzpaWlo=");
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
