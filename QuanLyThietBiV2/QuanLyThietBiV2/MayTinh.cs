using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThietBiV2
{
	class MayTinh
	{
		public List<IThietBi> list = new List<IThietBi>();
		#region Truy vấn siu cấp ಠ_ಠ
		public string TenMayTinh { get; set; }
		public float TongGia() => list.Sum(x => x.Gia);
		public float TinhTheoLoai<T>(QuanLyMayTinh.Tinh tinh)
		{
			switch (tinh)
			{
				case QuanLyMayTinh.Tinh.Speed:
					return list.Where(x => x is T).Sum(x => ((CPU)x).TocDo);
				case QuanLyMayTinh.Tinh.sCapacity:
					return list.Where(x => x is T).Sum(x => ((RAM)x).DungLuong);
			}
			return 0;
		}
		public float GiaTheoLoai<T>() => list.Where(x => x is T).Sum(x => x.Gia);
		public int DemThietBiTheoLoai<T>()
		{
			Type t = typeof(T);
			if (t.Name != "CPU")
				return list.Count(x => x is T);
			return list.Count(item => item is CPU && !(item is RAM) && !(item is HDD) && !(item is MAINBOARD) && !(item is PSU));
			//int count = 0;
			//foreach (var item in list)
			//{
			//	if (t.Name == "CPU")
			//		if (item is CPU && !(item is RAM) && !(item is HDD) && !(item is MAINBOARD) && !(item is PSU))
			//			count++;
			//		else
			//		if (item is T)
			//			count++;
			//}
			//return count;
		}
		#endregion
		#region Nhập xuất định dạng và truy vấn 🚀🚀🚀
		public void Them(IThietBi x) => list.Add(x);
		public override string ToString()
		{
			string str = $"\n\nMay tinh {TenMayTinh}\n";

			foreach (var item in list)
				str += item + "\n";
			str += $"\n\tTong so luong CPU: {DemThietBiTheoLoai<CPU>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<CPU>().ToString("C");
			str += $"\n\tTong so luong RAM: {DemThietBiTheoLoai<RAM>()}".PadRight(30) + "Tong gia RAM la: " + GiaTheoLoai<RAM>().ToString("C");
			str += $"\n\tTong so luong HDD: {DemThietBiTheoLoai<HDD>()}".PadRight(30) + "Tong gia HDD la: " + GiaTheoLoai<HDD>().ToString("C");
			str += $"\n\tTong so luong Mainboard: {DemThietBiTheoLoai<MAINBOARD>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<MAINBOARD>().ToString("C");
			str += $"\n\tTong so luong Power: {DemThietBiTheoLoai<PSU>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<PSU>().ToString("C");
			str += $"\n\nTong tat ca so luong thiet bi: {DemThietBiTheoLoai<IThietBi>()}".PadRight(40) + "Tong gia may tinh la: " + GiaTheoLoai<IThietBi>().ToString("C");
			return str;
		}
		#endregion
		#region Truy vấn và phân loại danh sách 👀👀👀
		public float ThuocTinhTheoLoai<T>(QuanLyMayTinh.Tinh tinh)
		{
			switch (tinh)
			{
				case QuanLyMayTinh.Tinh.Speed:
					return list.Find(x => x is CPU).TocDo;
				case QuanLyMayTinh.Tinh.sCapacity:
					return list.Find(x => x is RAM).DungLuong;
			}
			return 0;
		}
		public string HangThietBiTheoLoai<T>() => list.Find(x => x is T).HangSX;
		public List<IThietBi> TimThietBiTheoLoai<T>() => list.Where(x => x is T).ToList();
		public List<string> DanhSachHangTheoLoai<T>()
		{
			Type t = typeof(T);
			List<string> result = new List<string>();
			List<IThietBi> listTB = TimThietBiTheoLoai<T>();
			foreach (var item in listTB)
				if (!result.Contains(item.HangSX))
				{
					if (t.Name == "CPU" && t.Name != "RAM" && t.Name != "HDD" && t.Name != "MAINBOARD" && t.Name != "PSU")
					{
						if (item.HangSX.Equals("Intel") || item.HangSX.Equals("AMD"))
							result.Add(item.HangSX);
					}
					else
						result.Add(item.HangSX);
				}
			return result;
		}
		public List<float> DanhSachThuocTinhTheoLoai<T>(QuanLyMayTinh.Tinh tinh)
		{
			List<float> result = new List<float>();
			List<IThietBi> listTB = TimThietBiTheoLoai<T>();
			foreach (var item in listTB)
			{
				switch (tinh)
				{
					case QuanLyMayTinh.Tinh.Speed:
						if (!result.Contains(item.TocDo))
							if (!item.TocDo.Equals(item.DungLuong))
								result.Add(item.TocDo);
						break;
					case QuanLyMayTinh.Tinh.sCapacity:
						if (!result.Contains(item.DungLuong))
							result.Add(item.DungLuong);
						break;
				}
			}
			return result;
		}
		#endregion
	}
}