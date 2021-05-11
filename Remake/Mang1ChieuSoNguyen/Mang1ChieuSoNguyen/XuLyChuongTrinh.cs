using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Mang1ChieuSoNguyen
{
	class XuLyChuongTrinh
	{
		static int n;
		static List<int> a = new List<int>();
		XuLyMang xuLyMang = new XuLyMang();
		ProgramColor programColor = new ProgramColor();

		#region Xử lý menu 🚴‍♀️🚴‍♀️🚴‍♀️
		public void XuatMenu(string[] options)
		{
			ForegroundColor = ConsoleColor.White;
			BackgroundColor = programColor.BackgroundColor();
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
					Write("\nNhap kích thước của mảng (số lượng phần tử) >> ");
					n = int.Parse(ReadLine());
					xuLyMang.Nhap(a, n);
					xuLyMang.Xuat(a);
					break;
				case 2:
					Clear();
					a.Clear();
					WriteLine("\nNhập dữ liệu tự động");
					Write("\nNhap kích thước của mảng (số lượng phần tử) >> ");
					n = int.Parse(ReadLine());
					xuLyMang.NhapTuDong(a, n);
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
						ResetColor();
						ForegroundColor = programColor.ForegroundColor();
						BackgroundColor = programColor.BackgroundColor();
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
							Write("\nNhập vào phần tử x >> ");
							x = int.Parse(ReadLine());
							WriteLine("\nVị trí đầu tiên {0} xuất hiện là {1}", x, xuLyMang.ViTriDauTien(a, x));
							break;
						case 3:
							Clear();
							WriteLine("\nTìm vị trí cuối cùng của phần tử");
							xuLyMang.Xuat(a);
							Write("\nNhập vào phần tử x >> ");
							x = int.Parse(ReadLine());
							WriteLine("\nVị trí cuối cùng {0} xuất hiện là {1}", x, xuLyMang.ViTriCuoiCung(a, x));
							break;
						case 4:
							Clear();
							WriteLine("\nTìm phần tử lớn nhất");
							xuLyMang.Xuat(a);
							WriteLine("\nPhần tử lớn nhất là {0}", xuLyMang.Max(a));
							break;
						case 5:
							Clear();
							WriteLine("\nTìm phần tử nhỏ nhất");
							xuLyMang.Xuat(a);
							WriteLine("\nPhần tử nhỏ nhất là {0}", xuLyMang.Min(a));
							break;
						case 6:
							Clear();
							WriteLine("\nTìm tất cả các số âm[]");
							xuLyMang.Xuat(a);
							WriteLine("\nSố âm...");
							xuLyMang.Xuat(xuLyMang.SoAm(a));
							break;
						case 7:
							Clear();
							WriteLine("\nTìm tất cả các số dương[]");
							xuLyMang.Xuat(a);
							WriteLine("\nSố dương...");
							xuLyMang.Xuat(xuLyMang.SoDuong(a));
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tất cả các số chẵn[]");
							xuLyMang.Xuat(a);
							WriteLine("\nSố chẳn...");
							xuLyMang.Xuat(xuLyMang.SoChan(a));
							break;
						case 9:
							Clear();
							WriteLine("\nTìm tất cả các số lẻ[]");
							xuLyMang.Xuat(a);
							WriteLine("\nSố lẻ...");
							xuLyMang.Xuat(xuLyMang.SoLe(a));
							break;
						case 10:
							Clear();
							WriteLine("\nTìm phần tử xuất hiện nhiều nhất[]");
							xuLyMang.Xuat(a);
							WriteLine("\nPhần tử xuất hiện nhiều nhất trong mảng...");
							xuLyMang.Xuat(a.Mode(ExtensionMethod.MinMax.Max));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm phần tử xuất hiện ít nhất[]");
							xuLyMang.Xuat(a);
							WriteLine("\nPhần tử xuất hiện ít nhất trong mảng...");
							xuLyMang.Xuat(a.Mode(ExtensionMethod.MinMax.Min));
							break;
						case 12:
							Clear();
							WriteLine("\nTìm tất cả phần tử lớn hơn x[]");
							xuLyMang.Xuat(a);
							Write("\nNhập vào phần tử x >> ");
							x = int.Parse(ReadLine());
							WriteLine("\nSố lớn hơn {0}...", x);
							xuLyMang.Xuat(xuLyMang.LonHonX(a, x));
							break;
						case 13:
							Clear();
							WriteLine("\nTìm tất cả phần tử nhỏ hơn x[]");
							xuLyMang.Xuat(a);
							Write("\nNhập vào phần tử x >> ");
							x = int.Parse(ReadLine());
							WriteLine("\nSố nhỏ hơn {0}...", x);
							xuLyMang.Xuat(xuLyMang.NhoHonX(a, x));
							break;
						case 14:
							Clear();
							WriteLine("\nTìm tất cả phần tử từ vị trí[]");
							xuLyMang.Xuat(a);
							Write("\nNhập vào vị trí >> ");
							location = int.Parse(ReadLine());
							WriteLine("\nMảng từ vị trí {0}...", location);
							xuLyMang.Xuat(xuLyMang.TuViTri(a, location));
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
							xuLyMang.Xuat(a);
							xuLyMang.XoaDau(a);
							xuLyMang.Xuat(a);
							break;
						case 3:
							Clear();
							WriteLine("\nXóa phần tử cuối");
							xuLyMang.Xuat(a);
							xuLyMang.XoaCuoi(a);
							xuLyMang.Xuat(a);
							break;
						case 4:
							Clear();
							WriteLine("\nXóa phần tử tại vị trí");
							xuLyMang.Xuat(a);
							Write("Nhập vào vị trí cần xóa >> ");
							location = int.Parse(ReadLine());
							xuLyMang.XoaTaiViTri(a, location);
							xuLyMang.Xuat(a);
							break;
						case 5:
							Clear();
							WriteLine("\nXóa tất cả số dương");
							xuLyMang.Xuat(a);
							xuLyMang.XoaDuong(a);
							xuLyMang.Xuat(a);
							break;
						case 6:
							Clear();
							WriteLine("\nXóa tất cả số âm");
							xuLyMang.Xuat(a);
							xuLyMang.XoaAm(a);
							xuLyMang.Xuat(a);
							break;
						case 7:
							Clear();
							WriteLine("\nXóa tất cả số chẵn");
							xuLyMang.Xuat(a);
							xuLyMang.XoaChan(a);
							xuLyMang.Xuat(a);
							break;
						case 8:
							Clear();
							WriteLine("\nXóa tất cả số lẻ");
							xuLyMang.Xuat(a);
							xuLyMang.XoaLe(a);
							xuLyMang.Xuat(a);
							break;
						case 9:
							Clear();
							WriteLine("\nXóa phần tử xuất hiện ít nhất");
							xuLyMang.Xuat(a);
							WriteLine("\n Số xuất hiện ít nhất là ");
							xuLyMang.Xuat(a.Mode(ExtensionMethod.MinMax.Min));
							xuLyMang.XoaNhieuNhat(a);
							xuLyMang.Xuat(a);
							break;
						case 10:
							Clear();
							WriteLine("\nXóa phần tử xuất hiện nhiều nhất");
							xuLyMang.Xuat(a);
							WriteLine("\n Số xuất hiện nhiều nhất là ");
							xuLyMang.Xuat(a.Mode(ExtensionMethod.MinMax.Max));
							xuLyMang.XoaNhieuNhat(a);
							xuLyMang.Xuat(a);
							break;
						case 11:
							Clear();
							WriteLine("\nXóa tất cả số nguyên tố");
							xuLyMang.Xuat(a);
							WriteLine("\n Số xuất nguyên tố là ");
							a.ForEach(x => { if (xuLyMang.IsPrime(x)) Write("{0, 5}", x); });
							xuLyMang.XoaSoNguyenTo(a);
							WriteLine("\nSau khi xóa tất cả các số nguyên tố xác định được...");
							xuLyMang.Xuat(a);
							break;
						case 12:
							Clear();
							WriteLine("\nXóa phần tử trong mảng b có trong mảng a");
							Write("\nMảng b chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng b >> ");
							n = int.Parse(ReadLine());
							b = new List<int>(n);
							xuLyMang.NhapTuDong(b, n);
							WriteLine("\nMảng A...");
							xuLyMang.Xuat(a);
							WriteLine("\nMảng B...");
							xuLyMang.Xuat(b);
							xuLyMang.XoaMangTrongMang(a, b);
							WriteLine("\nMảng a sau khi xóa...");
							xuLyMang.Xuat(a);
							break;
						case 13:
							Clear();
							WriteLine("\nXóa tất cả phần tử");
							xuLyMang.Xuat(a);
							a.Clear();
							WriteLine("\nSau khi xóa tất cả các phần tử...");
							xuLyMang.Xuat(a);
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
							xuLyMang.Xuat(a);
							WriteLine("\n Có {0} số dương trong danh sách", xuLyMang.DemSoDuong(a));
							break;
						case 3:
							Clear();
							WriteLine("\nĐếm số âm");
							xuLyMang.Xuat(a);
							WriteLine("\n Có {0} số âm trong danh sách", xuLyMang.DemSoAm(a));
							break;
						case 4:
							Clear();
							WriteLine("\nĐếm số chẵn");
							xuLyMang.Xuat(a);
							WriteLine("\n Có {0} số chẵn trong danh sách", xuLyMang.DemSoChan(a));
							break;
						case 5:
							Clear();
							WriteLine("\nĐếm số lẻ");
							xuLyMang.Xuat(a);
							WriteLine("\n Có {0} số lẻ trong danh sách", xuLyMang.DemSoLe(a));
							break;
						case 6:
							Clear();
							WriteLine("\nĐếm số nguyên tố");
							xuLyMang.Xuat(a);
							WriteLine("\n Có {0} số nguyên tố trong danh sách", xuLyMang.DemSoNguyenTo(a));
							break;
						case 7:
							Clear();
							WriteLine("\nĐếm số lần xuất hiện của phần tử x trong mảng");
							xuLyMang.Xuat(a);
							Write("\nNhập vào x để kiêm tra >> ");
							x = int.Parse(ReadLine());
							WriteLine("\n Có {0} số {1} trong danh sách", xuLyMang.DemX(a, (int)x), x);
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
							xuLyMang.Xuat(a);
							Write("\nNhập phần tử cần thêm >> ");
							x = int.Parse(ReadLine());
							xuLyMang.ThemDau(a, (int)x);
							WriteLine("\nDanh sách sau khi thêm...");
							xuLyMang.Xuat(a);
							break;
						case 3:
							Clear();
							WriteLine("\nThêm phần tử cuối danh sách");
							xuLyMang.Xuat(a);
							Write("\nNhập phần tử cần thêm >> ");
							x = int.Parse(ReadLine());
							xuLyMang.ThemCuoi(a, (int)x);
							WriteLine("\nDanh sách sau khi thêm...");
							xuLyMang.Xuat(a);
							break;
						case 4:
							Clear();
							WriteLine("\nThêm phần tử tại vị trí");
							xuLyMang.Xuat(a);
							Write("\nNhập phần tử cần thêm >> ");
							x = int.Parse(ReadLine());
							Write("\nNhập vị trí cần thêm >> ");
							location = int.Parse(ReadLine());
							xuLyMang.ThemTaiViTri(a, (int)x, location);
							WriteLine("\nDanh sách sau khi thêm...");
							xuLyMang.Xuat(a);
							break;
						case 5:
							Clear();
							WriteLine("\nThêm 1 mảng mới vào đầu danh sách");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							n = int.Parse(ReadLine());
							b = new List<int>(n);
							xuLyMang.NhapTuDong(b, n);
							WriteLine("\nMảng A...");
							xuLyMang.Xuat(a);
							WriteLine("\nMảng mới...");
							xuLyMang.Xuat(b);
							xuLyMang.ThemMangVaoDau(a, b);
							WriteLine("\nMảng sau khi chèn mảng mới vào đầu...");
							xuLyMang.Xuat(a);
							break;
						case 6:
							Clear();
							WriteLine("\nThêm 1 mảng mới vào cuối danh sách");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							n = int.Parse(ReadLine());
							b = new List<int>(n);
							xuLyMang.NhapTuDong(b, n);
							WriteLine("\nMảng A...");
							xuLyMang.Xuat(a);
							WriteLine("\nMảng mới...");
							xuLyMang.Xuat(b);
							xuLyMang.ThemMangVaoCuoi(a, b);
							WriteLine("\nMảng sau khi chèn mảng mới vào cuối...");
							xuLyMang.Xuat(a);
							break;
						case 7:
							Clear();
							WriteLine("\nThêm 1 mảng vào danh sách tại vị trí");
							Write("\nMảng cần thêm chưa được xác định! Bắt đầu nhập dữ liệu...");
							Write("\nNhập số lượng phần tử của mảng mới >> ");
							n = int.Parse(ReadLine());
							b = new List<int>(n);
							xuLyMang.NhapTuDong(b, n);
							WriteLine("\nMảng A...");
							xuLyMang.Xuat(a);
							WriteLine("\nMảng mới...");
							xuLyMang.Xuat(b);
							Write("\nNhập vào vị trí cần thêm >> ");
							location = int.Parse(ReadLine());
							xuLyMang.ThemMangVaoViTri(a, b, location);
							WriteLine("\nMảng sau khi chèn mảng mới vào cuối...");
							xuLyMang.Xuat(a);
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
							xuLyMang.Xuat(a);
							xuLyMang.SapXepTang(a);
							WriteLine("\nSau khi sắp xếp");
							xuLyMang.Xuat(a);
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp giảm");
							xuLyMang.Xuat(a);
							WriteLine("\nSau khi sắp xếp");
							xuLyMang.Xuat(xuLyMang.SapXepGiam(a));
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
							xuLyMang.Xuat(a);
							Write("\nNhập vào phần tử cần thay thế >> ");
							x = int.Parse(ReadLine());
							Write("\nNhập vào giá trị sẽ thay thế >> ");
							int y = int.Parse(ReadLine());
							xuLyMang.ThayThe(a, (int)x, y);
							WriteLine("\nDanh sách sau khi thay đổi các giá trị...");
							xuLyMang.Xuat(a);
							break;
						case 3:
							Clear();
							WriteLine("\nKiểm tra x có trong mảng hay không");
							xuLyMang.Xuat(a);
							Write("\nNhập vào phần tử để kiểm tra >> ");
							x = int.Parse(ReadLine());
							if (a.Contains((int)x))
								WriteLine("\n {0} có tồn tại!", x);
							else
								WriteLine("\n {0} không tồn tại!", x);
							break;
						case 4:
							Clear();
							WriteLine("\nTính tổng các số nguyên");
							xuLyMang.Xuat(a);
							WriteLine("\nTổng tất cả các số nguyên là {0}", a.FindAll(x => x > 0).Sum());
							break;
						case 5:
							Clear();
							WriteLine("\nĐảo ngược mảng");
							xuLyMang.Xuat(a);
							WriteLine("\nDanh sách sau khi đảo ngược...");
							a.Reverse();
							xuLyMang.Xuat(a);
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}