using System;

namespace GeometryManagement
{
	class HinhChuNhat : HinhHoc
	{
		float chieuDai;
		public float ChieuDai
		{
			get => chieuDai;
			set
			{
				chieuDai = value;
			}
		}

		float chieuRong;
		public float ChieuRong
		{
			get => chieuRong;
			set
			{
				chieuRong = value;
			}
		}

		public HinhChuNhat()
		{

		}

		public HinhChuNhat(float chieuDai, float chieuRong)
		{
			this.chieuDai = chieuDai;
			this.chieuRong = chieuRong;
			//TinhChuVi();
			//TinhDienTich();
		}
		public void Nhap()
		{
			do
			{
				Console.Write("Nhap vao chieu dai hinh chu nhat: ");
				chieuDai = float.Parse(Console.ReadLine());
				Console.Write("Nhap vao chieu rong hinh chu nhat: ");
				chieuRong = float.Parse(Console.ReadLine());
				if (chieuDai < 0 || chieuRong < 0)
				{
					Console.Write("Ban phai nhap chieu dai hoac chieu rong cua hinh chu nhat lon hon 0.");
					Console.Read();
				}
			} while (chieuDai < 0 || chieuRong < 0);
			//TinhChuVi();
			//TinhDienTich();
		}

		public override float TinhDienTich() => (float)Math.Round(chieuRong * chieuDai, 0);

		public override float TinhChuVi() => (float)Math.Round(chieuRong + chieuDai * 2, 0);

		public override string ToString() => string.Format("Hinh Chu Nhat >> \nChieu dai = {0}, Chieu rong = {1}, Dien tich = {2}, Chu vi = {3}", chieuDai, chieuRong, TinhDienTich(), TinhChuVi());
	}
}
