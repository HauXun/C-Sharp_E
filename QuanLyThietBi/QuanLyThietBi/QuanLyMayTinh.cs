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
		public enum MinMax
		{
			Min,
			Max
		}
		#region Các hàm chức năng tìm kiếm
		public float Gia(DanhSachMayTinh list, LoaiGia loaiGia, MinMax minMax)
		{
			switch (minMax)
			{
				case MinMax.Min:
					switch (loaiGia)
					{
						case LoaiGia.GiaMayTinh:
							return list.listMayTinh.Min(x => x.TinhGia());
						case LoaiGia.GiaCPU:
							return list.listMayTinh.Min(x => x.TinhGiaCPU());
						case LoaiGia.GiaRAM:
							return list.listMayTinh.Min(x => x.TinhGiaRAM());
					}
					break;
				case MinMax.Max:
					switch (loaiGia)
					{
						case LoaiGia.GiaMayTinh:
							return list.listMayTinh.Max(x => x.TinhGia());
						case LoaiGia.GiaCPU:
							return list.listMayTinh.Max(x => x.TinhGiaCPU());
						case LoaiGia.GiaRAM:
							return list.listMayTinh.Max(x => x.TinhGiaRAM());
					}
					break;
			}
			return 0;
		}
		public DanhSachMayTinh ListMayTinhTheoLoai(DanhSachMayTinh list, LoaiGia loaiGia, MinMax minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (minMax)
			{
				case MinMax.Min:
					switch (loaiGia)
					{
						case LoaiGia.GiaMayTinh:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, loaiGia, minMax)).ToList();
							break;
						case LoaiGia.GiaCPU:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGiaCPU() == Gia(list, loaiGia, minMax)).ToList();
							break;
						case LoaiGia.GiaRAM:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGiaRAM() == Gia(list, loaiGia, minMax)).ToList();
							break;
					}
					break;
				case MinMax.Max:
					switch (loaiGia)
					{
						case LoaiGia.GiaMayTinh:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, loaiGia, minMax)).ToList();
							break;
						case LoaiGia.GiaCPU:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGiaCPU() == Gia(list, loaiGia, minMax)).ToList();
							break;
						case LoaiGia.GiaRAM:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGiaRAM() == Gia(list, loaiGia, minMax)).ToList();
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
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.TinhGiaCPU()).ToList();
					return result;
				case SortBy.GiaRAM:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.TinhGiaRAM()).ToList();
					return result;
				case SortBy.SoLuongCPU:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.SLCPU()).ToList();
					return result;
				case SortBy.SoLuongRAM:
					result.listMayTinh = list.listMayTinh.OrderBy(x => x.SLRAM()).ToList();
					return result;
				case SortBy.Hang:
					//result.listMayTinh = list.listMayTinh.OrderBy(x => x.TimDanhSachTheoLoai(MayTinh.Loai.TatCaHangSX)).ToList();
					return result;
			}
			return null;
		}

	}
}
