using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuanLyThietBiV2
{
	class QuanLyMayTinh
	{
		#region Các hàm tìm kiếm danh sách máy tính ☜(ﾟヮﾟ☜)
		public enum Tinh
		{
			Speed,
			sCapacity
		}
		public enum MinMax
		{
			Min,
			Max
		}
		public float TinhTheoLoai<T>(DanhSachMayTinh list, Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return list.listMayTinh.Min(x => x.TinhTheoLoai<T>(tinh));
				case MinMax.Max:
					return list.listMayTinh.Max(x => x.TinhTheoLoai<T>(tinh));
			}
			return 0;
		}
		public DanhSachMayTinh DanhSachMayTinhTheoLoai<T>(DanhSachMayTinh list, Tinh tinh, MinMax minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			result.listMayTinh = list.listMayTinh.Where(x => x.TinhTheoLoai<T>(tinh) == TinhTheoLoai<T>(list, tinh, minMax)).ToList();
			return result;
		}
		public float MinMaxThuocTinh<T>(DanhSachMayTinh list, Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return list.listMayTinh.Min(x => x.ThuocTinhTheoLoai<T>(tinh));
				case MinMax.Max:
					return list.listMayTinh.Max(x => x.ThuocTinhTheoLoai<T>(tinh));
			}
			return 0;
		}
		public List<string> DSHangMinMaxThuocTinh<T>(DanhSachMayTinh list, Tinh tinh, MinMax minMax)
		{
			List<string> result = new List<string>();
			foreach (var item in list.listMayTinh)
				if (item.ThuocTinhTheoLoai<T>(tinh) == MinMaxThuocTinh<T>(list, tinh, minMax))
					if (!result.Contains(item.HangThietBiTheoLoai<T>()))
						result.Add(item.HangThietBiTheoLoai<T>());
			return result;
		}
		public DanhSachMayTinh DSMTThuocTinhLonHonX<T>(DanhSachMayTinh list, Tinh tinh, float x)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			foreach (var item in list.listMayTinh)
				if (item.ThuocTinhTheoLoai<T>(tinh) > x)
					result.Them(item);
			return result;
		}
		public DanhSachMayTinh DSMTTheoThuocTinh_Hang<T>(DanhSachMayTinh list, Tinh tinh, float obj, string hangSX)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			foreach (var item in list.listMayTinh)
				if (item.ThuocTinhTheoLoai<T>(tinh) == obj && String.Compare(item.HangThietBiTheoLoai<T>(), hangSX, true) == 0)
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
		public DanhSachMayTinh SortTheoLoai<T>(DanhSachMayTinh list, Tinh tinh, UpOrDown upOrDown)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (upOrDown)
			{
				case UpOrDown.Increase:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.TinhTheoLoai<T>(tinh)).ToList();
					return result;
				case UpOrDown.Decrease:
					result.listMayTinh = list.listMayTinh.OrderByDescending(x => x.TinhTheoLoai<T>(tinh)).ToList();
					return result;
			}
			return null;
		}
		#endregion
		#region Các chức năng khác 🙆‍🙆‍🙆‍
		public void XoaMayTinhTheoThuocTinh<T>(DanhSachMayTinh list, Tinh tinh, float obj)
		{
			List<MayTinh> reList = new List<MayTinh>(list.listMayTinh);
			foreach (var item in reList)
				if (item.ThuocTinhTheoLoai<T>(tinh) == obj)
					list.listMayTinh.Remove(item);
		}
		public void CapNhapMayTinhTheoThuocTinh<T>(DanhSachMayTinh list, Tinh tinh, float obj2)
		{
			foreach (var item in list.listMayTinh)
				foreach (var s in item.list)
					switch (tinh)
					{
						case Tinh.Speed:
							s.TocDo = obj2;
							break;
						case Tinh.sCapacity:
							s.DungLuong = (int)obj2;
							break;

					}
		}
		public void GhiFile(DanhSachMayTinh list)
		{
			string result = "\n\n\t\t\tDANH SACH MAY TINH";
			foreach (var item in list.listMayTinh)
				result += item;
			using (StreamWriter file = new StreamWriter("maytinhsiucap.txt", append: false))
			{
				file.Write(result);
			}
		}
		#endregion
	}
}
