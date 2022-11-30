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
        public static readonly string baseUrl = "https://api.consumet.org/";

        public static async Task<string> GetAnime(string query)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + $"anime/gogoanime/{query}"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<string> GetRecentEpisodes()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "anime/gogoanime/recent-episodes"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<string> GetTopAiring()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "anime/gogoanime/top-airing"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<string> GetAnimeInfo(string animeId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + $"anime/gogoanime/info/{animeId}"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static async Task<string> GetStreaming(string episodeId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(baseUrl + $"anime/gogoanime/watch/{episodeId}"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return String.Empty;
        }

        public static string JsonFormatting(string jsonstr)
        {
            JToken token = JToken.Parse(jsonstr);
            return token.ToString(Newtonsoft.Json.Formatting.Indented);
        }
    }
}
