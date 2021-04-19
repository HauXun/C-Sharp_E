using System;
using static System.Console;

namespace QuanLyThietBi
{
	class Menu
	{
		DanhSachMayTinh listMayTinh = new DanhSachMayTinh();
		QuanLyMayTinh listMayTinhQL = new QuanLyMayTinh();
		MayTinh mayTinh = new MayTinh();
		float x;
		int location;

		public readonly string[] options = new string[]
		{
			"Thoat chuong trinh",
			"Doc du lieu tu tap tin",
			"Xuat danh sach",
			"Tim kiem theo chuc nang tuong ung",
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
			switch (menu)
			{
				case 0:
					return;
				case 1:
					#region Các chức năng nhập xuất cơ bản
					Clear();
					WriteLine("Doc du lieu tu tap tin...");
					listMayTinh.ImportFromFile();
					break;
				case 2:
					Clear();
					WriteLine("Xuat >> ");
					listMayTinh.Xuat();
					break;
				case 3:
					Clear();
					WriteLine("Tim kiem theo chuc nang tuong ung >> ");
					WriteLine("\nMay tinh co gia re nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 0, 0).Xuat();
					WriteLine("\nMay tinh co CPU gia thap nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 1, 0).Xuat();
					WriteLine("\nMay tinh co CPU gia cao nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 1, 1).Xuat();
					WriteLine("\nMay tinh co RAM gia thap nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 2, 0).Xuat();
					WriteLine("\nMay tinh co RAM gia cao nhat...");
					listMayTinhQL.ListMayTinhTheoLoai(listMayTinh, 2, 1).Xuat();
					WriteLine("\nMay tinh co gia re nhat...");
					WriteLine("\nMay tinh co gia re nhat...");
					WriteLine("\nMay tinh co gia re nhat...");
					break;
				#endregion
				case 4:
					Clear();
					WriteLine("Test code >> ");
					foreach (string s in listMayTinhQL.DanhSachTheoLoai(listMayTinh, 0))
						WriteLine(s);
					WriteLine("\n");
					foreach (string s in listMayTinhQL.DanhSachTheoLoai(listMayTinh, 1))
						WriteLine(s);
					break;
			}
			ReadLine();
		}
	}
}
