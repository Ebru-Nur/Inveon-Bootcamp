using System;

namespace DIP
{
    public class Havale : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Havale yap�larak {amount:C} �dendi.");
        }
    }
}


