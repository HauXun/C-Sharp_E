
namespace QuanLyDanhBa
{
	class Menu
	{
		public readonly string[] input = new string[]
		{
			"Thoát chương trình",
			"Nhập dữ liệu thuê bao",
			"Nhập dữ liệu thuê bao từ file",
			"Xuất dữ liệu thuê bao",
			"Tùy biến chức năng quản lý thuê bao"
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
			"Tìm thành phố có nhiều thuê bao nhất",
			"Tìm thành phố có ít thuê bao nhất",
			"Tìm thuê bao sở hữu ít số điện thoại nhất",
			"Tìm thuê bao sở hữu nhiều số điện thoại nhất",
			"Tìm ngày có nhiều thuê bao đăng ký nhất",
			"Tìm ngày có ít thuê bao đăng ký nhất",
			"Tìm tháng không có thuê bao nào đăng ký",
			"Tìm thuê bao theo giới tính\n\n",
			"Tìm thành phố có nhiều thuê bao cố định nhất",
			"Tìm thành phố có ít thuê bao cố định nhất",
			"Tìm thành phố có nhiều thuê bao di động nhất",
			"Tìm thành phố có ít thuê bao di động nhất",
			"Tìm thuê bao sở hữu nhiều số điện thoại cố định nhất",
			"Tìm thuê bao sở hữu ít số điện thoại cố định nhất",
			"Tìm thuê bao sở hữu nhiều số điện thoại di động nhất",
			"Tìm thuê bao sở hữu ít số điện thoại di động nhất",
			"Tìm tháng không có thuê bao nào đăng ký số cố định",
			"Tìm tháng không có thuê bao nào đăng ký số di động",
			"Tìm thuê bao di động theo giới tính",
			"Tìm thuê bao cố định theo giới tính"
		};

		public readonly string[] sort = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Sắp xếp danh sách thuê bao tăng theo họ tên",
			"Sắp xếp danh sách thuê bao giảm theo họ tên",
			"Sắp xếp danh sách thuê bao tăng theo số lượng điện thoại sở hữu",
			"Sắp xếp danh sách thuê bao giảm theo số lượng điện thoại sở hữu",
			"Sắp xếp danh sách các thành phố tăng theo số lượng thuê bao",
			"Sắp xếp danh sách các thành phố giảm theo số lượng thuê bao"
		};

		public readonly string[] delete = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Xóa thuê bao theo địa chỉ",
			"Xóa thuê bao theo ngày lắp đặt",
			"Xóa thuê bao theo nhà dịch vụ",
		};

		public readonly string[] other = new string[]
		{
			"Thoát luôn đi ngủ",
			"Quay về trang trước",
			"Tất cả khách hàng nào sinh tháng 1 thì được tặng thêm một số điện thoại mới có số là số CMND",
			"Thống kê và hiển thị dữ liệu theo từng tỉnh và mỗi tỉnh hiển thị theo thành phố theo mẫu sau",
			@"Tỉnh: Lâm Đồng (tổng số thuê bao: 4)
				Thành Phố: Dalat (tổng số thuê bao: 2)
			1)	001, nguyen van a, 01 PDTV, Dalat, Lam Dong, 123
			2)	002, nguyen van b, 01 PDTV, Dalat, Lam Dong, 123
			Thành phố bảo lộc: (Tổng số thuê bao: 2)
			--- Hiển thị danh sách thuê bao ở thành phố bảo lộc ---
			Tỉnh Khánh Hòa (Tổng số….)
				Thành Phố: Nha Trang (tổng số thuê bao:……)
				--- Danh sách thuê bao ---"
		};
	}
}
