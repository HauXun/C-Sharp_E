using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace QuanLyThietBi
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
			StringBuilder str = new StringBuilder();
			foreach (var item in listMayTinh)
				str.Append(item + "\n");
			return str.ToString();
		}
		public void Xuat() => WriteLine(ToString());
		#endregion
	}
}
