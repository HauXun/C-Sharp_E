using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace QuanLyHinhHoc
{
	class XuLyDuLieuHinhHoc
	{
		public void Xuat(List<HinhHoc> hinhHoc) => hinhHoc.ForEach(x => WriteLine(x));
		#region Phân loại enum 🗽🗽🗽
		public enum TypeList
		{
			HinhVuong = 0,
			HinhTron = 1,
			HinhChuNhat = 2,
			TatCaHinh = 3
		}
		public enum TypeCal
		{
			ChuVi = 0,
			DienTich = 1,
			Canh = 2,
			BanKinh = 3,
			CanhHCN = 4
		}
		public enum TypeMinMax
		{
			MaxChuVi = 0,
			MinChuVi = 1,
			MaxDienTich = 2,
			MinDienTich = 3,
			MaxCanh = 4,
			MinCanh = 5,
			MaxBanKinh = 6,
			MinBanKinh = 7,
			MaxCanhHCN = 8,
			MinCanhHCN = 9
		}
		public enum SortBy
		{
			SortUpByCV = 0,
			SortUpByDT = 1,
			SortDownByCV = 2,
			SortDownByDT = 3
		}
		#endregion
		#region Các hàm chức năng tìm kiếm hình học 🕵️‍♀️🕵️‍♀️🕵️‍♀️
		public List<HinhHoc> DanhSachTheoKieuHinh<T>(DanhSachHinhHoc danhSachHinhHoc)
			=> danhSachHinhHoc.ListHinhHoc.Where(x => x is T).ToList();
		public List<HinhHoc> TimHinhTheoKieuGoi<T>(DanhSachHinhHoc danhSachHinhHoc, TypeCal typeCal, float number)
		{
			List<HinhHoc> result = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
			switch (typeCal)
			{
				case TypeCal.ChuVi:
					result = result.Where(x => x.TinhChuVi() == number).ToList();
					break;
				case TypeCal.DienTich:
					result = result.Where(x => x.TinhDienTich() == number).ToList();
					break;
				case TypeCal.Canh:
					result = result.Where(x => (x as HinhVuong).Canh == number).ToList();
					break;
				case TypeCal.BanKinh:
					result = result.Where(x => (x as HinhTron).BanKinh == number).ToList();
					break;
				case TypeCal.CanhHCN:
					result = result.Where(x => (x as HinhChuNhat).TinhDienTich() == number).ToList();
					break;
			}
			return result;
		}
		public float MinMaxTheoKieuGoi<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax)
		{
			List<HinhHoc> hinhHoc = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
			switch (typeMinMax)
			{
				case TypeMinMax.MaxChuVi:
					return hinhHoc.FindAll(p => p is T).Max(x => x.TinhChuVi());
				case TypeMinMax.MinChuVi:
					return hinhHoc.FindAll(p => p is T).Min(x => x.TinhChuVi());
				case TypeMinMax.MaxDienTich:
					return hinhHoc.FindAll(p => p is T).Max(x => x.TinhDienTich());
				case TypeMinMax.MinDienTich:
					return hinhHoc.FindAll(p => p is T).Min(x => x.TinhDienTich());
				case TypeMinMax.MaxCanh:
					return hinhHoc.FindAll(p => p is T).Max(x => (x as HinhVuong).Canh);
				case TypeMinMax.MinCanh:
					return hinhHoc.FindAll(p => p is T).Min(x => (x as HinhVuong).Canh);
				case TypeMinMax.MaxBanKinh:
					return hinhHoc.FindAll(p => p is T).Max(x => (x as HinhTron).BanKinh);
				case TypeMinMax.MinBanKinh:
					return hinhHoc.FindAll(p => p is T).Min(x => (x as HinhTron).BanKinh);
				case TypeMinMax.MaxCanhHCN:
					return hinhHoc.FindAll(p => p is T).Max(x => (x as HinhChuNhat).TinhDienTich());
				case TypeMinMax.MinCanhHCN:
					return hinhHoc.FindAll(p => p is T).Min(x => (x as HinhChuNhat).TinhDienTich());
			}
			return 0;
		}
		public List<HinhHoc> TimHinhTheoKieuTinh<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax, TypeCal typeCal)
			=> TimHinhTheoKieuGoi<T>(danhSachHinhHoc, typeCal, MinMaxTheoKieuGoi<T>(danhSachHinhHoc, typeMinMax));
		#endregion
		#region Các hàm chức năng sắp xếp 💫💫💫
		#endregion
		#region Các hàm chức năng xóa 🚩🚩🚩
		#endregion
		#region Một số chức năng khác 👀👀👀
		#endregion
		#region Các hàm chức năng ghi danh sách các hình xuống file riêng 👨‍💻👨‍💻👨‍💻
		#endregion
	}
}
