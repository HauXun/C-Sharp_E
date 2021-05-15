using System;

namespace QuanLyHinhHoc
{
	class HinhVuong : HinhHoc
	{
		float canh;
		public float Canh
		{
			get => canh;
			set
			{
				canh = value;
			}
		}
		public HinhVuong() { }

		public HinhVuong(float canh) => this.canh = canh;
		public override HinhHoc Nhap()
		{
			do
			{
				Console.Write("Nhap vao do dai canh: ");
				canh = float.Parse(Console.ReadLine());
				if (canh < 0)
				{
					Console.Write("Ban phai nhap canh lon hon 0.");
					Console.Read();
				}
			} while (canh < 0);
			return new HinhVuong(Canh);
		}
		public override float TinhDienTich() => (float)Math.Round(canh * canh, 0);
		public override float TinhChuVi() => (float)Math.Round(canh * 4, 0);
		public override string ToString() => string.Format("Hinh Vuong >> Canh = {0}, Dien tich = {1}, Chu vi = {2}", canh, TinhDienTich(), TinhChuVi());
	}
}
