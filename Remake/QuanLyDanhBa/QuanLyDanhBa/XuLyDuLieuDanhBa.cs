using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyDanhBa
{
	class XuLyDuLieuDanhBa
	{
		#region Tìm kiếm 🕵️‍♀️🕵️‍♀️🕵️‍♀️
		public List<string> ThanhPhoNhieuThueBaoNhat(List<ThueBao> thueBao)
		{
			List<string> result = new List<string>();
			foreach (var item in thueBao)
				if (DemTheoThanhPho(thueBao, item.ThanhPho) == MaxSLXH_TheoThanhPho(thueBao) && !result.Contains(item.ThanhPho))
					result.Add(item.ThanhPho);
			return result;
		}
		public List<string> ThanhPhoItThueBaoNhat(List<ThueBao> thueBao)
		{
			List<string> result = new List<string>();
			foreach (var item in thueBao)
				if (DemTheoThanhPho(thueBao, item.ThanhPho) == MinSLXH_TheoThanhPho(thueBao) && !result.Contains(item.ThanhPho))
					result.Add(item.ThanhPho);
			return result;
		}
		public List<ThueBao> ThueBaoItSDTNhat(List<ThueBao> thueBao)
		{
			List<ThueBao> result = new List<ThueBao>();
			foreach (var item in thueBao)
				if (DemTheoSDT(thueBao, item.Sdt, item.Sdt2) == MinSLXH_TheoSDT(thueBao) && !result.Contains(item))
					result.Add(item);
			return result;
		}
		public List<ThueBao> ThueBaoNhieuSDTNhat(List<ThueBao> thueBao)
		{
			List<ThueBao> result = new List<ThueBao>();
			foreach (var item in thueBao)
				if (DemTheoSDT(thueBao, item.Sdt, item.Sdt2) == MaxSLXH_TheoSDT(thueBao) && !result.Contains(item))
					result.Add(item);
			return result;
		}
		public enum MinMax
		{
			Max,
			Min
		}
		public Dictionary<int, int> MinMaxNgayThueBaoDangKy(List<ThueBao> thueBao, MinMax minMax)
		{
			int i = 0;
			Dictionary<int, int> keys = thueBao.ToDictionary(x => i++, x => x.NgaySinh.Day);
			Dictionary<int, int> counts = new Dictionary<int, int>();
			foreach (var item in thueBao)
				if (!counts.ContainsKey(item.NgaySinh.Day))
					counts.Add(item.NgaySinh.Day, 0);
			Dictionary<int, int> result = new Dictionary<int, int>();
			foreach (var item in thueBao)
				if (keys.ContainsValue(item.NgaySinh.Day))
					counts[item.NgaySinh.Day]++;
			int obj = 0;
			switch (minMax)
			{
				case MinMax.Max:
					obj = counts.Max(x => x.Value);
					break;
				case MinMax.Min:
					obj = counts.Min(x => x.Value);
					break;
			}
			foreach (KeyValuePair<int, int> item in counts)
				if (item.Value == obj)
					result.Add(item.Key, 0);
			return result;
		}
		public List<int> ThangKhongCoThueBaoDangKy(List<ThueBao> thueBao)
		{
			List<int> result = new List<int>();
			List<int> month = new List<int>();
			foreach (var item in thueBao)
				if (!month.Contains(item.NgaySinh.Month))
					month.Add(item.NgaySinh.Month);
			for (int i = 1; i <= 12; i++)
				if (!month.Contains(i))
					result.Add(i);
			return result;
		}
		public List<ThueBao> TimThueBaoTheoGioiTinh(List<ThueBao> thueBao, GioiTinh gioiTinh) => thueBao.FindAll(x => x.GioiTinh == gioiTinh);
		public List<ThueBao> ThueBaoCoDinh(List<ThueBao> thueBao) => thueBao.FindAll(x => x.NgayCungCapDV != "Empty");
		public List<ThueBao> ThueBaoDiDong(List<ThueBao> thueBao) => thueBao.FindAll(x => x.NhaDichVu != "Empty");
		public List<string> ThanhPhoNhieuThueBaoCoDinhNhat(List<ThueBao> thueBao) => ThanhPhoNhieuThueBaoNhat(ThueBaoCoDinh(thueBao));
		public List<string> ThanhPhoItThueBaoCoDinhNhat(List<ThueBao> thueBao) => ThanhPhoItThueBaoNhat(ThueBaoCoDinh(thueBao));
		public List<string> ThanhPhoNhieuThueBaoDiDong(List<ThueBao> thueBao) => ThanhPhoNhieuThueBaoNhat(ThueBaoDiDong(thueBao));
		public List<string> ThanhPhoItThueBaoDiDong(List<ThueBao> thueBao) => ThanhPhoItThueBaoNhat(ThueBaoDiDong(thueBao));
		public List<ThueBao> ThueBaoNhieuSDTCoDinh(List<ThueBao> thueBao) => ThueBaoNhieuSDTNhat(ThueBaoCoDinh(thueBao));
		public List<ThueBao> ThueBaoItSDTCoDinh(List<ThueBao> thueBao) => ThueBaoItSDTNhat(ThueBaoCoDinh(thueBao));
		public List<ThueBao> ThueBaoNhieuSDTDiDong(List<ThueBao> thueBao) => ThueBaoNhieuSDTNhat(ThueBaoDiDong(thueBao));
		public List<ThueBao> ThueBaoItSDTDiDong(List<ThueBao> thueBao) => ThueBaoItSDTNhat(ThueBaoDiDong(thueBao));
		private Dictionary<int, int> ThangKhongCoDangKy(List<ThueBao> thueBao)
		{
			int i = 0;
			Dictionary<int, int> keys = thueBao.ToDictionary(x => i++, x => x.NgaySinh.Month);
			Dictionary<int, int> counts = new Dictionary<int, int>();
			foreach (var item in thueBao)
				if (!counts.ContainsKey(item.NgaySinh.Month))
					counts.Add(item.NgaySinh.Month, 0);
			Dictionary<int, int> result = new Dictionary<int, int>();
			foreach (var item in thueBao)
				if (keys.ContainsValue(item.NgaySinh.Month))
					counts[item.NgaySinh.Month]++;
			int khongco = counts.Min(x => x.Value);
			foreach (KeyValuePair<int, int> item in counts)
				if (item.Value == khongco)
					result.Add(item.Key, 0);
			return result;
		}
		public List<int> ThangKhongCoDangKyCoDinh(List<ThueBao> thueBao) => ThangKhongCoDangKy(ThueBaoCoDinh(thueBao)).Keys.ToList();
		public List<int> ThangKhongCoDangKyDiDong(List<ThueBao> thueBao) => ThangKhongCoDangKy(ThueBaoDiDong(thueBao)).Keys.ToList();
		public List<ThueBao> ThueBaoCoDinhTheoGioiTinh(List<ThueBao> thueBao, GioiTinh gioiTinh) => TimThueBaoTheoGioiTinh(ThueBaoCoDinh(thueBao), gioiTinh);
		public List<ThueBao> ThueBaoDiDongTheoGioiTinh(List<ThueBao> thueBao, GioiTinh gioiTinh) => TimThueBaoTheoGioiTinh(ThueBaoCoDinh(thueBao), gioiTinh);
		#endregion
		#region Sắp xếp 👩‍⚖️👩‍⚖️👩‍⚖️
		public void TangTheoHoTen(List<ThueBao> thueBao) => thueBao.Sort((x, y) => x.HoTen.CompareTo(y.HoTen));
		public void GiamTheoHoTen(List<ThueBao> thueBao) => thueBao.Sort((x, y) => y.HoTen.CompareTo(x.HoTen));
		public void TangTheoSLDT(List<ThueBao> thueBao) => thueBao.Sort((x, y) => DemTheoSDT(thueBao, x.Sdt, x.Sdt2).CompareTo(DemTheoSDT(thueBao, y.Sdt, y.Sdt2)));
		private void Swap<T>(IList<T> list, int iA, int iB)
		{
			T c = list[iA];
			list[iA] = list[iB];
			list[iB] = c;
		}
		public void GiamTheoSLDT(List<ThueBao> thueBao)
		{
			for (int i = 0; i < thueBao.Count - 1; i++)
				for (int j = i + 1; j < thueBao.Count; j++)
					if (DemTheoSDT(thueBao, thueBao[i].Sdt, thueBao[i].Sdt2) < (DemTheoSDT(thueBao, thueBao[j].Sdt, thueBao[j].Sdt2)))
						Swap(thueBao, i, j);
		}
		public void TangThanhPhoTheoSLTB(List<ThueBao> thueBao) => thueBao.Sort((x, y) => DemTheoThanhPho(thueBao, x.ThanhPho).CompareTo(DemTheoThanhPho(thueBao, y.ThanhPho)));
		public void GiamThanhPhoTheoSLTB(List<ThueBao> thueBao) => thueBao.Sort((x, y) => DemTheoThanhPho(thueBao, y.ThanhPho).CompareTo(DemTheoThanhPho(thueBao, x.ThanhPho)));
		#endregion
		#region Xóa 🚩🚩🚩
		public void XoaTheoDiaChi(List<ThueBao> thueBao, string diaChi) => thueBao.RemoveAll(x => string.Compare(x.DiaChi, diaChi, true) == 0);
		public void XoaTheoNgayLapDat(List<ThueBao> thueBao, int ngay)
		{
			List<ThueBao> copy = new List<ThueBao>(thueBao);
			foreach (var item in copy)
			{
				if (item.NgayCungCapDV != "Empty")
				{
					string[] ngayThangNam = item.NgayCungCapDV.Split('/');
					int ngayLapDat = int.Parse(ngayThangNam[0]);
					if (ngayLapDat == ngay)
						thueBao.Remove(item);
				}
			}
		}
		public void XoaTheoNhaDichVu(List<ThueBao> thueBao, string nhaDV) => thueBao.RemoveAll(x => string.Compare(x.NhaDichVu, nhaDV, true) == 0);
		#endregion
		#region Khác 👩‍🏫👩‍🏫👩‍🏫
		public void ThemSDTNeuSinhThang1(List<ThueBao> thueBao)
		{
			List<ThueBao> copy = new List<ThueBao>(thueBao);
			foreach (var item in copy)
			{
				if (item.NgaySinh.Month == 1)
				{
					if (item.Sdt == "Empty")
						item.Sdt = item.SoCMND;
					else if (item.Sdt2 == "Empty")
						item.Sdt2 = item.SoCMND;
					else
						item.Sdt2 += $" - {item.SoCMND}";
				}	
			}
		}
		private List<string> DanhSachCMNDTheoThanhPho(List<ThueBao> thueBao, string thanhpho)
		{
			List<string> result = new List<string>();
			foreach (var item in thueBao)
				if (item.ThanhPho == thanhpho)
					result.Add(item.SoCMND);
			return result;
		}
		private List<string> DanhSachCacTinh(List<ThueBao> thueBao)
		{
			List<string> result = new List<string>();
			foreach (var item in thueBao)
				if (!result.Contains(item.Tinh))
					result.Add(item.Tinh);
			return result;
		}
		private List<string> TimDanhSachThanhPhoTheoTinh(List<ThueBao> thueBao, string tinh)
		{
			List<string> result = new List<string>();
			foreach (var item in thueBao)
				if (!result.Contains(item.ThanhPho) && item.Tinh == tinh)
					result.Add(item.ThanhPho);
			return result;
		}
		private int TongThueBaoTheoTinh(List<ThueBao> thueBao, string tinh) => TimDanhSachThanhPhoTheoTinh(thueBao, tinh).Sum(x => DemTheoThanhPho(thueBao, x));
		private string XuatChuoiSDTThueBaoTheoSoCMND(List<ThueBao> thueBao, string soCMND, int stt)
		{
			string result = "\t\t";
			foreach (var sub in thueBao)
				if (sub.SoCMND == soCMND)
				{
					result += $"{"Số điện thoại thuê bao"} {stt} >> ";
					foreach (var subs in thueBao)
						if (subs.SoCMND == soCMND)
							result += $"{subs.Sdt} - {subs.Sdt2}";
					result += "\n";
				}
			return result;
		}
		private List<ThueBao> DanhSachThueBaoTheoThanhPho(List<ThueBao> thueBao, string thanhpho) => thueBao.FindAll(x => x.ThanhPho == thanhpho);
		private void ThọngKeTheoTinh(List<ThueBao> thueBao, string tinh)
		{
			string result = "\n";
			int stt = 1;
			List<string> cityList = TimDanhSachThanhPhoTheoTinh(thueBao, tinh);
			List<string> idList = new List<string>();
			result += "Tỉnh: " + tinh + " - Tổng số thuê bao: " + TongThueBaoTheoTinh(thueBao, tinh) + "\n";
			foreach (var city in cityList)
			{
				result += "\t" + "Thành phố: " + city + " - Tổng số thuê bao: " + DemTheoThanhPho(thueBao, city) + "\n";
				idList = DanhSachCMNDTheoThanhPho(thueBao, city);
				foreach (var id in idList)
				{
					result += XuatChuoiSDTThueBaoTheoSoCMND(thueBao, id, stt);
					stt++;
				}
			}
			Console.WriteLine(result);
			foreach (var cityOut in cityList)
			{
				Console.WriteLine("".PadRight(190, '='));
				foreach (var item in DanhSachThueBaoTheoThanhPho(thueBao, cityOut))
					Console.Write(item);
			}
		}
		public void ThongKeDuLieu(List<ThueBao> thueBao)
		{
			List<string> dsThueBao = new List<string>();
			dsThueBao = DanhSachCacTinh(thueBao);
			foreach (var item in dsThueBao)
			{
				ThọngKeTheoTinh(thueBao, item);
				Console.WriteLine("".PadRight(190, '='));
				Console.Write("\n\n\n\n".PadRight(10, '-') + "Next".PadRight(10, '-'));
			}
		}
		#endregion
		#region Đếm 👨‍🎓👨‍🎓👨‍🎓
		private int DemTheoThanhPho(List<ThueBao> thueBao, string thanhpho) => thueBao.Count(x => x.ThanhPho == thanhpho);
		private int DemTheoSDT(List<ThueBao> thueBao, string sdt, string sdt2) => thueBao.Count(x => (x.Sdt != "Empty" && x.Sdt2 != "Empty" && x.Sdt == sdt && x.Sdt2 == sdt2)) + 1;
		//	if (sdt == "Empty" && sdt2 == "Empty")
		//		return 0;
		#endregion
		#region MinMax 🚏🚏🚏
		private int MaxSLXH_TheoThanhPho(List<ThueBao> thueBao) => thueBao.Max(x => DemTheoThanhPho(thueBao, x.ThanhPho));
		private int MinSLXH_TheoThanhPho(List<ThueBao> thueBao) => thueBao.Min(x => DemTheoThanhPho(thueBao, x.ThanhPho));
		private int MaxSLXH_TheoSDT(List<ThueBao> thueBao) => thueBao.Max(x => DemTheoSDT(thueBao, x.Sdt, x.Sdt2));
		private int MinSLXH_TheoSDT(List<ThueBao> thueBao) => thueBao.Min(x => DemTheoSDT(thueBao, x.Sdt, x.Sdt2));
		#endregion
	}
}
