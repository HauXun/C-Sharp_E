using static System.Console;

namespace GeometryManagement
{
	class Menu
	{
		DanhSachHinhHoc listHinhHoc = new DanhSachHinhHoc();
		DanhSachHinhHoc result = new DanhSachHinhHoc();
		int x;

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc tu tap tin",
			"Nhap du lieu hinh hoc",
			"Xuat danh sach",
			"Tim hinh vuong co dien tich bang x",
			"Sort tang theo tung chuc nang tuong ung",
		};

		public void XuatMenu()
		{
			WriteLine("".PadRight(20, '=') + "MENU SELECTION" + "".PadRight(20, '='));
			for (int i = 0; i < options.Length; i++)
			{
				WriteLine("{0}. {1}", i, options[i]);
			}
			WriteLine("".PadRight(55, '='));
		}

		public int ChonMenu(int soMenu)
		{
			int stt = -1;
			while (stt < 0 || stt > soMenu)
			{
				Clear();
				XuatMenu();
				Write("\nNhap tuy chon menu tuong ung: ");
				stt = int.Parse(ReadLine());
			}
			return stt;
		}

		public void XuLyMenu(int menu)
		{
			switch (menu)
			{
				case 0:
					WriteLine("Thoat chuong trinh...");
					break;
				case 1:
					Clear();
					Write("Nhap ten tap tin de mo >> ");
					listHinhHoc.ImportFromFile();
					listHinhHoc.Xuat();
					break;
				case 2:
					Clear();
					WriteLine("Nhap du lieu cho cac loai hinh hoc...");
					listHinhHoc.Nhap();
					listHinhHoc.Xuat();
					break;
				case 3:
					Clear();
					WriteLine("Xuat >> ");
					listHinhHoc.Xuat();
					break;
				case 4:
					Clear();
					WriteLine("Tim hinh vuong co dien tich bang x >> ");
					Write("Nhap vao dien tich x >> ");
					x = int.Parse(ReadLine());
					WriteLine("Hinh vuong co dien tich = {0} la...", x);
					listHinhHoc.TimHinhVuongDTBangX(x).Xuat();
					break;
				case 5:
					Clear();
					WriteLine("Tim hinh vuong co chu vi bang x >> ");
					Write("Nhap vao chu vi x >> ");
					x = int.Parse(ReadLine());
					WriteLine("Hinh vuong co dien tich = {0} la...", x);
					listHinhHoc.TimHinhVuongCVBangX(x).Xuat();
					break;
				case 6:
					Clear();
					WriteLine("Tim hinh vuong co dien tich nho nhat >> ");
					listHinhHoc.TimHinhVuongMinDT().Xuat();
					break;
				case 7:
					Clear();
					WriteLine("Tim hinh vuong co chu vi nho nhat >> ");
					listHinhHoc.TimHinhVuongMinCV().Xuat();
					break;
				case 8:
					Clear();
					WriteLine("Tim hinh vuong co canh nho nhat >> ");
					listHinhHoc.TimHinhVuongMinCanh().Xuat();
					break;
				case 9:
					Clear();
					WriteLine("Tim hinh vuong co canh lon nhat >> ");
					listHinhHoc.TimHinhVuongMaxCanh().Xuat();
					break;
				case 10:
					Clear();
					WriteLine("Tim hinh co dien tich lon nhat >> ");
					listHinhHoc.TimHinhCoMaxDT().Xuat();
					break;
				case 11:
					Clear();
					WriteLine("Tim hinh co dien tich nho nhat >> ");
					listHinhHoc.TimHinhCoMinDT().Xuat();
					break;
				case 12:
					Clear();
					WriteLine("Tim hinh co chu vi lon nhat >> ");
					listHinhHoc.TimHinhCoMaxCV().Xuat();
					break;
				case 13:
					Clear();
					WriteLine("Tim hinh co chu vi nho nhat >> ");
					listHinhHoc.TimHinhCoMinCV().Xuat();
					break;
				case 14:
					Clear();
					WriteLine("Sort tang theo tung chuc nang tuong ung >> ");
					WriteLine("\n\tHINH VUONG >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortListHinhVuongTang_CV().Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortListHinhVuongGiam_CV().Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortListHinhVuongTang_DT().Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortListHinhVuongGiam_DT().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortListHinhTronTang_CV().Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortListHinhTronGiam_CV().Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortListHinhTronTang_DT().Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortListHinhTronGiam_DT().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >> ");
					WriteLine("\n\nTang theo chu vi...");
					listHinhHoc.SortListHinhChuNhatTang_CV().Xuat();
					WriteLine("\n\nGiam theo chu vi...");
					listHinhHoc.SortListHinhChuNhatGiam_CV().Xuat();
					WriteLine("\n\nTang theo dien tich...");
					listHinhHoc.SortListHinhChuNhatTang_DT().Xuat();
					WriteLine("\n\nGiam theo dien tich...");
					listHinhHoc.SortListHinhChuNhatGiam_DT().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE KET THUC CHUC NANG SAP SEP >> ");
					Read();
					break;
				case 15:
					Clear();
					WriteLine("Sort giam theo chu vi >> ");
					listHinhHoc.SortListHinhVuongGiam_CV().Xuat();
					break;
			}
			ReadLine();
		}
	}
}
