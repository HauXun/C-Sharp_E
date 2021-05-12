using System;
using static System.Console;

namespace MangPhanSo
{
	class XuLyChuongTrinh
	{
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, XuLyMangPhanSo xuLyMangPhanSo)
		{
			Object x;
			int location;
			switch (tuyChon)
			{
				case XuLyMenu.TuyChon.TimKiem:
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
							WriteLine("\nTìm phân số lớn nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Phân số lớn nhất trong mảng là {0}...", xuLyMangPhanSo.PhanSoDuongMax());
							break;
						case 3:
							Clear();
							WriteLine("\nTìm phân số âm lớn nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số âm...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoAm());
							WriteLine("\n Phân số âm lớn nhất trong mảng là {0}...", xuLyMangPhanSo.PhanSoAmMax());
							break;
						case 4:
							Clear();
							WriteLine("\nTìm phân số âm nhỏ nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số âm...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoAm());
							WriteLine("\n Phân số âm nhỏ nhất trong mảng là {0}...", xuLyMangPhanSo.PhanSoAmMin());
							break;
						case 5:
							Clear();
							WriteLine("\nTìm phân số dương lớn nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số dương...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoDuong());
							WriteLine("\n Phân số dương lớn nhất trong mảng là {0}...", xuLyMangPhanSo.PhanSoDuongMax());
							break;
						case 6:
							Clear();
							WriteLine("\nTìm phân số dương nhỏ nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số dương...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoDuong());
							WriteLine("\n Phân số dương nhỏ nhất trong mảng là {0}...", xuLyMangPhanSo.PhanSoDuongMin());
							break;
						case 7:
							Clear();
							WriteLine("\nTìm tất cả các phân số âm trong mảng");
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tất cả các phân số dương trong mảng");
							break;
						case 9:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số x trong mảng");
							break;
						case 10:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số âm trong mảng");
							break;
						case 11:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số dương trong mảng");
							break;
					}
					break;
				case XuLyMenu.TuyChon.Xoa:
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
							WriteLine("\nXóa phân số đầu tiên trong mảng");
							break;
						case 3:
							Clear();
							WriteLine("\nXóa phân số cuối cùng trong mảng");
							break;
						case 4:
							Clear();
							WriteLine("\nXóa phân số x trong mảng");
							break;
						case 5:
							Clear();
							WriteLine("\nXóa tất cả phân số có tử là x");
							break;
						case 6:
							Clear();
							WriteLine("\nXóa tất cả phân số có mẫu là x");
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
							WriteLine("\nXóa một phân số tại vị trí x trong mảng");
							break;
						case 10:
							Clear();
							WriteLine("\nXóa tất cả phân số âm trong mảng");
							break;
						case 11:
							Clear();
							WriteLine("\nXóa tất cả phân số dương trong mảng");
							break;
						case 12:
							Clear();
							WriteLine("\nXóa tất cả các phân số nhỏ nhất");
							break;
						case 13:
							Clear();
							WriteLine("\nXóa tất cả các phân số lớn nhất");
							break;
						case 14:
							Clear();
							WriteLine("\nXóa tất cả phân số có giá trị giống phân số đầu tiên trong mảng");
							break;
						case 15:
							Clear();
							WriteLine("\nXóa tất cả phân số có giá trị giống phân số cuối cùng trong mảng");
							break;
						case 16:
							Clear();
							WriteLine("\nXóa các phần tử tại các vị trí (vị trí được lưu trong mảng)");
							break;
					}
					break;
				case XuLyMenu.TuyChon.Dem:
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
							WriteLine("\nĐếm số phân số âm trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số âm...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoAm());
							WriteLine("\n Có {0} phân số âm trong mảng", xuLyMangPhanSo.DemPhanSoAm());
							break;
						case 3:
							Clear();
							WriteLine("\nĐếm số phân số dương trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số dương...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoDuong());
							WriteLine("\n Có {0} phân số dương trong mảng", xuLyMangPhanSo.DemPhanSoDuong());
							break;
						case 4:
							Clear();
							WriteLine("\nĐếm phân số có tử là x trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào tử số để kiểm tra >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Có {0} phân số có tử số là {1} trong mảng...", xuLyMangPhanSo.DemTuSoX((float)x), x);
							break;
						case 5:
							Clear();
							WriteLine("\nĐếm phân số có mẫu là x trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào mẫu số để kiểm tra >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Có {0} phân số có mẫu số là {1} trong mảng...", xuLyMangPhanSo.DemMauSoX((float)x), x);
							break;
					}
					break;
				case XuLyMenu.TuyChon.Them:
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
							WriteLine("\nThêm phân số đầu tiên trong mảng");
							break;
						case 3:
							Clear();
							WriteLine("\nThêm phân số cuối cùng trong mảng");
							break;
						case 4:
							Clear();
							WriteLine("\nThêm một phân số tại vị trí trong mảng");
							break;
					}
					break;
				case XuLyMenu.TuyChon.SapXep:
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
							WriteLine("\nSắp xếp phân số theo chiều tăng của tử");
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều tăng của mẫu");
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều giảm của mẫu");
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều giảm của mẫu");
							break;
					}
					break;
				case XuLyMenu.TuyChon.Tong:
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
							WriteLine("\nTổng tất cả các phân số âm trong mảng");
							break;
						case 3:
							Clear();
							WriteLine("\nTổng tất cả các phân số dương trong mảng");
							break;
						case 4:
							Clear();
							WriteLine("\nTổng tất cả phân số có tử là x");
							break;
						case 5:
							Clear();
							WriteLine("\nTổng tất cả phân số có mẫu là x");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
