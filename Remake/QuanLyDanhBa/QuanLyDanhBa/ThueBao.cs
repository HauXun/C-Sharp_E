using System;
using System.Globalization;

namespace QuanLyDanhBa
{
	public enum GioiTinh
	{
		Nam,
		Nu
	}
	class ThueBao
	{
		private string soCMND;
		private string hoTen;
		private GioiTinh gioiTinh;
		private DateTime ngaySinh;
		private string diaChi;
		private string sdt;
		private string sdt2;
		private string ngayCungCapDV;
		private string nhaDichVu;

		public string SoCMND { get => soCMND; set => soCMND = value; }
		public string HoTen { get => hoTen; set => hoTen = value; }
		public GioiTinh GioiTinh { get => gioiTinh; set => gioiTinh = value; }
		public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public string Sdt2 { get => sdt2; set => sdt2 = value; }
		public string NgayCungCapDV { get => ngayCungCapDV; set => ngayCungCapDV = value; }
		public string NhaDichVu { get => nhaDichVu; set => nhaDichVu = value; }

		public ThueBao() { }

		public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sdt, string sdt2, string ngayCungCapDV, string nhaDichVu)
		{
			SoCMND = soCMND;
			HoTen = hoTen;
			GioiTinh = gioiTinh;
			NgaySinh = ngaySinh;
			DiaChi = diaChi;
			Sdt = sdt;
			Sdt2 = sdt2;
			NgayCungCapDV = ngayCungCapDV;
			NhaDichVu = nhaDichVu;
		}

		public ThueBao(string line)
		{
			string[] s = line.Split(',');
			SoCMND = s[0].Trim();
			HoTen = s[1].Trim();
			GioiTinh = s[2].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
			NgaySinh = DateTime.Parse(s[3].Trim(), CultureInfo.CreateSpecificCulture("fr-FR"));
			DiaChi = s[4].Trim();
			Sdt = s[5].Trim();
			Sdt2 = s[6].Trim();
			NgayCungCapDV = s[7].Trim();
			NhaDichVu = s[8].Trim();
		}

		public string Tinh
		{
			get
			{
				string[] diaChi = this.DiaChi.Split('-');
				return diaChi[diaChi.Length - 1];
			}
		}
		public string ThanhPho
		{
			get
			{
				string[] diaChi = this.DiaChi.Split('-');
				return diaChi[diaChi.Length - 2];
			}
		}


		public override string ToString() => $"{"".PadRight(5)} {SoCMND.PadRight(10)} {HoTen.PadRight(19)} {GioiTinh.ToString().PadRight(11)} {NgaySinh.ToShortDateString().PadRight(24)}" +
			$" {DiaChi.PadRight(47)} {Sdt.PadRight(12)} {Sdt2.PadRight(12)} {NgayCungCapDV.PadRight(24)} {NhaDichVu.PadRight(14)}\n";
	}
}
