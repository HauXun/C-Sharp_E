using System;
using static System.Console;

namespace Exercise_5
{
	class CPU
	{
		public string cpuName;
		public string manufacturer;
		public double price;
		public int yearManufacture;

		public void Creat()
		{
			Write("Enter CPU name: ");
			cpuName = ReadLine();
			Write("Enter manufacturer name: ");
			manufacturer = ReadLine();
			Write("Enter CPU price: ");
			price = double.Parse(ReadLine());
			Write("Enter year of manufacture: ");
			yearManufacture = int.Parse(ReadLine());
		}

		public void Output()
		{
			Write("CPU name is: " + cpuName);
			Write("Manufacturer name is: " + manufacturer);
			Write("CPU price is: " + price);
			Write("Year of manufacture is: " + yearManufacture);
		}
	}
}
