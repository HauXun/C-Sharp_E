using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuanLyHinhHoc
{
	class XuLyMenu
	{
		DanhSachHinhHoc danhSachHinhHoc = new DanhSachHinhHoc();
		XuLyMauSac xuLyMauSac = new XuLyMauSac();
		public enum TuyChon
		{
			TimKiem = 2,
			SapXep,
			Xoa,
			Khac
		}
		#region Xử lý menu 🚴‍♀️🚴‍♀️🚴‍♀️
		public void XuatMenu(string[] options)
		{
			ForegroundColor = ConsoleColor.White;
			BackgroundColor = xuLyMauSac.BackgroundColor();
			WriteLine("".PadRight(20, '=') + "MENU".PadRight(20, '='));
			for (int i = 0; i < options.Length; i++)
				WriteLine("{0}. {1}", i, options[i]);
			WriteLine("".PadRight(40, '='));
		}
		public int ChonMenu(int soMenu, string[] options)
		{
			int stt = -1;
			while (stt < 0 || stt > soMenu)
			{
				Clear();
				XuatMenu(options);
				Write("\n Nhập vào tùy chọn menu tương ứng >> ");
				stt = int.Parse(ReadLine());
			}
			return stt;
		}
		public void XuLy(int menu)
		{
			switch (menu)
			{
				case 0:
					WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
					return;
				case 1:
					Clear();
					WriteLine("\nNhập dữ liệu hình học");
					danhSachHinhHoc.Nhap();
					danhSachHinhHoc.Xuat();
					break;
				case 2:
					Clear();
					WriteLine("\nNhập dữ liệu hình học từ file");
					danhSachHinhHoc.ImportFromFile();
					break;
				case 3:
					Clear();
					WriteLine("Xuất dữ liệu hình học");
					danhSachHinhHoc.Xuat();
					break;
				case 4:
					Clear();
					Menu meme = new Menu();
					int soMenu = meme.options.Length - 1;
					int menuM;
					do
					{
						menuM = ChonMenu(soMenu, meme.options);
						TuyChon tuyChon = (TuyChon)menuM;
						if (menuM == 1)
							return;
						else if (menuM == 0)
						{
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
						}
						ResetColor();
						ForegroundColor = xuLyMauSac.ForegroundColor();
						BackgroundColor = xuLyMauSac.BackgroundColor();
						XuLyTuyChon(tuyChon, danhSachHinhHoc);
					} while (menuM > 0);
					break;
			}
			ReadLine();
		}
		public void XuLyTuyChon(TuyChon tuyChon, DanhSachHinhHoc danhSachHinhHoc)
		{
			Menu menuM = new Menu();
			XuLyChuongTrinh xuLyChuongTrinh = new XuLyChuongTrinh();
			int menu;
			int soMenu;
			switch (tuyChon)
			{
				case TuyChon.TimKiem:
					soMenu = menuM.search.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.search);
						if (menu == 1)
							return;
						xuLyChuongTrinh.XuLyChucNang(tuyChon, menu, danhSachHinhHoc);
					} while (menu > 0);
					break;
				case TuyChon.SapXep:
					soMenu = menuM.sort.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.sort);
						if (menu == 1)
							return;
						xuLyChuongTrinh.XuLyChucNang(tuyChon, menu, danhSachHinhHoc);
					} while (menu > 0);
					break;
				case TuyChon.Xoa:
					soMenu = menuM.delete.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.delete);
						if (menu == 1)
							return;
						xuLyChuongTrinh.XuLyChucNang(tuyChon, menu, danhSachHinhHoc);
					} while (menu > 0);
					break;
				case TuyChon.Khac:
					soMenu = menuM.other.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.other);
						if (menu == 1)
							return;
						xuLyChuongTrinh.XuLyChucNang(tuyChon, menu, danhSachHinhHoc);
					} while (menu > 0);
					break;
			}
			ReadLine();
		}
		#endregion
	}
}
