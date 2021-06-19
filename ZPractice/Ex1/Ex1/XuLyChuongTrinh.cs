using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Ex1
{
	class XuLyChuongTrinh
	{
		static int n;
		static List<int> a = new List<int>();
		XuLyMang xuLyMang = new XuLyMang();

		#region Xử lý menu 🚴‍♀️🚴‍♀️🚴‍♀️
		public void XuatMenu(string[] options)
		{
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
		public enum TuyChon
		{
			TimKiem = 2,
			Xoa,
			Dem,
			Them,
			SapXep,
			Other
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
					a.Clear();
					WriteLine("\nNhập dữ liệu");
					xuLyMang.Nhap(a);
					xuLyMang.Xuat(a);
					break;
				case 2:
					Clear();
					a.Clear();
					WriteLine("\nNhập dữ liệu tự động");
					xuLyMang.NhapTuDong(a);
					xuLyMang.Xuat(a);
					break;
				case 3:
					Clear();
					WriteLine("Xuất dữ liệu");
					xuLyMang.Xuat(a);
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
						XuLyMenu(tuyChon);
					} while (menuM > 0);
					break;
			}
			ReadLine();
		}
		public void XuLyMenu(TuyChon tuyChon)
		{
			Menu menuM = new Menu();
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
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
				case TuyChon.Xoa:
					soMenu = menuM.delete.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.delete);
						if (menu == 1)
							return;
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
				case TuyChon.Dem:
					soMenu = menuM.count.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.count);
						if (menu == 1)
							return;
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
				case TuyChon.Them:
					soMenu = menuM.add.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.add);
						if (menu == 1)
							return;
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
				case TuyChon.SapXep:
					soMenu = menuM.sort.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.sort);
						if (menu == 1)
							return;
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
				case TuyChon.Other:
					soMenu = menuM.otherOptions.Length - 1;
					do
					{
						menu = ChonMenu(soMenu, menuM.otherOptions);
						if (menu == 1)
							return;
						XuLyChucNang(tuyChon, menu);
					} while (menu > 0);
					break;
			}
			ReadLine();
		}
		#endregion

		public void XuLyChucNang(TuyChon tuyChon, int menu)
		{
			Object x;
			int location;
			List<int> b;
			switch (tuyChon)
			{
				case TuyChon.TimKiem:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nTìm vị trí đầu tiên của phần tử");
							xuLyMang.Xuat(a);
							Write(" \nNhập vào phần tử cần tìm >> ");
							x = int.Parse(ReadLine());
							WriteLine("Vị trí đầu tiên của phần tử {0} xuất hiện là {1}", x, xuLyMang.ViTriDauTien(a, x));
							break;
						case 3:
							Clear();
							WriteLine("\nTìm vị trí cuối cùng của phần tử");
							xuLyMang.Xuat(a);
							Write(" \nNhập vào phần tử cần tìm >> ");
							x = int.Parse(ReadLine());
							WriteLine("Vị trí cuối cùng của phần tử {0} xuất hiện là {1}", x, xuLyMang.ViTriCuoiCung(a, x));
							break;
						case 4:
							Clear();
							WriteLine("\nTìm phần tử lớn nhất");
							xuLyMang.Xuat(a);
							WriteLine(" Phần tử lớn nhất là {0}", xuLyMang.PhanTuMax(a));
							break;
						case 5:
							Clear();
							WriteLine("\nTìm phần tử nhỏ nhất");
							xuLyMang.Xuat(a);
							WriteLine(" Phần tử nhỏ nhất là {0}", xuLyMang.PhanTuMin(a));
							break;
						case 6:
							Clear();
							WriteLine("\nTìm tất cả các số âm[]");
							xuLyMang.Xuat(a);
							WriteLine(" Mảng số âm là");
							xuLyMang.Xuat(xuLyMang.MangSoAm(a));
							break;
						case 7:
							Clear();
							WriteLine("\nTìm tất cả các số dương[]");
							xuLyMang.Xuat(a);
							WriteLine(" Mảng số dương là");
							xuLyMang.Xuat(xuLyMang.MangSoDuong(a));
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tất cả các số chẵn[]");
							break;
						case 9:
							Clear();
							WriteLine("\nTìm tất cả các số lẻ[]");
							break;
						case 10:
							Clear();
							WriteLine("\nTìm phần tử xuất hiện nhiều nhất[]");
							xuLyMang.Xuat(a);
							Write(" Các phần tử xuất hiện nhiều nhất là...");
							xuLyMang.Xuat(xuLyMang.MangXuatHienNhieuNhat(a));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm phần tử xuất hiện ít nhất[]");
							xuLyMang.Xuat(a);
							Write(" Các phần tử xuất hiện nhiều nhất là...");
							xuLyMang.Xuat(xuLyMang.MangXuatHienItNhat(a));
							break;
						case 12:
							Clear();
							WriteLine("\nTìm tất cả phần tử lớn hơn x[]");
							break;
						case 13:
							Clear();
							WriteLine("\nTìm tất cả phần tử nhỏ hơn x[]");
							break;
						case 14:
							Clear();
							WriteLine("\nTìm tất cả phần tử từ vị trí[]");
							xuLyMang.Xuat(a);
							Write(" Nhập vào vị trí >> ");
							location = int.Parse(ReadLine());
							Write(" Mảng tử vuh trí {0} là", location);
							xuLyMang.Xuat(xuLyMang.TimTuViTri(a, location));
							break;
					}
					break;
				case TuyChon.Xoa:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nXóa phần tử đầu tiên");
							break;
						case 3:
							Clear();
							WriteLine("\nXóa phần tử cuối");
							break;
						case 4:
							Clear();
							WriteLine("\nXóa phần tử tại vị trí");
							break;
						case 5:
							Clear();
							WriteLine("\nXóa tất cả số dương");
							break;
						case 6:
							Clear();
							WriteLine("\nXóa tất cả số âm");
							break;
						case 7:
							Clear();
							WriteLine("\nXóa tất cả số chẵn");
							break;
						case 8:
							Clear();
							WriteLine("\nXóa tất cả số lẻ");
							break;
						case 9:
							Clear();
							WriteLine("\nXóa phần tử xuất hiện ít nhất");
							break;
						case 10:
							Clear();
							WriteLine("\nXóa phần tử xuất hiện nhiều nhất");
							break;
						case 11:
							Clear();
							WriteLine("\nXóa tất cả số nguyên tố");
							break;
						case 12:
							Clear();
							WriteLine("\nXóa phần tử trong mảng b có trong mảng a");
							Write("\nMảng b chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng b >> ");
							break;
						case 13:
							Clear();
							WriteLine("\nXóa tất cả phần tử");
							break;
					}
					break;
				case TuyChon.Dem:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nĐếm số dương");
							break;
						case 3:
							Clear();
							WriteLine("\nĐếm số âm");
							break;
						case 4:
							Clear();
							WriteLine("\nĐếm số chẵn");
							break;
						case 5:
							Clear();
							WriteLine("\nĐếm số lẻ");
							break;
						case 6:
							Clear();
							WriteLine("\nĐếm số nguyên tố");
							break;
						case 7:
							Clear();
							WriteLine("\nĐếm số lần xuất hiện của phần tử x trong mảng");
							break;
					}
					break;
				case TuyChon.Them:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nThêm phần tử đầu danh sách");
							break;
						case 3:
							Clear();
							WriteLine("\nThêm phần tử cuối danh sách");
							break;
						case 4:
							Clear();
							WriteLine("\nThêm phần tử tại vị trí");
							break;
						case 5:
							Clear();
							WriteLine("\nThêm 1 mảng mới vào đầu danh sách");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							break;
						case 6:
							Clear();
							WriteLine("\nThêm 1 mảng mới vào cuối danh sách");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							break;
						case 7:
							Clear();
							WriteLine("\nThêm 1 mảng vào danh sách tại vị trí");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							break;
					}
					break;
				case TuyChon.SapXep:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nSắp xếp tăng");
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp giảm");
							break;
					}
					break;
				case TuyChon.Other:
					switch (menu)
					{
						case 0:
							WriteLine("\n Bạn đã lựa chọn đi ngủ.\n\tCÚT");
							Environment.Exit(0);
							return;
						case 1:
							WriteLine("\nQuay về trang trước");
							return;
						case 2:
							Clear();
							WriteLine("\nThay thế phần tử x thành phần tử y");
							break;
						case 3:
							Clear();
							WriteLine("\nKiểm tra x có trong mảng hay không");
							break;
						case 4:
							Clear();
							WriteLine("\nTính tổng các số nguyên");
							break;
						case 5:
							Clear();
							WriteLine("\nĐảo ngược mảng");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
