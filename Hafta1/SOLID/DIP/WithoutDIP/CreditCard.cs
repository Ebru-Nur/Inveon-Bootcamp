using System;

namespace WithoutDIP
{
    public class CreditCard
    {
        public void MakeCreditCardPayment(decimal amount)
        {
            Console.WriteLine($"Kredi Kart� ile {amount:C} �dendi.");
        }
    }
}
