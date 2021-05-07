using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using static System.Console;

namespace QuanLyThietBiV3
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
						mayTinh.Them(new MAINBOARD(item));
					if (item.IndexOf("Power") == 0)
						mayTinh.Them(new PSU(item));
				}
				Them(mayTinh);
			}
		}
		public void Them(MayTinh mt) => listMayTinh.Add(mt);
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			foreach (var item in listMayTinh)
				str.Append(item + "\n");
			return str.ToString();
		}
		public void Xuat() => WriteLine(ToString());
		#endregion
		#region Các hàm phân loại danh sách máy tính (☞ﾟヮﾟ)☞
		public List<string> DanhSachHangTheoLoai<T>()
		{
			List<string> result = new List<string>();
			foreach (var item in listMayTinh)
				if (!result.Contains(item.HangThietBiTheoLoai<T>()))
					result.Add(item.HangThietBiTheoLoai<T>());
			return result;
		}
		public List<float> DanhSachThuocTinhTheoLoai<T>(MayTinh.Tinh tinh)
		{
			List<float> result = new List<float>();
			foreach (var item in listMayTinh)
				if (!result.Contains(item.ThuocTinhTheoLoai(tinh)))
					result.Add(item.ThuocTinhTheoLoai(tinh));
			return result;
		}
		#endregion
		#region Các hàm tìm kiếm danh sách máy tính ☜(ﾟヮﾟ☜)
		public enum MinMax
		{
			Min,
			Max
		}
		public float TinhTheoLoai<T>(MayTinh.Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return listMayTinh.Min(x => x.TinhTheoLoai<T>(tinh));
				case MinMax.Max:
					return listMayTinh.Max(x => x.TinhTheoLoai<T>(tinh));
			}
			return 0;
		}
		public DanhSachMayTinh DanhSachMayTinhTheoLoai<T>(MayTinh.Tinh tinh, MinMax minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			result.listMayTinh = listMayTinh.Where(x => x.TinhTheoLoai<T>(tinh) == TinhTheoLoai<T>(tinh, minMax)).ToList();
			return result;
		}
		public float MinMaxThuocTinh<T>(MayTinh.Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return listMayTinh.Min(x => x.ThuocTinhTheoLoai(tinh));
				case MinMax.Max:
					return listMayTinh.Max(x => x.ThuocTinhTheoLoai(tinh));
			}
			return 0;
		}
		public List<string> DSHangMinMaxThuocTinh<T>(MayTinh.Tinh tinh, MinMax minMax)
		{
			List<string> result = new List<string>();
			foreach (var item in listMayTinh)
				if (item.ThuocTinhTheoLoai(tinh) == MinMaxThuocTinh<T>(tinh, minMax))
					if (!result.Contains(item.HangThietBiTheoLoai<T>()))
						result.Add(item.HangThietBiTheoLoai<T>());
			return result;
		}
		public DanhSachMayTinh DSMTThuocTinhLonHonX<T>(MayTinh.Tinh tinh, float x)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			foreach (var item in listMayTinh)
				if (item.ThuocTinhTheoLoai(tinh) > x)
					result.Them(item);
			return result;
		}
		public DanhSachMayTinh DSMTTheoThuocTinh_Hang<T>(MayTinh.Tinh tinh, float obj, string hangSX)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			foreach (var item in listMayTinh)
				if (item.ThuocTinhTheoLoai(tinh) == obj && String.Compare(item.HangThietBiTheoLoai<T>(), hangSX, true) == 0)
					result.Them(item);
			return result;
		}
		#endregion
		#region Các hàm sắp xếp danh sách máy tinh (☞ﾟヮﾟ)☞
		public enum UpOrDown
		{
			Increase,
			Decrease
		}
		public DanhSachMayTinh SortTheoLoai<T>(MayTinh.Tinh tinh, UpOrDown upOrDown)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (upOrDown)
			{
				case UpOrDown.Increase:
					result.listMayTinh = listMayTinh.OrderBy(x => x.TinhTheoLoai<T>(tinh)).ToList();
					return result;
				case UpOrDown.Decrease:
					result.listMayTinh = listMayTinh.OrderByDescending(x => x.TinhTheoLoai<T>(tinh)).ToList();
					return result;
			}
			return null;
		}
		#endregion
		#region Các chức năng khác 🙆‍🙆‍🙆‍
		public void XoaMayTinhTheoThuocTinh<T>(MayTinh.Tinh tinh, float obj)
		{
			List<MayTinh> reList = new List<MayTinh>(listMayTinh);
			foreach (var item in reList)
				if (item.ThuocTinhTheoLoai(tinh) == obj)
					listMayTinh.Remove(item);
		}
		public void CapNhapMayTinhTheoThuocTinh<T>(MayTinh.Tinh tinh, float obj, float obj2)
		{
			foreach (var item in listMayTinh)
				foreach (var s in item.TimThietBiTheoLoai<T>())
					switch (tinh)
					{
						case MayTinh.Tinh.Speed:
							if (((CPU)s).TocDo == obj)
								((CPU)s).TocDo = obj2;
							break;
						case MayTinh.Tinh.sCapacity:
							if (((RAM)s).DungLuong == obj)
								((RAM)s).DungLuong = (int)obj2;
							break;

					}
		}
		public void GhiFile()
		{
			string result = "\n\n\t\t\tDANH SACH MAY TINH";
			foreach (var item in listMayTinh)
				result += item;
			using (StreamWriter file = new StreamWriter("maytinhsiucap.txt", append: false))
				file.Write(result);
		}
		#endregion
	}
}