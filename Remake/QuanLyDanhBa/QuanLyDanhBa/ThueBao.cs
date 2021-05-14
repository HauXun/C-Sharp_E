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
		private int sdt;
		private string ngayCungCapDV;
		private string nhaDichVu;

		public string SoCMND { get => soCMND; set => soCMND = value; }
		public string HoTen { get => hoTen; set => hoTen = value; }
		public GioiTinh GioiTinh { get => gioiTinh; set => gioiTinh = value; }
		public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }
		public int Sdt { get => sdt; set => sdt = value; }
		public string NgayCungCapDV { get => ngayCungCapDV; set => ngayCungCapDV = value; }
		public string NhaDichVu { get => nhaDichVu; set => nhaDichVu = value; }

		public ThueBao() { }

		public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, int sdt, string ngayCungCapDV, string nhaDichVu)
		{
			SoCMND = soCMND;
			HoTen = hoTen;
			GioiTinh = gioiTinh;
			NgaySinh = ngaySinh;
			DiaChi = diaChi;
			Sdt = sdt;
			NgayCungCapDV = ngayCungCapDV;
			NhaDichVu = nhaDichVu;
		}

		public ThueBao(string line)
		{
			string[] s = line.Split(',');
			SoCMND = s[0].Trim();
			HoTen = s[1].Trim();
			GioiTinh = s[2].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
			NgaySinh = DateTime.ParseExact(s[3].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
			DiaChi = s[4].Trim();
			Sdt = int.Parse(s[5].Trim());
			NgayCungCapDV = s[6].Trim();
			NhaDichVu = s[7].Trim();
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

		public override string ToString() => $" {SoCMND.PadRight(13)} {HoTen.PadRight(21)} {GioiTinh.ToString().PadRight(14)} {NgaySinh.ToShortDateString().PadRight(26)}" +
			$" {DiaChi.PadRight(49)} {Sdt.ToString().PadRight(19)} {NgayCungCapDV.PadRight(25)} {NhaDichVu.PadRight(14)}\n";
	}
}