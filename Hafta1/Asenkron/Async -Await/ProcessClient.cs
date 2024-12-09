using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.Asenkron.Async__Await
{
    internal class ProcessClient
    {
        static async Task Main(string[] args)
        {
            Client apiClient = new Client();

            string validUrl = "https://jsonplaceholder.typicode.com/posts/1"; // Geçerli URL
            string invalidUrl = "https://invalidurl.com"; // Geçersiz URL

            // Geçerli URL için işlem
            Console.WriteLine("Geçerli URL:");
            await apiClient.FetchDataFromApiAsync(validUrl);

            Console.WriteLine();

            // Geçersiz URL için işlem
            Console.WriteLine("Geçersiz URL:");
            await apiClient.FetchDataFromApiAsync(invalidUrl);
        }
    }
}
