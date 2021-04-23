using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class Device : IThietBi
	{
		public string TenMayTinh { get; set; }
		public string ThietBi { get; set; }
		public string TenThietBi { get; set; }
		public string HangSX { get; set; }
		public float Gia { get; set; }
		public float GiaCPU { get; set; }
		public float GiaRAM { get; set; }
		public float GiaHDD { get; set; }
		public float GiaMainboard { get; set; }
		public float GiaPower { get; set; }
		public int SoLuongThietBi { get; set; }
		public int SoLuongCPU { get; set; }
		public int SoLuongRAM { get; set; }
		public int SoLuongHDD { get; set; }
		public int SoLuongMainboard { get; set; }
		public int SoLuongPower { get; set; }
		public Device(string line)
		{
			string[] str = line.Split(',');
			TenMayTinh = str[1];
		}
		public override string ToString() => $"\n\nMay tinh {TenMayTinh}";
	}
}
