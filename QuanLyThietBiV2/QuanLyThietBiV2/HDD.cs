namespace QuanLyThietBiV2
{
	class HDD : CPU
	{
		public HDD(string line) : base()
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