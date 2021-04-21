using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class Power : ILinkKien
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
		public Power()
		{
		}
		public Power(string thietBi, string hangsX, string tenThietBi, float gia)
		{
			ThietBi = thietBi;
			HangSX = hangsX;
			TenThietBi = tenThietBi;
			Gia = gia;
			SoLuongThietBi++;
		}
		public Power(string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			Gia = float.Parse(str[3]);
			SoLuongThietBi++;
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} - So luong: {SoLuongThietBi}".PadRight(65) + $"\t\t>> Gia = {Gia.ToString("C")}";
	}
}
