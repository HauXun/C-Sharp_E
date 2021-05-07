using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienDungChung;

namespace QuanLyThietBiV3
{
	class MayTinh
	{
		public List<IThietBi> list = new List<IThietBi>();
		#region Truy vấn siu cấp ಠ_ಠ
		public enum Tinh
		{
			Speed,
			sCapacity
		}
		public string TenMayTinh { get; set; }
		public float TongGia() => list.Sum(x => x.Gia);
		public float TinhTheoLoai<T>(Tinh tinh)
		{
			switch (tinh)
			{
				case Tinh.Speed:
					return list.Where(x => x is T).Sum(x => ((CPU)x).TocDo);
				case Tinh.sCapacity:
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
		}
		#endregion
		#region Nhập xuất định dạng và truy vấn 🚀🚀🚀
		public void Them(IThietBi x) => list.Add(x);
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append($"\n\nMay tinh {TenMayTinh}\n");

			foreach (var item in list)
				str.Append(item + "\n");
			str.Append($"\n\tTong so luong CPU: {DemThietBiTheoLoai<CPU>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<CPU>().ToString("C"));
			str.Append($"\n\tTong so luong RAM: {DemThietBiTheoLoai<RAM>()}".PadRight(30) + "Tong gia RAM la: " + GiaTheoLoai<RAM>().ToString("C"));
			str.Append($"\n\tTong so luong HDD: {DemThietBiTheoLoai<HDD>()}".PadRight(30) + "Tong gia HDD la: " + GiaTheoLoai<HDD>().ToString("C"));
			str.Append($"\n\tTong so luong Mainboard: {DemThietBiTheoLoai<MAINBOARD>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<MAINBOARD>().ToString("C"));
			str.Append($"\n\tTong so luong Power: {DemThietBiTheoLoai<PSU>()}".PadRight(30) + "Tong gia CPU la: " + GiaTheoLoai<PSU>().ToString("C"));
			str.Append($"\n\nTong tat ca so luong thiet bi: {DemThietBiTheoLoai<IThietBi>()}".PadRight(40) + "Tong gia may tinh la: " + GiaTheoLoai<IThietBi>().ToString("C"));
			return str.ToString();
		}
		#endregion
		#region Truy vấn và phân loại danh sách 👀👀👀
		public float ThuocTinhTheoLoai(Tinh tinh)
		{
			foreach (var item in list)
			{
				switch (tinh)
				{
					case Tinh.Speed:
						if (item is CPU)
							return ((CPU)item).TocDo;
						break;
					case Tinh.sCapacity:
						if (item is RAM)
							return ((RAM)item).DungLuong;
						break;
				}
			}
			return 0;
		}
		public string HangThietBiTheoLoai<T>() // list.Find(x => x is T).HangSX;
		{
			List<IThietBi> listTB = TimThietBiTheoLoai<T>();
			foreach (var item in listTB)
				foreach (var s in GeneralLibrary.dsHang)
					if (s.CompareTo(item.HangSX) == 0)
						return s;
			return null;
		}
		public List<IThietBi> TimThietBiTheoLoai<T>() => list.Where(x => x is T).ToList();
		#endregion
	}
}