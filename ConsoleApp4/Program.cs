using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        //static void Main()
        public static async Task Main()
        {



            People man = new People("Nursultan Nazarbaev");
            string data = JsonConvert.SerializeObject(man);
            var url = new Uri("https://api.namescan.io/v3/person-scans/emerald");
            var contentData = new StringContent(data, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            //var header = client.DefaultRequestHeaders.Add("api-key", "50BDC1424A9D4822A15123DBE772167C");
            var header = client.DefaultRequestHeaders;
            //header.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            header.Add("api-key", "50BDC1424A9D4822A15123DBE772167C");

            HttpResponseMessage response = await client.PostAsync(url, contentData);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
            Console.ReadLine();







            ////People man = new People("Nursultan Nazarbaev");
            ////var jsonMan = JsonConvert.SerializeObject(man);

            //var values = new Dictionary<string, string>
            //    {
            //        {"api-key", "50BDC1424A9D4822A15123DBE772167C"},
            //    };

            //HttpClient client = new HttpClient();
            //Uri url = new Uri("https://api.namescan.io/v3/person-scans/emerald");

            ////HttpResponseMessage content = new HttpResponseMessage();
            //var content = new FormUrlEncodedContent(values);
            //var response = client.PostAsync(url, content);


            //People man = new People("Nursultan Nazarbaev");
            //var jsonMan = JsonConvert.SerializeObject(man);
            //HttpClient client = new HttpClient();
            //var url = new Uri("https://api.namescan.io/v3/person-scans/emerald");
            //var request = new HttpRequestMessage();
            //var content = request.Content();

            //client.PostAsync(url,)


        }
    }
}
