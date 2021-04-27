using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class RAM : CPU
	{
		public RAM(string line) : base(line)
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
