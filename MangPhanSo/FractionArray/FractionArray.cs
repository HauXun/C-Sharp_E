using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace FractionManagement
{
	class FractionArray
	{
		public Fraction[] a = new Fraction[100];
		public int length = 0;

		public void Creat()
		{
			Write("\nEnter the length of array: ");
			length = int.Parse(ReadLine());
			for (int i = 0; i < length; i++)
			{
				a[i] = new Fraction();
				a[i].Creat();
			}
			Write("\nAccess...");
		}

		public void GeneratorRandom()
		{
			WriteLine("Enter the length of array: ");
			length = int.Parse(ReadLine());
			Random r = new Random();
			for (int i = 0; i < length; i++)
				a[i] = new Fraction(r.Next(10), r.Next(10));
			Write("\nAccess...");
		}

		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"data.txt";
			Write("Enter your txt file name to open it: ");
			string keyOpen = ReadLine().ToLower();
			string keyWord = ".txt";
			string a;
			if (keyOpen.Contains('.'))
				a = $@"{keyOpen}";
			else
				a = $@"{keyOpen + keyWord}";
			if (a != path)
			{
				Write("\nFail! Please try...");
				Read();
				return;
			}
			else
			{
				Write("\nAccess...");
			}
			StreamReader file = new StreamReader(a);

			string s;
			while ((s = file.ReadLine()) != null)
			{
				string[] temp = s.Split('/');
				int numerator = int.Parse(temp[0]);
				int denominator = int.Parse(temp[1]);
				LastInsert(new Fraction(numerator, denominator));
			}
		}
		public void Output()
		{
			for (int i = 0; i < length; i++)
				Write(a[i].ToString() + "\t");
		}


		// ========================================================================

		public void LastInsert(Fraction x)
		{
			a[length] = x;
			length++;
		}

		public int CompareTwoFractions(Fraction a, Fraction b)
		{
			float x = (float)a.numerator / a.denominator;
			float y = (float)b.numerator / b.denominator;
			return x.CompareTo(y);
		}
		public void RutGon()
		{
			for (int i = 0; i < length; i++)
				a[i].RutGon();
		}
		public static float Tinh_GT(Fraction a)
		{
			return (float)a.numerator / a.denominator;
		}

		public Fraction FindMax()
		{
			Fraction max = a[0];
			for (int i = 1; i < length; i++)
			{
				//float x = max.numerator * a[i].denominator;
				//float y = a[i].numerator * max.denominator;
				//if (x < y)
				//	max = a[i];

				//if (CompareTwoFractions(max, a[i]) < 0)
				if (max.CompareTwoFractions(a[i]) < 0)
					max = a[i];
			}
			max.RutGon();
			return max;
		}

		public Fraction FindMin()
		{
			//int x, y;
			Fraction min = a[0];
			for (int i = 1; i < length; i++)
			{
				//x = min.numerator * a[i].denominator;
				//y = a[i].numerator * min.denominator;
				//if (x > y)
				//	min = a[i];

				//if (CompareTwoFractions(max, a[i]) > 0)
				if (min.CompareTwoFractions(a[i]) > 0)
					min = a[i];

			}
			min.RutGon();
			return min;
		}

		public FractionArray FindSameDenominator_X(int x)
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
			{
				if (a[i].denominator == x)
					result.LastInsert(a[i]);
			}
			return result;
		}

		public FractionArray CountNegativeFractions()
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
				if (a[i].numerator * a[i].denominator < 0)
					result.LastInsert(a[i]);
			return result;
		}

		public FractionArray CountPositiveFractions()
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
				if (a[i].numerator * a[i].denominator > 0)
					result.LastInsert(a[i]);
			return result;
		}

		public FractionArray CountNumerator_X(int Numerator)
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
				if (a[i].numerator == Numerator)
					result.LastInsert(a[i]);
			return result;
		}

		//public int[] FindAllLocationX(Fraction x)
		//{
		//	List<int> result = new List<int>();
		//	for (int i = 0; i < length; i++)
		//		if (a[i] == x)
		//			result.Add(i);
		//	return result.ToArray();
		//}


		public int[] FindAllLocationX(Fraction x, ref int rLength)
		{
			int[] result = new int[100];
			rLength = 0;
			for (int i = 0; i < length; i++)
				// if(a[i].numerator == x.numerator && a[i].denominator == x.denominator)
				if (a[i].CompareTwoFractions(x) == 0)
					//result[rLength++] = i;
					result[rLength++] = i;
			return result;
		}

		//public int[] FindNegativeLocation()
		//{
		//	List<int> result = new List<int>();
		//	for (int i = 0; i < length; i++)
		//		if (a[i].numerator < 0 || (float)a[i].numerator / a[i].denominator < 0)
		//			result.Add(i);
		//	return result.ToArray();
		//}

		public int[] FindNegativeLocation(ref int rLength)
		{
			int[] result = new int[100];
			for (int i = 0; i < length; i++)
				if (a[i].numerator < 0 || a[i].numerator * a[i].denominator < 0)
					result[rLength++] = i;
			return result;
		}

		//public int[] FindPositiveLocation()
		//{
		//	List<int> result = new List<int>();
		//	for (int i = 0; i < length; i++)
		//		if ((float)a[i].numerator / a[i].denominator > 0)
		//			result.Add(i);
		//	return result.ToArray();
		//}

		public int[] FindPositiveLocation(ref int rlength)
		{
			int[] result = new int[100];
			for (int i = 0; i < length; i++)
				if (a[i].numerator * a[i].denominator > 0)
					result[rlength++] = i;
			return result;
		}

		public Fraction Sum()
		{
			Fraction sum = new Fraction(0, 1);
			for (int i = 0; i < length; i++)
				sum += a[i];
			return sum;
		}

		public FractionArray FindNumeratorX(int numerator)
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
				if (a[i].numerator == numerator)
					result.LastInsert(a[i]);
			return result;
		}

		public FractionArray FindDenominatorX(int denominator)
		{
			FractionArray result = new FractionArray();
			for (int i = 0; i < length; i++)
				if (a[i].denominator == denominator)
					result.LastInsert(a[i]);
			return result;
		}

		//public bool DeleteAt(int location)
		//{
		//	if (location < 0 || location > length)
		//		return false;
		//	List<Fraction> kq = a.ToList();
		//	kq.RemoveAt(location);
		//	a = kq.ToArray();
		//	length--;
		//	return true;
		//}

		public bool DeleteAt(int location)
		{
			if (location < 0 || location > length)
				return false;
			if (location == length - 1)
			{
				length--;
				return true;
			}

			for (int i = location; i < length; i++)
				a[i] = a[i + 1];
			length--;
			return true;
		}

		//public bool DeleteX(Fraction x)
		//{
		//	int[] kq = FindAllLocationX(x);
		//	if (kq.Length != 0)
		//	{
		//		for (int i = kq.Length - 1; i >= 0; i--)
		//			DeleteAt(kq[i]);
		//		return true;
		//	}
		//	return false;
		//}

		public bool DeleteX(Fraction x)
		{
			int length = 0;
			// int[] result = FindAllLocationX(x);
			int[] result = FindAllLocationX(x, ref length);
			if (length != 0)
			{
				for (int i = 0; i < length; i++)
					DeleteAt(result[i]);
				return true;
			}
			return false;
		}

		public bool DelFractionNumeratorX(int numerator)
		{
			// FractionArray result = Tim_TuX(tuSo);
			FractionArray result = FindNumeratorX(numerator);
			if (result.length == 0)
				return false;
			for (int i = 0; i < result.length; i++)
				DeleteX(result.a[i]);
			return true;
		}

		public bool DelFractionDenominatorX(int numerator)
		{
			// FractionArray result = FindDenominatorX(mauSo);
			FractionArray result = FindDenominatorX(numerator);
			if (result.length == 0)
				return false;
			for (int i = 0; i < result.length; i++)
				DeleteX(result.a[i]);
			return true;
		}

		public void DelLikeTheFirst()
		{
			int length = 0;
			// int[] result = FindAllLocationX(a[0]);
			int[] result = FindAllLocationX(a[0], ref length);
			if (length != 0)
			{
				for (int i = 1; i < length; i++)
					DeleteAt(result[i]);
			}
		}

		public void DelLikeTheLast()
		{
			int length = 0;
			// int[] result = FindAllLocationX(a[length - 1]);
			int[] result = FindAllLocationX(a[length - 1], ref length);
			if (length != 0)
			{
				for (int i = length - 2; i >= 0; i--)
					DeleteAt(result[i]);
			}
		}

		public void DelArrayAt(int[] location, int length)
		{
			Array.Sort(location, 0, length);
			for (int i = length - 1; i >= 0; i--)
			{
				if (location[i] < 0 || location[i] > length)
					WriteLine("\nThere is no x position in the array");
				else
					DeleteAt(location[i]);
			}
		}

		//public bool InsertAt(Fraction x, int vt)
		//{
		//	if (vt < 0 || vt > length)
		//		return false;
		//	List<Fraction> result = a.ToList();
		//	result.Insert(vt, x);
		//	a = result.ToArray();
		//	length++;
		//	return true;
		//}

		public bool InsertAt(Fraction x, int location)
		{
			if (location < 0 || location > length)
				return false;
			if (location == length - 1)
			{
				a[length++] = x;
				return true;
			}

			length++;
			for (int i = length - 1; i > location; i--)
				a[i] = a[i - 1];
			a[location] = x;
			return true;
		}

		public bool DelNegativeFraction()
		{
			FractionArray result = CountNegativeFractions();
			if (result.length != 0)
			{
				for (int i = 0; i < result.length; i++)
					DeleteX(result.a[i]);
				return true;
			}
			return false;
		}

		public bool DelPositiveFraction()
		{
			FractionArray result = CountPositiveFractions();
			if (result.length != 0)
			{
				for (int i = 0; i < result.length; i++)
					DeleteX(result.a[i]);
				return true;
			}
			return false;
		}

		public void SortUp()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
				{
					//if (CompareTwoFractions(a[i], a[j]) > 0)
					if (Tinh_GT(a[i]) > Tinh_GT(a[j]))
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
				}
			RutGon();
		}

		public void SortUpDenominator()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
					if (a[i].denominator > a[j].denominator)
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
		}

		public void SortUpNumerator()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
					if (a[i].numerator > a[j].numerator)
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
		}

		public void SortDown()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
					//if (CompareTwoFractions(a[i], a[j]) < 0)
					if (Tinh_GT(a[i]) < Tinh_GT(a[j]))
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
			RutGon();
		}

		public void SortDownDenominator()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
					if (a[i].denominator < a[j].denominator)
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
		}

		public void SortDownNumerator()
		{
			for (int i = 0; i < length - 1; i++)
				for (int j = i + 1; j < length; j++)
					if (a[i].numerator < a[j].numerator)
					{
						Fraction c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
		}
	}
}
