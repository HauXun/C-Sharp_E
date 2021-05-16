using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThuVienDungChung;

namespace QuanLyThietBi
{
	class MayTinh
	{
		public List<IThietBi> listTB = new List<IThietBi>();
		public enum Tinh
		{
			Speed,
			sCapacity
		}
		public string TenMayTinh { get; set; }
		#region Truy vấn dữ liệu ಠ_ಠ
		private float TinhGiaTheoLoai<T>() => listTB.Where(x => x is T).Sum(x => x.Gia);
		private int DemThietBiTheoLoai<T>()
		{
			Type type = typeof(T);
			if (type.Name == "RAM")
				return listTB.Count(item => item is RAM && !(item is CPU) && !(item is HDD) && !(item is MAINBOARD) && !(item is PSU));
			else if (type.Name == "CPU")
				return listTB.Count(item => item is CPU && !(item is RAM) && !(item is HDD) && !(item is MAINBOARD) && !(item is PSU));
			return listTB.Count(x => x is T);
		}
		#endregion
		#region Truy xuất dữ liệu 🚀🚀🚀
		public void Them(IThietBi thietBi) => listTB.Add(thietBi);
		public override string ToString()
		{
			StringBuilder str = new StringBuilder();
			str.Append($"\n\nMay tinh {TenMayTinh}\n");

			foreach (var item in listTB)
				str.Append(item + "\n");
			str.Append($"\n\tTong so luong CPU: {DemThietBiTheoLoai<CPU>()}".PadRight(30) + "Tong gia CPU la: " + TinhGiaTheoLoai<CPU>().ToString("C"));
			str.Append($"\n\tTong so luong RAM: {DemThietBiTheoLoai<RAM>()}".PadRight(30) + "Tong gia RAM la: " + TinhGiaTheoLoai<RAM>().ToString("C"));
			str.Append($"\n\tTong so luong HDD: {DemThietBiTheoLoai<HDD>()}".PadRight(30) + "Tong gia HDD la: " + TinhGiaTheoLoai<HDD>().ToString("C"));
			str.Append($"\n\tTong so luong Mainboard: {DemThietBiTheoLoai<MAINBOARD>()}".PadRight(30) + "Tong gia CPU la: " + TinhGiaTheoLoai<MAINBOARD>().ToString("C"));
			str.Append($"\n\tTong so luong Power: {DemThietBiTheoLoai<PSU>()}".PadRight(30) + "Tong gia CPU la: " + TinhGiaTheoLoai<PSU>().ToString("C"));
			str.Append($"\n\nTong tat ca so luong thiet bi: {DemThietBiTheoLoai<IThietBi>()}".PadRight(40) + "Tong gia may tinh la: " + TinhGiaTheoLoai<IThietBi>().ToString("C"));
			return str.ToString();
		}
		#endregion
		#region Truy vấn dữ liệu danh sách 👀👀👀
		public bool IsEquipment<T>()
		{
			foreach (var item in listTB)
				if (item is T)
					return true;
			return false;
		}
		private bool IsFirm(string hang)
		{
			foreach (var item in GeneralLibrary.dsHang)
				if (item.CompareTo(hang) == 0)
					return true;
			return false;
		}
		#endregion
		#region Phân loại danh sách thiết bị 👮‍♂️👮‍♂️👮‍♂️
		private List<IThietBi> DanhSachThietBiTheoLoai<T>() => listTB.Where(x => x is T).ToList();
		public float TinhTongThuocTinh<T>(Tinh tinh)
		{
			switch (tinh)
			{
				case Tinh.Speed:
					return listTB.Where(x => x is T).Sum(x => ((CPU)x).TocDo);
				case Tinh.sCapacity:
					return listTB.Where(x => x is T).Sum(x => ((RAM)x).DungLuong);
			}
			return 0;
		}
		public float TruyXuatThuocTinhThietBi(Tinh tinh)
		{
			foreach (var item in listTB)
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
		public string TruyXuatHangCuaThietBi<T>() => listTB.Find(x => x is T && (IsFirm(x.HangSX))).HangSX;
		public void CapNhapThuocTinhThietBi<T>(Tinh tinh, float obj, float obj2)
		{
			foreach (var item in DanhSachThietBiTheoLoai<T>())
				switch (tinh)
				{
					case Tinh.Speed:
						if (((CPU)item).TocDo == obj)
							((CPU)item).TocDo = obj2;
						break;
					case Tinh.sCapacity:
						if (((RAM)item).DungLuong == obj)
							((RAM)item).DungLuong = (int)obj2;
						break;
				}
		}
		#endregion
	}
}
