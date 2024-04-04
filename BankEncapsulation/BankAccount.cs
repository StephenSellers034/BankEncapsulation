using System;
namespace BankEncapsulation
{
	internal class BankAccount
	{
		private double _balance = 0;

		public void Deposit(double amount )
		{
			 _balance = amount + _balance;
		}

		public double GetBalance()
		{
			Console.WriteLine(_balance);
			return _balance;
		}
	}
}

