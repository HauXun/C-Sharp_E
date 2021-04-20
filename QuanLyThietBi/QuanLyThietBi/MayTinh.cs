using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace QuanLyThietBi
{
	class MayTinh : ILinkKien, IThietBi
	{
		List<ILinkKien> list = new List<ILinkKien>();
		#region Nhập xuất định dạng và truy vấn 🚀🚀🚀
		string tenMayTinh;
		string thietBi;
		string tenThietBi;
		string hangSX;
		float gia;
		int soLuong;
		public float giaRAM, giaCPU, giaHDD;
		public string ThietBi { get => thietBi; set { thietBi = value; } }
		public string TenThietBi { get => tenThietBi; set { tenThietBi = value; } }
		public string HangSX { get => hangSX; set { hangSX = value; } }
		public float Gia { get => gia; set { gia = value; } }
		public int SoLuongThietBi { get => soLuong; set { soLuong = value; } }
		public float GiaCPU { get => giaCPU; set { giaCPU = value; } }
		public float GiaRAM { get => giaRAM; set { giaRAM = value; } }
		public float GiaHDD { get => giaHDD; set { giaHDD = value; } }
		public string TenMayTinh { get => tenMayTinh; set { tenMayTinh = value; } }
		public MayTinh()
		{
		}
		public MayTinh(string tenMayTinh, CPU c, RAM r, HDD h)
		{
			TenMayTinh = tenMayTinh;
			Them(c);
			GiaCPU = c.Gia;
			Them(r);
			GiaRAM = r.Gia;
			Them(h);
			GiaHDD = h.Gia;
		}
		public float TinhGia() => list.Sum(x => x.Gia);
		public int SLThietBi() => list.Sum(x => x.SoLuongThietBi);
		public void Them(ILinkKien x)
		{
			if (!list.Contains(x))
				list.Add(x);
		}
		public override string ToString()
		{
			string str = "\n\nMay tinh " + TenMayTinh + "\n";
			foreach (var item in list)
			{
				str += item + "\n";
			}
			str += "\tSo luong: " + SLThietBi() + "\n\tTong gia la: " + TinhGia().ToString("C");
			return str;
		}
		#endregion
		public int DemTheoLoai(Loai loai, string kieu)
		{
			switch (loai)
			{
				case Loai.HangCPU:
					return list.FindAll(x => x.ThietBi == "CPU").Count(p => p.HangSX == kieu);
				case Loai.HangRAM:
					return list.FindAll(x => x.ThietBi == "RAM").Count(p => p.HangSX == kieu);
				case Loai.HangHDD:
					return list.FindAll(x => x.ThietBi == "HDD").Count(p => p.HangSX == kieu);
				case Loai.CPU:
					return list.FindAll(x => x.ThietBi == "CPU").Count(p => p.HangSX == kieu);
				case Loai.RAM:
					return list.FindAll(x => x.ThietBi == "RAM").Count(p => p.HangSX == kieu);
				case Loai.HDD:
					return list.FindAll(x => x.ThietBi == "HDD").Count(p => p.HangSX == kieu);
			}
			return 0;
		}
		public enum Loai
		{
			TatCaHangSX,
			HangCPU,
			HangRAM,
			HangHDD,
			TatCaThietBi,
			CPU,
			RAM,
			HDD
		}
		public List<string> TimDanhSachTheoLoai(Loai loai)
		{
			List<string> result = new List<string>();
			foreach (var item in list)
			{
				switch (loai)
				{
					case Loai.TatCaHangSX:
						result.Add(item.HangSX);
						break;
					case Loai.HangCPU:
						if (item.ThietBi == "CPU")
							result.Add(item.HangSX);
						break;
					case Loai.HangRAM:
						if (item.ThietBi == "RAM")
							result.Add(item.HangSX);
						break;
					case Loai.HangHDD:
						if (item.ThietBi == "HDD")
							result.Add(item.HangSX);
						break;
					case Loai.TatCaThietBi:
						result.Add(item.ThietBi);
						break;
					case Loai.CPU:
						if (item.ThietBi == "CPU")
							result.Add("CPU");
						break;
					case Loai.RAM:
						if (item.ThietBi == "RAM")
							result.Add("RAM");
						break;
					case Loai.HDD:
						if (item.ThietBi == "HDD")
							result.Add("HDD");
						break;
				}
			}
			return result;
		}
	}
}
