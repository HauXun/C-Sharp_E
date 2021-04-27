using static System.Console;

namespace QuanLyThietBiV2
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
			"Xoa may tinh theo thuoc tinh:\n\t(thuoc tinh duoc xac dinh tu du lieu nhap tu ban phim)",
			"Cap nhap theo thuoc tinh x:\n\t(thuoc tinh duoc xac dinh tu du lieu nhap tu ban phim) va cap nhap sang thuoc tinh y",
			"Luu du lieu hien tai vao tep moi theo dung cau truc cua du lieu hien tai",
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
			float obj = -1, obj2 = -1;
			string hangSX;
			QuanLyMayTinh.Tinh properties;
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
					WriteLine("May tinh co dung luong ram thap nhat...");
					listMayTinhQL.DanhSachMayTinhTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Min).Xuat();
					WriteLine("May tinh co dung luong ram lon nhat...");
					listMayTinhQL.DanhSachMayTinhTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max).Xuat();
					WriteLine("\nHang san xuat RAM co dung luong thap nhat...");
					listMayTinhQL.DSHangMinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Min).ForEach(x => WriteLine(x));
					WriteLine("Dung luong RAM thap nhat duoc xac dinh >> " + listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Min));
					WriteLine("\nHang san xuat RAM co dung luong lon nhat...");
					listMayTinhQL.DSHangMinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max).ForEach(x => WriteLine(x));
					WriteLine("Dung luong RAM lon nhat duoc xac dinh >> " + listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max));
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("May tinh co toc do CPU thap nhat...");
					listMayTinhQL.DanhSachMayTinhTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Min).Xuat();
					WriteLine("May tinh co toc do CPU lon nhat...");
					listMayTinhQL.DanhSachMayTinhTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max).Xuat();
					WriteLine("Hang san xuat CPU co toc do thap nhat...");
					listMayTinhQL.DSHangMinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Min).ForEach(x => WriteLine(x));
					WriteLine("Toc do CPU thap nhat duoc xac dinh >> " + listMayTinhQL.MinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Min));
					WriteLine("\nHang san xuat CPU co toc do lon nhat...");
					listMayTinhQL.DSHangMinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max).ForEach(x => WriteLine(x));
					WriteLine("Toc do CPU lon nhat duoc xac dinh >> " + listMayTinhQL.MinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max));
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh co dung luong Gb RAM lon hon x");
					Write("Nhap vao muc dung luong RAM can xet(Gb) >> ");
					obj = float.Parse(ReadLine());
					listMayTinhQL.DSMTThuocTinhLonHonX<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, obj).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM  KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh co toc do Ghz CPU lon hon x");
					Write("Nhap vao muc toc do CPU can xet(Ghz) >> ");
					obj = float.Parse(ReadLine());
					listMayTinhQL.DSMTThuocTinhLonHonX<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, obj).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh theo dung luong RAM va hang san xuat RAM");
					WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(QuanLyMayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Gb\t  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
					Write("Nhap vao muc dung luong RAM can xet(Gb) >> ");
					obj = float.Parse(ReadLine());
					WriteLine("\n\t\tDANH SACH CAC HANG RAM TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachHangTheoLoai<RAM>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat RAM tuong ung >> ");
					hangSX = ReadLine();
					listMayTinhQL.DSMTTheoThuocTinh_Hang<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, obj, hangSX).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh theo toc do CPU va hang san xuat CPU");
					WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(QuanLyMayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
					Write("Nhap vao muc toc do CPU can xet(Ghz) >> ");
					obj = float.Parse(ReadLine());
					WriteLine("\n\t\tDANH SACH CAC HANG CPU TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat CPU tuong ung >> ");
					hangSX = ReadLine();
					listMayTinhQL.DSMTTheoThuocTinh_Hang<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, obj, hangSX).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN KET THUC CHE DO TIM KIEM >> ");
					break;
				#endregion
				case 4:
					#region Các chức năng sắp xếp ¯\_(ツ)_/¯
					Clear();
					WriteLine("Sap xep danh sach may tinh theo chuc nang tuong ung >> ");
					WriteLine("Sap xep danh sach may tinh tang dan theo dung luong RAM...");
					listMayTinhQL.SortTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.UpOrDown.Increase).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh giam dan theo dung luong RAM...");
					listMayTinhQL.SortTheoLoai<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.UpOrDown.Decrease).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh tang dan theo toc do CPU...");
					listMayTinhQL.SortTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.UpOrDown.Increase).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh giam dan theo toc do CPU...");
					listMayTinhQL.SortTheoLoai<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.UpOrDown.Decrease).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE KET THUC CHE DO SAP XEP >> ");
					break;
				#endregion
				case 5:
					#region Chức năng xóa ༼ つ ◕_◕ ༽つ
					Clear();
					WriteLine("Xoa may tinh theo thuoc tinh: x\n\t(loai thuoc tinh se duoc duoc xac dinh truoc) >> ");
					properties = (QuanLyMayTinh.Tinh)int.MaxValue;
					while (properties < (QuanLyMayTinh.Tinh)0 || properties > (QuanLyMayTinh.Tinh)1)
					{
						Clear();
						WriteLine("\n\t\tDANH SACH CAC HANG RAM TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachHangTheoLoai<RAM>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
						WriteLine("\n\t\tDANH SACH CAC HANG CPU TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
						WriteLine("\n\n\tBAN MUON XOA THEO KIEU THUOC TINH NAO (RAM - CPU) ?");
						WriteLine("\nBan phai nhap trong pham vi quy dinh!");
						WriteLine("\nVD: RAM nhap 0\tCPU nhap 1");
						Write("\nXin moi nhap kieu thuoc tinh de xoa (RAM = 0 or CPU = 1)? >> ");
						properties = (QuanLyMayTinh.Tinh)int.Parse(ReadLine());
					}
					if (properties == 0)
					{
						while (obj < 0 || obj > listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(QuanLyMayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\nVD: 4Gb RAM thi nhap 4");
							Write("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren >> ");
							obj = float.Parse(ReadLine());
						}
						listMayTinhQL.XoaMayTinhTheoThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, obj);
						Clear();
						WriteLine("\nDanh sach sau khi xoa");
						listMayTinh.Xuat();
					}
					else
					{
						while (obj < 0 || obj > listMayTinhQL.MinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(QuanLyMayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\nVD: 3.2Ghz Speed thi nhap 3.2");
							Write("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren >> ");
							obj = float.Parse(ReadLine());
						}
						listMayTinhQL.XoaMayTinhTheoThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, obj);
						Clear();
						WriteLine("\nDanh sach sau khi xoa");
						listMayTinh.Xuat();
					}
					break;
				#endregion
				case 6:
					#region Chức năng cập nhập 👮👮👮
					Clear();
					WriteLine("Cap nhap theo thuoc tinh x:\n\t(thuoc tinh duoc xac dinh tu du lieu nhap tu ban phim) va cap nhap sang thuoc tinh y >> ");
					properties = (QuanLyMayTinh.Tinh)int.MaxValue;
					while (properties < (QuanLyMayTinh.Tinh)0 || properties > (QuanLyMayTinh.Tinh)1)
					{
						Clear();
						WriteLine("\n\t\tDANH SACH CAC HANG RAM TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachHangTheoLoai<RAM>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
						WriteLine("\n\t\tDANH SACH CAC HANG CPU TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
						WriteLine("\n\n\tBAN MUON CAP NHAP THEO KIEU THUOC TINH NAO (RAM - CPU) ?");
						WriteLine("\nBan phai nhap trong pham vi quy dinh!");
						WriteLine("\nVD: RAM nhap 0\tCPU nhap 1");
						Write("\nXin moi nhap kieu thuoc tinh de cap nhap (RAM = 0 or CPU = 1)? >> ");
						properties = (QuanLyMayTinh.Tinh)int.Parse(ReadLine());
					}
					if (properties == 0)
					{
						Clear();
						WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(QuanLyMayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
						WriteLine("\n\nVD: 4Gb RAM thi nhap 4");
						WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
						Write("\nNhap muc dung luong ram muon thay doi >> ");
						obj = float.Parse(ReadLine());
						Write("\nThay doi thanh muc dung luong? Nhap vao muc dung luong >> ");
						obj2 = float.Parse(ReadLine());
						while ((obj < 0 || obj > listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max)) ||
							(obj2 < 0 || obj2 > listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max)))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(QuanLyMayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\n\nBan da nhap sai 1 trong 2 du lieu! Vui long kiem tra lai va nhap dung 2 truong du lieu!!!");
							WriteLine("\n\nVD: 4Gb RAM thi nhap 4");
							WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
							Write("\nNhap muc dung luong ram muon thay doi >> ");
							obj = float.Parse(ReadLine());
							Write("\nThay doi thanh muc dung luong? Nhap vao muc dung luong RAM >> ");
							obj2 = float.Parse(ReadLine());
						}
						Clear();
						WriteLine("\n\t\tDANH SACH TRUOC KHI CAP NHAP");
						listMayTinh.Xuat();
						WriteLine("\n\t\tDANH SACH TRUOC KHI CAP NHAP");
						Write("\nNhan phim bat ki de bat dau cap nhap >> ");
						ReadLine();
						listMayTinhQL.CapNhapMayTinhTheoThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, obj2);
						Clear();
						WriteLine("\nDanh sach sau khi cap nhap");
						listMayTinh.Xuat();
					}
					else
					{
						Clear();
						WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(QuanLyMayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
						WriteLine("\n\nVD: 3.2Ghz Speed thi nhap 3.2");
						WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
						Write("\nNhap muc toc do CPU muon thay doi >> ");
						obj = float.Parse(ReadLine());
						Write("\nThay doi thanh muc toc do? Nhap vao muc toc do CPU >> ");
						obj2 = float.Parse(ReadLine());
						while ((obj < 0 || obj > listMayTinhQL.MinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max)) ||
							(obj2 < 0 || obj2 > listMayTinhQL.MinMaxThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, QuanLyMayTinh.MinMax.Max)))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(QuanLyMayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\n\nBan da nhap sai 1 trong 2 du lieu! Vui long kiem tra lai va nhap dung 2 truong du lieu!!!");
							WriteLine("\n\nVD: 3.2Ghz Speed thi nhap 3.2");
							WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
							Write("\nNhap muc toc do CPU muon thay doi >> ");
							obj = float.Parse(ReadLine());
							Write("\nThay doi thanh muc toc do? Nhap vao muc toc do CPU >> ");
							obj2 = float.Parse(ReadLine());
						}
						Clear();
						WriteLine("\n\t\tDANH SACH TRUOC KHI CAP NHAP");
						listMayTinh.Xuat();
						WriteLine("\n\t\tDANH SACH TRUOC KHI CAP NHAP");
						Write("\nNhan phim bat ki de bat dau cap nhap >> ");
						ReadLine();
						listMayTinhQL.CapNhapMayTinhTheoThuocTinh<CPU>(listMayTinh, QuanLyMayTinh.Tinh.Speed, obj2);
						Clear();
						WriteLine("\nDanh sach sau khi cap nhap");
						listMayTinh.Xuat();
					}
					break;
				#endregion
				case 7:
					#region Chức năng ghi file 💩💩💩
					Clear();
					WriteLine("Luu du lieu hien tai vao tep moi theo dung cau truc cua du lieu hien tai");
					Write("\nNhan phim bat ki de bat dau ghi file >> ");
					ReadLine();
					listMayTinhQL.GhiFile(listMayTinh);
					WriteLine("\nGhi file hoan tat! Kiem tra lai trong duong dan chua Solution...");
					break;
				#endregion
				case 8:
					Clear();
					WriteLine("Test code >> ");
					WriteLine(listMayTinhQL.MinMaxThuocTinh<RAM>(listMayTinh, QuanLyMayTinh.Tinh.sCapacity, QuanLyMayTinh.MinMax.Max));
					break;
			}
			ReadLine();
		}
	}
}