using System;

namespace WithoutDIP
{
    public class PaymentProcessor
    {
        private CreditCard creditCardPayment;
        public PaymentProcessor()
        {
            creditCardPayment = new CreditCard();
            //doğrudan bağımlı olduğundan yeni bir ödeme sistemi getirildiğinde koda müdahale etmek gerekecek
        }

        public void MakePayment(decimal amount)
        {
            creditCardPayment.MakeCreditCardPayment(amount);
        }
    }
}
