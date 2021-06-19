using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex1
{
	class XuLyMang
	{
		public void Nhap(List<int> a)
		{
			Write(" Nhập vào số lượng phần tử muốn nhập >> ");
			int n = Convert.ToInt32(ReadLine());

			for (int i = 0; i < n; i++)
			{
				Write(" Nhập a[{0}] >> ", i);
				a.Add(Convert.ToInt32(ReadLine()));
			}
		}

		/// <summary>
		/// random.Next(i, j);
		/// tham số i >> Giá trị min + 1 nhất có thể random ra
		/// tham số j >> Giá trị max - 1 nhất có thể random ra
		/// </summary>
		/// <param name="a"></param>
		public void NhapTuDong(List<int> a)
		{
			Write(" Nhập vào số lượng phần tử muốn nhập >> ");
			int n = Convert.ToInt32(ReadLine());

			// Lớp dựng sẵn để thực hiện random ngẫu nhiên
			Random random = new Random();

			for (int i = 0; i < n; i++)
			{
				a.Add(random.Next(-10, 10));
			}
		}

		public void Xuat(List<int> a)
		{
			Write('\n');

			//foreach (var item in a)
			//{
			//	// Canh lề chuỗi sau khi xuất ra 6 ô trống
			//	Write("{0, 6}\t", item);
			//}

			int i = 0;
			a.ForEach((x) =>
			{
				if ((++i + 1) % 10 == 0)
					Write('\n');
				Write("{0, 6}\t", x);
			});

			//a.Count lấy ra số lượng phần tử trong list(danh sách)
			WriteLine(" \nKích của mảng là >> " + a.Count);
		}

		public int ViTriDauTien(List<int> a, object x) => a.IndexOf((int)x);
		//{
		//	int n = a.Count;
		//	for (int i = 0; i < n; i++)
		//	{
		//		if (a[i] == (int)x)
		//		{
		//			return i;
		//		}	
		//	}
		//	return -1;
		//}

		public int ViTriCuoiCung(List<int> a, object x) => a.LastIndexOf((int)x);
		//{
		//	int n = a.Count;
		//	//for (int i = n - 1; i >= 0; i--)
		//	//{
		//	//	if (a[i] == (int)x)
		//	//	{
		//	//		return i;
		//	//	}
		//	//}
		//	//return -1;
		//	int idx = -1;
		//	for (int i = 0; i < n; i++)
		//	{
		//		if (a[i] == (int)x)
		//		{
		//			idx = i;
		//		}
		//	}
		//	return idx;
		//}

		public int PhanTuMax(List<int> a) => a.Max();
		//{
		//	int max = -1;
		//	foreach (var item in a)
		//	{
		//		if (item > max)
		//			max = item;
		//	}
		//	return max;
		//}

		public int PhanTuMin(List<int> a) => a.Min();
		//{
		//	int min = 10000;
		//	foreach (var item in a)
		//	{
		//		if (item < min)
		//			min = item;
		//	}
		//	return min;
		//}

		public List<int> MangSoAm(List<int> a) => (from value in a where value < 0 select value).ToList();
		//{
		//	List<int> result = new List<int>();
		//	foreach (var item in a)
		//	{
		//		if (item < 0)
		//		{
		//			result.Add(item);
		//		}	
		//	}
		//	return result;
		//}

		public List<int> MangSoDuong(List<int> a) => a.FindAll((x) => x > 0);
		//{
		//	List<int> result = new List<int>();
		//	foreach (var item in a)
		//	{
		//		if (item > 0)
		//		{
		//			result.Add(item);
		//		}
		//	}
		//	return result;
		//}

		public List<int> TimTuViTri(List<int> a, int vitri) => a.Skip(vitri).Take(a.Count - vitri).ToList();
		//{
		//	int n = a.Count;
		//	List<int> result = new List<int>();
		//	for (int i = vitri; i < n; i++)
		//	{
		//		result.Add(a[i]);
		//	}
		//	return result;
		//}

		private int DemPhanTu(List<int> a, int x)
		{
			int dem = 0;
			foreach (var item in a)
			{
				if (item == x)
					dem++;
			}
			return dem;
		}

		private int XuatHienNhieuNhat(List<int> a)
		{
			int max = -1;
			foreach (var item in a)
			{
				int demItem = DemPhanTu(a, item);
				if (demItem > max)
					max = demItem;
			}
			return max;
		}

		private int XuatHienItNhat(List<int> a)
		{
			int min = int.MaxValue;
			foreach (var item in a)
			{
				int demItem = DemPhanTu(a, item);
				if (demItem < min)
					min = demItem;
			}
			return min;
		}

		private bool TonTaiX(List<int> a, int x)
		{
			foreach (var item in a)
			{
				if (item == x)
					return true;
			}
			return false;
		}

		public List<int> MangXuatHienNhieuNhat(List<int> a)
		{
			int x = XuatHienNhieuNhat(a);
			List<int> result = new List<int>();
			foreach (var item in a)
			{
				if (DemPhanTu(a, item) == x && !TonTaiX(result, item))
					result.Add(item);
			}
			return result;
		}

		public List<int> MangXuatHienItNhat(List<int> a)
		{
			int x = XuatHienItNhat(a);
			List<int> result = new List<int>();
			foreach (var item in a)
			{
				if (DemPhanTu(a, item) == x && !TonTaiX(result, item))
					result.Add(item);
			}
			return result;
		}

		public void XoaDau(List<int> a)
		{
			try
			{
				a.RemoveAt(0);
			}
			catch (Exception e)
			{
				Write(e.Message);
			}
			finally
			{
				Write("Sau khi thực hiện");
			}
		}

		public void XoaCuoi(List<int> a)
		{
			try
			{
				a.RemoveAt(a.Count - 1);
			}
			catch (Exception e)
			{
				Write(e.Message);
			}
			finally
			{
				Write("Sau khi thực hiện");
			}
		}

		public void XoaSoDuong(List<int> a)
		{
			List<int> b = new List<int>(a);
			foreach (int item in b)
			{
				if (item > 0)
				{
					a.Remove(item);
				}
			}
		}

		public void XoaNhieuNhat(List<int> a)
		{
			int max = XuatHienNhieuNhat(a);
			List<int> b = new List<int>(a);
			foreach (var item in b)
			{
				if (DemPhanTu(a, item) == max && TonTaiX(a, item))
				{
					a.RemoveAll((x) => x == item);
				}
			}
		}

		public bool LaSoNguyenTo(int a)
		{
			if (a < 2)
				return false;
			for (int i = 2; i <= a / 2; i++)
				if (a % i == 0)
					return false;
			return true;
		}

		public void XoaSoNguyen(List<int> a) => a.RemoveAll((x) => LaSoNguyenTo(x));
		//{
		//	a.RemoveAll((x) => LaSoNguyenTo(x));
		//}

		public void XoaMangTrongMang(List<int> a, List<int> b)
		{
			// Đếm xem có bao nhiêu phần tử a ở trong cái mảng b
			int size = a.Count(x => b.Contains(x));
			if (size == a.Count)
				return;
			List<int> copy = new List<int>(a);
			copy.ForEach((x) =>
			{
				if (b.Contains(x))
					a.Remove(x);
			});
		}

		public void ThemDau(List<int> a, int x)
		{
			a.Insert(0, x);
		}

		public void ThemTaiViTri(List<int> a, int x, int vitri)
		{
			a.Insert(vitri, x);
		}

		public void ThemMangVaoDau(List<int> a, List<int> b)
		{
			int n = b.Count;
			for (int i =  n - 1; i >= 0; i--)
			{
				ThemDau(a, b[i]);
			}
		}

		public void ThemMangVaoCuoi(List<int> a, List<int> b)
		{
			int n = b.Count;
			for (int i = 0; i < n; i++)
			{
				ThemDau(a, b[i]);
			}
		}

		public void ThemMangVaoViTri(List<int> a, List<int> b, int vitri)
		{
			int n = b.Count;
			for (int i = 0; i < n; i++)
			{
				ThemTaiViTri(a, b[i], vitri);
			}
		}
	}
}
