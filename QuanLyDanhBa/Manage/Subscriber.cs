using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Manage
{
	public enum GioiTinh
	{
		Nam,
		Nu
	}
	public class Subscriber
	{

		public string soCMND;
		public string hoTen;
		public string diaChi;
		public GioiTinh gioiTinh;
		public DateTime ngaySinh;
		public string sdt;

		public Subscriber()
		{
		}

		public Subscriber(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sdt)
		{
			this.soCMND = soCMND;
			this.hoTen = hoTen;
			this.diaChi = diaChi;
			this.gioiTinh = gioiTinh;
			this.ngaySinh = ngaySinh;
			this.sdt = sdt;
		}

		public Subscriber(string line)
		{
			string[] s = line.Split(',');
			this.soCMND = s[0].Trim();
			this.hoTen = s[1].Trim();
			this.diaChi = s[2].Trim();
			this.gioiTinh = s[3].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
			this.ngaySinh = DateTime.Parse(s[4]);
			this.sdt = s[5];
		}

		public string provincial
		{
			get
			{
				string[] ct = diaChi.Split('-');
				return ct[ct.Length - 1];
				//int index = diaChi.LastIndexOf('-');
				//return diaChi.Substring(index + 1, diaChi.Length - index - 1);
			}
		}

		public string city
		{
			get
			{
				string[] ct = diaChi.Split('-');
				return ct[ct.Length - 2];
			}
		}

		public void Output()
		{
			WriteLine("{0} {1} {2} {3} {4} {5}", soCMND, hoTen, diaChi, gioiTinh, ngaySinh, sdt);
		}

		public override string ToString()
		{
			string s = "{0} {1} {2} {3} {4} {5} \n";
			return string.Format(s, soCMND.PadRight(10), hoTen.PadRight(20), diaChi.PadRight(50), ngaySinh.ToShortDateString().PadRight(11), sdt.PadRight(15), gioiTinh);
		}
	}
}
