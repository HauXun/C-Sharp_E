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
		private int MaxSLXH_TheoThanhPho(List<ThueBao> thueBao) => thueBao.Max(x => DemTheoThanhPho(thueBao, x.ThanhPho));
		private int MinSLXH_TheoThanhPho(List<ThueBao> thueBao) => thueBao.Min(x => DemTheoThanhPho(thueBao, x.ThanhPho));
		private int MaxSLXH_TheoSDT(List<ThueBao> thueBao) => thueBao.Max(x => DemTheoSDT(thueBao, x.Sdt, x.Sdt2));
		private int MinSLXH_TheoSDT(List<ThueBao> thueBao) => thueBao.Min(x => DemTheoSDT(thueBao, x.Sdt, x.Sdt2));

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
		public List<int> MinMaxNgayThueBaoDangKy(List<ThueBao> thueBao, MinMax minMax)
		{
			int i = 0;
			Dictionary<int, int> keys = thueBao.ToDictionary(x => i++, x => x.NgaySinh.Day);
			Dictionary<int, int> counts = new Dictionary<int, int>();
			for (int key = 0; key < keys.Max(x => x.Value); key++)
				counts.Add(key, 0);
			List<int> result = new List<int>();
			foreach (var item in thueBao)
			{
				if (keys.ContainsValue(item.NgaySinh.Day))
					counts[item.NgaySinh.Day]++;
				else
					counts.Add(item.NgaySinh.Day, 1);
			}
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
				if (item.Value == obj + 1)
					result.Add(item.Value);
			return result;
		}
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
	}
}
