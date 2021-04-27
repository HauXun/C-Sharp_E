using System;
using static System.Console;

namespace QuanLyThietBi
{
	class Menu
	{
		DanhSachMayTinh listMayTinh = new DanhSachMayTinh();
		QuanLyMayTinh listMayTinhQL = new QuanLyMayTinh();

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc du lieu tu tap tin",
			"Xuat danh sach",
			"Tim kiem theo chuc nang tuong ung",
			"Sap xep theo chuc nang tuong ung",
			"Tim danh sach may tinh theo hang",
			"Xoa may tinh theo hang CPU",
			"Cap nhap theo chi muc:\n\tCap nhap lai may tinh neu la CPU cua Intel",
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
			int i = 0;
			string hangSX;
			switch (menu)
			{
				case 0:
					return;
				case 1:
					#region Các chức năng nhập xuất cơ bản 🤷‍🤷‍🤷‍
					Clear();
					WriteLine("Doc du lieu tu tap tin...");
					listMayTinh.ImportFromFile();
					break;
				case 2:
					Clear();
					WriteLine("Xuat >> ");
					listMayTinh.Xuat();
					break;
				#endregion
				case 3:
					#region Các chức năng tìm kiếm 🚀🚀🚀
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nMay tinh co gia re nhat...");
					listMayTinhQL.DanhSachMayTinhTheoGia<IThietBi>(listMayTinh, QuanLyMayTinh.MinMax.Min).Xuat();
					WriteLine("\nMay tinh co CPU gia thap nhat...");
					listMayTinhQL.DanhSachMayTinhTheoGia<CPU>(listMayTinh, QuanLyMayTinh.MinMax.Min).Xuat();
					WriteLine("\nMay tinh co CPU gia cao nhat...");
					listMayTinhQL.DanhSachMayTinhTheoGia<CPU>(listMayTinh, QuanLyMayTinh.MinMax.Max).Xuat();
					WriteLine("\nMay tinh co RAM gia thap nhat...");
					listMayTinhQL.DanhSachMayTinhTheoGia<RAM>(listMayTinh, QuanLyMayTinh.MinMax.Min).Xuat();
					WriteLine("\nMay tinh co RAM gia cao nhat...");
					listMayTinhQL.DanhSachMayTinhTheoGia<RAM>(listMayTinh, QuanLyMayTinh.MinMax.Max).Xuat();
					WriteLine("\nHang duoc su dung CPU nhieu nhat...");
					listMayTinhQL.DanhSachXHMinMax<CPU>(listMayTinh, QuanLyMayTinh.MinMax.Max).ForEach(x => Write($"{x.PadRight(20)}\t"));
					WriteLine("\nHang duoc su dung CPU it nhat...");
					listMayTinhQL.DanhSachXHMinMax<CPU>(listMayTinh, QuanLyMayTinh.MinMax.Min).ForEach(x => Write($"{x.PadRight(20)}\t"));
					WriteLine("\nHang duoc su dung RAM nhieu nhat...");
					listMayTinhQL.DanhSachXHMinMax<RAM>(listMayTinh, QuanLyMayTinh.MinMax.Max).ForEach(x => Write($"{x.PadRight(20)}\t"));
					WriteLine("\nHang duoc su dung RAM it nhat...");
					listMayTinhQL.DanhSachXHMinMax<CPU>(listMayTinh, QuanLyMayTinh.MinMax.Min).ForEach(x => Write($"{x.PadRight(20)}\t"));
					break;
				#endregion
				case 4:
					#region Các chức năng sắp xếp ¯\_(ツ)_/¯
					Clear();
					WriteLine("Sap xep danh sach may tinh theo chuc nang tuong ung >> ");
					WriteLine("\nSap xep danh sach may tinh theo so luong thiet bi...");
					listMayTinhQL.SortTheoLoai<IThietBi>(listMayTinh, QuanLyMayTinh.SortBy.SLThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia thiet bi...");
					listMayTinhQL.SortTheoLoai<IThietBi>(listMayTinh, QuanLyMayTinh.SortBy.GiaThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia CPU...");
					listMayTinhQL.SortTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.SortBy.GiaThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo gia RAM...");
					listMayTinhQL.SortTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.SortBy.GiaThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo so luong CPU...");
					listMayTinhQL.SortTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.SortBy.SLThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("\nSap xep danh sach may tinh theo so luong RAM...");
					listMayTinhQL.SortTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.SortBy.SLThietBi).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE KET THUC CHUC NANG SAP XEP >> ");
					break;
				#endregion
				case 5:
					#region Các chức năng khác ༼ つ ◕_◕ ༽つ
					Clear();
					WriteLine("Tim danh sach may tinh theo hang >> ");
					WriteLine("Danh sach cac hang ton tai trong du lieu...");
					listMayTinh.DanhSachHangTheoLoai<IThietBi>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat tuong ung de tim kiem >> ");
					hangSX = ReadLine();
					try { listMayTinhQL.TimDSMayTinhByInput(listMayTinh, hangSX); }
					catch (Exception e) { WriteLine("Bad Exeption (ngoai le khong mong muon): " + e.Message); }
					finally { Clear(); WriteLine("\nDanh sach cac hang may tinh " + hangSX); listMayTinhQL.TimDSMayTinhByInput(listMayTinh, hangSX).Xuat(); }
					break;
				case 6:
					Clear();
					WriteLine("Xoa may tinh theo hang CPU");
					WriteLine("Danh sach cac hang CPU ton tai trong du lieu...");
					listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat tuong ung de tim kiem >> ");
					hangSX = ReadLine();
					try { listMayTinhQL.XoaMayTinhTheoHangCPU(listMayTinh, hangSX); }
					catch (Exception e) { WriteLine("Bad Exeption (ngoai le khong mong muon): " + e.Message); }
					finally { Clear(); WriteLine("\nDanh sach cac hang may tinh sau khi xoa cac may tinh hang " + hangSX); listMayTinhQL.XoaMayTinhTheoHangCPU(listMayTinh, hangSX); listMayTinh.Xuat(); }
					break;
				case 7:
					Clear();
					WriteLine("\n\t\tDanh sach cap nhap...");
					listMayTinhQL.CapNhapMayTinh(listMayTinh);
					listMayTinh.Xuat();
					break;
				#endregion
				case 8:
					Clear();
					WriteLine("Test code >> ");
					listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => WriteLine(x));
					break;
			}
			ReadLine();
		}
	}
}
