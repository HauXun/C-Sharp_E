using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuanLyThietBi
{
	class XuLyDuLieuMayTinh
	{
		#region Xuất dữ liệu 🎢🎢🎢
		public void Xuat(List<object> list) => list.ForEach(x => Console.WriteLine(x));
		public void XuatDuLieuDuocCanLe(List<object> list)
		{
			int i = 0;
			foreach (var item in list)
			{
				Console.Write($"\t{item}\t");
				if ((++i + 5) % 4 == 0)
					Console.Write('\n');
			}
		}
		#endregion
		#region Các hàm phân loại danh sách MinMax theo thuộc tính ☜(ﾟヮﾟ☜)
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
		private float MinMaxTongThuocTinhThietBi<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
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
		public List<MayTinh> DanhSachMayTinhMinMaxTheoThuocTinh<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, MinMax minMax)
			=> danhSachMayTinh.listMayTinh.Where(x => x.TinhTongThuocTinh<T>(tinh) == MinMaxTongThuocTinhThietBi<T>(danhSachMayTinh, tinh, minMax)).ToList();
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
		public List<MayTinh> DSMTThuocTinhLonHonX<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, float x)
			=> danhSachMayTinh.listMayTinh.FindAll(item => item.TruyXuatThuocTinhThietBi(tinh) > x);
		public List<MayTinh> DSMTTheoThuocTinh_Hang<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, float obj, string hangSX)
			=> danhSachMayTinh.listMayTinh.FindAll(item => item.TruyXuatThuocTinhThietBi(tinh) == obj
			&& String.Compare(item.TruyXuatHangCuaThietBi<T>(), hangSX, true) == 0);
		#endregion
		#region Các hàm sắp xếp danh sách máy tinh (☞ﾟヮﾟ)☞
		public enum UpDown
		{
			Up,
			Down
		}
		public void SapXepTheoKieuGoi<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, UpDown upDown)
		{
			switch (upDown)
			{
				case UpDown.Up:
					danhSachMayTinh.listMayTinh = danhSachMayTinh.listMayTinh.OrderBy(x => x.TinhTongThuocTinh<T>(tinh)).ToList();
					return;
				case UpDown.Down:
					danhSachMayTinh.listMayTinh = danhSachMayTinh.listMayTinh.OrderByDescending(x => x.TinhTongThuocTinh<T>(tinh)).ToList();
					return;
			}
		}
		#endregion
		#region Các chức năng khác 🙆‍🙆‍🙆‍
		public void XoaMayTinhTheoThuocTinh<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, float obj)
		{
			List<MayTinh> reList = new List<MayTinh>(danhSachMayTinh.listMayTinh);
			foreach (var item in reList)
				if (item.TruyXuatThuocTinhThietBi(tinh) == obj)
					danhSachMayTinh.listMayTinh.Remove(item);
		}
		public void CapNhapMayTinhTheoThuocTinh<T>(DanhSachMayTinh danhSachMayTinh, MayTinh.Tinh tinh, float obj, float obj2)
		{
			foreach (var item in danhSachMayTinh.listMayTinh)
				if (item.IsEquipment<T>())
					item.CapNhapThuocTinhThietBi<T>(tinh, obj, obj2);
		}
		public void GhiFile(DanhSachMayTinh danhSachMayTinh)
		{
			string result = "\n\n\t\t\tDANH SACH MAY TINH";
			foreach (var item in danhSachMayTinh.listMayTinh)
				result += item;
			using (StreamWriter file = new StreamWriter("maytinhsiucap.txt", append: false))
				file.Write(result);
		}
		#endregion
	}
}
