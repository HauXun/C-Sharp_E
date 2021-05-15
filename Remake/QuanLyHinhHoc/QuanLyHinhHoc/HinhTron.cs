using System;

namespace QuanLyHinhHoc
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
		public HinhTron() { }
		public HinhTron(float banKinh) => this.banKinh = banKinh;

		public override HinhHoc Nhap()
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
			return new HinhTron(BanKinh);
		}
		public override float TinhDienTich() => (float)Math.Round(Math.PI * banKinh * banKinh, 0);
		public override float TinhChuVi() => (float)Math.Round(Math.PI * 2 * banKinh, 0);
		public override string ToString() => string.Format("Hinh Tron >> Ban kinh = {0}, Dien tich = {1},  Chu vi = {2}", banKinh, TinhDienTich(), TinhChuVi());
	}
}
