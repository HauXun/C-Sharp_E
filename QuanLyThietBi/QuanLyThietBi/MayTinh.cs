using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace QuanLyThietBi
{
	class MayTinh : ILinkKien
	{
		List<IThietBi> list = new List<IThietBi>();
		#region Nhập xuất định dạng và truy vấn 🚀🚀🚀
		public MayTinh()
		{
		}
		public float TinhGia() => list.Sum(x => x.Gia);
		public int SLThietBi() => list.Sum(x => x.SoLuongThietBi);
		public float TinhGiaCPU() => list.Sum(x => x.GiaCPU);
		public float TinhGiaRAM() => list.Sum(x => x.GiaRAM);
		public float TinhGiaHDD() => list.Sum(x => x.GiaHDD);
		public float TinhGiaMainboard() => list.Sum(x => x.GiaMainboard);
		public float TinhGiaPower() => list.Sum(x => x.GiaPower);
		public int SLCPU() => list.Sum(x => x.SoLuongCPU);
		public int SLRAM() => list.Sum(x => x.SoLuongRAM);
		public int SLHDD() => list.Sum(x => x.SoLuongHDD);
		public int SLMainboard() => list.Sum(x => x.SoLuongMainboard);
		public int SLPower() => list.Sum(x => x.SoLuongPower);
		public void Them(IThietBi x)
		{
			list.Add(x);
		}
		public override string ToString()
		{
			string str = null;
			foreach (var item in list)
			{
				str += item + "\n";
			}
			str += "\tTong so luong thiet bi: " + SLThietBi() + "\n\tTong gia la: " + TinhGia().ToString("C");
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
			HDD,
			HangMayTinh
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
					case Loai.HangMayTinh:
						result.Add(item.TenMayTinh);
						break;
				}
			}
			return result;
		}
	}
}
