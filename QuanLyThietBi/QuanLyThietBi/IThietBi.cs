using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	interface IThietBi
	{
		string ThietBi { get; set; }
		string TenThietBi { get; set; }
		string HangSX { get; set; }
		float Gia { get; set; }
	}
}
