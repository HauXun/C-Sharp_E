using System;
using static System.Console;

namespace FractionManagement
{
	class Fraction
	{
		#region Create, Export, Distribute, and Access
		public int numerator;
		public int denominator;

		public Fraction()
		{
		}

		public Fraction(Fraction a)
		{
			numerator = a.numerator;
			denominator = a.denominator;
		}

		public Fraction(int Numerator)
		{
			numerator = Numerator;
			denominator = 1;
		}
		public Fraction(int Numerator, int Denominator)
		{
			numerator = Numerator;
			denominator = Denominator;
		}

		public void Creat()
		{
			Write("Enter numerator: ");
			numerator = int.Parse(ReadLine());
			do
			{
				Write("Enter demoninator ( > 0 ): ");
				denominator = int.Parse(ReadLine());
			} while (denominator <= 0);
			//RutGon();
		}

		public void Output()
		{
			Write($"{numerator}/{denominator}\t");
		}

		public sealed override string ToString()
		{
			string result = "";
			if (numerator == 0)
				return "0";
			if (denominator == 1)
				return numerator.ToString();
			result += numerator.ToString() + "/" + denominator.ToString();
			return result;
		}
		#endregion Create, Export, Distribute, and Access


		// Find the greatest common divisor
		public static int UCLN(int a, int b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			while (b > 0)
			{
				if (a > b)
					a = a - b;
				else
					b = b - a;
			}
			return Math.Abs(a);
		}


		// Find the least common multiple

		//public static int BCNN(int a, int b)
		//{
		//	return Math.Abs((a * b) / UCLN(a, b));
		//}

		public void RutGon()
		{
			float UC = UCLN(numerator, denominator);
			numerator /= (int)UC;
			denominator /= (int)UC;
			//return this;
		}

		public static void QuyDong(Fraction a, Fraction b)
		{
			//int d;
			//a.RutGon();
			//b.RutGon();
			//d = BCNN(a.denominator, b.denominator);
			//a.numerator *= (d / a.denominator);
			//b.numerator *= (d / b.denominator);
			//a.denominator = b.denominator = d;

			int d = a.denominator * b.denominator;
			a.numerator = a.numerator * b.denominator;
			b.numerator = b.numerator * a.denominator;
			a.denominator = b.denominator = d;
		}

		public static Fraction operator +(Fraction a, Fraction b)
		{
			Fraction result = new Fraction();
			QuyDong(a, b);
			result.numerator = a.numerator + b.numerator;
			result.denominator = a.denominator;
			result.RutGon();
			return result;
		}

		//public Fraction Add(Fraction a)
		//{
		//	return Add(this, a);
		//}

		//public static Fraction operator +(Fraction a, Fraction b)
		//{
		//	return a.Add(b);
		//}

		public static Fraction operator -(Fraction a, Fraction b)
		{
			Fraction result = new Fraction();
			QuyDong(a, b);
			result.numerator = a.numerator - b.numerator;
			result.denominator = a.denominator;
			result.RutGon();
			return result;
		}

		//public Fraction Minus(Fraction a)
		//{
		//	return Minus(this, a);
		//}

		//public static Fraction operator -(Fraction a, Fraction b)
		//{
		//	return a.Minus(b);
		//}

		public static Fraction operator *(Fraction a, Fraction b)
		{
			Fraction result = new Fraction();
			a.RutGon();
			b.RutGon();
			result.numerator = a.numerator * b.numerator;
			result.denominator = a.denominator * b.denominator;
			result.RutGon();
			return result;
		}

		//public Fraction Multi(Fraction a)
		//{
		//	return Multi(this, a);
		//}

		//public static Fraction operator *(Fraction a, Fraction b)
		//{
		//	return a.Multi(b);
		//}

		public static Fraction operator /(Fraction a, Fraction b)
		{
			Fraction result = new Fraction();
			a.RutGon();
			b.RutGon();
			result.numerator = a.numerator * b.denominator;
			result.denominator = Math.Abs(a.denominator * b.numerator);
			result.RutGon();
			return result;
		}

		//public Fraction Divide(Fraction a)
		//{
		//	return Divide(this, a);
		//}

		//public static Fraction operator /(Fraction a, Fraction b)
		//{
		//	return a.Divide(b);
		//}

		public static bool operator ==(Fraction a, Fraction b)
		{
			QuyDong(a, b);
			return (a.numerator == b.numerator);
		}

		public static bool operator !=(Fraction a, Fraction b)
		{
			//QuyDong(a, b);
			//return (a.numerator != b.numerator);
			return !(a == b);
		}

		public static bool operator >(Fraction a, Fraction b)
		{
			QuyDong(a, b);
			return (a.numerator > b.numerator);
		}

		public static bool operator <(Fraction a, Fraction b)
		{
			QuyDong(a, b);
			return (a.numerator < b.numerator);
		}

		public static bool operator >=(Fraction a, Fraction b)
		{
			return (a > b || a == b);
		}

		public static bool operator <=(Fraction a, Fraction b)
		{
			return (a < b || a == b);
		}

		public static Fraction operator ++(Fraction a)
		{
			Fraction one = new Fraction(1);
			return (a + one);
		}

		public static Fraction operator --(Fraction a)
		{
			Fraction one = new Fraction(1);
			return (a - one);
		}

		public int CompareTwoFractions(Fraction a)
		{
			int x = this.numerator * a.denominator;
			int y = this.denominator * a.numerator;
			return (x.CompareTo(y));
		}

		//public static explicit operator float(Fraction a)
		//{
		//	return (float)a.numerator / a.denominator;
		//}
	}
}