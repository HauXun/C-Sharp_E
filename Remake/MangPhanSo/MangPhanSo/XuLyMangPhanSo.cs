using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace MangPhanSo
{
	class XuLyMangPhanSo
	{
		public List<PhanSo> a = new List<PhanSo>();
		private int n;

		#region Nhập xuất cơ bản 🚀🚀🚀
		public void Nhap()
		{
			Write("\n Nhập vào kich thước danh sách mảng phân số >> ");
			n = int.Parse(ReadLine());
			for (int i = 0; i < n; i++)
			{
				a[i] = new PhanSo();
				a[i].Nhap();
				a.Add(a[i]);
			}
			Write("\nAccess...");
		}
		public void NhapTuDong()
		{
			Write("\n Nhập vào kich thước danh sách mảng phân số >> ");
			n = int.Parse(ReadLine());
			Random r = new Random();
			int r1;
			int r2;
			for (int i = 0; i < n; i++)
			{
				do
				{
					r1 = r.Next(10 * -1, 10);
					r2 = r.Next(10 * -1, 10);
				} while (r2 == 0);
				a.Add(new PhanSo(r1, r2));
			}
			Write("\nAccess...");
		}
		private void LastInsert(PhanSo x) => a.Add(x);
		public void NhapTuFile()
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
				LastInsert(new PhanSo(numerator, denominator));
			}
		}
		public void Xuat(List<PhanSo> phanSo)
		{
			Write("\n");
			int i = 0;
			foreach (var item in phanSo)
			{
				i++;
				Write("{0, 10}", item.ToString());
				if ((i + 1) % 10 == 0)
					Write('\n');
			}
			Write('\n');
		}
		#endregion

		private float CompareTo(PhanSo a, PhanSo b)
		{
			var x = a.TuSo / a.MauSo;
			var y = b.TuSo / b.MauSo;
			return x.CompareTo(y);
		}


		#region Tìm kiếm 🕵️‍♀️🕵️‍♀️🕵️‍♀️
		private float MaxAm() => PhanSoAm().Max(x => x.GiaTri);
		private float MaxDuong() => PhanSoDuong().Max(x => x.GiaTri);
		private float MinAm() => PhanSoAm().Min(x => x.GiaTri);
		private float MinDuong() => PhanSoDuong().Min(x => x.GiaTri);
		public List<PhanSo> PhanSoAm() => a.FindAll(x => x < 0);
		public List<PhanSo> PhanSoDuong() => a.FindAll(x => x > 0);
		public PhanSo PhanSoAmMax() => a.Find(x => x == MaxAm());
		public PhanSo PhanSoAmMin() => a.Find(x => x == MinAm());
		public PhanSo PhanSoDuongMax() => a.Find(x => x == MaxDuong());
		public PhanSo PhanSoDuongMin() => a.Find(x => x == MinDuong());
		#endregion
		#region Xóa 🚩🚩🚩
		#endregion
		#region Đếm 👩‍🏫👩‍🏫👩‍🏫
		public int DemPhanSoAm() => a.Count(x => x.GiaTri < 0);
		public int DemPhanSoDuong() => a.Count(x => x.GiaTri > 0);
		public int DemTuSoX(float x) => a.Count(obj => obj.TuSo == x);
		public int DemMauSoX(float x) => a.Count(obj => obj.MauSo == x);
		#endregion
		#region Thêm 👨‍🎓👨‍🎓👨‍🎓
		#endregion
		#region Sắp xếp 👩‍⚖️👩‍⚖️👩‍⚖️
		#endregion
		#region Tổng 👨‍✈️👨‍✈️👨‍✈️
		#endregion
	}
}
