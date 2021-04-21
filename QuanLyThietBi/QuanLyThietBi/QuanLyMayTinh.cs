using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuanLyThietBi
{
	class QuanLyMayTinh
	{
		public enum LoaiGia
		{
			GiaMayTinh,
			GiaCPU,
			GiaRAM
		}
		public enum LinkKien
		{
			CPU,
			RAM
		}
		#region Các hàm chức năng tìm kiếm
		public float Gia(DanhSachMayTinh list, int loaiGia, int minMax)
		{
			switch (minMax)
			{
				case 0:
					switch (loaiGia)
					{
						case 0:
							return list.listMayTinh.Min(x => x.TinhGia());
						case 1:
							return list.listMayTinh.Min(x => x.GiaCPU);
						case 2:
							return list.listMayTinh.Min(x => x.GiaRAM);
					}
					break;
				case 1:
					switch (loaiGia)
					{
						case 0:
							return list.listMayTinh.Max(x => x.TinhGia());
						case 1:
							return list.listMayTinh.Max(x => x.GiaCPU);
						case 2:
							return list.listMayTinh.Max(x => x.GiaRAM);
					}
					break;
			}
			return 0;
		}
		public DanhSachMayTinh ListMayTinhTheoLoai(DanhSachMayTinh list, int loaiGia, int minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (minMax)
			{
				case 0:
					switch (loaiGia)
					{
						case 0:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, 0, 0)).ToList();
							break;
						case 1:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaCPU == Gia(list, 1, 0)).ToList();
							break;
						case 2:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaRAM == Gia(list, 2, 0)).ToList();
							break;
					}
					break;
				case 1:
					switch (loaiGia)
					{
						case 0:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, 0, 1)).ToList();
							break;
						case 1:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaCPU == Gia(list, 1, 1)).ToList();
							break;
						case 2:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaRAM == Gia(list, 2, 1)).ToList();
							break;
					}
					break;
			}
			return result;
		}
		#endregion
		public enum SortBy
		{
			SLThietBi,
			GiaThietBi,
			GiaCPU,
			GiaRAM,
			SoLuongCPU,
			SoLuongRAM,
			Hang
		}
		public DanhSachMayTinh SortMayTinh(DanhSachMayTinh list, SortBy sortBy)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (sortBy)
			{
				case SortBy.SLThietBi:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.SLThietBi()).ToList();
					return result;
				case SortBy.GiaThietBi:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.TinhGia()).ToList();
					return result;
				case SortBy.GiaCPU:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.GiaCPU).ToList();
					return result;
				case SortBy.GiaRAM:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.GiaRAM).ToList();
					return result;
				case SortBy.SoLuongCPU:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.SoLuongThietBi).ToList();
					return result;
				case SortBy.SoLuongRAM:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.SoLuongThietBi).ToList();
					return result;
				case SortBy.Hang:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.TimDanhSachTheoLoai(MayTinh.Loai.TatCaHangSX)).ToList();
					return result;
			}
			return null;
		}
	}
}
