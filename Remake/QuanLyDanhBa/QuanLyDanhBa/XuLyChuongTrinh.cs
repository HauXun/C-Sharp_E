using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuanLyDanhBa
{
	class XuLyChuongTrinh
	{
		XuLyDuLieuDanhBa xuLyDuLieuDanhBa = new XuLyDuLieuDanhBa();
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
							xuLyDuLieuDanhBa.MinMaxNgayThueBaoDangKy(danhSachDanhBa.thueBao, XuLyDuLieuDanhBa.MinMax.Max).ForEach(x => Write("{0, 5}", x));
							break;
						case 7:
							Clear();
							WriteLine("\nTìm ngày có ít thuê bao đăng ký nhất");
							WriteLine("\nNgày có ít thuê bao đăng ký nhất");
							xuLyDuLieuDanhBa.MinMaxNgayThueBaoDangKy(danhSachDanhBa.thueBao, XuLyDuLieuDanhBa.MinMax.Min).ForEach(x => Write("{0, 5}", x));
							break;
						case 8:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký");
							break;
						case 9:
							Clear();
							WriteLine("\nTìm thuê bao theo giới tính");
							break;
						case 10:
							Clear();
							WriteLine("\nTìm thành phố có nhiều thuê bao cố định nhất");
							break;
						case 11:
							Clear();
							WriteLine("\n\nTìm thành phố có ít thuê bao cố định nhất");
							break;
						case 12:
							Clear();
							WriteLine("\nTìm thành phố có nhiều thuê bao di động nhất");
							break;
						case 13:
							Clear();
							WriteLine("\nTìm thành phố có ít thuê bao di động nhất");
							break;
						case 14:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu nhiều số điện thoại cố định nhất");
							break;
						case 15:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu ít số điện thoại cố định nhất");
							break;
						case 16:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu nhiều số điện thoại di động nhất");
							break;
						case 17:
							Clear();
							WriteLine("\nTìm thuê bao sở hữu ít số điện thoại di động nhất");
							break;
						case 18:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký số cố định");
							break;
						case 19:
							Clear();
							WriteLine("\nTìm tháng không có thuê bao nào đăng ký số di động");
							break;
						case 20:
							Clear();
							WriteLine("\nTìm thuê bao di động theo giới tính");
							break;
						case 21:
							Clear();
							WriteLine("\nTìm thuê bao cố định theo giới tính");
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
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao giảm theo họ tên");
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao tăng theo số lượng điện thoại sở hữu");
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp danh sách thuê bao giảm theo số lượng điện thoại sở hữu");
							break;
						case 6:
							Clear();
							WriteLine("\nSắp xếp danh sách các thành phố tăng theo số lượng thuê bao");
							break;
						case 7:
							Clear();
							WriteLine("\nSắp xếp danh sách các thành phố giảm theo số lượng thuê bao");
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
							break;
						case 3:
							Clear();
							WriteLine("\nXóa thuê bao theo ngày lắp đặt");
							break;
						case 4:
							Clear();
							WriteLine("\nXóa thuê bao theo nhà dịch vụ");
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
							break;
						case 3:
							Clear();
							WriteLine("\nThống kê và hiển thị dữ liệu theo từng tỉnh và mỗi tỉnh hiển thị theo thành phố theo mẫu sau");
							break;
						case 4:
							Clear();
							WriteLine(@"Tỉnh: Lâm Đồng (tổng số thuê bao: 4)
											Thành Phố: Dalat (tổng số thuê bao: 2)
										1)	001, nguyen van a, 01 PDTV, Dalat, Lam Dong, 123
										2)	002, nguyen van b, 01 PDTV, Dalat, Lam Dong, 123
										Thành phố bảo lộc: (Tổng số thuê bao: 2)
										--- Hiển thị danh sách thuê bao ở thành phố bảo lộc ---
										Tỉnh Khánh Hòa (Tổng số….)
											Thành Phố: Nha Trang (tổng số thuê bao:……)
											--- Danh sách thuê bao ---");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
