using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	interface IThietBi
	{
		public string TenMayTinh { get; set; }
		string ThietBi { get; set; }
		string TenThietBi { get; set; }
		string HangSX { get; set; }
		float Gia { get; set; }
		public float GiaCPU { get; set; }
		public float GiaRAM { get; set; }
		public float GiaHDD { get; set; }
		public float GiaMainboard { get; set; }
		public float GiaPower { get; set; }
		int SoLuongThietBi { get; set; }
		int SoLuongCPU { get; set; }
		int SoLuongRAM { get; set; }
		int SoLuongHDD { get; set; }
		int SoLuongMainboard { get; set; }
		int SoLuongPower { get; set; }
	}
}
