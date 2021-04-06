using static System.Console;

namespace GeometryManagement
{
	class Menu
	{
		DanhSachHinhHoc listHinhHoc = new DanhSachHinhHoc();
		DanhSachHinhHoc result = new DanhSachHinhHoc();
		float x;
		int location;

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc tu tap tin",
			"Nhap du lieu hinh hoc",
			"Xuat danh sach",
			"Cac ham tim kiem theo chuc nang tuong ung",
			"Sort tang theo tung chuc nang tuong ung",
			"Delete theo tung chuc nang tuong ung",
			"Them mot hinh hoc tai vi tri",
			"Dem so luong cac loai hinh hoc",
			"Ghi tat ca thong tin hinh hoc vao file txt",
			"Ghi tat ca thong tin hinh vuong vao file txt",
			"Ghi tat ca thong tin hinh tron vao file txt",
			"Ghi tat ca thong tin hinh chu nhat vao file txt"
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
					#region Các chức năng nhập xuất cơ bản
					Clear();
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
				#endregion
				case 4:
					#region Chức năng tìm kiếm
					Clear();
					WriteLine("\tCac ham tim kiem theo chuc nang tuong ung >> ");
					WriteLine("Tim kiem theo x");
					WriteLine("\n\tHINH VUONG >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh vuong co dien tich = {0} la...", x);
					listHinhHoc.TimHinhVuongDTBangX(x).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh vuong co chu vi = {0} la...", x);
					listHinhHoc.TimHinhVuongCVBangX(x).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh tron co dien tich = {0} la...", x);
					listHinhHoc.TimHinhTronDTBangX(x).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh tron co chu vi = {0} la...", x);
					listHinhHoc.TimHinhTronCVBangX(x).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >>");
					Write("Nhap vao dien tich x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh chu nhat co dien tich = {0} la...", x);
					listHinhHoc.TimHinhChuNhatDTBangX(x).Xuat();
					Write("\nNhap vao chu vi x >> ");
					x = float.Parse(ReadLine());
					WriteLine("Hinh chu nhat co chu vi = {0} la...", x);
					listHinhHoc.TimHinhChuNhatCVBangX(x).Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\tCac ham tim kiem theo chuc nang tuong ung >> ");
					WriteLine("Tim min max Chu vi, Dien tich tung hinh");
					WriteLine("\n\tHINH VUONG >>");
					WriteLine("Hinh vuong dien tich nho nhat la...");
					listHinhHoc.TimHinhVuongMinDT().Xuat();
					WriteLine("Hinh vuong chu vi nho nhat la...");
					listHinhHoc.TimHinhVuongMinCV().Xuat();
					WriteLine("Hinh vuong canh nho nhat la...");
					listHinhHoc.TimHinhVuongMinCanh().Xuat();
					WriteLine("Hinh vuong canh lon nhat la...");
					listHinhHoc.TimHinhVuongMaxCanh().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH TRON >>");
					WriteLine("Hinh tron dien tich nho nhat la...");
					listHinhHoc.TimHinhTronMinDT().Xuat();
					WriteLine("Hinh tron chu vi nho nhat la...");
					listHinhHoc.TimHinhTronMinCV().Xuat();
					WriteLine("Hinh tron ban kinh nho nhat la...");
					listHinhHoc.TimHinhTronMinBanKinh().Xuat();
					WriteLine("Hinh tron ban kinh lon nhat la...");
					listHinhHoc.TimHinhTronMaxBanKinh().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN QUA HINH TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHINH CHU NHAT >>");
					WriteLine("Hinh chu nhat dien tich nho nhat la...");
					listHinhHoc.TimHinhChuNhatMinDT().Xuat();
					WriteLine("Hinh chu nhat chu vi nho nhat la...");
					listHinhHoc.TimHinhChuNhatMinCV().Xuat();
					WriteLine("Hinh chu nhat canh nho nhat la...");
					listHinhHoc.TimHinhChuNhatMinChieuDai().Xuat();
					WriteLine("Hinh chu nhat canh lon nhat la...");
					listHinhHoc.TimHinhChuNhatMaxChieuDai().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tMin, max Chu vi, Dien tich trong cac hinh>>");
					WriteLine("Hinh co dien tich nho nhat la...");
					listHinhHoc.TimHinhCoMinDT().Xuat();
					WriteLine("Hinh co dien tich lon nhat la...");
					listHinhHoc.TimHinhCoMaxDT().Xuat();
					WriteLine("Hinh co chu vi nho nhat la...");
					listHinhHoc.TimHinhCoMinCV().Xuat();
					WriteLine("Hinh co chu vi lon nhat la...");
					listHinhHoc.TimHinhCoMaxCV().Xuat();
					Write("\n\tNHAN PHIM BAT KI DE CHUYEN CHUC NANG TIEP THEO >> ");
					ReadLine();
					Clear();
					WriteLine("\n\tHinh co tong dien tich, chu vi lon nhat, nho nhat >>");
					WriteLine("Hinh co tong dien tich nho nhat la...");
					x = listHinhHoc.HinhDTNhoNhat();
					if (x == 1)
						WriteLine("Hinh Vuong");
					else if (x == 0)
						WriteLine("Hinh tron");
					else
						WriteLine("Hinh chu nhat");
					WriteLine("Hinh co tong dien tich lon nhat la...");
					x = listHinhHoc.HinhDTLonNhat();
					if (x == 1)
						WriteLine("Hinh Vuong");
					else if (x == 0)
						WriteLine("Hinh tron");
					else
						WriteLine("Hinh chu nhat");
					WriteLine("Hinh co tong chu vi nho nhat la...");
					x = listHinhHoc.HinhCVNhoNhat();
					if (x == 1)
						WriteLine("Hinh Vuong");
					else if (x == 0)
						WriteLine("Hinh tron");
					else
						WriteLine("Hinh chu nhat");
					WriteLine("Hinh co tong chu vi lon nhat la...");
					x = listHinhHoc.HinhCVLonNhat();
					if (x == 1)
						WriteLine("Hinh Vuong");
					else if (x == 0)
						WriteLine("Hinh tron");
					else
						WriteLine("Hinh chu nhat");
					Write("\n\tNHAN PHIM BAT KI DE KET THUC CHUC NANG TIM KIEM >> ");
					Read();
					break;
				#endregion Chức năng tìm kiếm
				case 5:
					#region Chức năng sắp xếp
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
				#endregion
				case 6:
					#region Chức năng xóa
					Clear();
					WriteLine("Delete theo tung chuc nang tuong ung >> ");
					WriteLine("\tXoa hinh co dien tich lon nhat");
					listHinhHoc.XoaHinhDTLonNhat().Xuat();
					WriteLine("\n\n\tXoa hinh co dien tich lon nhat");
					listHinhHoc.XoaHinhDTNhoNhat().Xuat();
					WriteLine("\n\n\tXoa hinh co chu vi lon nhat");
					listHinhHoc.XoaHinhCVLonNhat().Xuat();
					WriteLine("\n\n\tXoa hinh co chu vi lon nhat");
					listHinhHoc.XoaHinhCVNhoNhat().Xuat();
					Write("\n\nNhap vao vi tri x can xoa >> ");
					location = int.Parse(ReadLine());
					listHinhHoc.XoaHinhTaiViTri(location);
					listHinhHoc.Xuat();
					#endregion
					break;
				case 7:
					#region Các chức năng khác
					Clear();
					WriteLine("Them mot hinh hoc tai vi tri");
					Write("\n\nNhap vao vi tri x can them >> ");
					location = int.Parse(ReadLine());
					listHinhHoc.ThemHinhTaiViTri(location);
					break;
				case 8:
					Clear();
					WriteLine("Dem so luong cac loai hinh hoc");
					Write("\n\nSo luong hinh vuong la >> " + listHinhHoc.DemHinhVuong());
					Write("\n\nSo luong hinh tron la >> " + listHinhHoc.DemHinhTron());
					Write("\n\nSo luong hinh chu nhat la >> " + listHinhHoc.DemHinhChuNhat());
					break;
				case 9:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh hoc vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFile();
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 10:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh vuong vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFileHinhVuong();
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 11:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh tron vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFileHinhTron();
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
				case 12:
					Clear();
					WriteLine("Ghi tat ca thong tin hinh chu nhat vao file txt.");
					WriteLine("Nhan phim bat ki de bat dau thuc hien >> ");
					listHinhHoc.GhiFileHinhChuNhat();
					ReadLine();
					WriteLine("Ghi file hoan tat !");
					break;
					#endregion
			}
			ReadLine();
		}
	}
}
