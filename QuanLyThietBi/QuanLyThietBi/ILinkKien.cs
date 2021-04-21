using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	interface ILinkKien
	{
		float TinhGia();
		float TinhGiaCPU();
		float TinhGiaRAM();
		float TinhGiaHDD();
		float TinhGiaMainboard();
		float TinhGiaPower();
		int SLThietBi();
		int SLCPU();
		int SLRAM();
		int SLHDD();
		int SLMainboard();
		int SLPower();
	}
}
