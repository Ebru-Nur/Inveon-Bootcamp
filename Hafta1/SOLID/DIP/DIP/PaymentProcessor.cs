using System;

namespace DIP
{
    public class PaymentProcessor
    {
        private readonly IPaymentMethod paymentMethod;
        // bağımlılık yok dışardan gelen parametre ile çalışmakta
        //yeni bir ödeme tipi eklense bile IPaymentMethod dan implemente etmesi yeterli
        public PaymentProcessor(IPaymentMethod paymentMethod) 
        {
            paymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}