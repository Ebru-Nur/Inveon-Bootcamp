using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1.Asenkron.Async__Await
{
    internal class Client
    {
        private readonly HttpClient httpClient;

        public Client()
        {
            httpClient = new HttpClient();
        }

        public async Task FetchDataFromApiAsync(string url)
        {
            try
            {
                Console.WriteLine("API çağrısı başlıyor.");

                // Asenkron olarak API'den veri çek
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Başarılı olup olmadığını kontrol et
                response.EnsureSuccessStatusCode();

                // İçeriği oku
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("API'den alınan veri:");
                Console.WriteLine(content);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP hatası oluştu: {e.Message}");
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine($"Zaman aşımı hatası: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Bilinmeyen bir hata oluştu: {e.Message}");
            }
            finally
            {
                Console.WriteLine("API çağrısı tamamlandı.");
            }
        }
    }
}
