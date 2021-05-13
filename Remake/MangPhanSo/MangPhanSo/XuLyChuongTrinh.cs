using System;
using System.Collections.Generic;
using static System.Console;

namespace MangPhanSo
{
	class XuLyChuongTrinh
	{
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, XuLyMangPhanSo xuLyMangPhanSo)
		{
			PhanSo phanSo = new PhanSo();
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
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số dương...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoDuong());
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tất cả các phân số dương trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng phân số dương...");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.PhanSoDuong());
							break;
						case 9:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số x trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào phân số x:");
							phanSo.Nhap();
							WriteLine("\n Vị trí của phân số {0}...", phanSo);
							xuLyMangPhanSo.ViTriPhanSoX(phanSo).ForEach(x => Write("{0, 10}", x));
							break;
						case 10:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số âm trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Vị trí của phân số âm");
							xuLyMangPhanSo.ViTriPhanSoAm().ForEach(x => Write("{0, 10}", x));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm tất cả vị trí của phân số dương trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Vị trí của phân số dương");
							xuLyMangPhanSo.ViTriPhanSoDuong().ForEach(x => Write("{0, 10}", x));
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
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaDau();
							WriteLine("\n Mảng sau khi xóa phân số đầu tiên");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 3:
							Clear();
							WriteLine("\nXóa phân số cuối cùng trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaCuoi();
							WriteLine("\n Mảng sau khi xóa phân số cuối cùng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 4:
							Clear();
							WriteLine("\nXóa phân số x trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào phân số:");
							phanSo.Nhap();
							xuLyMangPhanSo.XoaX(phanSo);
							WriteLine("\n Mảng sau khi xóa phân số {0}", phanSo);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 5:
							Clear();
							WriteLine("\nXóa tất cả phân số có tử là x");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào tử >> ");
							x = int.Parse(ReadLine());
							xuLyMangPhanSo.XoaPhanSoTuX((int)x);
							WriteLine("\n Mảng sau khi xóa phân số có tử là {0}", x);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 6:
							Clear();
							WriteLine("\nXóa tất cả phân số có mẫu là x");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào mẫu >> ");
							x = int.Parse(ReadLine());
							xuLyMangPhanSo.XoaPhanSoMauX((int)x);
							WriteLine("\n Mảng sau khi xóa phân số có mẫu là {0}", x);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 7:
							Clear();
							WriteLine("\nXóa tất cả phân số chẵn");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoChan();
							WriteLine("\n Mảng sau khi xóa phân số chẵn");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 8:
							Clear();
							WriteLine("\nXóa tất cả phân số lẻ");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoLe();
							WriteLine("\n Mảng sau khi xóa phân số lẻ");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 9:
							Clear();
							WriteLine("\nXóa một phân số tại vị trí x trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào vị trí >> ");
							location = int.Parse(ReadLine());
							xuLyMangPhanSo.XoaTaiViTri(location);
							WriteLine("\n Mảng sau khi xóa phân số tại vị trí {0}", location);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 10:
							Clear();
							WriteLine("\nXóa tất cả phân số âm trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoAm();
							WriteLine("\n Mảng sau khi xóa tất phân số âm");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 11:
							Clear();
							WriteLine("\nXóa tất cả phân số dương trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoDuong();
							WriteLine("\n Mảng sau khi xóa tất phân số dương");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 12:
							Clear();
							WriteLine("\nXóa tất cả các phân số nhỏ nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng sau khi xóa tất phân số nhỏ nhất {0}", xuLyMangPhanSo.PhanSoAmMin());
							xuLyMangPhanSo.XoaPhanSoMin();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 13:
							Clear();
							WriteLine("\nXóa tất cả các phân số lớn nhất");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Mảng sau khi xóa tất phân số lớn nhất {0}", xuLyMangPhanSo.PhanSoDuongMax());
							xuLyMangPhanSo.XoaPhanSoMax();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 14:
							Clear();
							WriteLine("\nXóa tất cả phân số có giá trị giống phân số đầu tiên trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoGiongDau();
							WriteLine("\n Mảng sau khi xóa tất phân số có giá trị giống phân số đầu tiên trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 15:
							Clear();
							WriteLine("\nXóa tất cả phân số có giá trị giống phân số cuối cùng trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							xuLyMangPhanSo.XoaPhanSoGiongCuoi();
							WriteLine("\n Mảng sau khi xóa tất phân số có giá trị giống phân số cuối cùng trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 16:
							Clear();
							WriteLine("\nXóa các phần tử tại các vị trí (vị trí được lưu trong mảng)");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							List<int> position = xuLyMangPhanSo.XacDinhViTri();
							WriteLine("\n Các vị trí được xác định");
							position.ForEach(x => Write("{0, 10}", x));
							position.Sort();
							position.Reverse();
							xuLyMangPhanSo.XoaTaiCacViTri(position);
							WriteLine("\n Mảng sau khi xóa tất phân số có các vị trí được xác định trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
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
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập phân số cần thêm:");
							phanSo.Nhap();
							xuLyMangPhanSo.ThemDau(phanSo);
							WriteLine("\n Danh sách sau khi thêm phân số {0} vào đầu", phanSo);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 3:
							Clear();
							WriteLine("\nThêm phân số cuối cùng trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập phân số cần thêm:");
							phanSo.Nhap();
							xuLyMangPhanSo.ThemCuoi(phanSo);
							WriteLine("\n Danh sách sau khi thêm phân số {0} vào cuối", phanSo);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 4:
							Clear();
							WriteLine("\nThêm một phân số tại vị trí trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập phân số cần thêm:");
							phanSo.Nhap();
							Write("\n Nhập vào vị trí cần thêm >> ");
							location = int.Parse(ReadLine());
							xuLyMangPhanSo.ThemTaiViTri(location, phanSo);
							WriteLine("\n Danh sách sau khi thêm phân số {0} vào danh sách tại vị trí {1}", phanSo, location);
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
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
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Danh sách sau khi sắp xếp tăng theo chiều tăng của tử");
							xuLyMangPhanSo.TangTheoTu();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều tăng của mẫu");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Danh sách sau khi sắp xếp tăng theo chiều tăng của mẫu");
							xuLyMangPhanSo.TangTheoMau();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều giảm của mẫu");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Danh sách sau khi sắp xếp giảm theo chiều giảm của tử");
							xuLyMangPhanSo.GiamTheoTu();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp phân số theo chiều giảm của mẫu");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Danh sách sau khi sắp xếp giảm theo chiều giảm của mẫu");
							xuLyMangPhanSo.GiamTheoMau();
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
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
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Tổng tất cả các phân số âm trong mảng là {0}", xuLyMangPhanSo.TongAm());
							break;
						case 3:
							Clear();
							WriteLine("\nTổng tất cả các phân số dương trong mảng");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							WriteLine("\n Tổng tất cả các phân số dương trong mảng là {0}", xuLyMangPhanSo.TongDuong());
							break;
						case 4:
							Clear();
							WriteLine("\nTổng tất cả phân số có tử là x");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào tử số >> ");
							x = int.Parse(ReadLine());
							WriteLine("\n Tổng tất cả các phân số có tử là {0} trong mảng là {1}", x, xuLyMangPhanSo.TongTuX((int)x));
							break;
						case 5:
							Clear();
							WriteLine("\nTổng tất cả phân số có mẫu là x");
							xuLyMangPhanSo.Xuat(xuLyMangPhanSo.a);
							Write("\n Nhập vào mẫu số >> ");
							x = int.Parse(ReadLine());
							WriteLine("\n Tổng tất cả các phân số có mẫu là {0} trong mảng là {1}", x, xuLyMangPhanSo.TongMauX((int)x));
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
