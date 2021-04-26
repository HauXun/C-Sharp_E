using System.Collections.Generic;
using System.Linq;

namespace QuanLyThietBi
{
	class QuanLyMayTinh
	{
		#region Các hàm tìm kiếm danh sách máy tính ☜(ﾟヮﾟ☜)
		public enum MinMax
		{
			Min,
			Max,
			All
		}
		public float TinhGia<T>(DanhSachMayTinh list, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return list.listMayTinh.Min(x => x.GiaTheoLoai<T>());
				case MinMax.Max:
					return list.listMayTinh.Max(x => x.GiaTheoLoai<T>());
				case MinMax.All:
					return list.listMayTinh.Sum(x => x.TongGia());
			}
			return 0;
		}
		public DanhSachMayTinh DanhSachMayTinhTheoGia<T>(DanhSachMayTinh list, MinMax minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			result.listMayTinh = list.listMayTinh.Where(x => x.GiaTheoLoai<T>() == TinhGia<T>(list, minMax)).ToList();
			return result;
		}
		public int DemTheoHangSX<T>(DanhSachMayTinh list, string hangSX) => list.listMayTinh.Sum(x => x.DemTheoHangSX<T>(hangSX));
		public int TimSLSDMinMax<T>(DanhSachMayTinh list, MinMax minMax)
		{
			List<string> dsHang = list.DanhSachHangTheoLoai<T>();
			switch (minMax)
			{
				case MinMax.Min:
					return dsHang.Min(x => DemTheoHangSX<T>(list, x));
				case MinMax.Max:
					return dsHang.Max(x => DemTheoHangSX<T>(list, x));
			}
			return 0;
		}
		public List<string> DanhSachXHMinMax<T>(DanhSachMayTinh list, MinMax minMax)
		{
			List<string> result = new List<string>();
			List<string> dsHang = list.DanhSachHangTheoLoai<T>();
			int obj = TimSLSDMinMax<T>(list, minMax);
			foreach (var item in dsHang)
				if (DemTheoHangSX<T>(list, item) == obj)
					result.Add(item);
			return result;
		}
		public DanhSachMayTinh TimDSMayTinhByInput(DanhSachMayTinh list, string hangSX)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			//foreach (var item in list.listMayTinh)
			//	foreach (var ss in item.DanhSachHang())
			//		if (ss.CompareTo(hangSX) == 0)
			//			result.Them(item);
			list.listMayTinh.ForEach(item => item.DanhSachHang().ForEach(ss => { if (ss.CompareTo(hangSX) == 0) result.Them(item); }));
			return result;
		}
		#endregion
		#region Các hàm sắp xếp danh sách máy tinh (☞ﾟヮﾟ)☞
		public enum SortBy
		{
			SLThietBi,
			GiaThietBi
		}
		public DanhSachMayTinh SortTheoLoai<T>(DanhSachMayTinh list, SortBy sortBy)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (sortBy)
			{
				case SortBy.SLThietBi:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.DemThietBiTheoLoai<T>()).ToList();
					return result;
				case SortBy.GiaThietBi:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.GiaTheoLoai<T>()).ToList();
					return result;
			}
			return null;
		}
		#endregion
		#region Các hàm chức năng khác ¯\_(ツ)_/¯
		public void XoaMayTinhTheoHangCPU(DanhSachMayTinh list, string hangSX)
		{
			List<MayTinh> reList = new List<MayTinh>(list.listMayTinh);
			//foreach (var item in reList)
			//	foreach (var ss in item.DanhSachHangTheoLoai<CPU>())
			//		if (ss.CompareTo(hangSX) == 0)
			//			listMayTinh.Remove(item);
			reList.ForEach(item => item.DanhSachHangTheoLoai<CPU>().ForEach(ss => { if (ss.CompareTo(hangSX) == 0) list.listMayTinh.Remove(item); }));
		}
		public void CapNhapMayTinh(DanhSachMayTinh list)
		{
			//foreach (var item in list.listMayTinh)
			//	foreach (var ss in item.list)
			//		if (ss is CPU && ss.HangSX.CompareTo("Intel") == 0)
			//			ss.Gia = 700;
			list.listMayTinh.ForEach(item => item.list.ForEach(ss => { if (ss.HangSX.CompareTo("Intel") == 0) ss.Gia = 700; }));
		}
		#endregion
	}
}
