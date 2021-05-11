using System.Collections.Generic;
using System.Linq;

namespace Mang1ChieuSoNguyen
{
	static class ExtensionMethod
	{
		public enum MinMax
		{
			Min,
			Max
		}
		public static List<T> Mode<T>(this IEnumerable<T> list, MinMax minMax)
		{
			// Khởi tạo giá trị trả về
			T mode = default(T);
			List<T> result = new List<T>();

			// Kiểm tra tham chiếu rỗng và danh sách trống
			if (list != null && list.Count() > 0)
			{
				// Lưu trử số lần xuất hiện cho mỗi phần tử
				Dictionary<T, int> counts = new Dictionary<T, int>();

				// Tăng 1 lần vào counts cho sự lần xuất hiện của 1 kí tự
				foreach (T element in list)
				{
					if (counts.ContainsKey(element))
						counts[element]++;
					else
						counts.Add(element, 1);
				}

				// Lặp lại số lần xuất hiện và tìm ra phần tử xuất hiện nhiều nhất
				int obj = 0;
				foreach (KeyValuePair<T, int> count in counts)
				{
					switch (minMax)
					{
						case MinMax.Min:
							if (count.Value < obj)
							{
								mode = count.Key;
								obj = count.Value;
							}
							break;
						case MinMax.Max:
							if (count.Value > obj)
							{
								mode = count.Key;
								obj = count.Value;
							}
							break;
					}
				}
				foreach (KeyValuePair<T, int> item in counts)
				{
					switch (minMax)
					{
						case MinMax.Min:
							// Default is 0 so add 1 to consider the least number of impressions
							if (item.Value == obj + 1)
								result.Add(item.Key);
							break;
						case MinMax.Max:
							if (item.Value == obj)
								result.Add(item.Key);
							break;
					}
				}
			}
			return result;
		}
	}
}
