using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class RAM : ILinkKien
	{
		string thietBi;
		string tenThietBi;
		string hangSX;
		float gia;
		public string ThietBi { get => thietBi; set { thietBi = value; } }
		public string TenThietBi { get => tenThietBi; set { tenThietBi = value; } }
		public string HangSX { get => hangSX; set { hangSX = value; } }
		public float Gia { get => gia;  set { gia = value; } }
		public RAM()
		{
		}
		public RAM(string hangSX, string tenTB, float gia)
		{
			ThietBi = "RAM";
			HangSX = hangSX;
			TenThietBi = tenTB;
			Gia = gia;
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} >> Gia = {Gia.ToString("C")}";
	}
}
