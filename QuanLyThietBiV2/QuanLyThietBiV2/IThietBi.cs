namespace QuanLyThietBiV2
{
	interface IThietBi
	{
		string ThietBi { get; set; }
		string TenThietBi { get; set; }
		string HangSX { get; set; }
		float Gia { get; set; }
		public float TocDo { get; set; }
		public int DungLuong { get; set; }
	}
}
