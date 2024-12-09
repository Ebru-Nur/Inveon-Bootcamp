using System;

namespace DIP
{
    public class Bitcoin : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Bitcoin ile {amount:C} ödendi.");
        }
    }
}


