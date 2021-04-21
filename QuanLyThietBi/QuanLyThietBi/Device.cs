using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class Device : ILinkKien
	{
		string tenMayTinh;
		public string TenMayTinh { get => tenMayTinh; set { tenMayTinh = value; } }
		public string ThietBi { get; set; }
		public string TenThietBi { get; set; }
		public string HangSX { get; set; }
		public float Gia { get; set; }
		public int SoLuongThietBi { get; set; }
		public Device()
		{
		}
		public Device(string tenMayTinh)
		{
			TenMayTinh = tenMayTinh;
		}
		//public Device(string line)
		//{
		//	string[] str = line.Split(',');
		//	TenMayTinh = str[1];
		//}
		public override string ToString() => $"\n\nMay tinh {TenMayTinh}".PadRight(65);
	}
}
