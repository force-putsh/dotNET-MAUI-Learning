using Code_Quote.Modeles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Quote.Services
{
    
    public class QuoteService
    {
        HttpClient client = new HttpClient();
        public QuoteService()
        {
            client.BaseAddress = new Uri("https://api.quotable.io/");
        }

        public async Task<Quote> GetRandomQuote()
        {
            var response = client.GetAsync("random").Result;
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var quote = JsonConvert.DeserializeObject<Quote>(content);
                return quote;
            }
            return null;
        }
    }
}
