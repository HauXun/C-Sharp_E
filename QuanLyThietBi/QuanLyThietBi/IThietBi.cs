using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	interface IThietBi
	{
		string TenMayTinh { get; set; }
		string ThietBi { get; set; }
		string TenThietBi { get; set; }
		string HangSX { get; set; }
		float Gia { get; set; }
		float GiaCPU { get; set; }
		float GiaRAM { get; set; }
		float GiaHDD { get; set; }
		float GiaMainboard { get; set; }
		float GiaPower { get; set; }
		int SoLuongThietBi { get; set; }
		int SoLuongCPU { get; set; }
		int SoLuongRAM { get; set; }
		int SoLuongHDD { get; set; }
		int SoLuongMainboard { get; set; }
		int SoLuongPower { get; set; }
	}
}
