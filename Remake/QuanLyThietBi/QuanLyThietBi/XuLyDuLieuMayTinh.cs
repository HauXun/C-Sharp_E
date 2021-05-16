using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class XuLyDuLieuMayTinh
	{
		#region MinMax
		public enum MinMax
		{
			Min,
			Max
		}
		public float MinMaxThuocTinhThietBi<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return danhSachMayTinh.listMayTinh.Min(x => x.TruyXuatThuocTinhThietBi(tinh));
				case MinMax.Max:
					return danhSachMayTinh.listMayTinh.Max(x => x.TruyXuatThuocTinhThietBi(tinh));
			}
			return 0;
		}
		public float MinMaxTongThuocTinhThietBi<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					return danhSachMayTinh.listMayTinh.Min(x => x.TinhTongThuocTinh<T>(tinh));
				case MinMax.Max:
					return danhSachMayTinh.listMayTinh.Max(x => x.TinhTongThuocTinh<T>(tinh));
			}
			return 0;
		}
		#endregion
		public List<MayTinh> DanhSachMayTinhTheoLoai<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
			=> danhSachMayTinh.listMayTinh.Where(x => x.TinhTongThuocTinh<T>(tinh) == MinMaxTongThuocTinhThietBi<T>(danhSachMayTinh, tinh, minMax)).ToList();
		
		#region Các hàm tìm kiếm danh sách máy tính ☜(ﾟヮﾟ☜)
		#endregion
		#region Các hàm phân loại danh sách thuộc tính (☞ﾟヮﾟ)☞
		public List<string> DanhSachHangTheoThietBi<T>(DanhSachMayTinh danhSachMayTinh)
		{
			List<string> result = new List<string>();
			foreach (var item in danhSachMayTinh.listMayTinh)
				if (!result.Contains(item.TruyXuatHangCuaThietBi<T>()))
					result.Add(item.TruyXuatHangCuaThietBi<T>());
			return result;
		}
		public List<float> DanhSachThuocTinhTheoThietBi<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh)
		{
			List<float> result = new List<float>();
			foreach (var item in danhSachMayTinh.listMayTinh)
				if (!result.Contains(item.TruyXuatThuocTinhThietBi(tinh)))
					result.Add(item.TruyXuatThuocTinhThietBi(tinh));
			return result;
		}
		public List<string> DanhSachHangMinMaxThuocTinh<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
		{
			List<string> result = new List<string>();
			foreach (var item in danhSachMayTinh.listMayTinh)
			{
				if (item.TruyXuatThuocTinhThietBi(tinh) == MinMaxThuocTinhThietBi<T>(danhSachMayTinh, tinh, minMax))
					if (!result.Contains(item.TruyXuatHangCuaThietBi<T>()))
						result.Add(item.TruyXuatHangCuaThietBi<T>());
			}
			return result;
		}	
		#endregion
	}
}
