using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TaskFonksiyonlar
{
    public static async void BirdenFazlaTask(string[] args)
    {

        var task1 = LoadDataAsync("Kaynak 1");
        var task2 = LoadDataAsync("Kaynak 2");
        var task3 = LoadDataAsync("Kaynak 3");

        var task4 = LoadDataAsync("Kaynak 4");
        var task5 = LoadDataAsync("Kaynak 5");
        var task6 = LoadDataAsync("Kaynak 6");

        // herhangi biri tamamlanıncaya kadar bekle
        var firstCompleted = await Task.WhenAny(task1, task2, task3);

        // hepsi tamamlanıncaya kadar bekle
       await Task.WhenAll(task4, task5, task6);

        await Task.Run(async () =>//arka planda başka bir işi tetikleme
        {
            var task7= await LoadDataAsync("Kaynak 7");
            Console.WriteLine(task7);
        });

        Console.WriteLine(await firstCompleted);


        try
        {
            await FaultyLoadDataAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }

    }

    public static async Task<string> LoadDataAsync(string source)
    {
        var random = new Random();
        int delay = random.Next(1000, 5000);
        await Task.Delay(delay); // bekletme 
        return $"{source} yüklendi. Süre: {delay}";
    }

    public static Task FaultyLoadDataAsync()
    {
        return Task.FromException(new InvalidOperationException("Geçersiz işlem!")); //Task hata yönetme 
    }
}
