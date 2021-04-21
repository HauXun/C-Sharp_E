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
			//while ((str = file.ReadLine()) != null)
			//{
			//	// CPU,Intel,300 * CPU,Intel,300 * RAM,SamSung,50 * HDD,Seagate,500
			//	MayTinh mayTinh = new MayTinh();
			//	string[] s = str.Split('*');
			//	foreach (string item in s)
			//	{
			//		if (item.IndexOf("MT") == 0)
			//			mayTinh.Them(new Device(item));
			//		if (item.IndexOf("CPU") == 0)
			//			mayTinh.Them(new CPU(item));
			//		if (item.IndexOf("RAM") == 0)
			//			mayTinh.Them(new RAM(item));
			//		if (item.IndexOf("HDD") == 0)
			//			mayTinh.Them(new HDD(item));
			//		if (item.IndexOf("Mainboard") == 0)
			//			mayTinh.Them(new Mainboard(item));
			//		if (item.IndexOf("Power") == 0)
			//			mayTinh.Them(new Power(item));
			//	}
			//	Them(mayTinh);
			//}
			while ((str = file.ReadLine()) != null)
			{
				Device d = new Device();
				CPU c = new CPU();
				RAM r = new RAM();
				HDD h = new HDD();
				Mainboard m = new Mainboard();
				Power p = new Power();
				string[] s = str.Split('*');
				foreach (var item in s)
				{
					if (item.IndexOf("MT") == 0)
					{
						string[] ss = item.Split(',');
						d = new Device(ss[1]);
					}
					if (item.IndexOf("CPU") == 0)
					{
						string[] ss = item.Split(',');
						c = new CPU(ss[0], ss[1], ss[2], float.Parse(ss[3]));
					}
					if (item.IndexOf("RAM") == 0)
					{
						string[] ss = item.Split(',');
						r = new RAM(ss[0], ss[1], ss[2], float.Parse(ss[3]));
					}
					if (item.IndexOf("HDD") == 0)
					{
						string[] ss = item.Split(',');
						h = new HDD(ss[0], ss[1], ss[2], float.Parse(ss[3]));
					}
					if (item.IndexOf("Mainboard") == 0)
					{
						string[] ss = item.Split(',');
						m = new Mainboard(ss[0], ss[1], ss[2], float.Parse(ss[3]));
					}
					if (item.IndexOf("Power") == 0)
					{
						string[] ss = item.Split(',');
						p = new Power(ss[0], ss[1], ss[2], float.Parse(ss[3]));
					}
				}
				Them(new MayTinh(d, c, r, h, m, p));
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
		public int XuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai loai, MinMax minMax)
		{
			int max = int.MinValue;
			int min = int.MaxValue;
			List<string> list = DanhSachTheoLoai(loai);
			foreach (var item in list)
			{
				int temp = DemThietBiTheoLoai(loai, item);
				switch (minMax)
				{
					case MinMax.Min:
						if (min > temp)
							min = temp;
						break;
					case MinMax.Max:
						if (max < temp)
							max = temp;
						break;
				}
			}
			if (minMax == MinMax.Max)
				return max;
			else
				return min;
		}
		public List<string> DanhSachXuatHienNhieuNhatItNhatTheoLoai(MayTinh.Loai loai, MinMax minMax)
		{
			List<string> result = new List<string>();
			int obj = XuatHienNhieuNhatItNhatTheoLoai(loai, minMax);
			List<string> list = DanhSachTheoLoai(loai);
			foreach (var item in list)
			{
				int temp = DemThietBiTheoLoai(loai, item);
				if (temp == obj)
					result.Add(item);
			}
			return result;
		}
		#endregion
		public List<MayTinh> SortTheoHang()
		{
			List<MayTinh> mayTinhs = new List<MayTinh>(listMayTinh);
			mayTinhs.OrderBy(x => x.TenMayTinh);
			return mayTinhs;
		}
	}
}