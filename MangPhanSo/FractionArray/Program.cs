using System;
using static System.Console;

namespace FractionManagement
{
	class FractionManagement
	{
		enum Menu
		{
			Exit = 0,
			Input = 1,
			Out = 2,
			FindMax,
			FindDenominator_X,
			CountNegativeFractions,
			CountPositiveFractions,
			CountNumerator_X,
			CountNumerator_Y,
			FindNegativeFractionMax,
			FindNegativeFractionMin,
			FindPositiveFractionMax,
			FindPositiveFractionMin,
			FindAllNegativeFractions,
			FindAllPositiveFractions,
			FindAllLocationX,
			FindFractionsLocation_Negative_Positive,
			SumOfNegativeFraction,
			SumOfPositiveFraction,
			SumOfFractionsNumeratorX,
			SumOfFractionsDenominatorX,
			DelAtLocation,
			DelAtFirstLocation,
			DelAtLastLocation,
			DelFractionX,
			DelFractionNumeratorX,
			DelFractionDenominatorX,
			DelLikeFirstElement,
			DelLikeLastElement,
			DelAllFractionMin,
			DelMultiLocation,
			AddAtLocation,
			AddAtFirstLocation,
			DelNegativeFraction,
			DelPositiveFraction,
			Sort
		}

		public static void MenuOutput()
		{
			WriteLine("\n".PadRight(30, '=') + " MENU SELECT" + "".PadRight(30, '='));
			WriteLine("0. Enter {0} to exit", (int)Menu.Exit);
			WriteLine("1. Enter {0} to insert information", (int)Menu.Input);
			WriteLine("2. Enter {0} to display array of fractions", (int)Menu.Out);
			WriteLine("3. Enter {0} to find max value", (int)Menu.FindMax);
			WriteLine("4. Enter {0} to find fractions with the same denominator", (int)Menu.FindDenominator_X);
			WriteLine("5. Enter {0} to count negative fractions", (int)Menu.CountNegativeFractions);
			WriteLine("6. Enter {0} to count positive fractions", (int)Menu.CountPositiveFractions);
			WriteLine("7. Enter {0} to count fractions with denominator X in array", (int)Menu.CountNumerator_X);
			WriteLine("8. Enter {0} to count fractions with denominator Y in array", (int)Menu.CountNumerator_Y);
			WriteLine("9. Enter {0} to find the biggest negative fraction", (int)Menu.FindNegativeFractionMax);
			WriteLine("10. Enter {0} to find the smallest negative fraction", (int)Menu.FindNegativeFractionMin);
			WriteLine("11. Enter {0} to find the biggest positive fraction", (int)Menu.FindPositiveFractionMax);
			WriteLine("12. Enter {0} to find the smallest positive fraction", (int)Menu.FindPositiveFractionMin);
			WriteLine("13. Enter {0} to find all negative element in array", (int)Menu.FindAllNegativeFractions);
			WriteLine("14. Enter {0} to find all positive element in array", (int)Menu.FindAllPositiveFractions);
			WriteLine("15. Enter {0} to find all positive of x in array", (int)Menu.FindAllLocationX);
			WriteLine("16. Enter {0} to find position of negative and positive fractions in array", (int)Menu.FindFractionsLocation_Negative_Positive);
			WriteLine("17. Enter {0} to sum all negative fractions in the array", (int)Menu.SumOfNegativeFraction);
			WriteLine("18. Enter {0} to sum all positive fractions in the array", (int)Menu.SumOfPositiveFraction);
			WriteLine("19. Enter {0} to sum all fractions with the numerator x", (int)Menu.SumOfFractionsNumeratorX);
			WriteLine("20. Enter {0} to sum all fractions with the denominator x", (int)Menu.SumOfFractionsDenominatorX);
			WriteLine("21. Enter {0} to delete at location in array", (int)Menu.DelAtLocation);
			WriteLine("22. Enter {0} to delete at first location in array", (int)Menu.DelAtFirstLocation);
			WriteLine("23. Enter {0} to delete at last location in array", (int)Menu.DelAtLastLocation);
			WriteLine("24. Enter {0} to delete fraction x in array", (int)Menu.DelFractionX);
			WriteLine("25. Enter {0} to delete fraction with numerator x in array", (int)Menu.DelFractionNumeratorX);
			WriteLine("26. Enter {0} to delete fraction with denominator x in array", (int)Menu.DelFractionDenominatorX);
			WriteLine("27. Enter {0} to delete all fractions with the same value as the first fraction in the array", (int)Menu.DelLikeFirstElement);
			WriteLine("28. Enter {0} to delete all fractions with the same value as the last fraction in the array", (int)Menu.DelLikeLastElement);
			WriteLine("29. Enter {0} to delete all smallest fractions", (int)Menu.DelAllFractionMin);
			WriteLine("30. Enter {0} to delete multiple locations", (int)Menu.DelMultiLocation);
			WriteLine("31. Enter {0} to add fraction at location", (int)Menu.AddAtLocation);
			WriteLine("32. Enter {0} to add fraction at first location", (int)Menu.AddAtFirstLocation);
			WriteLine("33. Enter {0} to delete negative fractions array", (int)Menu.DelNegativeFraction);
			WriteLine("34. Enter {0} to delete positive fractions array", (int)Menu.DelPositiveFraction);
			WriteLine("35. Enter {0} to sort", (int)Menu.Sort);
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
			FractionArray list = new FractionArray();
			Fraction X = new Fraction();
			int[] result = new int[100];
			int menu;
			int length = 0;
			int numerator;
			int denominator;
			int a;
			MenuOutput();
			Write("The total number of functions is currently: ");
			int function = int.Parse(ReadLine());
			Clear();
			do
			{
				menu = SelectMenu(function);
				int x;
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
						//list.Creat();
						//list.GeneratorRandom();
						break;
					case Menu.Out:
						Clear();
						WriteLine("\n2. Enter {0} to display array of fractions\n", (int)Menu.Out);
						list.Output();
						break;
					case Menu.FindMax:
						Clear();
						WriteLine("\n3. Enter {0} to find max value\n", (int)Menu.FindMax);
						list.FindMax().Output();
						Write(" is max value");
						break;
					case Menu.FindDenominator_X:
						Clear();
						WriteLine("\n4. Enter {0} to find fractions with the same denominator\n", (int)Menu.FindDenominator_X);
						list.Output();
						Write("\nEnter denominator X to find: ");
						list.FindSameDenominator_X(int.Parse(ReadLine())).Output();
						break;
					case Menu.CountNegativeFractions:
						Clear();
						WriteLine("\n5. Enter {0} to count negative fractions\n", (int)Menu.CountNegativeFractions);
						WriteLine("\nNegative fraction array...");
						list.CountNegativeFractions().Output();
						WriteLine("\nThere is {0} negative faction in array", list.CountNegativeFractions().length);
						break;
					case Menu.CountPositiveFractions:
						Clear();
						WriteLine("\n6. Enter {0} to count positive fractions", (int)Menu.CountPositiveFractions);
						WriteLine("\nPositive fraction array...");
						list.CountPositiveFractions().Output();
						WriteLine("\nThere is {0} positive faction in array", list.CountPositiveFractions().length);
						break;
					case Menu.CountNumerator_X:
						Clear();
						WriteLine("\n7. Enter {0} to count fractions with numerator X in array", (int)Menu.CountNumerator_X);
						list.Output();
						Write("\nEnter numerator X to count: ");
						x = int.Parse(ReadLine());
						list.CountNumerator_X(x).Output();
						WriteLine("\nThere is {0} fractions have numerator is {1} in array", list.CountNumerator_X(x).length, x);
						break;
					case Menu.CountNumerator_Y:
						Clear();
						WriteLine("\n8. Enter {0} to count fractions with numerator Y in array", (int)Menu.CountNumerator_Y);
						list.Output();
						Write("\nEnter numerator Y to count: ");
						x = int.Parse(ReadLine());
						list.CountNumerator_X(x).Output();
						WriteLine("\nThere is {0} fractions have numerator is {1} in array", list.CountNumerator_X(x).length, x);
						break;
					case Menu.FindNegativeFractionMax:
						Clear();
						WriteLine("\n9. Enter {0} to find the biggest negative fraction", (int)Menu.FindNegativeFractionMax);
						list.Output();
						WriteLine("\nNegative array...");
						list.CountNegativeFractions().Output();
						WriteLine("\nThe largest negative fraction in array is {0}", list.CountNegativeFractions().FindMax());
						break;
					case Menu.FindNegativeFractionMin:
						Clear();
						WriteLine("\n10. Enter {0} to find the smallest negative fraction", (int)Menu.FindNegativeFractionMin);
						list.Output();
						WriteLine("\nNegative array...");
						list.CountNegativeFractions().Output();
						WriteLine("\nThe largest negative fraction in array is {0}", list.CountNegativeFractions().FindMin());
						break;
					case Menu.FindPositiveFractionMax:
						Clear();
						WriteLine("\n11. Enter {0} to find the biggest positive fraction", (int)Menu.FindPositiveFractionMax);
						list.Output();
						WriteLine("\nPositive array...");
						list.CountPositiveFractions().Output();
						WriteLine("\nThe largest negative fraction in array is {0}", list.CountPositiveFractions().FindMax());
						break;
					case Menu.FindPositiveFractionMin:
						Clear();
						WriteLine("\n12. Enter {0} to find the biggest positive fraction", (int)Menu.FindPositiveFractionMin);
						list.Output();
						WriteLine("\nPositive array...");
						list.CountPositiveFractions().Output();
						WriteLine("\nThe largest negative fraction in array is {0}", list.CountPositiveFractions().FindMin());
						break;
					case Menu.FindAllNegativeFractions:
						Clear();
						WriteLine("\n13. Enter {0} to find all negative element in array", (int)Menu.FindAllNegativeFractions);
						list.Output();
						WriteLine("\nNegative array...");
						list.CountNegativeFractions().Output();
						break;
					case Menu.FindAllPositiveFractions:
						Clear();
						WriteLine("\n14. Enter {0} to find all positive element in array", (int)Menu.FindAllPositiveFractions);
						list.Output();
						WriteLine("\nPositive array...");
						list.CountPositiveFractions().Output();
						break;
					case Menu.FindAllLocationX:
						Clear();
						WriteLine("\n15. Enter {0} to find all positive of x in array", (int)Menu.FindAllLocationX);
						list.Output();
						WriteLine("\nEnter X to find all positive of x in array...");
						X.Creat();
						length = 0;
						result = list.FindAllLocationX(X, ref length);
						if (length == 0)
							WriteLine("\nThere is no fraction X in array");
						else
						{
							WriteLine("\nArray of location X...");

							for (int i = 0; i < length; i++)
								Write(result[i] + "\t");
						}
						break;
					case Menu.FindFractionsLocation_Negative_Positive:
						Clear();
						WriteLine("\n16. Enter {0} to find position of negative and positive fractions in array", (int)Menu.FindFractionsLocation_Negative_Positive);
						list.Output();

						length = 0;
						result = list.FindNegativeLocation(ref length);
						WriteLine("\nArray of negative frations...");
						for (int i = 0; i < length; i++)
							Write(result[i] + "\t");

						Array.Clear(result, 0, result.Length);

						length = 0;
						result = list.FindPositiveLocation(ref length);
						WriteLine("\nArray of positive fractions...");
						for (int i = 0; i < length; i++)
							Write(result[i] + "\t");
						break;
					case Menu.SumOfNegativeFraction:
						Clear();
						WriteLine("\n17. Enter {0} to sum all negative fractions in the array", (int)Menu.SumOfNegativeFraction);
						list.Output();
						WriteLine("\nNegative array...");
						list.CountNegativeFractions().Output();
						WriteLine("\nSum all negative fractions in the array is {0}", list.CountNegativeFractions().Sum());
						break;
					case Menu.SumOfPositiveFraction:
						Clear();
						WriteLine("\n18. Enter {0} to sum all positive fractions in the array", (int)Menu.SumOfPositiveFraction);
						list.Output();
						WriteLine("\npositive array...");
						list.CountPositiveFractions().Output();
						WriteLine("\nSum all positive fractions in the array is {0}", list.CountPositiveFractions().Sum());
						break;
					case Menu.SumOfFractionsNumeratorX:
						Clear();
						WriteLine("\n19. Enter {0} to sum all fractions with the numerator x", (int)Menu.SumOfFractionsNumeratorX);
						list.Output();
						WriteLine("\nEnter the numerator x to calculate the sum: ");
						x = int.Parse(ReadLine());
						list.FindNumeratorX(x);
						if (list.FindNumeratorX(x).length == 0)
							WriteLine("\nThere is no fraction with the numerator x in the array");
						else
						{
							WriteLine("\nArray with numerator {0}...", x);

							list.FindNumeratorX(x).Output();
							WriteLine("\nThe total value of the resulting array is {0}", list.FindNumeratorX(x).Sum());
						}
						break;
					case Menu.SumOfFractionsDenominatorX:
						Clear();
						WriteLine("\n20. Enter {0} to sum all fractions with the denominator x", (int)Menu.SumOfFractionsDenominatorX);
						list.Output();
						WriteLine("\nEnter the denominator x to calculate the sum: ");
						x = int.Parse(ReadLine());
						list.FindDenominatorX(x);
						if (list.FindDenominatorX(x).length == 0)
							WriteLine("\nThere is no fraction with the denominator x in the array");
						else
						{
							WriteLine("\nArray with denominator {0}...", x);

							list.FindDenominatorX(x).Output();
							WriteLine("\nThe total value of the resulting array is {0}", list.FindDenominatorX(x).Sum());
						}
						break;
					case Menu.DelAtLocation:
						Clear();
						WriteLine("\n21. Enter {0} to delete at location in array", (int)Menu.DelAtLocation);
						list.Output();
						Write("\nEnter location to delete: ");
						if (list.DeleteAt(int.Parse(ReadLine())))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nThe location to be deleted is not valid");
						break;
					case Menu.DelAtFirstLocation:
						Clear();
						WriteLine("\n22. Enter {0} to delete at first location in array", (int)Menu.DelAtFirstLocation);
						list.Output();
						list.DeleteAt(0);
						WriteLine("\nNew array...");
						list.Output();
						break;
					case Menu.DelAtLastLocation:
						Clear();
						WriteLine("\n23. Enter {0} to delete at last location in array", (int)Menu.DelAtLastLocation);
						list.Output();
						list.DeleteAt(list.length);
						WriteLine("\nNew array...");
						list.Output();
						break;
					case Menu.DelFractionX:
						Clear();
						WriteLine("\n24. Enter {0} to delete fraction x in array", (int)Menu.DelFractionX);
						list.Output();
						WriteLine("\nEnter fraction x to delete: ");
						X.Creat();
						if (list.DeleteX(X))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nThere is no fraction {0} in the array", X);
						break;
					case Menu.DelFractionNumeratorX:
						Clear();
						WriteLine("\n25. Enter {0} to delete fraction with numerator x in array", (int)Menu.DelFractionNumeratorX);
						list.Output();
						Write("\nEnter numerator x will be deleted: ");
						numerator = int.Parse(ReadLine());
						if (list.DelFractionNumeratorX(numerator))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nThere is no numerator {0} in the array", numerator);
						break;
					case Menu.DelFractionDenominatorX:
						Clear();
						WriteLine("\n26. Enter {0} to delete fraction with denominator x in array", (int)Menu.DelFractionDenominatorX);
						list.Output();
						Write("\nEnter denominator x will be deleted: ");
						denominator = int.Parse(ReadLine());
						if (list.DelFractionDenominatorX(denominator))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nThere is no numerator {0} in the array", denominator);
						break;
					case Menu.DelLikeFirstElement:
						Clear();
						WriteLine("\n27. Enter {0} to delete all fractions with the same value as the first fraction in the array", (int)Menu.DelLikeFirstElement);
						list.Output();
						list.DelLikeTheFirst();
						WriteLine("\nNew array...");
						list.Output();
						break;
					case Menu.DelLikeLastElement:
						Clear();
						WriteLine("\n28. Enter {0} to delete all fractions with the same value as the last fraction in the array", (int)Menu.DelLikeLastElement);
						list.Output();
						list.DelLikeTheLast();
						WriteLine("\nNew array...");
						list.Output();
						break;
					case Menu.DelAllFractionMin:
						Clear();
						WriteLine("\n29. Enter {0} to delete all smallest fractions", (int)Menu.DelAllFractionMin);
						list.Output();
						WriteLine("\nThe smallest fraction in the array is " + list.FindMin());
						WriteLine("\nNew array...");
						list.DeleteX(list.FindMin());
						list.Output();
						break;
					case Menu.DelMultiLocation:
						Clear();
						WriteLine("\n30. Enter {0} to delete multiple locations", (int)Menu.DelMultiLocation);
						list.Output();
						WriteLine("\nEnter the position number to delete: ");
						a = int.Parse(ReadLine());
						for (int i = 0; i < a; i++)
						{
							Write("Location {0} = ", i);
							result[i] = int.Parse(ReadLine());
						}
						list.DelArrayAt(result, a);
						WriteLine("\nArray new...");
						list.Output();
						break;
					case Menu.AddAtLocation:
						Clear();
						WriteLine("31. Enter {0} to add fraction at location", (int)Menu.AddAtLocation);
						list.Output();
						WriteLine("\nEnter the fraction x to insert: ");
						X.Creat();
						Write("\nEnter a location to insert: ");

						if (list.InsertAt(X, int.Parse(ReadLine())))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nThe position to be inserted is not valid!");
						break;
					case Menu.AddAtFirstLocation:
						Clear();
						WriteLine("\n32. Enter {0} to add fraction at first location", (int)Menu.AddAtFirstLocation);
						list.Output();
						WriteLine("\nEnter the fraction x to insert: ");
						X.Creat();
						if (list.InsertAt(X, 0))
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nSomething wrong!");
						break;
					case Menu.DelNegativeFraction:
						Clear();
						WriteLine("\n33. Enter {0} to delete negative fractions array", (int)Menu.DelNegativeFraction);
						list.Output();
						if (list.DelNegativeFraction())
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nArray without negative fractions!");
						break;
					case Menu.DelPositiveFraction:
						Clear();
						WriteLine("\n34. Enter {0} to delete positive fractions array", (int)Menu.DelPositiveFraction);
						list.Output();
						if (list.DelPositiveFraction())
						{
							WriteLine("\nNew array...");
							list.Output();
						}
						else
							WriteLine("\nArray without positive fractions!");
						break;
					case Menu.Sort:
						Clear();
						WriteLine("35. Enter {0} to sort", (int)Menu.Sort);
						WriteLine("\nCurrent Array...");
						list.Output();
						WriteLine("\nSort up...");
						list.SortUp();
						list.Output();
						WriteLine("\nSort increments by numerator...");
						list.SortUpNumerator();
						list.Output();
						WriteLine("\nSort increments by denominator...");
						list.SortUpDenominator();
						list.Output();
						WriteLine("\nSort down...");
						list.SortDown();
						list.Output();
						WriteLine("\nSort descending by numerator...");
						list.SortDownNumerator();
						list.Output();
						WriteLine("\nSort descending by denominator...");
						list.SortDownDenominator();
						list.Output();
						break;
					default:
						break;
				}
				ReadLine();
			} while (menu > 0);
		}
		public static void Main(string[] args)
		{
			//Fraction a = new Fraction(1, 2);
			//Fraction b = new Fraction(3, 4);
			//Fraction c = a.Add(a, b);
			//c.Output();

			ProcessMenu();
		}
	}
}
