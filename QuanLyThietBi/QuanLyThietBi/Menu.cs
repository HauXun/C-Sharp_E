using System;
using static System.Console;

namespace QuanLyThietBi
{
	class Menu
	{
		DanhSachMayTinh listMayTinh = new DanhSachMayTinh();
		QuanLyMayTinh listMayTinhQL = new QuanLyMayTinh();
		MayTinh mayTinh = new MayTinh();
		float x;
		int location;

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc du lieu tu tap tin",
			"Xuat danh sach",
			"Tim kiem theo chuc nang tuong ung",
			"Sap xep theo chuc nang tuong ung",
			"Test code"
		};

		public void XuatMenu()
		{
			WriteLine("".PadRight(20, '=') + "MENU SELECTION" + "".PadRight(20, '='));
			for (int i = 0; i < options.Length; i++)
				WriteLine("{0}. {1}", i, options[i]);
			WriteLine("".PadRight(55, '='));
		}

		public int ChonMenu(int soMenu)
		{
			int stt = -1;
			while (stt < 0 || stt > soMenu)
			{
				Clear();
				XuatMenu();
				Write("\nNhap tuy chon menu tuong ung >> ");
				stt = int.Parse(ReadLine());
			}
			return stt;
		}

		public void XuLyMenu(int menu)
		{
			switch (menu)
			{
				case 0:
					return;
				case 1:
					#region Các chức năng nhập xuất cơ bản
					Clear();
					WriteLine("Doc du lieu tu tap tin...");
					listMayTinh.ImportFromFile();
					break;
				case 2:
					Clear();
					WriteLine("Xuat >> ");
					listMayTinh.Xuat();
					break;
				case 3:
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nMay tinh co gia re nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 0, 0).Xuat();
					WriteLine("\nMay tinh co CPU gia thap nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 1, 0).Xuat();
					WriteLine("\nMay tinh co CPU gia cao nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 1, 1).Xuat();
					WriteLine("\nMay tinh co RAM gia thap nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 2, 0).Xuat();
					WriteLine("\nMay tinh co RAM gia cao nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 2, 1).Xuat();
					WriteLine("\nHang duoc su dung CPU nhieu nhat...");
					foreach (var item in listMayTinh.DanhSachXuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai.HangCPU, DanhSachMayTinh.MinMax.Max))
						WriteLine(item);
					WriteLine("\nHang duoc su dung CPU it nhat...");
					foreach (var item in listMayTinh.DanhSachXuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai.HangCPU, DanhSachMayTinh.MinMax.Min))
						WriteLine(item);
					WriteLine("\nHang duoc su dung RAM nhieu nhat...");
					foreach (var item in listMayTinh.DanhSachXuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai.HangRAM, DanhSachMayTinh.MinMax.Max))
						WriteLine(item);
					WriteLine("\nHang duoc su dung RAM it nhat...");
					foreach (var item in listMayTinh.DanhSachXuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai.HangRAM, DanhSachMayTinh.MinMax.Min))
						WriteLine(item);
					break;
				#endregion
				case 4:
					Clear();
					WriteLine("Sap xep danh sach may tinh theo chuc nang tuong ung >> ");
					WriteLine("\nSap xep danh sach may tinh theo so luong thiet bi...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.SLThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					Read();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia thiet bi...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.GiaThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					Read();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia CPU...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.GiaCPU).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					Read();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia RAM...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.GiaRAM).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					Read();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo so luong CPU...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.SoLuongCPU).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					Read();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo so luong RAM...");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.SoLuongRAM).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE KET THUC CHUC NANG SAP XEP >> ");
					Read();
					break;
				case 5:
					Clear();
					WriteLine("Test code >> ");
					listMayTinhQL.SortMayTinh(listMayTinh, QuanLyMayTinh.SortBy.SoLuongCPU).Xuat();
					break;
			}
			ReadLine();
		}
	}
}
