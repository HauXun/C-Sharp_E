using System;
using static System.Console;

namespace QuanLyThietBi
{
	class XuLyChuongTrinh
	{
		XuLyDuLieuMayTinh xuLyDuLieuMayTinh = new XuLyDuLieuMayTinh();
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, DanhSachMayTinh danhSachMayTinh)
		{
			Object x;
			Object y;
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
							WriteLine("\nTìm máy tính có dung lượng ram thấp nhất");
							WriteLine("\nMáy tính có dung lượng ram thấp nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachMayTinhMinMaxTheoThuocTinh<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Min).ConvertAll(x => (object)x));
							break;
						case 3:
							Clear();
							WriteLine("\nTìm máy tính có dung lượng ram lớn nhất");
							WriteLine("\nMáy tính có dung lượng ram lớn nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachMayTinhMinMaxTheoThuocTinh<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Max).ConvertAll(x => (object)x));
							break;
						case 4:
							Clear();
							WriteLine("\nTìm hãng sản xuất RAM có dung lượng thấp nhất");
							WriteLine("\nHãng sản xuất RAM có dung lượng thấp nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachHangMinMaxThuocTinh<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Min).ConvertAll(x => (object)x));
							break;
						case 5:
							Clear();
							WriteLine("\nTìm hãng sản xuất RAM có dung lượng lớn nhất");
							WriteLine("\nHãng sản xuất RAM có dung lượng lớn nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachHangMinMaxThuocTinh<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Max).ConvertAll(x => (object)x));
							break;
						case 6:
							Clear();
							WriteLine("\nTìm máy tính có tốc độc CPU thấp nhất");
							WriteLine("\nMáy tính có tốc độc CPU thấp nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachMayTinhMinMaxTheoThuocTinh<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Min).ConvertAll(x => (object)x));
							break;
						case 7:
							Clear();
							WriteLine("\nTìm máy tính có tốc độc CPU lớn nhất");
							WriteLine("\nMáy tính có tốc độc CPU lớn nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachMayTinhMinMaxTheoThuocTinh<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Max).ConvertAll(x => (object)x));
							break;
						case 8:
							Clear();
							WriteLine("\nTìm hãng sản xuất CPU có tốc độ thấp nhất");
							WriteLine("\nHãng sản xuất CPU có tốc độ thấp nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachHangMinMaxThuocTinh<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Min).ConvertAll(x => (object)x));
							break;
						case 9:
							Clear();
							WriteLine("\nTìm hãng sản xuất CPU có tốc độ lớn nhất");
							WriteLine("\nHãng sản xuất CPU có tốc độ lớn nhất");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DanhSachHangMinMaxThuocTinh<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Max).ConvertAll(x => (object)x));
							break;
						case 10:
							Clear();
							WriteLine("\nTìm máy tính có dung lượng RAM(Gb) lớn hơn mức dung lượng nhập");
							Write("\n Nhập vào mức dung lượng RAM(Gb) cần xét >> ");
							x = float.Parse(ReadLine());
							WriteLine("\nMáy tính có dung lượng RAM(Gb) lớn hơn mức dung lượng nhập");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DSMTThuocTinhLonHonX<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, (float)x).ConvertAll(x => (object)x));
							break;
						case 11:
							Clear();
							WriteLine("\nTìm máy tính có tốc độ CPU(Ghz) lớn hơn mức dung lượng nhập");
							Write("\n Nhập vào mức tốc độ CPU(Ghz) cần xét >> ");
							x = float.Parse(ReadLine());
							WriteLine("\nMáy tính có tốc độ CPU(Ghz) lớn hơn mức dung lượng nhập");
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DSMTThuocTinhLonHonX<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, (float)x).ConvertAll(x => (object)x));
							break;
						case 12:
							Clear();
							WriteLine("\nTìm máy tính theo dung lượng RAM và hảng sản xuất");
							WriteLine("\n\t\tDANH SÁCH MỨC DUNG LƯỢNG RAM TỒN TẠI TRONG DỮ LIỆU");
							xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity).ConvertAll(x => (object)x));
							Write("\n Nhập vào mức dung lượng RAM(Gb) cần xét >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n\t\tDANH SÁCH CÁC HÃNG RAM TỒN TẠI TRONG DỮ LIỆU");
							xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachHangTheoThietBi<RAM>
								(danhSachMayTinh).ConvertAll(x => (object)x));
							Write("\n Nhập vào hãng sản xuất RAM tương ứng cần xét >> ");
							y = ReadLine();
							WriteLine("\nMáy tính theo dung lượng {0}Gb và hãng sản xuất {1}", x, y);
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DSMTTheoThuocTinh_Hang<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, (float)x, (string)y).ConvertAll(x => (object)x));
							break;
						case 13:
							Clear();
							WriteLine("\nTìm máy tính theo tốc độ CPU và hảng sản xuất");
							WriteLine("\n\t\tDANH SÁCH MỨC TỐC ĐỘ CPU TỒN TẠI TRONG DỮ LIỆU");
							xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed).ConvertAll(x => (object)x));
							Write("\n Nhập vào mức tốc độ CPU(Ghz) cần xét >> ");
							x = float.Parse(ReadLine());
							WriteLine("\n\t\tDANH SÁCH CÁC HÃNG CPU TỒN TẠI TRONG DỮ LIỆU");
							xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachHangTheoThietBi<CPU>
								(danhSachMayTinh).ConvertAll(x => (object)x));
							Write("\n Nhập vào hãng sản xuất CPU tương ứng cần xét >> ");
							y = ReadLine();
							WriteLine("\nMáy tính theo tốc độ {0}Ghz và hãng sản xuất {1}", x, y);
							xuLyDuLieuMayTinh.Xuat(xuLyDuLieuMayTinh.DSMTTheoThuocTinh_Hang<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, (float)x, (string)y).ConvertAll(x => (object)x));
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
							WriteLine("\nSắp xếp danh sách máy tính tăng dần theo dung lượng RAM(Gb)");
							WriteLine("\nDanh sách máy tính sau khi tăng dần theo dung lượng RAM(Gb)");
							xuLyDuLieuMayTinh.SapXepTheoKieuGoi<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.UpDown.Up);
							danhSachMayTinh.Xuat();
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính giảm dần theo dung lượng RAM(Gb)");
							WriteLine("\nDanh sách máy tính sau khi giảm dần theo dung lượng RAM(Gb)");
							xuLyDuLieuMayTinh.SapXepTheoKieuGoi<RAM>
								(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.UpDown.Down);
							danhSachMayTinh.Xuat();
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính tăng dần theo tốc độ CPU(Ghz)");
							WriteLine("\nDanh sách máy tính sau khi tăng dần theo tốc độ CPU(Ghz)");
							xuLyDuLieuMayTinh.SapXepTheoKieuGoi<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.UpDown.Up);
							danhSachMayTinh.Xuat();
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính giảm dần theo tốc độ CPU(Ghz)");
							WriteLine("\nDanh sách máy tính sau khi giảm dần theo tốc độ CPU(Ghz)");
							xuLyDuLieuMayTinh.SapXepTheoKieuGoi<CPU>
								(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.UpDown.Down);
							danhSachMayTinh.Xuat();
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
							WriteLine("\nXóa máy tính theo thuộc tính");
							x = (MayTinh.Tinh)int.MaxValue;
							while ((MayTinh.Tinh)x < MayTinh.Tinh.Speed || (MayTinh.Tinh)x < MayTinh.Tinh.sCapacity)
							{
								Clear();
								WriteLine("\n\t\tDANH SÁCH CÁC HÃNG RAM TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachHangTheoThietBi<RAM>
									(danhSachMayTinh).ConvertAll(x => (object)x));
								WriteLine("\n\t\tDANH SÁCH MỨC TỐC ĐỘ CPU TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<CPU>
									(danhSachMayTinh, MayTinh.Tinh.Speed).ConvertAll(x => (object)x));
								WriteLine("\n\n\tBẠN MUỐN XÓA THEO KIỂU THUỘC TÍNH NÀO (RAM - CPU) ?");
								WriteLine("\nBạn phải nhập trong phạm vi quy định!");
								WriteLine("\nVD: RAM nhập 0\tCPU nhập 1");
								Write("\nXin mời nhập kiểu thuộc tính để xóa (RAM = 0 or CPU = 1)? >> ");
								x = (MayTinh.Tinh)int.Parse(ReadLine());
							}
							if ((MayTinh.Tinh)x == MayTinh.Tinh.sCapacity)
							{
								while ((int)x < 0 || (int)x > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Max))
								{
									Clear();
									WriteLine("\n\t\tDANH SÁCH MỨC DUNG LƯỢNG RAM TỒN TẠI TRONG DỮ LIỆU");
									xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<RAM>
										(danhSachMayTinh, MayTinh.Tinh.sCapacity).ConvertAll(x => (object)x));
									WriteLine("\n\nVD: 4Gb RAM thì nhập 4");
									Write("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên >> ");
									x = float.Parse(ReadLine());
								}
								xuLyDuLieuMayTinh.XoaMayTinhTheoThuocTinh<RAM>(danhSachMayTinh, MayTinh.Tinh.sCapacity, (float)x);
								Clear();
								WriteLine("\nDanh sách sau khi xóa");
								danhSachMayTinh.Xuat();
							}
							else
							{
								while ((int)x < 0 || (int)x > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Max))
								{
									Clear();
									WriteLine("\n\t\tDANH SÁCH MỨC TỐC ĐỘ CPU TỒN TẠI TRONG DỮ LIỆU");
									xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<CPU>
										(danhSachMayTinh, MayTinh.Tinh.Speed).ConvertAll(x => (object)x)); ;
									WriteLine("\n\nVD: 3.2Ghz Speed thì nhập 3.2");
									Write("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên >> ");
									x = float.Parse(ReadLine());
								}
								xuLyDuLieuMayTinh.XoaMayTinhTheoThuocTinh<CPU>(danhSachMayTinh, MayTinh.Tinh.Speed, (float)x);
								Clear();
								WriteLine("\nDanh sách sau khi xóa");
								danhSachMayTinh.Xuat();
							}
							break;
						case 3:
							Clear();
							WriteLine("Cập nhập máy tính theo thuộc tính");
							x = (MayTinh.Tinh)int.MaxValue;
							while ((MayTinh.Tinh)x < MayTinh.Tinh.Speed || (MayTinh.Tinh)x > MayTinh.Tinh.sCapacity)
							{
								Clear();
								WriteLine("\n\t\tDANH SÁCH CÁC HÃNG RAM TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachHangTheoThietBi<RAM>
									(danhSachMayTinh).ConvertAll(x => (object)x));
								WriteLine("\n\t\tDANH SÁCH CÁC HÃNG CPU TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachHangTheoThietBi<CPU>
									(danhSachMayTinh).ConvertAll(x => (object)x));
								WriteLine("\n\n\tBẠN MUỐN NHẬP THEO KIỂU THUỘC TÍNH NÀO (RAM - CPU) ?");
								WriteLine("\nBạn phải nhập trong phạm vi quy định!");
								WriteLine("\nVD: RAM nhập 0\tCPU nhập 1");
								Write("\nXin mời nhập kiểu thuộc tính để nhập (RAM = 0 or CPU = 1)? >> ");
								x = (MayTinh.Tinh)int.Parse(ReadLine());
							}
							if ((MayTinh.Tinh)x == MayTinh.Tinh.sCapacity)
							{
								Clear();
								WriteLine("\n\t\tDANH SÁCH MỨC DUNG LƯỢNG RAM TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.sCapacity).ConvertAll(x => (object)x));
								WriteLine("\n\nVD: 4Gb RAM thì nhập 4");
								WriteLine("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên");
								Write("\nNhập mức dung lượng RAM muốn thay đổi >> ");
								x = float.Parse(ReadLine());
								Write("\nThay đổi thành mức dung lượng? Nhập vào mức dung lượng >> ");
								y = float.Parse(ReadLine());
								while ((int)x < 0 || (int)x > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Max) ||
									(int)y < 0 || (int)y > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.sCapacity, XuLyDuLieuMayTinh.MinMax.Max))
								{
									Clear();
									WriteLine("\n\t\tDANH SÁCH MỨC DUNG LƯỢNG RAM TỒN TẠI TRONG DỮ LIỆU");
									xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<RAM>
										(danhSachMayTinh, MayTinh.Tinh.sCapacity).ConvertAll(x => (object)x));
									WriteLine("\n\n\nBạn đã nhập sai 1 trong 2 dữ liệu! Vui lòng kiểm tra lại và nhập đúng 2 trường dữ liệu này!!!");
									WriteLine("\n\nVD: 4Gb RAM thì nhập 4");
									WriteLine("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên");
									Write("\nNhập mức dung lượng RAM muốn thay đổi >> ");
									x = float.Parse(ReadLine());
									Write("\nThay đổi thành mức dung lượng? Nhập vào mức dung lượng >> ");
									y = float.Parse(ReadLine());
								}
								Clear();
								WriteLine("\n\t\tDANH SÁCH TRƯỚC KHI CẬP NHẬP");
								danhSachMayTinh.Xuat();
								WriteLine("\n\t\tDANH SÁCH TRƯỚC KHI CẬP NHẬP");
								Write("\nNhấn phím bất kì để bắt đầu cập nhập >> ");
								ReadLine();
								xuLyDuLieuMayTinh.CapNhapMayTinhTheoThuocTinh<RAM>(danhSachMayTinh, MayTinh.Tinh.sCapacity, (float)x, (float)y);
								Clear();
								WriteLine("\nDanh sách sau khi cập nhập");
								danhSachMayTinh.Xuat();
							}
							else
							{
								Clear();
								WriteLine("\n\t\tDANH SÁCH MỨC TỐC ĐỘ CPU TỒN TẠI TRONG DỮ LIỆU");
								xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<CPU>
									(danhSachMayTinh, MayTinh.Tinh.Speed).ConvertAll(x => (object)x));
								WriteLine("\n\nVD: 3.2Ghz Speed thì nhập 3.2");
								WriteLine("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên");
								Write("\nNhập mức tốc độ CPU muốn thay đổi >> ");
								x = float.Parse(ReadLine());
								Write("\nThay đổi thành mức tốc độ? Nhập vào mức tốc độ CPU >> ");
								y = float.Parse(ReadLine());
								while ((int)x < 0 || (int)x > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Max) ||
									(int)y < 0 || (int)y > xuLyDuLieuMayTinh.MinMaxThuocTinhThietBi<RAM>
									(danhSachMayTinh, MayTinh.Tinh.Speed, XuLyDuLieuMayTinh.MinMax.Max))
								{
									Clear();
									WriteLine("\n\t\tDANH SÁCH MỨC TỐC ĐỘ CPU TỒN TẠI TRONG DỮ LIỆU");
									xuLyDuLieuMayTinh.XuatDuLieuDuocCanLe(xuLyDuLieuMayTinh.DanhSachThuocTinhTheoThietBi<CPU>
										(danhSachMayTinh, MayTinh.Tinh.Speed).ConvertAll(x => (object)x));
									WriteLine("\n\n\nBạn đã nhập sai 1 trong 2 dữ liệu! Vui lòng kiểm tra lại và nhập đúng 2 trường dữ liệu này!!!");
									WriteLine("\n\nVD: 3.2Ghz Speed thì nhập 3.2");
									WriteLine("\n\tMời nhập dữ liệu tương ứng với kiểu thuộc tính đã chọn ở trên");
									Write("\nNhập mức tốc độ CPU muốn thay đổi >> ");
									x = float.Parse(ReadLine());
									Write("\nThay đổi thành mức tốc độ? Nhập vào mức tốc độ >> ");
									y = float.Parse(ReadLine());
								}
								Clear();
								WriteLine("\n\t\tDANH SÁCH TRƯỚC KHI CẬP NHẬP");
								danhSachMayTinh.Xuat();
								WriteLine("\n\t\tDANH SÁCH TRƯỚC KHI CẬP NHẬP");
								Write("\nNhấn phím bất kì để bắt đầu cập nhập >> ");
								ReadLine();
								xuLyDuLieuMayTinh.CapNhapMayTinhTheoThuocTinh<CPU>(danhSachMayTinh, MayTinh.Tinh.Speed, (float)x, (float)y);
								Clear();
								WriteLine("\nDanh sách sau khi cập nhập");
								danhSachMayTinh.Xuat();
							}
							break;
						case 4:
							Clear();
							WriteLine("Lưu dữ liệu hiện tại vào tệp mới với đúng cấu trúc của dữ liệu hiện tại");
							Write("\n Nhấn phím bất kì để bắt đầu ghi file >> ");
							ReadLine();
							xuLyDuLieuMayTinh.GhiFile(danhSachMayTinh);
							WriteLine("\nGhi file hoàn tất! Kiểm tra lại trong đường dẫn chứa Solution...");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
