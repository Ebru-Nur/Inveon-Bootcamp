using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    public class ClientServis
    {
        public string GetDataSync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetStringAsync(url).Result; 
                return response;
            }
        }

        public async Task<string> GetDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url); // Asenkron kullanım
                return response;
            }
        }
    }

}
