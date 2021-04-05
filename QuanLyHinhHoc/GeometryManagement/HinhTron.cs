using System;

namespace GeometryManagement
{
	class HinhTron : HinhHoc
	{
		float banKinh;
		public float BanKinh
		{
			get => banKinh;
			set
			{
				banKinh = value;
			}
		}
		public HinhTron()
		{

		}

		public HinhTron(float banKinh)
		{
			this.banKinh = banKinh;
			//TinhChuVi();
			//TinhDienTich();
		}

		public void Nhap()
		{
			do
			{
				Console.Write("Nhap vao do dai ban kinh: ");
				banKinh = float.Parse(Console.ReadLine());
				if (banKinh < 0)
				{
					Console.Write("Ban phai nhap ban kinh lon hon 0.");
					Console.Read();
				}
			} while (banKinh < 0);
			//TinhChuVi();
			//TinhDienTich();
		}
		public float TinhDienTich() => (float)Math.PI * banKinh * banKinh;

		public float TinhChuVi() => (float)Math.PI * 2 * banKinh;

		public override string ToString() => string.Format("Hinh Tron >> \nBan kinh = {0}, Dien tich = {1},  Chu vi = {2}", banKinh, TinhDienTich(), TinhDienTich());
	}
}
