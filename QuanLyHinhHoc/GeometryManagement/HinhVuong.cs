using System;

namespace GeometryManagement
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

		public HinhVuong()
		{

		}

		public HinhVuong(float canh)
		{
			this.canh = canh;
			//TinhChuVi();
			//TinhDienTich();
		}

		public void Nhap()
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
			//TinhChuVi();
			//TinhDienTich();
		}

		public float TinhDienTich() => (float)Math.Pow(canh, 2);

		public float TinhChuVi() => canh * 4;

		public override string ToString() => string.Format("Hinh Vuong >> \nCanh = {0}, Dien tich = {1}, Chu vi = {2}", canh, TinhDienTich(), TinhChuVi());
	}
}
