using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace QuanLyThietBi
{
	class MayTinh : IThietBi
	{
		List<ILinkKien> listLinkKien = new List<ILinkKien>();
		public float giaRAM, giaCPU, giaHDD;
		public float GiaCPU { get { return giaCPU; } set { giaCPU = value; } }
		public float GiaRAM { get { return giaRAM; } set { giaRAM = value; } }
		public float GiaHDD { get { return giaHDD; } set { giaHDD = value; } }

		string tenMayTinh;
		public string TenMayTinh
		{
			get => tenMayTinh;
			set
			{
				tenMayTinh = value;
			}
		}
		public MayTinh()
		{
		}
		public MayTinh(string tenMayTinh , CPU c, RAM r, HDD h)
		{
			TenMayTinh = tenMayTinh;
			Them(c);
			giaCPU = c.Gia;
			Them(r);
			giaRAM = r.Gia;
			Them(h);
			giaHDD = h.Gia;
		}
		public void Them(ILinkKien x)
		{
			if (!listLinkKien.Contains(x))
				listLinkKien.Add(x);
		}

		public float TinhGia() => listLinkKien.Sum(x => x.Gia);

		public override string ToString()
		{
			string str = "\n\nMay tinh " + TenMayTinh + "\n";
			foreach (var item in listLinkKien)
			{
				str += item + "\n";
			}
			str += " Tong gia la: " + TinhGia().ToString("C");
			return str;
		}

		public int DemTheoHang(string hang) => listLinkKien.Count(x => x.HangSX == hang);

		public List<string> TimDanhSachTheoLoai(int loai)
		{
			List<string> result = new List<string>();
			foreach (var item in listLinkKien)
			{
				switch (loai)
				{
					case 0:
						result.Add(item.HangSX);
						break;
					case 1:
						result.Add(item.ThietBi);
						break;
				}
			}
			return result;
		}
	}
}
