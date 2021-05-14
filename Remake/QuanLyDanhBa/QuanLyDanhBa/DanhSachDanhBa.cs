using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace QuanLyDanhBa
{
	class DanhSachDanhBa
	{
		List<ThueBao> thueBao = new List<ThueBao>();
		public int length { get { return thueBao.Count; } }

		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"thuebao.txt";
			Write("Enter your txt file name to open it: ");
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
			string s;
			while ((s = file.ReadLine()) != null)
				thueBao.Add(new ThueBao(s));
		}

		public void WriteFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"thuebao.txt";
			Write("Enter your txt file name to open it: ");
			string keyOpen = ReadLine().ToLower();
			string keyWord = ".txt";
			string a;
			if (keyOpen.Contains('.'))
				a = $@"{keyOpen}";
			else
				a = $@"{keyOpen + keyWord}";
			//if (a != path)
			//{
			//	Write("\nFail! Please try...");
			//	Read();
			//	return;
			//}
			//else
			//	Write("\nAccess...");
			string str = "";
			WriteLine("\nStart enter a contact...\n");
			Write("\nNhập số CMND >> ");
			string soCMND = ReadLine();
			Write("\nNhập họ và tên >> ");
			string hoTen = ReadLine();
			Write("\nNhập giới tính >> ");
			GioiTinh gioiTinh = ReadLine().Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
			Write("\nNhập ngày tháng năm sinh (mm/dd/yyy) >> ");
			DateTime ngaySinh = DateTime.Parse(ReadLine());
			Write("\nNhập địa chỉ >> ");
			string diaChi = ReadLine();
			Write("\nNhập số điện thoại >> ");
			string sdt = ReadLine();
			Write("\nNhập ngày tháng năm được cung cấp dịch vụ (mm/dd/yyy) Nếu không rõ thì nhập Empty để bỏ qua >> ");
			string ngayCungCapDV = ReadLine();
			Write("\nNhập nhà cung cấp dịch vụ (Nếu không rõ thì nhập Empty để bỏ qua) >> ");
			string nhaDichVu = ReadLine();

			str += "\r\n" + soCMND + ", " + hoTen + ", " + gioiTinh + ", " + ngaySinh + ", " + diaChi + ", " + sdt + ", " + ngayCungCapDV + ", " + nhaDichVu;
			StreamWriter file = new StreamWriter(new FileStream(a, FileMode.Append, FileAccess.Write));

			file.Write(str);
			file.Flush();
			file.Close();
		}

		public void XuatThongTinThueBao()
		{
			WriteLine("".PadRight(190, '='));
			WriteLine(" Số CMND".PadRight(15) + "Họ và tên".PadRight(20) + "Giới Tính".PadRight(15) + "Ngày tháng năm sinh".PadRight(25) + "Địa chỉ".PadRight(50) + "SDT".PadRight(20) + "Ngày cung cấp dịch vụ".PadRight(25) + "Nhà dịch vụ".PadRight(15));
			WriteLine("".PadRight(190, '='));
			foreach (var (item, index) in thueBao.WithIndex())
				Write($"{thueBao[index]}");
			WriteLine("".PadRight(190, '='));
		}
	}
}
