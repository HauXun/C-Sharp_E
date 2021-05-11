using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Mang1ChieuSoNguyen
{
	class XuLyMang
	{
		#region Nhập xuất cơ bản 🚀🚀🚀
		public void Nhap(List<int> a, int n)
		{
			WriteLine("\n Nhập vào mỗi phần tử trong mảng...");
			for (int i = 0; i < n; i++)
			{
				Write(" a[{0}] = ", i);
				a.Add(int.Parse(ReadLine()));
			}
		}
		public void NhapTuDong(List<int> a, int n)
		{
			Random random = new Random();
			for (int i = 0; i < n; i++)
				a.Add(random.Next(-10, 10));
		}
		public void Xuat(List<int> a)
		{
			Write("\n");
			foreach (var item in a)
				Write("{0, 5}", item);
			WriteLine("\n Kích thước của mảng là >> " + a.Count);
		}
		#endregion
		#region Tìm kiếm 🕵️‍♀️🕵️‍♀️🕵️‍♀️
		public int ViTriDauTien(List<int> a, object x) => a.IndexOf((int)x);
		public int ViTriCuoiCung(List<int> a, object x) => a.LastIndexOf((int)x);
		public object Max(List<int> a) => a.Max();
		public object Min(List<int> a) => a.Min();
		public List<int> SoAm(List<int> a) => (from enumVal in a where enumVal < 0 select enumVal).ToList();
		public List<int> SoDuong(List<int> a) => (from enumVal in a where enumVal > 0 select enumVal).ToList();
		public List<int> SoChan(List<int> a) => (from enumVal in a where (enumVal % 2) == 0 select enumVal).ToList();
		public List<int> SoLe(List<int> a) => (from enumVal in a where (enumVal % 2) != 0 select enumVal).ToList();
		public List<int> LonHonX(List<int> a, object x) => (from enumVal in a where enumVal > (int)x select enumVal).ToList();
		public List<int> NhoHonX(List<int> a, object x) => (from enumVal in a where enumVal < (int)x select enumVal).ToList();
		public List<int> TuViTri(List<int> a, int location) => a.Skip(location).Take(a.Count - location).ToList();
		#endregion
		#region Xóa 🚩🚩🚩
		public void XoaDau(List<int> a) => a.RemoveAt(0);
		public void XoaCuoi(List<int> a) => a.RemoveAt(a.Count - 1);
		public void XoaTaiViTri(List<int> a, int location) => a.RemoveAt(location);
		public void XoaDuong(List<int> a) => a.RemoveAll(x => x > 0);
		public void XoaAm(List<int> a) => a.RemoveAll(x => x < 0);
		public void XoaChan(List<int> a) => a.RemoveAll(x => (x % 2) == 0);
		public void XoaLe(List<int> a) => a.RemoveAll(x => (x % 2) != 0);
		public void XoaNhieuNhat(List<int> a) => a.Mode(ExtensionMethod.MinMax.Max).ForEach(x => a.RemoveAll(p => p == x));
		public void XoaItNhat(List<int> a) => a.Mode(ExtensionMethod.MinMax.Min).ForEach(x => a.RemoveAll(p => p == x));
		public bool IsPrime(int number)
		{
			if (number < 2)
				return false;
			for (int i = 2; i <= number / 2; i++)
				if (number % i == 0)
					return false;
			return true;
		}
		public void XoaSoNguyenTo(List<int> a) => a.RemoveAll(x => (IsPrime(x)));
		public void XoaMangTrongMang(List<int> a, List<int> b)
		{
			// Đếm xem có bao nhiêu phần tử a trong mảng b
			int size = a.Count(x => b.Contains(x));
			if (size == a.Count)
				return;
			List<int> copy = new List<int>(a);
			copy.ForEach(x => { if (b.Contains(x)) a.Remove(x); });
		}
		#endregion
		#region Đếm 👩‍🏫👩‍🏫👩‍🏫
		public int DemSoDuong(List<int> a) => a.Count(x => x > 0);
		public int DemSoAm(List<int> a) => a.Count(x => x < 0);
		public int DemSoChan(List<int> a) => a.Count(x => (x % 2) == 0);
		public int DemSoLe(List<int> a) => a.Count(x => (x % 2) != 0);
		public int DemSoNguyenTo(List<int> a) => a.Count(x => IsPrime(x));
		public int DemX(List<int> a, int x) => a.Count(p => p == x);
		#endregion
		#region Thêm 👨‍🎓👨‍🎓👨‍🎓
		public void ThemDau(List<int> a, int x) => a.Insert(0, x);
		public void ThemCuoi(List<int> a, int x) => a.Insert(a.Count, x);
		public void ThemTaiViTri(List<int> a, int x, int location) => a.Insert(location, x);
		public void ThemMangVaoDau(List<int> a, List<int> b) => a.InsertRange(0, b);
		public void ThemMangVaoCuoi(List<int> a, List<int> b) => a.InsertRange(a.Count, b);
		public void ThemMangVaoViTri(List<int> a, List<int> b, int location) => a.InsertRange(location, b);
		#endregion
		#region Sắp xếp 👩‍⚖️👩‍⚖️👩‍⚖️
		public void SapXepTang(List<int> a) => a.Sort();
		public List<int> SapXepGiam(List<int> a) => (from x in a orderby x descending select x).ToList();
		#endregion
		#region Thay thế 👨‍✈️👨‍✈️👨‍✈️
		public void ThayThe(List<int> a, int x, int y)
		{
			do
			{
				a[a.FindIndex(index => index.Equals(x))] = y;
			} while (a.Contains(x));
		}
		#endregion
	}
}
