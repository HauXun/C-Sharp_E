using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangPhanSo
{
	class Menu
	{
		public readonly string[] input = new string[]
		{
			"Thoát chương trình",
			"Nhập dữ liệu",
			"Nhập dữ liệu ngẫu nhiên",
			"Xuất dữ liệu",
			"Tùy biến chức năng"
		};

		public readonly string[] options = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tìm kiếm",
			"Xóa",
			"Đếm",
			"Thêm",
			"Sắp xếp"
		};

		public readonly string[] search = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tìm phân số lớn nhất",
			"Tìm phân số âm lớn nhất",
			"Tìm phân số âm nhỏ nhất",
			"Tìm phân số dương lớn nhất",
			"Tìm phân số dương nhỏ nhất",
			"Tìm tất cả các phân số âm trong mảng",
			"Tìm tất cả các phân số dương trong mảng",
			"Tìm tất cả vị trí của phân số x trong mảng",
			"Tìm tất cả vị trí của phân số âm trong mảng",
			"Tìm tất cả vị trí của phân số dương trong mảng"
		};

		public readonly string[] delete = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Xóa phân số đầu tiên trong mảng",
			"Xóa phân số cuối cùng trong mảng",
			"Xóa phân số x trong mảng",
			"Xóa tất cả phân số có tử là x",
			"Xóa tất cả phân số có mẫu là x",
			"Xóa tất cả phân số chẵn",
			"Xóa tất cả phân số lẻ",
			"Xóa một phân số tại vị trí x trong mảng",
			"Xóa tất cả phân số âm trong mảng",
			"Xóa tất cả phân số dương trong mảng",
			"Xóa tất cả các phân số nhỏ nhất",
			"Xóa tất cả các phân số lớn nhất",
			"Xóa tất cả phân số có giá trị giống phân số đầu tiên trong mảng",
			"Xóa tất cả phân số có giá trị giống phân số cuối cùng trong mảng",
			"Xóa các phần tử tại các vị trí (vị trí được lưu trong mảng)"
		};

		public readonly string[] count = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Đếm số phân số âm trong mảng",
			"Đếm số phân số dương trong mảng",
			"Đếm phân số có tử là x trong mảng",
			"Đếm phân số có mẫu là x trong mảng"
		};

		public readonly string[] sum = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tổng tất cả các phân số âm trong mảng",
			"Tổng tất cả các phân số dương trong mảng",
			"Tổng tất cả phân số có tử là x",
			"Tổng tất cả phân số có mẫu là x"
		};

		public readonly string[] sort = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Sắp xếp phân số theo chiều tăng của tử",
			"Sắp xếp phân số theo chiều tăng của mẫu",
			"Sắp xếp phân số theo chiều giảm của tử",
			"Sắp xếp phân số theo chiều giảm của mẫu"
		};

		public readonly string[] add = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Thêm phân số đầu tiên trong mảng",
			"Thêm phân số cuối cùng trong mảng",
			"Thêm một phân số tại vị trí trong mảng"
		};
	}
}
