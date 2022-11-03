using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyStream.Utils
{
    public static class ApiHelper
    {
        public static readonly string baseUrl = "https://reqres.in/api/";
        public static async Task<string> GetAll()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "users"))
                {
                    using(HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static string JsonFormatting(string jsonstr)
        {
            JToken token = JToken.Parse(jsonstr);
            return token.ToString(Newtonsoft.Json.Formatting.Indented);
        }
    }
}
