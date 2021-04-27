using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace QuanLyThietBiV2
{
	class DanhSachMayTinh
	{
		public List<MayTinh> listMayTinh = new List<MayTinh>();
		#region Các hàm nhập xuất, định dạng và truy vấn 🚀🚀🚀
		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"maytinh.txt";
			Write("Nhap ten tap tin de mo >> ");
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
			string str = "";
			while ((str = file.ReadLine()) != null)
			{
				MayTinh mayTinh = new MayTinh();
				string[] s = str.Split('*');
				mayTinh.TenMayTinh = s[0];
				foreach (string item in s)
				{

					if (item.IndexOf("CPU") == 0)
						mayTinh.Them(new CPU(item));
					if (item.IndexOf("RAM") == 0)
						mayTinh.Them(new RAM(item));
					if (item.IndexOf("HDD") == 0)
						mayTinh.Them(new HDD(item));
					if (item.IndexOf("Mainboard") == 0)
						mayTinh.Them(new MAINBOARD(item));
					if (item.IndexOf("Power") == 0)
						mayTinh.Them(new PSU(item));
				}
				Them(mayTinh);
			}
		}
		public void Them(MayTinh mt) => listMayTinh.Add(mt);
		public override string ToString()
		{
			string str = null;
			foreach (var item in listMayTinh)
				str += item + "\n";
			return str;
		}
		public void Xuat() => WriteLine(ToString());
		#endregion
		#region Các hàm phân loại danh sách máy tính (☞ﾟヮﾟ)☞
		public List<string> DanhSachHangTheoLoai<T>()
		{
			List<string> result = new List<string>();
			foreach (var item in listMayTinh)
				foreach (var s in item.DanhSachHangTheoLoai<T>())
					if (!result.Contains(s))
						result.Add(s);
			return result;
		}
		public List<float> DanhSachThuocTinhTheoLoai<T>(QuanLyMayTinh.Tinh tinh)
		{
			List<float> result = new List<float>();
			foreach (var item in listMayTinh)
				foreach (var s in item.DanhSachThuocTinhTheoLoai<T>(tinh))
					if (!result.Contains(s))
						result.Add(s);
			return result;
		}
		#endregion
	}
}