using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mang1ChieuSoNguyen
{
	class XuLyMang
	{
		#region Nhập xuất cơ bản 🚀🚀🚀
		public void Nhap(int[] a, ref int n)
		{
			WriteLine("\n Nhập vào mỗi phần tử trong mảng...");
			for (int i = 0; i < n; i++)
			{
				Write(" a[{0}] = ", i);
				a[i] = int.Parse(ReadLine());
			}
		}
		public void NhapTuDong(int[] a, ref int n)
		{
			Random random = new Random();
			for (int i = 0; i < n; i++)
				a[i] = random.Next(-10, 10);
		}
		public void Xuat(int[] a, int n)
		{
			Write("\n");
			for (int i = 0; i < n; i++)
				Write("{0, 5}", a[i]);
			WriteLine("\n Kích thước của mảng là >> " + n);
		}
		#endregion
		#region Tìm kiếm 👀👀👀
		#endregion
	}
}
