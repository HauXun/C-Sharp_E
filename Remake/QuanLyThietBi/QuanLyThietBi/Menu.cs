
namespace QuanLyThietBi
{
	class Menu
	{
		public readonly string[] input = new string[]
		{
			"Thoát chương trình",
			"Nhập dữ liệu máy tính từ file",
			"Xuất dữ liệu máy tính",
			"Tùy biến chức năng quản lý thiết bị"
		};

		public readonly string[] options = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tìm kiếm",
			"Sắp xếp",
			"Xóa",
			"Khác"
		};

		public readonly string[] search = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tìm máy tính có dung lượng ram thấp nhất",
			"Tìm máy tính có dung lượng ram lớn nhất",
			"Tìm hãng sản xuất RAM có dung lượng thấp nhất",
			"Tìm hãng sản xuất RAM có dung lượng lớn nhất\n",
			"Tìm máy tính có tốc độc CPU thấp nhất",
			"Tìm máy tính có tốc độc CPU lớn nhất",
			"Tìm hãng sản xuất CPU có tốc độ thấp nhất",
			"Tìm hãng sản xuất CPU có tốc độ lớn nhất\n",
			"Tìm máy tính có dung lượng RAM(Gb) lớn hơn mức dung lượng nhập",
			"Tìm máy tính có tốc độ CPU(Ghz) lớn hơn mức dung lượng nhập\n",
			"Tìm máy tính theo dung lượng RAM và hảng sản xuất",
			"Tìm máy tính theo tốc độ CPU và hảng sản xuất"
		};

		public readonly string[] sort = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Sắp xếp danh sách máy tính tăng dần theo dung lượng RAM(Gb)",
			"Sắp xếp danh sách máy tính giảm dần theo dung lượng RAM(Gb)",
			"Sắp xếp danh sách máy tính tăng dần theo tốc độ CPU(Ghz)",
			"Sắp xếp danh sách máy tính giảm dần theo tốc độ CPU(Ghz)",
			"Sắp xếp hình tròn tăng theo chu vi"
		};

		public readonly string[] other = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Xóa máy tính theo thuộc tính",
			"Cập nhập máy tính theo thuộc tính",
			"Lưu dữ liệu hiện tại vào tệp mới với đúng cấu trúc của dữ liệu hiện tại"
		};
	}
}
