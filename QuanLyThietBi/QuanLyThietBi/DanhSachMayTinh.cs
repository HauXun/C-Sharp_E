using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace QuanLyThietBi
{
	class DanhSachMayTinh
	{
		public List<MayTinh> listMayTinh = new List<MayTinh>();
		#region Các hàm nhập xuất, định dạng và truy vấn 🚀🚀🚀
		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"maytinh.txt";
			Write("Nhap ten tap tin de mo >> ");
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
				Write("\nAccess...");
			StreamReader file = new StreamReader(a);
			string str = "";
			while ((str = file.ReadLine()) != null)
			{
				MayTinh mayTinh = new MayTinh();
				string[] s = str.Split('*');
				mayTinh.TenMayTinh = s[0];
				foreach (string item in s)
				{

					if (item.IndexOf("CPU") == 0)
						mayTinh.Them(new CPU(item));
					if (item.IndexOf("RAM") == 0)
						mayTinh.Them(new RAM(item));
					if (item.IndexOf("HDD") == 0)
						mayTinh.Them(new HDD(item));
					if (item.IndexOf("Mainboard") == 0)
						mayTinh.Them(new Mainboard(item));
					if (item.IndexOf("Power") == 0)
						mayTinh.Them(new Power(item));
				}
				Them(mayTinh);
			}
		}
		public void Them(MayTinh mt) => listMayTinh.Add(mt);
		public override string ToString()
		{
			string str = null;
			foreach (var item in listMayTinh)
				str += item + "\n";
			return str;
		}
		public void Xuat() => WriteLine(ToString());
		#endregion
		#region Các hàm phân loại danh sách máy tính (☞ﾟヮﾟ)☞
		public void ThemDanhSach(List<string> result, List<string> kieu)
		{
			foreach (var item in kieu)
				if (!result.Contains(item))
					result.Add(item);
		}
		public List<string> DanhSachHangTheoLoai<T>()
		{
			List<string> result = new List<string>();
			foreach (var item in listMayTinh)
				ThemDanhSach(result, item.DanhSachHangTheoLoai<T>());
			return result;
		}
		#endregion
		#region Các hàm tìm kiếm danh sách máy tính ☜(ﾟヮﾟ☜)
		public enum MinMax
		{
			Min,
			Max,
			All
		}
		public float TinhGia<T>(MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return listMayTinh.Min(x => x.GiaTheoLoai<T>());
				case MinMax.Max:
					return listMayTinh.Max(x => x.GiaTheoLoai<T>());
				case MinMax.All:
					return listMayTinh.Sum(x => x.TongGia());
			}
			return 0;
		}
		public DanhSachMayTinh DanhSachMayTinhTheoGia<T>(MinMax minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			result.listMayTinh = listMayTinh.Where(x => x.GiaTheoLoai<T>() == TinhGia<T>(minMax)).ToList();
			return result;
		}
		public int DemTheoHangSX<T>(string hangSX) => listMayTinh.Sum(x => x.DemTheoHangSX<T>(hangSX));
		public int TimSLSDMinMax<T>(MinMax minMax)
		{
			List<string> dsHang = DanhSachHangTheoLoai<T>();
			switch (minMax)
			{
				case MinMax.Min:
					return dsHang.Min(x => DemTheoHangSX<T>(x));
				case MinMax.Max:
					return dsHang.Max(x => DemTheoHangSX<T>(x));
			}
			return 0;
		}
		public List<string> DanhSachXHMinMax<T>(MinMax minMax)
		{
			List<string> result = new List<string>();
			List<string> dsHang = DanhSachHangTheoLoai<T>();
			int obj = TimSLSDMinMax<T>(minMax);
			foreach (var item in dsHang)
				if (DemTheoHangSX<T>(item) == obj)
					result.Add(item);
			return result;
		}
		public DanhSachMayTinh TimDSMayTinhByInput(string hangSX)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			//foreach (var item in listMayTinh)
			//	foreach (var ss in item.DanhSachHang())
			//		if (ss.CompareTo(hangSX) == 0)
			//			result.Them(item);
			listMayTinh.ForEach(item => item.DanhSachHang().ForEach(ss => { if (ss.CompareTo(hangSX) == 0) result.Them(item); }));
			return result;
		}
		#endregion
		#region Các hàm chức năng khác ¯\_(ツ)_/¯
		public void XoaMayTinhTheoHangCPU(string hangSX)
		{
			List<MayTinh> reList = new List<MayTinh>(listMayTinh);
			//foreach (var item in reList)
			//	foreach (var ss in item.DanhSachHangTheoLoai<CPU>())
			//		if (ss.CompareTo(hangSX) == 0)
			//			listMayTinh.Remove(item);
			reList.ForEach(item => item.DanhSachHangTheoLoai<CPU>().ForEach(ss => { if (ss.CompareTo(hangSX) == 0) listMayTinh.Remove(item); }));
		}
		public void CapNhapMayTinh()
		{
			//foreach (var item in listMayTinh)
			//	foreach (var ss in item.list)
			//		if (ss is CPU && ss.HangSX.CompareTo("Intel") == 0)
			//			ss.Gia = 700;
			listMayTinh.ForEach(item => item.list.ForEach(ss => { if (ss.HangSX.CompareTo("Intel") == 0) ss.Gia = 700; }));
		}
		#endregion
	}
}