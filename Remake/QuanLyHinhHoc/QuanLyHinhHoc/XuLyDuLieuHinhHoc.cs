using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
		private float MinMaxTheoKieuGoi<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax)
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
		public List<HinhHoc> TimHinhMinMaxKieuTinh<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax, TypeCal typeCal)
			=> TimHinhTheoKieuGoi<T>(danhSachHinhHoc, typeCal, MinMaxTheoKieuGoi<T>(danhSachHinhHoc, typeMinMax));
		private float TongPhepTinhMinMaxTheoHinh<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax)
		{
			if (typeMinMax == TypeMinMax.MaxDienTich || typeMinMax == TypeMinMax.MaxChuVi)
				return danhSachHinhHoc.ListHinhHoc.FindAll(p => p is T).Sum(x => x.TinhDienTich());
			else
				return danhSachHinhHoc.ListHinhHoc.FindAll(p => p is T).Sum(x => x.TinhChuVi());
		}
		public string HinhCoTongPhepTinhMinMax(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax)
		{
			float hinhVuong = TongPhepTinhMinMaxTheoHinh<HinhVuong>(danhSachHinhHoc, typeMinMax);
			float hinhTron = TongPhepTinhMinMaxTheoHinh<HinhTron>(danhSachHinhHoc, typeMinMax);
			float hinhChuNhat = TongPhepTinhMinMaxTheoHinh<HinhChuNhat>(danhSachHinhHoc, typeMinMax);
			if (typeMinMax == TypeMinMax.MaxDienTich || typeMinMax == TypeMinMax.MaxChuVi)
				return hinhVuong > hinhTron ? (hinhVuong > hinhChuNhat ? "Hình Vuông" : "Hình Chữ Nhật") : (hinhTron > hinhChuNhat ? "Hình Tròn" : "Hình Chữ Nhật");
			return hinhVuong < hinhTron ? (hinhVuong < hinhChuNhat ? "Hình Vuông" : "Hình Chữ Nhật") : (hinhTron < hinhChuNhat ? "Hình Tròn" : "Hình Chữ Nhật");
		}
		#endregion
		#region Các hàm chức năng sắp xếp 💫💫💫
		public List<HinhHoc> SapXepTheoCachGoi<T>(DanhSachHinhHoc danhSachHinhHoc, SortBy sortBy)
		{
			List<HinhHoc> result = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
			switch (sortBy)
			{
				case SortBy.SortUpByCV:
					result = result.OrderBy(hinh => hinh.TinhChuVi()).ToList();
					return result;
				case SortBy.SortUpByDT:
					result = result.OrderBy(hinh => hinh.TinhDienTich()).ToList();
					return result;
				case SortBy.SortDownByCV:
					result = result.OrderByDescending(hinh => hinh.TinhChuVi()).ToList();
					return result;
				case SortBy.SortDownByDT:
					result = result.OrderByDescending(hinh => hinh.TinhDienTich()).ToList();
					return result;
			}
			return null;
		}
		#endregion
		#region Các hàm chức năng xóa 🚩🚩🚩
		public void XoaTheoCachGoi<T>(DanhSachHinhHoc danhSachHinhHoc, TypeMinMax typeMinMax)
		{
			List<HinhHoc> list = DanhSachTheoKieuHinh<HinhHoc>(danhSachHinhHoc);
			foreach (var item in list)
			{
				switch (typeMinMax)
				{
					case TypeMinMax.MaxChuVi:
					case TypeMinMax.MinChuVi:
						if (item.TinhChuVi().Equals(MinMaxTheoKieuGoi<T>(danhSachHinhHoc, typeMinMax)))
							danhSachHinhHoc.ListHinhHoc.Remove(item);
						break;
					case TypeMinMax.MaxDienTich:
					case TypeMinMax.MinDienTich:
						if (item.TinhDienTich().Equals(MinMaxTheoKieuGoi<T>(danhSachHinhHoc, typeMinMax)))
							danhSachHinhHoc.ListHinhHoc.Remove(item);
						break;
				}
			}
		}
		public void XoaHinhTaiViTri(DanhSachHinhHoc danhSachHinhHoc, int location) => danhSachHinhHoc.ListHinhHoc.RemoveAt(location);
		#endregion
		#region Một số chức năng khác 👀👀👀
		public int DemTheoHinh<T>(DanhSachHinhHoc danhSachHinhHoc) => DanhSachTheoKieuHinh<T>(danhSachHinhHoc).Count();
		public void ThemHinhTaiViTri(DanhSachHinhHoc danhSachHinhHoc, TypeList typeList, int location)
		{
			HinhHoc hh = new HinhHoc();
			switch (typeList)
			{
				case TypeList.HinhVuong:
					WriteLine("\nHinh Vuong >>");
					hh = new HinhTron();
					break;
				case TypeList.HinhTron:
					WriteLine("\nHinh Vuong >>");
					hh = new HinhVuong();
					break;
				case TypeList.HinhChuNhat:
					WriteLine("\nHinh chu nhat >>");
					hh = new HinhChuNhat();
					break;
			}
			danhSachHinhHoc.ListHinhHoc.Insert(location, hh.Nhap());
		}
		#endregion
		#region Các hàm chức năng ghi danh sách các hình xuống file riêng 👨‍💻👨‍💻👨‍💻
		public void GhiFile<T>(DanhSachHinhHoc danhSachHinhHoc, TypeList typeList)
		{
			StringBuilder str = new StringBuilder();
			StringBuilder filename = new StringBuilder();
			StringBuilder kq = new StringBuilder();
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			switch (typeList)
			{
				case TypeList.HinhVuong:
					str.Append("hinhvuong");
					filename.Append(str + ".txt");
					result.ListHinhHoc = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
					kq.Append($"\n\n\t\t\tDANH SACH {str.ToString().ToUpper()}\n{result}\n");
					break;
				case TypeList.HinhTron:
					str.Append("hinhtron");
					filename.Append(str + ".txt");
					result.ListHinhHoc = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
					kq.Append($"\n\n\t\t\tDANH SACH {str.ToString().ToUpper()}\n{result}\n");
					break;
				case TypeList.HinhChuNhat:
					str.Append("hinhchunhat");
					filename.Append(str + ".txt");
					result.ListHinhHoc = DanhSachTheoKieuHinh<T>(danhSachHinhHoc);
					kq.Append($"\n\n\t\t\tDANH SACH {str.ToString().ToUpper()}\n{result}\n");
					break;
				case TypeList.TatCaHinh:
					str.Append("tatcahinh");
					filename.Append(str + ".txt");
					kq.Append($"\t\t\tBANG TONG HOP THONG TIN\n1) Tong so cac doi tuong hinh hoc la: {DemTheoHinh<HinhHoc>(danhSachHinhHoc)}\n");
					kq.Append($"2) Tong so hinh tron la: {DemTheoHinh<HinhTron>(danhSachHinhHoc)}\n");
					kq.Append($"3) Tong so hinh vuong la: {DemTheoHinh<HinhVuong>(danhSachHinhHoc)}\n");
					kq.Append($"4) Tong so hinh chu nhat la {DemTheoHinh<HinhChuNhat>(danhSachHinhHoc)}\n");
					result.ListHinhHoc = DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc);
					kq.Append($"\nA. Danh sach hinh tron\n{result}");
					result.ListHinhHoc = DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc);
					kq.Append($"\n\nB. Danh sach hinh vuong\n{result}");
					result.ListHinhHoc = DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc);
					kq.Append($"\n\nC. Danh sach hinh chu nhat\n{result}\n");
					break;
			}
			using (StreamWriter file = new StreamWriter(filename.ToString(), append: false)) // FileMode.Append, FileAccess.Write)
			{
				file.Write(kq);
			}
		}
		#endregion
	}
}
