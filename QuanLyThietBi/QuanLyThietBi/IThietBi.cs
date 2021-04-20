using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	interface IThietBi
	{
		float TinhGia();
		int SLThietBi();
		public float GiaCPU { get; set; }
		public float GiaRAM { get; set; }
		public float GiaHDD { get; set; }
	}
}
