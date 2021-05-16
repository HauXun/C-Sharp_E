using ThuVienDungChung;

namespace QuanLyThietBi
{
	class CPU : IThietBi
	{
		public string ThietBi { get; set; }
		public string TenThietBi { get; set; }
		string hangSX;
		public string HangSX
		{
			get => hangSX;
			set
			{
				hangSX = value;
				GeneralLibrary.Them<CPU>(value);
			}
		}
		public float Gia { get; set; }
		public float TocDo { get; set; }
		public CPU() { }
		public CPU(string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			TocDo = float.Parse(str[3]);
			Gia = float.Parse(str[4]);
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} -> Speed: {TocDo} Ghz";
	}
}
