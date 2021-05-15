using System;
using System.Collections.Generic;
using static System.Console;

namespace QuanLyDanhBa
{
	class XuLyChuongTrinh
	{
		XuLyDuLieuDanhBa xuLyDuLieuDanhBa = new XuLyDuLieuDanhBa();
		Dictionary<int, int> result;
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, DanhSachDanhBa danhSachDanhBa)
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
							WriteLine("\nTìm thành phố có nhiều thuê bao nhất");
							WriteLine("\nThành phố có nhiều thuê bao nhất");
							xuLyDuLieuDanhBa.ThanhPhoNhieuThueBaoNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x));
							break;
						case 3:
							Clear();
							WriteLine("\nTìm thành phố có ít thuê bao nhất");
							WriteLine("\nThành phố có ít thuê bao nhất");
							xuLyDuLieuDanhBa.ThanhPhoItThueBaoNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x));
							break;
						case 4:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu ít số điện thoại nhất");
							WriteLine("\nThuê bao sở hữu ít số điện thoại nhất");
							xuLyDuLieuDanhBa.ThueBaoItSDTNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x));
							break;
						case 5:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu nhiều số điện thoại nhất");
							WriteLine("\nThuê bao sở hữu nhiều số điện thoại nhất");
							xuLyDuLieuDanhBa.ThueBaoNhieuSDTNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x));
							break;
						case 6:
							Clear();
							WriteLine("\nTìm ngày có nhiều thuê bao đăng ký nhất");
							WriteLine("\nNgày có nhiều thuê bao đăng ký nhất");
							result = new Dictionary<int, int>(xuLyDuLieuDanhBa.MinMaxNgayThueBaoDangKy(danhSachDanhBa.thueBao, XuLyDuLieuDanhBa.MinMax.Max));
							foreach (KeyValuePair<int, int> item in result)
								Write("Ngày {0}, ", item.Key);
							break;
						case 7:
							Clear();
							WriteLine("\nTìm ngày có ít thuê bao đăng ký nhất");
							WriteLine("\nNgày có ít thuê bao đăng ký nhất");
							result = new Dictionary<int, int>(xuLyDuLieuDanhBa.MinMaxNgayThueBaoDangKy(danhSachDanhBa.thueBao, XuLyDuLieuDanhBa.MinMax.Min));
							foreach (KeyValuePair<int, int> item in result)
								Write("Ngày {0}, ", item.Key);
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký");
							WriteLine("\nTháng không có thuê bao nào đăng ký");
							xuLyDuLieuDanhBa.ThangKhongCoThueBaoDangKy(danhSachDanhBa.thueBao).ForEach(x => Write("Tháng {0}, ", x));
							break;
						case 9:
							Clear();
							WriteLine("\nTìm thuê bao theo giới tính");
							WriteLine("\n Thuê bao theo giới tính Nam");
							xuLyDuLieuDanhBa.TimThueBaoTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nam).ForEach(x => WriteLine(x));
							WriteLine("\n Thuê bao theo giới tính Nữ");
							xuLyDuLieuDanhBa.TimThueBaoTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nu).ForEach(x => WriteLine(x));
							break;
						case 10:
							Clear();
							WriteLine("\n\nnTìm thành phố có nhiều thuê bao cố định nhất");
							WriteLine("\nThành phố có nhiều thuê bao cố định nhất");
							xuLyDuLieuDanhBa.ThanhPhoNhieuThueBaoCoDinhNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}, ", x));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm thành phố có ít thuê bao cố định nhất");
							WriteLine("\nTìm thành phố có ít thuê bao cố định nhất");
							xuLyDuLieuDanhBa.ThanhPhoItThueBaoCoDinhNhat(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}, ", x));
							break;
						case 12:
							Clear();
							WriteLine("\nTìm thành phố có nhiều thuê bao di động nhất");
							WriteLine("\nThành phố có nhiều thuê bao di động nhất");
							xuLyDuLieuDanhBa.ThanhPhoNhieuThueBaoDiDong(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}, ", x));
							break;
						case 13:
							Clear();
							WriteLine("\nTìm thành phố có ít thuê bao di động nhất");
							WriteLine("\nThành phố có ít thuê bao di động nhất");
							xuLyDuLieuDanhBa.ThanhPhoItThueBaoDiDong(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}, ", x));
							break;
						case 14:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu nhiều số điện thoại cố định nhất");
							WriteLine("\nThuê bao sở hữu nhiều số điện thoại cố định nhất");
							xuLyDuLieuDanhBa.ThueBaoNhieuSDTCoDinh(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x)); ;
							break;
						case 15:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu ít số điện thoại cố định nhất");
							WriteLine("\nThuê bao sở hữu ít số điện thoại cố định nhất");
							xuLyDuLieuDanhBa.ThueBaoItSDTCoDinh(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x)); ;
							break;
						case 16:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu nhiều số điện thoại di động nhất");
							WriteLine("\nThuê bao sở hữu nhiều số điện thoại di động nhất");
							xuLyDuLieuDanhBa.ThueBaoNhieuSDTDiDong(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x)); ;
							break;
						case 17:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu ít số điện thoại di động nhất");
							WriteLine("\nThuê bao sở hữu ít số điện thoại di động nhất");
							xuLyDuLieuDanhBa.ThueBaoItSDTDiDong(danhSachDanhBa.thueBao).ForEach(x => Write("{0, 5}", x)); ;
							break;
						case 18:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký số cố định");
							xuLyDuLieuDanhBa.ThangKhongCoDangKyCoDinh(danhSachDanhBa.thueBao).ForEach(x => Write("Tháng {0}, ", x));
							break;
						case 19:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký số di động");
							xuLyDuLieuDanhBa.ThangKhongCoDangKyDiDong(danhSachDanhBa.thueBao).ForEach(x => Write("Tháng {0}, ", x));
							break;
						case 20:
							Clear();
							WriteLine("\nTìm thuê bao di động theo giới tính");
							WriteLine("\n Thuê bao cố định theo giới tính Nam");
							xuLyDuLieuDanhBa.ThueBaoCoDinhTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nam).ForEach(x => WriteLine(x));
							WriteLine("\n Thuê bao cố định theo giới tính Nữ");
							xuLyDuLieuDanhBa.ThueBaoCoDinhTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nu).ForEach(x => WriteLine(x));
							break;
						case 21:
							Clear();
							WriteLine("\nTìm thuê bao cố định theo giới tính");
							WriteLine("\n Thuê bao theo giới tính Nam");
							xuLyDuLieuDanhBa.ThueBaoDiDongTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nam).ForEach(x => WriteLine(x));
							WriteLine("\n Thuê bao theo giới tính Nữ");
							xuLyDuLieuDanhBa.ThueBaoDiDongTheoGioiTinh(danhSachDanhBa.thueBao, GioiTinh.Nu).ForEach(x => WriteLine(x));
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
							WriteLine("\nSắp xếp danh sách thuê bao tăng theo họ tên");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp thuê bao tăng theo họ tên");
							xuLyDuLieuDanhBa.TangTheoHoTen(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao giảm theo họ tên");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp thuê bao giảm theo họ tên");
							xuLyDuLieuDanhBa.GiamTheoHoTen(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao tăng theo số lượng điện thoại sở hữu");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp thuê bao tăng theo số lượng điện thoại sở hữu");
							xuLyDuLieuDanhBa.TangTheoSLDT(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao giảm theo số lượng điện thoại sở hữu");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp thuê bao giảm theo số lượng điện thoại sở hữu");
							xuLyDuLieuDanhBa.GiamTheoSLDT(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 6:
							Clear();
							WriteLine("\nSắp xếp danh sách các thành phố tăng theo số lượng thuê bao");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp danh sách các thành phố tăng theo số lượng thuê bao");
							xuLyDuLieuDanhBa.TangThanhPhoTheoSLTB(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 7:
							Clear();
							WriteLine("\nSắp xếp danh sách các thành phố giảm theo số lượng thuê bao");
							danhSachDanhBa.XuatThongTinThueBao();
							WriteLine("\n Danh sách sau khi sắp xếp danh sách các thành phố giảm theo số lượng thuê bao");
							xuLyDuLieuDanhBa.GiamThanhPhoTheoSLTB(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
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
							WriteLine("\nXóa thuê bao theo địa chỉ");
							danhSachDanhBa.XuatThongTinThueBao();
							Write("\n Nhập vào địa chỉ của thuê bao cần xóa >> ");
							x = ReadLine();
							xuLyDuLieuDanhBa.XoaTheoDiaChi(danhSachDanhBa.thueBao, (string)x);
							WriteLine("\n Danh sách sau khi xóa các thuê bao có địa chỉ {0}", x);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 3:
							Clear();
							WriteLine("\nXóa thuê bao theo ngày lắp đặt");
							danhSachDanhBa.XuatThongTinThueBao();
							Write("\n Nhập vào ngày lắp đặt của thuê bao cần xóa >> ");
							x = int.Parse(ReadLine());
							xuLyDuLieuDanhBa.XoaTheoNgayLapDat(danhSachDanhBa.thueBao, (int)x);
							WriteLine("\n Danh sách sau khi xóa các thuê bao có ngày lắp đặt là {0}", x);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 4:
							Clear();
							WriteLine("\nXóa thuê bao theo nhà dịch vụ");
							danhSachDanhBa.XuatThongTinThueBao();
							Write("\n Nhập vào nhà dịch vụ của thuê bao cần xóa >> ");
							x = ReadLine();
							xuLyDuLieuDanhBa.XoaTheoNhaDichVu(danhSachDanhBa.thueBao, (string)x);
							WriteLine("\n Danh sách sau khi xóa các thuê bao có nhà dịch vụ là {0}", x);
							danhSachDanhBa.XuatThongTinThueBao();
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
							WriteLine("\nTất cả khách hàng nào sinh tháng 1 thì được tặng thêm một số điện thoại mới có số là số CMND");
							danhSachDanhBa.XuatThongTinThueBao();
							xuLyDuLieuDanhBa.ThemSDTNeuSinhThang1(danhSachDanhBa.thueBao);
							danhSachDanhBa.XuatThongTinThueBao();
							break;
						case 3:
							Clear();
							WriteLine(@"Thống kê và hiển thị dữ liệu theo từng tỉnh và mỗi tỉnh hiển thị theo thành phố theo mẫu sau
							Tỉnh: Lâm Đồng(tổng số thuê bao: 4)
								Thành Phố: Dalat(tổng số thuê bao: 2)
									1)  001, nguyen van a, 01 PDTV, Dalat, Lam Dong, 123
									2)	002, nguyen van b, 01 PDTV, Dalat, Lam Dong, 123
									Thành phố bảo lộc: (Tổng số thuê bao: 2)
									---Hiển thị danh sách thuê bao ở thành phố bảo lộc ---
									Tỉnh Khánh Hòa(Tổng số….)
										Thành Phố: Nha Trang(tổng số thuê bao:……)
										---Danh sách thuê bao-- - ");
							xuLyDuLieuDanhBa.ThongKeDuLieu(danhSachDanhBa.thueBao);
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
