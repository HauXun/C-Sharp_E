using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace Manage
{
	class Program
	{
		enum Menu
		{
			Exit = 0,
			Input = 1,
			Out = 2,
			CountPhoneNumbersByID,
			FindSub_TheMostPhoneNumbers,
			SortUpByName,
			SortDownByDoB,
			WriteFromFile,
			FindCity_TheMostSub,
			FindCity_AtLeastSub,
			FindSub_AtLeastID,
			Sort_Combined,
			Sortcity,
			FindMonth_WithoutSub,
			FindListSub_ByGender,
			DelSub_Bycity,
			AddNumberPhone_IfJanuary,
			FindDaySub_TheMost,
			OutListStatistical_ByProvincial
		}

		public static void MenuOutput()
		{
			WriteLine("\n".PadRight(30, '=') + " MENU SELECT" + "".PadRight(30, '='));
			WriteLine("0. Enter {0} to exit", (int)Menu.Exit);
			WriteLine("1. Enter {0} to insert information", (int)Menu.Input);
			WriteLine("2. Enter {0} to display contacts", (int)Menu.Out);
			WriteLine("3. Enter {0} to count phone numbers by ID", (int)Menu.CountPhoneNumbersByID);
			WriteLine("4. Enter {0} to find subscriber has the most phone numbers", (int)Menu.FindSub_TheMostPhoneNumbers);
			WriteLine("5. Enter {0} to sort up contacts by name", (int)Menu.SortUpByName);
			WriteLine("6. Enter {0} to sort down contacts by DoB", (int)Menu.SortDownByDoB);
			WriteLine("7. Enter {0} to write information", (int)Menu.WriteFromFile);
			WriteLine("8. Enter {0} to find the city with the most sub", (int)Menu.FindCity_TheMostSub);
			WriteLine("9. Enter {0} to find the city with at least sub", (int)Menu.FindCity_AtLeastSub);
			WriteLine("10. Enter {0} to find the sub with the least numbers phone", (int)Menu.FindSub_AtLeastID);
			WriteLine("11. Enter {0} to sort contacts combined", (int)Menu.Sort_Combined);
			WriteLine("12. Enter {0} to sort sort city list", (int)Menu.Sortcity);
			WriteLine("13. Enter {0} to find a month without sub", (int)Menu.FindMonth_WithoutSub);
			WriteLine("14. Enter {0} to find list sub by gender", (int)Menu.FindListSub_ByGender);
			WriteLine("15. Enter {0} to del all sub by city", (int)Menu.DelSub_Bycity);
			WriteLine("16. Enter {0} to provide additional ID number as phone number if customer was born in January", (int)Menu.AddNumberPhone_IfJanuary);
			WriteLine("17. Enter {0} to find the most day sub", (int)Menu.FindDaySub_TheMost);
			WriteLine("18. Enter {0} to export series of statistical listings by province", (int)Menu.OutListStatistical_ByProvincial);
			WriteLine("".PadRight(71, '=') + "\n");
		}

		public static int SelectMenu(int soMenu)
		{
			int stt = -1;
			while (stt < 0 || stt > soMenu)
			{
				Clear();
				MenuOutput();
				Write("\nEnter the corresponding menu option: ");
				stt = int.Parse(ReadLine());
			}
			return stt;
		}

		public static void ProcessMenu()
		{
			Contacts list = new Contacts();
			List<Subscriber> listSub = new List<Subscriber>();
			List<int> month = new List<int>();
			List<string> subList = new List<string>();
			int menu;
			string[] result;
			string input;
			MenuOutput();
			Write("The total number of functions is currently: ");
			int function = int.Parse(ReadLine());
			Clear();
			do
			{
				menu = SelectMenu(function);
				Write("\n");
				switch ((Menu)menu)
				{
					case Menu.Exit:
						WriteLine("\n0. Enter {0} to exit\n", (int)Menu.Exit);
						return;
					case Menu.Input:
						Clear();
						WriteLine("\n1. Enter {0} to insert information\n", (int)Menu.Input);
						list.ImportFromFile();
						break;
					case Menu.Out:
						Clear();
						WriteLine("\n2. Enter {0} to display array of fractions\n", (int)Menu.Out);
						WriteLine("\nList of contacts...\n");
						list.Output();
						break;
					case Menu.CountPhoneNumbersByID:
						Clear();
						WriteLine("\n3. Enter {0} to count phone numbers by ID\n", (int)Menu.CountPhoneNumbersByID);
						WriteLine("\nList of contacts...\n");
						list.Output();
						Write("\nEnter you ID to check and count: ");
						input = ReadLine();
						WriteLine("\nSubscriber number with ID {0} is {1}", input, list.CountPhoneNumbersByID(input));
						break;
					case Menu.FindSub_TheMostPhoneNumbers:
						Clear();
						WriteLine("\n4. Enter {0} to find subscriber has the most phone numbers", (int)Menu.FindSub_TheMostPhoneNumbers);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe subscriber has the most phone numbers...\n");
						list.FindSub_TheMostPhoneNumbers().Output();
						break;
					case Menu.SortUpByName:
						Clear();
						WriteLine("\n5. Enter {0} to sort up contacts by name", (int)Menu.SortUpByName);
						WriteLine("\nList of contacts...\n");
						list.Output();
						list.SortUpByName();
						WriteLine("\nList of contacts affter sort up by name...\n");
						list.Output();
						break;
					case Menu.SortDownByDoB:
						Clear();
						WriteLine("\n6. Enter {0} to sort down contacts by DoB", (int)Menu.SortDownByDoB);
						WriteLine("\nList of contacts...\n");
						list.Output();
						list.SortDownByDoB();
						WriteLine("\nList of contacts affter sort down by DoB...\n");
						list.Output();
						break;
					case Menu.WriteFromFile:
						Clear();
						WriteLine("\n7. Enter {0} to write information", (int)Menu.WriteFromFile);
						list.WriteFromFile();
						break;
					case Menu.FindCity_TheMostSub:
						Clear();
						WriteLine("\n8. Enter {0} to find the city with the most sub", (int)Menu.FindCity_TheMostSub);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe city with the most subscribers is: ");
						foreach (var item in list.FindCity_TheMostSub())
							Write(item + "\t");
						break;
					case Menu.FindCity_AtLeastSub:
						Clear();
						WriteLine("\n9. Enter {0} to find the city with at least sub", (int)Menu.FindCity_AtLeastSub);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe city with at least subscribers is: ");
						foreach (var item in list.FindCity_AtLeastSub())
							Write(item + "\t");
						break;
					case Menu.FindSub_AtLeastID:
						Clear();
						WriteLine("\n10. Enter {0} to find the sub with the least numbers phone", (int)Menu.FindSub_AtLeastID);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe sub with the least numbers phone is: ");
						foreach (var item in list.FindSub_AtLeastID())
							Write(item + "\t");
						break;
					case Menu.Sort_Combined:
						Clear();
						WriteLine("\n11. Enter {0} to sort contacts combined", (int)Menu.Sort_Combined);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe list of contacts after sort up by name...\n");
						list.SortUp_ByName();
						list.Output();
						WriteLine("\nThe list of contacts after sort down by name...\n");
						list.SortDown_ByName();
						list.Output();
						WriteLine("\nThe list of contacts after sort up by amount of sub...\n");
						list.SortUp_BySubID();
						list.Output();
						WriteLine("\nThe list of contacts after sort down by amount of sub...\n");
						list.SortDown_BySubID();
						list.Output();
						break;
					case Menu.Sortcity:
						Clear();
						WriteLine("\n12. Enter {0} to sort sort city list", (int)Menu.Sortcity);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nThe list of city after sort up by id...\n");
						result = list.SortUpcity_BySubID();
						foreach (var item in result)
							WriteLine(item);
						WriteLine("\nThe list of city after sort down by id...\n");
						result = list.SortDowncity_BySubID();
						foreach (var item in result)
							WriteLine(item);
						break;
					case Menu.FindMonth_WithoutSub:
						Clear();
						WriteLine("\n13. Enter {0} to find a month without sub", (int)Menu.FindMonth_WithoutSub);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nMonths without any subscription are...\n");
						month = list.FindMonth_WithoutSub();
						foreach (var item in month)
							Write(item + "\t");
						break;
					case Menu.FindListSub_ByGender:
						Clear();
						WriteLine("\n14. Enter {0} to find list sub by gender", (int)Menu.FindListSub_ByGender);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nList of sub by gender famale...\n");
						listSub = list.FindListSub_ByGender((GioiTinh)0);
						foreach (var item in listSub)
							WriteLine(item);
						WriteLine("\nList of sub by gender male...\n");
						listSub = list.FindListSub_ByGender((GioiTinh)1);
						foreach (var item in listSub)
							WriteLine(item);
						break;
					case Menu.DelSub_Bycity:
						Clear();
						WriteLine("\n15. Enter {0} to del all sub by city", (int)Menu.DelSub_Bycity);
						WriteLine("\nList of contacts...\n");
						list.Output();
						WriteLine("\nEnter a city name to delete: ");
						input = " " + ReadLine();
						WriteLine("\nNew list of contacts...\n");
						list.DelSub_Bycity(input);
						list.Output();
						break;
					case Menu.AddNumberPhone_IfJanuary:
						Clear();
						WriteLine("\n16. Enter {0} to provide additional ID number as phone number if customer was born in January", (int)Menu.AddNumberPhone_IfJanuary);
						WriteLine("\nList of contacts...\n");
						list.AddNumberPhone_IfJanuary();
						list.Output();
						break;
					case Menu.FindDaySub_TheMost:
						Clear();
						WriteLine("\n17. Enter {0} to find the most day sub", (int)Menu.FindDaySub_TheMost);
						WriteLine("\nThe day with the most subscribers");
						foreach (var item in list.FindDaySub_TheMost())
							Write(item + "\t");
						WriteLine("\nThe day with at least subscribers");
						foreach (var item in list.FindDaySub_AtLeast())
							Write(item + "\t");
						break;
					case Menu.OutListStatistical_ByProvincial:
						Clear();
						WriteLine("\n18. Enter {0} to export series of statistical listings by province", (int)Menu.OutListStatistical_ByProvincial);
						subList = list.FindProvincialList();
						foreach (var item in subList)
						{
							list.OutListStatistical_ByProvincial(item);
							WriteLine("".PadRight(120, '=') + "\n");
							Write("\n\n\n\n".PadRight(10, '-') + "Next".PadRight(10, '-'));
						}
						break;
				}
				ReadLine();
			} while (menu > 0);
		}
		public static void Main(string[] args)
		{
			ProcessMenu();
		}
	}
}
