using ThuVienDungChung;

namespace QuanLyThietBi
{
	class PSU : IThietBi
	{
		public string ThietBi { get; set; }
		public string TenThietBi { get; set; }
		private string hangSX;
		public string HangSX
		{
			get => hangSX;
			set
			{
				hangSX = value;
				GeneralLibrary.Them<PSU>(value);
			}
		}
		public float Gia { get; set; }
		public PSU(string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			Gia = float.Parse(str[3]);
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi}";
	}
}
