using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class Mainboard : IThietBi
	{
		public string TenMayTinh { get; set; }
		public string ThietBi { get; set; }
		public string TenThietBi { get; set; }
		public string HangSX { get; set; }
		public float Gia { get; set; }
		public Mainboard(string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			Gia = float.Parse(str[3]);
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi}";
	}
}
