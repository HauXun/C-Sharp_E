namespace QuanLyThietBiV2
{
	class RAM : CPU
	{
		public RAM(string line) : base(line)
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