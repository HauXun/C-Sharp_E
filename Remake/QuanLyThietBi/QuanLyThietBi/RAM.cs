using ThuVienDungChung;

namespace QuanLyThietBi
{
	class RAM : IThietBi
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
				GeneralLibrary.Them<RAM>(value);
			}
		}
		public float Gia { get; set; }
		public float DungLuong { get; set; }
		public RAM(string line)
		{
			string[] str = line.Split(',');
			ThietBi = str[0];
			HangSX = str[1];
			TenThietBi = str[2];
			DungLuong = int.Parse(str[3]);
			Gia = float.Parse(str[4]);
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} -> {DungLuong} GB";
	}
}