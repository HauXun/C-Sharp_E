using System;
using static System.Console;

namespace Exercise_1
{
	class Student
	{
		public int code;
		public int day;
		public int month;
		public int year;
		public string name;
		public string address;
		public void Creat()
		{
			Write("Enter your student code: ");
			code = int.Parse(ReadLine());
			Write("Enter your day of birth: ");
			day = int.Parse(ReadLine());
			Write("Enter your month of birth: ");
			month = int.Parse(ReadLine());
			Write("Enter the year of birth: ");
			year = int.Parse(ReadLine());
			Write("Enter your first and last name: ");
			name = ReadLine();
			Write("Enter your address: ");
			address = ReadLine();
		}

		public void Output()
		{
			WriteLine("\nYour student code is: " + code);
			WriteLine("Your day of birth is: " + day);
			WriteLine("Your month of birth is: " + month);
			WriteLine("The year of birth is: " + year);
			WriteLine("Your first and last name is: " + name);
			WriteLine("Your address: " + address);
		}
	}
}
