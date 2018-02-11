using System;
using System.Net;

namespace API_Hackatemia
{
    class Program
    {
        public Program() //the Constructor function
        {
        }

        static void Main() //the main functions
        {
            Console.WriteLine("Write the name to search: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            string data = Program.GetRequest(name);
            Console.WriteLine(data);
        }

        ///Makes GetRequest and returns the data(json)
        public static string GetRequest(string name)
        {
            string api = "https://newsapi.org/v2/everything?"; //the url of the api
            string apikey = "a93471e18f9f40b186f8e64bc9d48a86"; //The api key for newsapi.org

            string totalUrl = $"{api}q={name}&language=en&apiKey={apikey}";

            string json = new WebClient().DownloadString(totalUrl);

            return json;
        }
    }
}
