using System;
using static System.Console;

namespace MangPhanSo
{
	class PhanSo
	{
		private int tuSo, mauSo;

		public int TuSo { get => tuSo; set => tuSo = value; }
		public int MauSo
		{
			get => mauSo;
			set
			{
				if (value == 0)
					throw new ArgumentException("Can't divide by zero!");
				mauSo = value;
			}
		}


		public PhanSo() { }

		public PhanSo(int tuSo)
		{
			this.TuSo = tuSo;
			this.MauSo = 1;
		}

		public PhanSo(int tuSo, int mauSo)
		{
			this.TuSo = tuSo;
			this.MauSo = mauSo;
		}

		public void Nhap()
		{
			Write("\n Nhập tử số >> ");
			TuSo = int.Parse(ReadLine());
			do
			{
				Write("\n Nhập mẫu số ( > 0 ) >> ");
				MauSo = int.Parse(ReadLine());
			} while (MauSo == 0);
		}

		public void Xuat() => Write($@" {TuSo}/{MauSo}\t");

		public sealed override string ToString()
		{
			if (TuSo == 0)
				return "0";
			if (MauSo == 1)
				return tuSo.ToString();
			return $@" {TuSo.ToString()}/{MauSo.ToString()}";
		}

		public float GiaTri => (float)TuSo / MauSo;


		#region Nạp chồng biểu thức hai phân số
		public static PhanSo operator +(PhanSo a, PhanSo b)
		{
			PhanSo result = new PhanSo();
			QuyDong(a, b);
			result.TuSo = a.TuSo + b.TuSo;
			result.MauSo = a.MauSo;
			RutGon(result);
			return result;
		}
		public static PhanSo operator -(PhanSo a, PhanSo b)
		{
			PhanSo result = new PhanSo();
			QuyDong(a, b);
			result.TuSo = a.TuSo - b.TuSo;
			result.MauSo = a.MauSo;
			RutGon(result);
			return result;
		}
		public static PhanSo operator *(PhanSo a, PhanSo b)
		{
			PhanSo result = new PhanSo();
			QuyDong(a, b);
			result.TuSo = a.TuSo * b.TuSo;
			result.MauSo = a.MauSo * b.MauSo;
			RutGon(result);
			return result;
		}
		public static PhanSo operator /(PhanSo a, PhanSo b)
		{
			PhanSo result = new PhanSo();
			QuyDong(a, b);
			result.TuSo = a.TuSo * b.TuSo;
			result.MauSo = Math.Abs(a.MauSo * b.TuSo);
			RutGon(result);
			return result;
		}
		public static bool operator ==(PhanSo a, PhanSo b)
		{
			QuyDong(a, b);
			return (a.TuSo == b.MauSo);
		}
		public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);
		public static bool operator >(PhanSo a, PhanSo b)
		{
			QuyDong(a, b);
			return (a.TuSo > b.MauSo);
		}
		public static bool operator <(PhanSo a, PhanSo b)
		{
			QuyDong(a, b);
			return (a.TuSo < b.MauSo);
		}
		public static bool operator >=(PhanSo a, PhanSo b) => (a > b || a == b);
		public static bool operator <=(PhanSo a, PhanSo b) => (a < b || a == b);
		public int CompareTo(PhanSo x, PhanSo y) => x == y ? 0 : (x > y ? 1 : -1);
		#endregion

		#region Nạp chồng biểu thức so sánh phân số với 1 biến số nguyên
		public static bool operator ==(PhanSo a, object b)
		{
			Type type = b.GetType();
			if (type == typeof(int))
				return a.TuSo / a.MauSo == (int)b;
			return a.TuSo / a.MauSo == (float)b;
			//try
			//{
			//	double tempNumber = Convert.ToDouble(b);
			//	return a.TuSo / a.MauSo == tempNumber;
			//}
			//catch (Exception)
			//{
			//	throw new InvalidOperationException("Type of object b should be a numeric type!");
			//}
		}

		public static bool operator !=(PhanSo a, object b)
		{
			Type type = b.GetType();
			if (type == typeof(int))
				return a.TuSo / a.MauSo != (int)b;
			return a.TuSo / a.MauSo != (float)b;
		}

		public static bool operator >(PhanSo a, object b)
		{
			Type type = b.GetType();
			if (type == typeof(int))
				return a.TuSo / a.MauSo > (int)b;
			return a.TuSo / a.MauSo > (float)b;
		}

		public static bool operator <(PhanSo a, object b)
		{
			Type type = b.GetType();
			if (type == typeof(int))
				return a.TuSo / a.MauSo < (int)b;
			return a.TuSo / a.MauSo < (float)b;
		}

		public static bool operator >=(PhanSo a, object b) => a > b || a == b;

		public static bool operator <=(PhanSo a, object b) => a < b || a == b;
		#endregion


		private static int UCLN(int a, int b)
		{
			a = Math.Abs(a);
			b = Math.Abs(b);
			while (b > 0)
			{
				if (a > b)
					a -= b;
				else
					b -= a;
			}
			return Math.Abs(a);
		}
		public static void RutGon(PhanSo phanSo)
		{
			int UC = UCLN(phanSo.TuSo, phanSo.MauSo);
			phanSo.TuSo /= UC;
			phanSo.MauSo /= UC;
		}
		public static void QuyDong(PhanSo a, PhanSo b)
		{
			int mauChung = a.MauSo * b.MauSo;
			a.TuSo *= b.MauSo;
			b.TuSo *= a.MauSo;
			a.TuSo = b.MauSo = mauChung;
		}
	}
}
