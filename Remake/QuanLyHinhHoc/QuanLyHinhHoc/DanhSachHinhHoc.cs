using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace QuanLyHinhHoc
{
	class DanhSachHinhHoc
	{
		public List<HinhHoc> ListHinhHoc = new List<HinhHoc>();
		#region Các hàm chức năng cho lớp HinhHoc
		private void Them(HinhHoc geometry) => ListHinhHoc.Add(geometry);
		#endregion
		#region Các hàm nhập, xuất, định dạng và truy vấn
		public override string ToString()
		{
			string s = "";
			foreach (var item in ListHinhHoc)
				s += "\n" + item;
			return s;
		}
		public void Xuat() => WriteLine(this.ToString());
		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"data.txt";
			Write("Nhập tên file để mở >> ");
			string keyOpen = ReadLine().ToLower();
			string keyWord = ".txt";
			string a;
			if (keyOpen.Contains('.'))
				a = $@"{keyOpen}";
			else
				a = $@"{keyOpen + keyWord}";
			if (a != path)
			{
				Write("\nFail! Please try...");
				Read();
				return;
			}
			else
				Write("\nAccess...");
			StreamReader file = new StreamReader(a);
			string s = "";
			while ((s = file.ReadLine()) != null)
			{
				string[] str = s.Split(' ');
				if (str[0] == "HT")
					Them(new HinhTron(float.Parse(str[1])));
				else if (str[0] == "HV")
					Them(new HinhVuong(float.Parse(str[1])));
				else
					Them(new HinhChuNhat(float.Parse(str[1]), float.Parse(str[2])));
			}
		}
		public void Nhap()
		{
			HinhHoc hh = new HinhHoc();
			string isContinue = null;
			do
			{
				Write("\nBạn muốn nhập hình gì (1 - HV, 2 - HT, 3 - HCN) >> ");
				int type = int.Parse(ReadLine());
				switch (type)
				{
					case 1:
						WriteLine("\nHình Vuông >>");
						hh = new HinhVuong();
						break;
					case 2:
						WriteLine("\nHình Tròn >>");
						hh = new HinhTron();
						break;
					case 3:
						WriteLine("\nHình chữ nhật >>");
						hh = new HinhChuNhat();
						break;
					default:
						WriteLine("Có lỗi gì đó đã xảy ra! Vui lòng kiểm tra lại");
						break;
				}
				ListHinhHoc.Add(hh.Nhap());
				WriteLine("\n\tBạn có muốn nhập nữa không ?");
				Write("Nhấn phím bất kì để tiếp tục. Gõ 'No' nếu không! >> ");
				isContinue = ReadLine().ToUpper();
			} while (isContinue != "NO");
		}
		#endregion
	}
}
