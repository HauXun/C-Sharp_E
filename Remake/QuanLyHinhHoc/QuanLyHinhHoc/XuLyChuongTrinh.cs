using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace QuanLyHinhHoc
{
	class XuLyChuongTrinh
	{
		Dictionary<int, int> result;
		public void XuLyChucNang(XuLyMenu.TuyChon tuyChon, int menu)
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
							break;
						case 3:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi x");
							break;
						case 4:
							Clear();
							WriteLine("\nTìm hình vuông có diện tích nhỏ nhất");
							break;
						case 5:
							Clear();
							WriteLine("\nTìm hình vuông có diện tích lớn nhất");
							break;
						case 6:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi nhỏ nhất");
							break;
						case 7:
							Clear();
							WriteLine("\nTìm hình vuông có chu vi lớn nhất");
							break;
						case 8:
							Clear();
							WriteLine("\nTìm hình vuông có cạnh nhỏ nhất");
							break;
						case 9:
							Clear();
							WriteLine("\nTìm hình vuông có cạnh lớn nhất");
							break;
						case 10:
							Clear();
							WriteLine("\nTìm hình tròn có diện tích x");
							break;
						case 11:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi x");
							break;
						case 12:
							Clear();
							WriteLine("\nTìm hình vuông có diện tích nhỏ nhất");
							break;
						case 13:
							Clear();
							WriteLine("\nTìm hình tròn có diện tích lớn nhất");
							break;
						case 14:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi nhỏ nhất");
							break;
						case 15:
							Clear();
							WriteLine("\nTìm hình tròn có chu vi lớn nhất");
							break;
						case 16:
							Clear();
							WriteLine("\nTìm hình tròn có bán kính nhỏ nhất");
							break;
						case 17:
							Clear();
							WriteLine("\nTìm hình tròn có bán kính lớn nhất");
							break;
						case 18:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích x");
							break;
						case 19:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi x");
							break;
						case 20:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích nhỏ nhất");
							break;
						case 21:
							Clear();
							WriteLine("\nTìm hình chữ nhật có diện tích lớn nhất");
							break;
						case 22:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi nhỏ nhất");
							break;
						case 23:
							Clear();
							WriteLine("\nTìm hình chữ nhật có chu vi lớn nhất");
							break;
						case 24:
							Clear();
							WriteLine("\nTìm hình chữ nhật có cạnh nhỏ nhất");
							break;
						case 25:
							Clear();
							WriteLine("\nTìm hình chữ nhật có cạnh lớn nhất");
							break;
						case 26:
							Clear();
							WriteLine("\nTìm hình có diện tích nhỏ nhất");
							break;
						case 27:
							Clear();
							WriteLine("\nTìm hình có diện tích lớn nhất");
							break;
						case 28:
							Clear();
							WriteLine("\nTìm hình có chu vi nhỏ nhất");
							break;
						case 29:
							Clear();
							WriteLine("\nTìm hình có chu vi lớn nhất");
							break;
						case 30:
							Clear();
							WriteLine("\nTìm hình có tổng diện tích nhỏ nhất");
							break;
						case 31:
							Clear();
							WriteLine("\nTìm hình có tổng diện tích lớn nhất");
							break;
						case 32:
							Clear();
							WriteLine("\nTìm hình có tổng chu vi nhỏ nhất");
							break;
						case 33:
							Clear();
							WriteLine("\nTìm hình có tổng chu vi lớn nhất");
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
							break;
						case 3:
							Clear();
							WriteLine("\nSắp xếp hình vuông giảm theo chu vi");
							break;
						case 4:
							Clear();
							WriteLine("\nSắp xếp hình vuông tăng theo diện tích");
							break;
						case 5:
							Clear();
							WriteLine("\nSắp xếp hình vuông giảm theo diện tích");
							break;
						case 6:
							Clear();
							WriteLine("\nSắp xếp hình tròn vuông tăng theo chu vi");
							break;
						case 7:
							Clear();
							WriteLine("\nSắp xếp hình tròn vuông giảm theo chu vi");
							break;
						case 8:
							Clear();
							WriteLine("\nSắp xếp hình tròn vuông tăng theo diện tích");
							break;
						case 9:
							Clear();
							WriteLine("\nSắp xếp hình tròn vuông giảm theo diện tích");
							break;
						case 10:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật vuông tăng theo chu vi");
							break;
						case 11:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật vuông giảm theo chu vi");
							break;
						case 12:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật vuông tăng theo diện tích");
							break;
						case 13:
							Clear();
							WriteLine("\nSắp xếp hình chữ nhật vuông giảm theo diện tích");
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
							break;
						case 3:
							Clear();
							WriteLine("\nXóa hình có diện tích nhỏ nhất");
							break;
						case 4:
							Clear();
							WriteLine("\nXóa hình có chu vi lớn nhất");
							break;
						case 5:
							Clear();
							WriteLine("\nXóa hình có chu vi nhỏ nhất");
							break;
						case 6:
							Clear();
							WriteLine("\nXóa hình tại vị trí");
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
							break;
						case 3:
							Clear();
							WriteLine("Đếm số lượng các loại hình học");
							break;
						case 4:
							Clear();
							WriteLine("Ghi file các hình xuống file riêng");
							break;
					}
					break;
			}
			ReadLine();
		}
	}
}
