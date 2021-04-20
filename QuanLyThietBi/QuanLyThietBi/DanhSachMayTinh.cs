using System.Collections.Generic;
using System.IO;
using System.Linq;
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
			string[] tC;
			string[] tR;
			string[] tH;
			while ((str = file.ReadLine()) != null)
			{
				string[] s = str.Split(',');
				tC = s[1].Split(' ');
				tR = s[2].Split(' ');
				tH = s[3].Split(' ');
				Them(new MayTinh(s[0], new CPU(tC[0], tC[1], float.Parse(tC[2])),
					new RAM(tR[0], tR[1], float.Parse(tR[2])),
					new HDD(tH[0], tH[1], float.Parse(tH[2]))));
			}
		}
		public void Them(MayTinh mt)
		{
			listMayTinh.Add(mt);
		}
		public override string ToString()
		{
			string str = null;
			foreach (var item in listMayTinh)
				str += item + "\n";
			return str;
		}
		public void Xuat()
		{
			WriteLine(ToString());
		}
		#endregion
		#region Các hàm phân loại danh sách máy tinh 🚀🚀🚀
		public enum MinMax
		{
			Min,
			Max
		}
		public void ThemDanhSach(List<string> result, List<string> kieu)
		{
			foreach (var item in kieu)
				if (!result.Contains(item))
					result.Add(item);
		}
		public List<string> DanhSachTheoLoai(MayTinh.Loai loai)
		{
			List<string> result = new List<string>();
			foreach (var item in listMayTinh)
				ThemDanhSach(result, item.TimDanhSachTheoLoai(loai));
			return result;
		}
		public int DemThietBiTheoLoai(MayTinh.Loai loai, string kieu)
		{
			switch (loai)
			{
				case MayTinh.Loai.HangCPU:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
				case MayTinh.Loai.HangRAM:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
				case MayTinh.Loai.HangHDD:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
				case MayTinh.Loai.CPU:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
				case MayTinh.Loai.RAM:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
				case MayTinh.Loai.HDD:
					return listMayTinh.Sum(x => x.DemTheoLoai(loai, kieu));
			}
			return 0;
		}
		public int XuatHienNhieuNhatTheoLoai(MayTinh.Loai loai)
		{
			int max = int.MinValue;
			List<string> list = DanhSachTheoLoai(loai);
			foreach (var item in list)
			{
				int temp = DemThietBiTheoLoai(loai, item);
				if (max < temp)
					max = temp;
			}
			return max;
		}
		public List<string> DanhSachXuatHienNhieuNhatTheoLoai(MayTinh.Loai loai)
		{
			List<string> result = new List<string>();
			int max = XuatHienNhieuNhatTheoLoai(loai);
			List<string> list = DanhSachTheoLoai(loai);
			foreach (var item in list)
			{
				int temp = DemThietBiTheoLoai(loai, item);
				if (temp == max)
				result.Add(item);
			}
			return result;
		}
		#endregion
	}
}
