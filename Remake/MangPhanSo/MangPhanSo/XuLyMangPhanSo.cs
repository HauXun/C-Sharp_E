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
				if ((i + 1) % 11 == 0)
					Write('\n');
			}
			Write('\n');
		}
		#endregion

		private int CompareTo(PhanSo a, PhanSo b)
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
		public List<PhanSo> PhanSoAm() => a.FindAll(x => x.GiaTri < 0);
		public List<PhanSo> PhanSoDuong() => a.FindAll(x => x.GiaTri > 0);
		public PhanSo PhanSoAmMax() => PhanSoAm().Find(x => x.GiaTri == MaxAm());
		public PhanSo PhanSoAmMin() => PhanSoAm().Find(x => x.GiaTri == MinAm());
		public PhanSo PhanSoDuongMax() => a.Find(x => x.GiaTri == MaxDuong());
		public PhanSo PhanSoDuongMin() => a.Find(x => x.GiaTri == MinDuong());
		public List<int> ViTriPhanSoX(PhanSo x)
		{
			int i = 0;
			List<int> result = new List<int>();
			Dictionary<PhanSo, int> keys = a.ToDictionary(x => x, x => i++);
			foreach (var item in keys)
				if (item.Key.GiaTri.Equals(x.GiaTri))
					result.Add(item.Value);
			return result;
		}
		public List<int> ViTriPhanSoAm()
		{
			int i = 0;
			List<int> result = new List<int>();
			Dictionary<PhanSo, int> keys = a.ToDictionary(x => x, x => i++);
			foreach (var item in keys)
				if (item.Key.GiaTri < 0)
					result.Add(item.Value);
			return result;
		}
		public List<int> ViTriPhanSoDuong()
		{
			int i = 0;
			List<int> result = new List<int>();
			Dictionary<PhanSo, int> keys = a.ToDictionary(x => x, x => i++);
			foreach (var item in keys)
				if (item.Key.GiaTri > 0)
					result.Add(item.Value);
			return result;
		}
		#endregion
		#region Xóa 🚩🚩🚩
		public void XoaDau() => a.RemoveAt(0);
		public void XoaCuoi() => a.RemoveAt(a.Count - 1);
		public void XoaTaiViTri(int location) => a.RemoveAt(location);
		public void XoaX(PhanSo ps) => a.RemoveAll(x => x.GiaTri == ps.GiaTri);
		public void XoaPhanSoTuX(int tuso) => a.RemoveAll(x => x.TuSo == tuso);
		public void XoaPhanSoMauX(int mauso) => a.RemoveAll(x => x.TuSo == mauso);
		public void XoaPhanSoChan() => a.RemoveAll(x => (x.GiaTri % 2) == 0);
		public void XoaPhanSoLe() => a.RemoveAll(x => (x.GiaTri % 2) != 0);
		public void XoaPhanSoAm() => PhanSoAm().ForEach(x => a.Remove(x));
		public void XoaPhanSoDuong() => PhanSoDuong().ForEach(x => a.Remove(x));
		public void XoaPhanSoMax() => a.Remove(PhanSoDuongMax());
		public void XoaPhanSoMin() => a.Remove(PhanSoAmMin());
		public void XoaPhanSoGiongDau()
		{
			List<PhanSo> s = new List<PhanSo>(a.Skip(1));
			s.RemoveAll(x => x.GiaTri == a[0].GiaTri);
			s.Insert(0, a[0]);
			a = s;
		}	
		public void XoaPhanSoGiongCuoi()
		{
			List<PhanSo> s = new List<PhanSo>(a.Take(a.Count - 1));
			s.RemoveAll(x => x.GiaTri == a[a.Count - 1].GiaTri);
			s.Insert(s.Count - 1, a[a.Count - 1]);
			a = s;
		}
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
