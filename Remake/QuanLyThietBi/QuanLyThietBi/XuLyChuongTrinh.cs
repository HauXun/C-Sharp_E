using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuanLyThietBi
{
	class XuLyChuongTrinh
	{
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu, DanhSachMayTinh danhSachMayTinh)
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
							WriteLine("\nTìm máy tính có dung lượng ram thấp nhất");
							break;
						case 3:
							Clear();
							WriteLine("\nTìm máy tính có dung lượng ram lớn nhất");
							break;
						case 4:
							Clear();
							WriteLine("\nTìm hãng sản xuất RAM có dung lượng thấp nhất");
							break;
						case 5:
							Clear();
							WriteLine("\nTìm hãng sản xuất RAM có dung lượng lớn nhất");
							break;
						case 6:
							Clear();
							WriteLine("\nTìm máy tính có tốc độc CPU thấp nhất");
							break;
						case 7:
							Clear();
							WriteLine("\nTìm máy tính có tốc độc CPU lớn nhất");
							break;
						case 8:
							Clear();
							WriteLine("\nTìm hãng sản xuất CPU có tốc độ thấp nhất");
							break;
						case 9:
							Clear();
							WriteLine("\nTìm hãng sản xuất CPU có tốc độ lớn nhất");
							break;
						case 10:
							Clear();
							WriteLine("\nTìm máy tính có dung lượng RAM(Gb) lớn hơn mức dung lượng nhập");
							break;
						case 11:
							Clear();
							WriteLine("\nTìm máy tính có tốc độ CPU(Ghz) lớn hơn mức dung lượng nhập");
							break;
						case 12:
							Clear();
							WriteLine("\nTìm máy tính theo dung lượng RAM và hảng sản xuất");
							break;
						case 13:
							Clear();
							WriteLine("\nTìm máy tính theo tốc độ CPU và hảng sản xuất");
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
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính giảm dần theo dung lượng RAM(Gb)");
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính tăng dần theo tốc độ CPU(Ghz)");
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp danh sách máy tính giảm dần theo tốc độ CPU(Ghz)");
							break;
						case 6:
							Clear();
							WriteLine("\nSắp xếp hình tròn tăng theo chu vi");
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
							break;
						case 3:
							Clear();
							WriteLine("Cập nhập máy tính theo thuộc tính");
							break;
						case 4:
							Clear();
							WriteLine("Lưu dữ liệu hiện tại vào tệp mới với đúng cấu trúc của dữ liệu hiện tại");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
