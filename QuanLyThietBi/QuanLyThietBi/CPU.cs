using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class CPU : IThietBi
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
		public CPU (string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			Gia = float.Parse(str[3]);
			GiaCPU = Gia;
			SoLuongThietBi++;
			SoLuongCPU = SoLuongThietBi;
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} - So luong: {SoLuongThietBi}".PadRight(65) + $"\t\t>> Gia = {Gia.ToString("C")}";
	}
}
