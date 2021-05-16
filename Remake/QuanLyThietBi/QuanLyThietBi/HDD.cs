using ThuVienDungChung;

namespace QuanLyThietBi
{
	class HDD : IThietBi
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
				GeneralLibrary.Them<HDD>(value);
			}
		}
		public float Gia { get; set; }
		public HDD(string line)
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