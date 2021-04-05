using System;
using static System.Console;

namespace Exercise_4
{
	class TelephoneDirectory
	{
		public string numberPhone;
		public string customerName;
		public string address;

		public void Creat()
		{
			Write("Enter the customer's phone number: ");
			numberPhone = ReadLine();
			Write("Enter the customer's full name: ");
			customerName = ReadLine();
			Write("Enter the customer's address: ");
			address = ReadLine();
		}

		public void Output()
		{
			WriteLine("The customer's phone number is: " + numberPhone);
			WriteLine("The customer's full name is: " + customerName);
			WriteLine("The customer's address is: " + address);
		}
	}
}
