using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class CPU : ILinkKien
	{
		string thietBi;
		string tenThietBi;
		string hangSX;
		float gia;
		int soLuong;
		public string ThietBi { get => thietBi; set { thietBi = value; } }
		public string TenThietBi { get => tenThietBi; set { tenThietBi = value; } }
		public string HangSX { get => hangSX; set { hangSX = value; } }
		public float Gia { get => gia; set { gia = value; } }
		public int SoLuongThietBi { get => soLuong; set { soLuong = value; } }
		public CPU()
		{
		}
		public CPU (string hangSX, string tenTB, float gia)
		{
			ThietBi = "CPU";
			HangSX = hangSX;
			TenThietBi = tenTB;
			Gia = gia;
			SoLuongThietBi = 1;
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} >> Gia = {Gia.ToString("C")}";
	}
}
