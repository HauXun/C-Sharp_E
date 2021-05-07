using static System.Console;

namespace QuanLyThietBiV3
{
	class Menu
	{
		DanhSachMayTinh listMayTinh = new DanhSachMayTinh();

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
			MayTinh.Tinh properties;
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
					listMayTinh.DanhSachMayTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Min).Xuat();
					WriteLine("May tinh co dung luong ram lon nhat...");
					listMayTinh.DanhSachMayTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max).Xuat();
					WriteLine("\nHang san xuat RAM co dung luong thap nhat...");
					listMayTinh.DSHangMinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Min).ForEach(x => WriteLine(x));
					WriteLine("Dung luong RAM thap nhat duoc xac dinh >> " + listMayTinh.MinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Min));
					WriteLine("\nHang san xuat RAM co dung luong lon nhat...");
					listMayTinh.DSHangMinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max).ForEach(x => WriteLine(x));
					WriteLine("Dung luong RAM lon nhat duoc xac dinh >> " + listMayTinh.MinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max));
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("May tinh co toc do CPU thap nhat...");
					listMayTinh.DanhSachMayTinhTheoLoai<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Min).Xuat();
					WriteLine("May tinh co toc do CPU lon nhat...");
					listMayTinh.DanhSachMayTinhTheoLoai<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max).Xuat();
					WriteLine("Hang san xuat CPU co toc do thap nhat...");
					listMayTinh.DSHangMinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Min).ForEach(x => WriteLine(x));
					WriteLine("Toc do CPU thap nhat duoc xac dinh >> " + listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Min));
					WriteLine("\nHang san xuat CPU co toc do lon nhat...");
					listMayTinh.DSHangMinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max).ForEach(x => WriteLine(x));
					WriteLine("Toc do CPU lon nhat duoc xac dinh >> " + listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max));
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh co dung luong Gb RAM lon hon x");
					Write("Nhap vao muc dung luong RAM can xet(Gb) >> ");
					obj = float.Parse(ReadLine());
					listMayTinh.DSMTThuocTinhLonHonX<RAM>(MayTinh.Tinh.sCapacity, obj).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM  KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh co toc do Ghz CPU lon hon x");
					Write("Nhap vao muc toc do CPU can xet(Ghz) >> ");
					obj = float.Parse(ReadLine());
					listMayTinh.DSMTThuocTinhLonHonX<CPU>(MayTinh.Tinh.Speed, obj).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh theo dung luong RAM va hang san xuat RAM");
					WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Gb\t  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
					Write("Nhap vao muc dung luong RAM can xet(Gb) >> ");
					obj = float.Parse(ReadLine());
					WriteLine("\n\t\tDANH SACH CAC HANG RAM TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachHangTheoLoai<RAM>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat RAM tuong ung >> ");
					hangSX = ReadLine();
					listMayTinh.DSMTTheoThuocTinh_Hang<RAM>(MayTinh.Tinh.sCapacity, obj, hangSX).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO TIM KIEM KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nTim may tinh theo toc do CPU va hang san xuat CPU");
					WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(MayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
					Write("Nhap vao muc toc do CPU can xet(Ghz) >> ");
					obj = float.Parse(ReadLine());
					WriteLine("\n\t\tDANH SACH CAC HANG CPU TON TAI TRONG DU LIEU");
					listMayTinh.DanhSachHangTheoLoai<CPU>().ForEach(x => { Write($"\t{x.PadRight(15)}  "); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); });
					Write("\nNhap vao hang san xuat CPU tuong ung >> ");
					hangSX = ReadLine();
					listMayTinh.DSMTTheoThuocTinh_Hang<CPU>(MayTinh.Tinh.Speed, obj, hangSX).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN KET THUC CHE DO TIM KIEM >> ");
					break;
				#endregion
				case 4:
					#region Các chức năng sắp xếp ¯\_(ツ)_/¯
					Clear();
					WriteLine("Sap xep danh sach may tinh theo chuc nang tuong ung >> ");
					WriteLine("Sap xep danh sach may tinh tang dan theo dung luong RAM...");
					listMayTinh.SortTheoLoai<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.UpOrDown.Increase).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh giam dan theo dung luong RAM...");
					listMayTinh.SortTheoLoai<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.UpOrDown.Decrease).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh tang dan theo toc do CPU...");
					listMayTinh.SortTheoLoai<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.UpOrDown.Increase).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE CHUYEN QUA CHE DO SAP XEP KHAC >> ");
					ReadLine();
					Clear();
					WriteLine("Sap xep danh sach may tinh giam dan theo toc do CPU...");
					listMayTinh.SortTheoLoai<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.UpOrDown.Decrease).Xuat();
					WriteLine("\n\t\tNHAN PHIM BAT KI DE KET THUC CHE DO SAP XEP >> ");
					break;
				#endregion
				case 5:
					#region Chức năng xóa ༼ つ ◕_◕ ༽つ
					Clear();
					WriteLine("Xoa may tinh theo thuoc tinh: x\n\t(loai thuoc tinh se duoc duoc xac dinh truoc) >> ");
					properties = (MayTinh.Tinh)int.MaxValue;
					while (properties < (MayTinh.Tinh)0 || properties > (MayTinh.Tinh)1)
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
						properties = (MayTinh.Tinh)int.Parse(ReadLine());
					}
					if (properties == 0)
					{
						while (obj < 0 || obj > listMayTinh.MinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\nVD: 4Gb RAM thi nhap 4");
							Write("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren >> ");
							obj = float.Parse(ReadLine());
						}
						listMayTinh.XoaMayTinhTheoThuocTinh<RAM>(MayTinh.Tinh.sCapacity, obj);
						Clear();
						WriteLine("\nDanh sach sau khi xoa");
						listMayTinh.Xuat();
					}
					else
					{
						while (obj < 0 || obj > listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(MayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
							WriteLine("\n\nVD: 3.2Ghz Speed thi nhap 3.2");
							Write("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren >> ");
							obj = float.Parse(ReadLine());
						}
						listMayTinh.XoaMayTinhTheoThuocTinh<CPU>(MayTinh.Tinh.Speed, obj);
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
					properties = (MayTinh.Tinh)int.MaxValue;
					while (properties < (MayTinh.Tinh)0 || properties > (MayTinh.Tinh)1)
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
						properties = (MayTinh.Tinh)int.Parse(ReadLine());
					}
					if (properties == 0)
					{
						Clear();
						WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
						WriteLine("\n\nVD: 4Gb RAM thi nhap 4");
						WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
						Write("\nNhap muc dung luong ram muon thay doi >> ");
						obj = float.Parse(ReadLine());
						Write("\nThay doi thanh muc dung luong? Nhap vao muc dung luong >> ");
						obj2 = float.Parse(ReadLine());
						while ((obj < 0 || obj > listMayTinh.MinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max)) ||
							(obj2 < 0 || obj2 > listMayTinh.MinMaxThuocTinh<RAM>(MayTinh.Tinh.sCapacity, DanhSachMayTinh.MinMax.Max)))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC DUNG LUONG RAM TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<RAM>(MayTinh.Tinh.sCapacity).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
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
						listMayTinh.CapNhapMayTinhTheoThuocTinh<RAM>(MayTinh.Tinh.sCapacity, obj, obj2);
						Clear();
						WriteLine("\nDanh sach sau khi cap nhap");
						listMayTinh.Xuat();
					}
					else
					{
						Clear();
						WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
						listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(MayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
						WriteLine("\n\nVD: 3.2Ghz Speed thi nhap 3.2");
						WriteLine("\n\tMoi nhap du lieu tuong ung voi kieu thuoc tinh da chon o tren");
						Write("\nNhap muc toc do CPU muon thay doi >> ");
						obj = float.Parse(ReadLine());
						Write("\nThay doi thanh muc toc do? Nhap vao muc toc do CPU >> ");
						obj2 = float.Parse(ReadLine());
						while ((obj < 0 || obj > listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max)) ||
							(obj2 < 0 || obj2 > listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max)))
						{
							Clear();
							WriteLine("\n\t\tDANH SACH MUC TOC DO CPU TON TAI TRONG DU LIEU");
							listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(MayTinh.Tinh.Speed).ForEach(x => { Write($"\t{x} Ghz\t"); i++; if ((i + 1) % 4 == 0) WriteLine("\t"); }); ;
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
						listMayTinh.CapNhapMayTinhTheoThuocTinh<CPU>(MayTinh.Tinh.Speed, obj, obj2);
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
					listMayTinh.GhiFile();
					WriteLine("\nGhi file hoan tat! Kiem tra lai trong duong dan chua Solution...");
					break;
				#endregion
				case 8:
					Clear();
					WriteLine("Test code >> ");
					//listMayTinh.DanhSachThuocTinhTheoLoai<CPU>(MayTinh.Tinh.Speed).ForEach(x => { WriteLine(x); });
					WriteLine(listMayTinh.MinMaxThuocTinh<CPU>(MayTinh.Tinh.Speed, DanhSachMayTinh.MinMax.Max));
					break;
			}
			ReadLine();
		}
	}
}