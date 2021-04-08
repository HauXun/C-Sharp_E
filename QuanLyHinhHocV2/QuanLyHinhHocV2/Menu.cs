using System;
using static System.Console;

namespace GeometryManagement
{
	class Menu
	{
		DanhSachHinhHoc listHinhHoc = new DanhSachHinhHoc();
		DanhSachHinhHoc result = new DanhSachHinhHoc();
		float x;
		int location;

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc tu tap tin",
			"Nhap du lieu hinh hoc",
			"Xuat danh sach",
			"Cac ham tim kiem theo chuc nang tuong ung",
			"Sort tang theo tung chuc nang tuong ung",
			"Delete theo tung chuc nang tuong ung",
			"Them mot hinh hoc tai vi tri",
			"Dem so luong cac loai hinh hoc",
			"Ghi tat ca thong tin hinh hoc vao file txt",
			"Ghi tat ca thong tin hinh vuong vao file txt",
			"Ghi tat ca thong tin hinh tron vao file txt",
			"Ghi tat ca thong tin hinh chu nhat vao file txt"
		};

		public void XuatMenu()
		{
			WriteLine("".PadRight(20, '=') + "MENU SELECTION" + "".PadRight(20, '='));
			for (int i = 0; i < options.Length; i++)
			{
				WriteLine("{0}. {1}", i, options[i]);
			}
			WriteLine("".PadRight(55, '='));
		}

		public int ChonMenu(int soMenu)
		{
			int stt = -1;
			while (stt < 0 || stt > soMenu)
			{
				Clear();
				XuatMenu();
				Write("\nNhap tuy chon menu tuong ung: ");
				stt = int.Parse(ReadLine());
			}
			return stt;
		}

		public void XuLyMenu(int menu)
		{
			switch (menu)
			{
				case 0:
					WriteLine("Thoat chuong trinh...");
					break;
				case 1:
					#region Các chức năng nhập xuất cơ bản
					Clear();
					listHinhHoc.ImportFromFile();
					listHinhHoc.Xuat();
					break;
				case 2:
					Clear();
					WriteLine("Nhap du lieu cho cac loai hinh hoc...");
					listHinhHoc.Nhap();
					listHinhHoc.Xuat();
					break;
				case 3:
					Clear();
					WriteLine("Xuat >> ");
					listHinhHoc.Xuat();
					break;
				#endregion
				case 4:
					#region Chức năng tìm kiếm
					Clear();
					WriteLine("\tCac ham tim kiem theo chuc nang tuong ung >> ");
					WriteLine("Tim kiem theo x");
					WriteLine("\n\tHINH VUONG >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh vuong co dien tich = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.dienTich, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh vuong co chu vi = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.chuVi, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh tron co dien tich = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.dienTich, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh tron co chu vi = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.chuVi, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh chu nhat co dien tich = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.dienTich, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh chu nhat co chu vi = {0} la...", x);
					listHinhHoc.TimHinhTheoDT_CV(x, DanhSachHinhHoc.TypeCal.chuVi, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\tCac ham tim kiem theo chuc nang tuong ung >> ");
					WriteLine("Tim min max Chu vi, Dien tich tung hinh");
					WriteLine("\n\tHINH VUONG >>");
					WriteLine("Hinh vuong dien tich nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhVuong, DanhSachHinhHoc.TypeMinMax.minDienTich).Xuat();
					WriteLine("Hinh vuong chu vi nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhVuong, DanhSachHinhHoc.TypeMinMax.minChuVi).Xuat();
					WriteLine("Hinh vuong canh nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhVuong, DanhSachHinhHoc.TypeMinMax.minCanh).Xuat();
					WriteLine("Hinh vuong canh lon nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhVuong, DanhSachHinhHoc.TypeMinMax.maxCanh).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >>");
					WriteLine("Hinh tron dien tich nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhTron, DanhSachHinhHoc.TypeMinMax.minDienTich).Xuat();
					WriteLine("Hinh tron chu vi nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhTron, DanhSachHinhHoc.TypeMinMax.minChuVi).Xuat();
					WriteLine("Hinh tron ban kinh nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhTron, DanhSachHinhHoc.TypeMinMax.minBanKinh).Xuat();
					WriteLine("Hinh tron ban kinh lon nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhTron, DanhSachHinhHoc.TypeMinMax.maxBanKinh).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >>");
					WriteLine("Hinh chu nhat dien tich nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhChuNhat, DanhSachHinhHoc.TypeMinMax.minDienTich).Xuat();
					WriteLine("Hinh chu nhat chu vi nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhChuNhat, DanhSachHinhHoc.TypeMinMax.minChuVi).Xuat();
					WriteLine("Hinh chu nhat canh nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhChuNhat, DanhSachHinhHoc.TypeMinMax.minChieuDai).Xuat();
					WriteLine("Hinh chu nhat canh lon nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.HinhChuNhat, DanhSachHinhHoc.TypeMinMax.maxChieuDai).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tMin, max Chu vi, Dien tich trong cac hinh>>");
					WriteLine("Hinh co dien tich nho nhat la...");
					WriteLine(listHinhHoc.TimHinhMinMaxCV_DT(DanhSachHinhHoc.TypeMinMax.minDienTich));
					WriteLine("Hinh co dien tich lon nhat la...");
					WriteLine(listHinhHoc.TimHinhMinMaxCV_DT(DanhSachHinhHoc.TypeMinMax.maxDienTich));
					WriteLine("Hinh co chu vi nho nhat la...");
				    WriteLine(listHinhHoc.TimHinhMinMaxCV_DT(DanhSachHinhHoc.TypeMinMax.minChuVi));
					WriteLine("Hinh co chu vi lon nhat la...");
					WriteLine(listHinhHoc.TimHinhMinMaxCV_DT(DanhSachHinhHoc.TypeMinMax.maxChuVi));
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHinh co tong dien tich, chu vi lon nhat, nho nhat >>");
					WriteLine("Hinh co tong dien tich nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.TatCaHinh, DanhSachHinhHoc.TypeMinMax.minDienTich).Xuat();
					WriteLine("Hinh co tong dien tich lon nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.TatCaHinh, DanhSachHinhHoc.TypeMinMax.maxDienTich).Xuat();
					WriteLine("Hinh co tong chu vi nho nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.TatCaHinh, DanhSachHinhHoc.TypeMinMax.minChuVi).Xuat();
					WriteLine("Hinh co tong chu vi lon nhat la...");
					listHinhHoc.TimHinhMinMaxDT_CV(DanhSachHinhHoc.TypeList.TatCaHinh, DanhSachHinhHoc.TypeMinMax.maxChuVi).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE KET THUC CHUC NANG TIM KIEM >> ");
					Read();
					break;
				#endregion
				case 5:
					#region Chức năng sắp xếp
					Clear();
					WriteLine("Sort tang theo tung chuc nang tuong ung >> ");
					WriteLine("\n\tHINH VUONG >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByCV, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByCV, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByDT, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByDT, DanhSachHinhHoc.TypeList.HinhVuong).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByCV, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByCV, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByDT, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByDT, DanhSachHinhHoc.TypeList.HinhTron).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByCV, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByCV, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortUpByDT, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortHinhHoc(DanhSachHinhHoc.SortBy.SortDownByDT, DanhSachHinhHoc.TypeList.HinhChuNhat).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE KET THUC CHUC NANG SAP SEP >> ");
					Read();
					break;
				#endregion
				case 6:
					#region Chức năng xóa
					Clear();
					WriteLine("Delete theo tung chuc nang tuong ung >> ");
					WriteLine("\tXoa hinh co dien tich lon nhat");
					listHinhHoc.XoaHinh(DanhSachHinhHoc.TypeMinMax.maxDienTich, DanhSachHinhHoc.TypeList.TatCaHinh);
					listHinhHoc.Xuat();
					WriteLine("\n\n\tXoa hinh co dien tich nho nhat");
					listHinhHoc.XoaHinh(DanhSachHinhHoc.TypeMinMax.minDienTich, DanhSachHinhHoc.TypeList.TatCaHinh);
					listHinhHoc.Xuat();
					WriteLine("\n\n\tXoa hinh co chu vi lon nhat");
					listHinhHoc.XoaHinh(DanhSachHinhHoc.TypeMinMax.maxChuVi, DanhSachHinhHoc.TypeList.TatCaHinh);
					listHinhHoc.Xuat();
					WriteLine("\n\n\tXoa hinh co chu vi nho nhat");
					listHinhHoc.XoaHinh(DanhSachHinhHoc.TypeMinMax.minChuVi, DanhSachHinhHoc.TypeList.TatCaHinh);
					listHinhHoc.Xuat();
					Write("\n\nNhap vao vi tri x can xoa >> ");
					location = int.Parse(ReadLine());
					listHinhHoc.XoaHinhTaiViTri(location);
					listHinhHoc.Xuat();
					break;
				#endregion
				case 7:
					#region Các chức năng khác
					Clear();
					WriteLine("Them mot hinh hoc tai vi tri");
					Write("\n\nNhap vao vi tri x can them >> ");
					location = int.Parse(ReadLine());
					Clear();
					Write("\nBan muon them hinh gi?\nMoi nhap so tuong ung ( 0 - Hinh Vuong, 1 - Hinh Tron, 2 - Hinh Chu Nhat ) >> ");
					DanhSachHinhHoc.TypeList isContinue = (DanhSachHinhHoc.TypeList)int.Parse(ReadLine());
					listHinhHoc.ThemHinhTaiViTri(location, isContinue);
					break;
				case 8:
					Clear();
					WriteLine("Dem so luong cac loai hinh hoc");
					Write("\n\nSo luong hinh vuong la >> " + listHinhHoc.DemHinhHoc(DanhSachHinhHoc.TypeList.HinhVuong));
					Write("\n\nSo luong hinh tron la >> " + listHinhHoc.DemHinhHoc(DanhSachHinhHoc.TypeList.HinhTron));
					Write("\n\nSo luong hinh chu nhat la >> " + listHinhHoc.DemHinhHoc(DanhSachHinhHoc.TypeList.HinhChuNhat));
					break;
				case 9:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh hoc vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFile(DanhSachHinhHoc.TypeList.TatCaHinh);
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 10:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh vuong vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFile(DanhSachHinhHoc.TypeList.HinhVuong);
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 11:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh tron vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFile(DanhSachHinhHoc.TypeList.HinhTron);
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 12:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh chu nhat vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFile(DanhSachHinhHoc.TypeList.HinhChuNhat);
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
					#endregion
			}
			ReadLine();
		}
	}
}
