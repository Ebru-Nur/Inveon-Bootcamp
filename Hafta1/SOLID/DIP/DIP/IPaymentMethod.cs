using System;

namespace DIP
{
	public interface IPaymentMethod
	{
		void ProcessPayment(decimal amount);
	}

}