using ConsoleApp1;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string Url = "https://api.coindesk.com/v1/bpi/currentprice.json";
        // Örnek bir public API bulduğum kaynak :https://abhiappmobiledeveloper.medium.com/free-api-huge-list-of-public-apis-for-developertesting-b9cf371282b3

        ClientServis apiService = new ClientServis();
        Console.WriteLine("Senkron çağrı başladı.");
        var syncStartTime = DateTime.Now;

        string syncResult = apiService.GetDataSync(Url);
        var syncEndTime = DateTime.Now;

        Console.WriteLine("Senkron sonuç:");
        Console.WriteLine(syncResult);// Senkron kullanımda ana işlem kesiliyor o yüzden uzun sürer
        Console.WriteLine($"Senkron Süre: {(syncEndTime - syncStartTime).TotalSeconds} saniye\n");

        Console.WriteLine("Asenkron çağrı başladı.");
        var asyncStartTime = DateTime.Now;
        var asyncResult = apiService.GetDataAsync(Url).Result;
        var asyncEndTime = DateTime.Now;
        Console.WriteLine("Asenkron sonuç:");
        Console.WriteLine(asyncResult);
        Console.WriteLine($"Asenkron Süre: {(asyncEndTime - asyncStartTime).TotalSeconds} saniye\n");



    }
}
