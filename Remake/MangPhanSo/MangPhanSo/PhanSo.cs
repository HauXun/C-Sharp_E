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
	}
}
