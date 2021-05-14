using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				if (DemTheoSDT(thueBao, item.Sdt, item.Sdt2) == MaxSLXH_TheoSDT(thueBao) && !result.Contains(item))
					result.Add(item);
			return result;
		}
		public List<ThueBao> ThueBaoNhieuSDTNhat(List<ThueBao> thueBao)
		{
			List<ThueBao> result = new List<ThueBao>();
			foreach (var item in thueBao)
				if (DemTheoSDT(thueBao, item.Sdt, item.Sdt2) == MinSLXH_TheoSDT(thueBao) && !result.Contains(item))
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
		#endregion
		#region Sắp xếp 👩‍⚖️👩‍⚖️👩‍⚖️
		#endregion
		#region Xóa 🚩🚩🚩
		#endregion
		#region Khác 👩‍🏫👩‍🏫👩‍🏫
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
