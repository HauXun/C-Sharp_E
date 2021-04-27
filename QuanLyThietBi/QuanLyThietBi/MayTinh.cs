using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThietBi
{
	class MayTinh
	{
		public List<IThietBi> list = new List<IThietBi>();
		#region Truy vấn siu cấp ಠ_ಠ
		public string TenMayTinh { get; set; }
		public float TongGia() => list.Sum(x => x.Gia);
		public float GiaTheoLoai<T>() => list.Where(x => x is T).Sum(x => x.Gia);
		public int DemThietBiTheoLoai<T>()
		{
			Type t = typeof(T);
			if (t.Name != "CPU")
				return list.Count(x => x is T);
			return list.Count(item => item is CPU && !(item is RAM) && !(item is HDD) && !(item is Mainboard) && !(item is Power));
			//int count = 0;
			//foreach (var item in list)
			//{
			//	if (t.Name == "CPU")
			//		if (item is CPU && !(item is RAM) && !(item is HDD) && !(item is Mainboard) && !(item is Power))
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
			str += $"\n\tTong so luong Mainboard: {DemThietBiTheoLoai<Mainboard>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<Mainboard>().ToString("C");
			str += $"\n\tTong so luong Power: {DemThietBiTheoLoai<Power>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<Power>().ToString("C");
			str += $"\n\nTong tat ca so luong thiet bi: {DemThietBiTheoLoai<IThietBi>()}".PadRight(40) + "Tong gia may tinh la: " + GiaTheoLoai<IThietBi>().ToString("C");
			return str;
		}
		#endregion
		#region Truy vấn và phân loại danh sách 👀👀👀
		public int DemTheoHangSX<T>(string hangSX) => list.Count(x => x is T && x.HangSX.CompareTo(hangSX) == 0);
		public List<IThietBi> TimThietBiTheoLoai<T>() => list.Where(x => x is T).ToList();
		public List<string> DanhSachHangTheoLoai<T>()
		{
			List<string> result = new List<string>();
			List<IThietBi> listTB = TimThietBiTheoLoai<T>();
			foreach (var item in listTB)
				if (!result.Contains(item.HangSX))
					result.Add(item.HangSX);
			return result;
		}
		public List<string> DanhSachHang()
		{
			List<string> result = new List<string>();
			foreach (var item in list)
				if (!result.Contains(item.HangSX))
					result.Add(item.HangSX);
			return result;
		}
		#endregion
	}
}