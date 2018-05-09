using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NerdBirdCalenday2017
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    class RestClient
    {
        private static HttpClient client = new HttpClient();
        
        public async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://serene-waters-30997.herokuapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Entry>> GetEntryAsync(string path)
        {

            List<Entry> entry = new List<Entry>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                entry = await response.Content.ReadAsAsync<List<Entry>>();
            }
            return entry;
        }


    }
}
