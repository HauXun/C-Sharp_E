using System;
using static System.Console;

namespace QuanLyHinhHoc
{
	class XuLyChuongTrinh
	{
		XuLyDuLieuHinhHoc xuLyDuLieuHinhHoc = new XuLyDuLieuHinhHoc();
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, DanhSachHinhHoc danhSachHinhHoc)
		{
			Object x;
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
							WriteLine("\nTìm hình vuông có diện tích x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							Write("\n Nhập vào diện tích >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình vuông có diện tích {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.DienTich, (float)x));
							break;
						case 3:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							Write("\n Nhập vào chu vi >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình vuông có chu vi {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.ChuVi, (float)x));
							break;
						case 4:
							Clear();
							WriteLine("\nTìm hình vuông có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 5:
							Clear();
							WriteLine("\nTìm hình vuông có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 6:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 7:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 8:
							Clear();
							WriteLine("\nTìm hình vuông có cạnh nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có cạnh nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinCanh, XuLyDuLieuHinhHoc.TypeCal.Canh));
							break;
						case 9:
							Clear();
							WriteLine("\nTìm hình vuông có cạnh lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhVuong>(danhSachHinhHoc));
							WriteLine("\nHình vuông có cạnh lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxCanh, XuLyDuLieuHinhHoc.TypeCal.Canh));
							break;
						case 10:
							Clear();
							WriteLine("\nTìm hình tròn có diện tích x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							Write("\n Nhập vào diện tích >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình tròn có diện tích {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.DienTich, (float)x));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							Write("\n Nhập vào chu vi >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình tròn có chu vi {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.ChuVi, (float)x));
							break;
						case 12:
							Clear();
							WriteLine("\nTìm hình tròn có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 13:
							Clear();
							WriteLine("\nTìm hình tròn có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 14:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 15:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 16:
							Clear();
							WriteLine("\nTìm hình tròn có bán kính nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có bán kính nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinBanKinh, XuLyDuLieuHinhHoc.TypeCal.BanKinh));
							break;
						case 17:
							Clear();
							WriteLine("\nTìm hình tròn có bán kính lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhTron>(danhSachHinhHoc));
							WriteLine("\nHình tròn có bán kính lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxBanKinh, XuLyDuLieuHinhHoc.TypeCal.BanKinh));
							break;
						case 18:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							Write("\n Nhập vào diện tích >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình chữ nhật có diện tích {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.DienTich, (float)x));
							break;
						case 19:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi x");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							Write("\n Nhập vào chu vi >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n Hình chữ nhật có chu vi {0}", x);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeCal.ChuVi, (float)x));
							break;
						case 20:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 21:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 22:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 23:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 24:
							Clear();
							WriteLine("\nTìm hình chữ nhật có cạnh nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có cạnh nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinCanhHCN, XuLyDuLieuHinhHoc.TypeCal.CanhHCN));
							break;
						case 25:
							Clear();
							WriteLine("\nTìm hình chữ nhật có cạnh lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(
								xuLyDuLieuHinhHoc.DanhSachTheoKieuHinh<HinhChuNhat>(danhSachHinhHoc));
							WriteLine("\nHình chữ nhật có cạnh lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhTheoKieuTinh<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxCanhHCN, XuLyDuLieuHinhHoc.TypeCal.CanhHCN));
							break;
						case 26:
							Clear();
							WriteLine("\nTìm hình có diện tích nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhMinMaxKieuTinh<HinhHoc>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 27:
							Clear();
							WriteLine("\nTìm hình có diện tích lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhMinMaxKieuTinh<HinhHoc>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich, XuLyDuLieuHinhHoc.TypeCal.DienTich));
							break;
						case 28:
							Clear();
							WriteLine("\nTìm hình có chu vi nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhMinMaxKieuTinh<HinhHoc>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 29:
							Clear();
							WriteLine("\nTìm hình có chu vi lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.TimHinhMinMaxKieuTinh<HinhHoc>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi, XuLyDuLieuHinhHoc.TypeCal.ChuVi));
							break;
						case 30:
							Clear();
							WriteLine("\nTìm hình có tổng diện tích nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có tổng diện tích nhỏ nhất");
							WriteLine(xuLyDuLieuHinhHoc.HinhCoTongPhepTinhMinMax(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich));
							break;
						case 31:
							Clear();
							WriteLine("\nTìm hình có tổng diện tích lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có tổng diện tích lớn nhất");
							WriteLine(xuLyDuLieuHinhHoc.HinhCoTongPhepTinhMinMax(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich));
							break;
						case 32:
							Clear();
							WriteLine("\nTìm hình có tổng chu vi nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có tổng chu vi nhỏ nhất");
							WriteLine(xuLyDuLieuHinhHoc.HinhCoTongPhepTinhMinMax(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi));
							break;
						case 33:
							Clear();
							WriteLine("\nTìm hình có tổng chu vi lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nHình có tổng chu vi lớn nhất");
							WriteLine(xuLyDuLieuHinhHoc.HinhCoTongPhepTinhMinMax(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi));
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
							WriteLine("\nSắp xếp hình vuông tăng theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình vuông sau khi sắp xếp tăng theo chu vi");
							xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhVuong>(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByCV);
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByCV));
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp hình vuông giảm theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình vuông sau khi sắp xếp giảm theo chu vi");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortDownByCV));
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp hình vuông tăng theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình vuông sau khi sắp xếp tăng theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByDT));
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp hình vuông giảm theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình vuông sau khi sắp xếp giảm theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhVuong>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortDownByDT));
							break;
						case 6:
							Clear();
							WriteLine("\nSắp xếp hình tròn tăng theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình tròn sau khi sắp xếp tăng theo chu vi");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByCV));
							break;
						case 7:
							Clear();
							WriteLine("\nSắp xếp hình tròn giảm theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình tròn sau khi sắp xếp giảm theo chu vi");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortDownByCV));
							break;
						case 8:
							Clear();
							WriteLine("\nSắp xếp hình tròn tăng theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình tròn sau khi sắp xếp tăng theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByDT));
							break;
						case 9:
							Clear();
							WriteLine("\nSắp xếp hình tròn giảm theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình tròn sau khi sắp xếp giảm theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhTron>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortDownByDT));
							break;
						case 10:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật tăng theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình chữ nhật tăng theo chu vi");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByCV));
							break;
						case 11:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật giảm theo chu vi");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình chữ nhật giảm theo chu vi");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByCV));
							break;
						case 12:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật tăng theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình chữ nhật tăng theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortUpByDT));
							break;
						case 13:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật giảm theo diện tích");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách hình chữ nhật giảm theo diện tích");
							xuLyDuLieuHinhHoc.Xuat(xuLyDuLieuHinhHoc.SapXepTheoCachGoi<HinhChuNhat>
								(danhSachHinhHoc, XuLyDuLieuHinhHoc.SortBy.SortDownByDT));
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
							WriteLine("\nXóa hình có diện tích lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách sau khi xóa hình có diện tích lớn nhất");
							xuLyDuLieuHinhHoc.XoaTheoCachGoi<HinhHoc>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxDienTich);
							xuLyDuLieuHinhHoc.Xuat(danhSachHinhHoc.ListHinhHoc);
							break;
						case 3:
							Clear();
							WriteLine("\nXóa hình có diện tích nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách sau khi xóa hình có diện tích nhỏ nhất");
							xuLyDuLieuHinhHoc.XoaTheoCachGoi<HinhHoc>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinDienTich);
							xuLyDuLieuHinhHoc.Xuat(danhSachHinhHoc.ListHinhHoc);
							break;
						case 4:
							Clear();
							WriteLine("\nXóa hình có chu vi lớn nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách sau khi xóa hình có chu vi lớn nhất");
							xuLyDuLieuHinhHoc.XoaTheoCachGoi<HinhHoc>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MaxChuVi);
							xuLyDuLieuHinhHoc.Xuat(danhSachHinhHoc.ListHinhHoc);
							break;
						case 5:
							Clear();
							WriteLine("\nXóa hình có chu vi nhỏ nhất");
							danhSachHinhHoc.Xuat();
							WriteLine("\nDanh sách sau khi xóa hình có chu vi nhỏ nhất");
							xuLyDuLieuHinhHoc.XoaTheoCachGoi<HinhHoc>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeMinMax.MinChuVi);
							xuLyDuLieuHinhHoc.Xuat(danhSachHinhHoc.ListHinhHoc);
							break;
						case 6:
							Clear();
							WriteLine("\nXóa hình tại vị trí");
							danhSachHinhHoc.Xuat();
							Write("\n Nhập vào vị trí cần xóa >> ");
							x = int.Parse(ReadLine());
							WriteLine("\nDanh sách sau khi xóa hình tại vị trí {0}", x);
							xuLyDuLieuHinhHoc.XoaHinhTaiViTri(danhSachHinhHoc, (int)x);
							danhSachHinhHoc.Xuat();
							break;
					}
					break;
				case XuLyMenu.TuyChon.Khac:
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
							WriteLine("\nThêm 1 hình học tại vị trí");
							Write("\nNhập vào vị trí để thêm >> ");
							x = int.Parse(ReadLine());
							Write("\nBạn muốn thêm hình gì?\nNhập vào số tương ứng ( 0 - Hình Vuông, 1 - Hình Tròn, 2 - Hình Chữ Nhật ) >> ");
							XuLyDuLieuHinhHoc.TypeList typeList = (XuLyDuLieuHinhHoc.TypeList)int.Parse(ReadLine());
							xuLyDuLieuHinhHoc.ThemHinhTaiViTri(danhSachHinhHoc, typeList, (int)x);
							Clear();
							WriteLine("\n Danh sách hiện hành");
							danhSachHinhHoc.Xuat();
							break;
						case 3:
							Clear();
							WriteLine("Đếm số lượng các loại hình học");
							Write("\n\nSố lượng hình vuông là >> " + xuLyDuLieuHinhHoc.DemTheoHinh<HinhVuong>(danhSachHinhHoc));
							Write("\n\nSố lượng hình tròn là >> " + xuLyDuLieuHinhHoc.DemTheoHinh<HinhTron>(danhSachHinhHoc));
							Write("\n\nSố lượng hình chữ nhật là >> " + xuLyDuLieuHinhHoc.DemTheoHinh<HinhChuNhat>(danhSachHinhHoc));
							Write("\n\nTổng số lượng hình học là >> " + xuLyDuLieuHinhHoc.DemTheoHinh<HinhHoc>(danhSachHinhHoc));
							break;
						case 4:
							Clear();
							WriteLine("Ghi file các hình xuống file riêng");
							WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
							xuLyDuLieuHinhHoc.GhiFile<HinhVuong>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeList.HinhVuong);
							xuLyDuLieuHinhHoc.GhiFile<HinhTron>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeList.HinhTron);
							xuLyDuLieuHinhHoc.GhiFile<HinhChuNhat>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeList.HinhChuNhat);
							xuLyDuLieuHinhHoc.GhiFile<HinhHoc>(danhSachHinhHoc, XuLyDuLieuHinhHoc.TypeList.TatCaHinh);
							ReadLine();
							WriteLine("Ghi file hoan tat !");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
