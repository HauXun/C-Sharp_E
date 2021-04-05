using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Manage
{
	public class SapXepContactTangDanTheoHoTen : IComparer<Subscriber>
	{
		public int Compare(Subscriber x, Subscriber y)
		{
			return x.hoTen.CompareTo(y.hoTen);
		}
	}

	public class Contacts
	{
		// Subscriber[] a = new Subscriber[100];
		List<Subscriber> a = new List<Subscriber>();

		public int length { get { return a.Count; } }

		public void InsertLast(Subscriber x)
		{
			a.Add(x);
			// a[length++] = x;
		}

		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"data.txt";
			Write("Enter your txt file name to open it: ");
			string keyOpen = ReadLine().ToLower();
			string keyWord = ".txt";
			string a;
			if (keyOpen.Contains('.'))
				a = $@"{keyOpen}";
			else
				a = $@"{keyOpen + keyWord}";
			if (a != path)
			{
				Write("\nFail! Please try...");
				Read();
				return;
			}
			else
				Write("\nAccess...");
			StreamReader file = new StreamReader(a);
			string s;
			while ((s = file.ReadLine()) != null)
				InsertLast(new Subscriber(s));
		}

		public void WriteFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"data.txt";
			Write("Enter your txt file name to open it: ");
			string keyOpen = ReadLine().ToLower();
			string keyWord = ".txt";
			string a;
			if (keyOpen.Contains('.'))
				a = $@"{keyOpen}";
			else
				a = $@"{keyOpen + keyWord}";
			if (a != path)
			{
				Write("\nFail! Please try...");
				Read();
				return;
			}
			else
				Write("\nAccess...");
			string str = "";
			WriteLine("\nStart enter a contact...\n");
			Write("\nNhap so CMND: ");
			string soCMND = ReadLine();
			Write("\nNhap ho va ten: ");
			string hoTen = ReadLine();
			Write("\nNhap dia chi: ");
			string diaChi = ReadLine();
			Write("\nNhap gioi tinh: ");
			GioiTinh gioiTinh = ReadLine().Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
			Write("\nNhap ngay thang nam sinh (mm/dd/yyy): ");
			DateTime ngaySinh = DateTime.Parse(ReadLine());
			Write("\nNhap so dien thoai: ");
			string sdt = ReadLine();

			str += "\r\n" + soCMND + ", " + hoTen + ", " + diaChi + ", " + gioiTinh + ", " + ngaySinh + ", " + sdt;
			StreamWriter file = new StreamWriter(new FileStream(a, FileMode.Append, FileAccess.Write));

			file.Write(str);
			file.Flush();
			file.Close();
		}

		//public override string ToString()
		//{
		//	string s = "";
		//	for (int i = 0; i < length; i++)
		//	{
		//		int k = i + 1;
		//		s += k.ToString() + ". " + a[i];
		//	}
		//	return s;
		//}

		public void Output()
		{
			WriteLine("".PadRight(120, '='));
			WriteLine("ID Code".PadRight(11) + "Full Name".PadRight(21) + "Adreass".PadRight(51) + "DoB".PadRight(13) + "Number Phone".PadRight(15) + "Gender");
			WriteLine("".PadRight(120, '='));
			for (int i = 0; i < length; i++)
			{
				Write($"{a[i]}");
			}
			WriteLine("".PadRight(120, '='));
		}

		public int CountPhoneNumbersByID(string cmnd)
		{
			int count = 0;
			for (int i = 0; i < length; i++)
			{
				if (String.Compare(a[i].soCMND, cmnd, true) == 0)
					count++;
			}
			return count;
		}

		public int FindTheMostAppearances()
		{
			int max = -1;
			for (int i = 0; i < length; i++)
			{
				int count = CountPhoneNumbersByID(a[i].soCMND);
				if (count > max)
					max = count;
			}
			return max;
		}

		public bool CheckExist(Subscriber x)
		{
			for (int i = 0; i < length; i++)
			{
				if (a[i].soCMND == x.soCMND)
					return true;
			}
			return false;
		}

		public Contacts FindSub_TheMostPhoneNumbers()
		{
			Contacts result = new Contacts();
			int max = FindTheMostAppearances();
			for (int i = 0; i < length; i++)
			{
				if (CountPhoneNumbersByID(a[i].soCMND) == max && !result.CheckExist(a[i]))
					result.InsertLast(a[i]);
			}
			return result;
		}

		public enum TypeSort
		{
			UpByFullName,
			DownByFullName,
			UpByDoB,
			DownByDoB
		}

		public int CheckCondition(Subscriber a, Subscriber b, TypeSort k)
		{
			switch (k)
			{
				case TypeSort.UpByFullName:
					//return (a.hoTen.CompareTo(b.hoTen));
					return (String.Compare(a.hoTen, b.hoTen, true));
				case TypeSort.DownByFullName:
					//return (b.hoTen.CompareTo(a.hoTen));
					return (String.Compare(b.hoTen, a.hoTen, true));
				case TypeSort.UpByDoB:
					return (a.ngaySinh > b.ngaySinh ? 1 : 0);
				case TypeSort.DownByDoB:
					return (b.ngaySinh > a.ngaySinh ? 1 : 0);
			}
			return 0;
		}

		public void Sort(TypeSort k)
		{
			for (int i = 0; i < length - 1; i++)
			{
				for (int j = i + 1; j < length; j++)
				{
					if (CheckCondition(a[i], a[j], k) > 0)
					{
						Subscriber c = a[i];
						a[i] = a[j];
						a[j] = c;
					}
				}
			}
		}
		public void SortUpByName()
		{
			Sort(TypeSort.UpByFullName);
		}

		public void SortDownByDoB()
		{
			Sort(TypeSort.DownByDoB);
		}

		#region Tìm thành phố có nhiều thuê bao nhất/ ít nhất

		public string GetcityNameFromAddress(string address)
		{
			int index = address.LastIndexOf('-');
			return address.Substring(index + 1, address.Length - index - 1);
		}

		/// Tìm danh sách các thành phố xuất hiện trong danh sách khách hàng
		//public string[] DanhSachThanhPho()
		//{
		//	string city = "";
		//	for (int i = 0; i < length; i++)
		//	{
		//		if (!city.Contains(GetcityNameFromAddress(a[i].diaChi)))
		//			city += GetcityNameFromAddress(a[i].diaChi) + ",";
		//	}
		//	string[] result = city.Split(',');
		//	return result;
		//}

		public List<string> DanhSachThanhPho()
		{
			List<string> result = new List<string>();
			for (int i = 0; i < length; i++)
			{
				if (!result.Contains(GetcityNameFromAddress(a[i].diaChi)))
					result.Add(GetcityNameFromAddress(a[i].diaChi));
			}
			return result;
		}

		/// Tìm danh sách CMND dựa vào tên thành phố trong danh sách
		//public string[] FindIDList_ByCity(string city)
		//{
		//	string id = "";
		//	for (int i = 0; i < length; i++)
		//	{
		//		if (GetcityNameFromAddress(a[i].diaChi) == city)
		//			id += a[i].soCMND + ",";
		//	}
		//	string[] result = id.Split(',');
		//	return result;
		//}

		public List<string> FindIDList_ByCity(string city)
		{
			List<string> result = new List<string>();
			foreach (var item in a)
				if (item.city == city)
					result.Add(item.soCMND);
			return result;
		}

		/// Tìm danh sách thuê bao mà mỗi người sử dụng
		public List<Subscriber> FindListSub_ByID(string cmnd)
		{
			List<Subscriber> listContacts = new List<Subscriber>();
			for (int i = 0; i < length; i++)
			{
				if (a[i].soCMND.Contains(cmnd))
					listContacts.Add(a[i]);
			}
			//string[] result = listContacts.Split(',');
			return listContacts;
		}

		/// Tính tổng số thuê bao có trong thành phố
		public int SumOfContacts_ByCity(string city)
		{
			int result = 0;
			//string[] idList = FindIDList_ByCity(city);
			List<string> idList = FindIDList_ByCity(city);
			foreach (var item in idList)
				result += FindListSub_ByID(item).Count;
			return result;
		}

		/// Tìm danh sách các thành phố có nhiều thuê bao nhất
		public List<string> FindCityList_TheMostContacts()
		{
			List<string> result = new List<string>();
			//string[] cityList = DanhSachThanhPho();
			List<string> cityList = DanhSachThanhPho();
			int max = int.MinValue;
			int temp;
			foreach (var item in cityList)
			{
				temp = SumOfContacts_ByCity(item);
				if (temp > max)
					max = temp;
			}
			foreach (var item in cityList)
				if (SumOfContacts_ByCity(item) == max)
				{
					if (!result.Contains(item))
						result.Add(item);
				}
			return result;
		}

		/// Tìm danh sách các thành phố có ít thuê bao nhất
		public List<string> FindCityList_AtLeastContacts()
		{
			List<string> result = new List<string>();
			//string[] cityList = DanhSachThanhPho();
			List<string> cityList = DanhSachThanhPho();
			int min = int.MaxValue;
			int temp;
			foreach (var item in cityList)
			{
				temp = SumOfContacts_ByCity(item);
				if (temp < min)
					min = temp;
			}
			foreach (var item in cityList)
				if (SumOfContacts_ByCity(item) == min)
				{
					if (!result.Contains(item))
						result.Add(item);
				}
			return result;
		}
		#endregion

		public int CountSubByCity(string city)
		{
			int count = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i].city == city)
					count++;
			}
			return count;
		}

		public int CountSubByID(string id)
		{
			int count = 0;
			for (int i = 0; i < length; i++)
			{
				if (a[i].soCMND == id)
					count++;
			}
			return count;
		}

		public int FindTheMostOccurrencesBycity()
		{
			int max = int.MinValue;
			for (int i = 0; i < length; i++)
			{
				if (max < CountSubByCity(a[i].city))
					max = CountSubByCity(a[i].city);
			}
			return max;
		}

		public int FindAtLeastOccurrencesBycity()
		{
			int min = int.MaxValue;
			for (int i = 0; i < length; i++)
			{
				if (min > CountSubByCity(a[i].city))
					min = CountSubByCity(a[i].city);
			}
			return min;
		}

		public int FindAtLeastOccurrencesByID()
		{
			int min = int.MaxValue;
			for (int i = 0; i < length; i++)
			{
				if (min > CountSubByID(a[i].soCMND))
					min = CountSubByID(a[i].soCMND);
			}
			return min;
		}

		public List<string> FindCity_TheMostSub()
		{
			List<string> result = new List<string>();
			int max = FindTheMostOccurrencesBycity();
			for (int i = 0; i < length; i++)
			{
				if (CountSubByCity(a[i].city) == max && !result.Contains(a[i].city))
					result.Add(a[i].city);
			}
			return result;
		}

		public List<string> FindCity_AtLeastSub()
		{
			List<string> result = new List<string>();
			int min = FindAtLeastOccurrencesBycity();
			for (int i = 0; i < length; i++)
			{
				if (CountSubByCity(a[i].city) == min && !result.Contains(a[i].city))
					result.Add(a[i].city);
			}
			return result;
		}

		public List<string> FindSub_AtLeastID()
		{
			List<string> result = new List<string>();
			int min = FindAtLeastOccurrencesByID();
			for (int i = 0; i < length; i++)
			{
				if (CountSubByID(a[i].soCMND) == min && !result.Contains(a[i].soCMND))
					result.Add(a[i].soCMND);
			}
			return result;
		}

		public void Swap<T>(IList<T> list, int iA, int iB)
		{
			T c = list[iA];
			list[iA] = list[iB];
			list[iB] = c;
		}

		public void SortUp_ByName()
		{
			//for (int i = 0; i < a.Count - 1; i++)
			//	for (int j = i + 1; j < a.Count; j++)
			//		if (string.Compare(a[i].hoTen, a[j].hoTen) > 0)
			//			Swap(a, i, j);
			//{
			//	Subscriber temp = a[i];
			//	a[i] = a[j];
			//	a[j] = temp;
			//}

			a.Sort(new SapXepContactTangDanTheoHoTen());

			//a.Sort(delegate (Subscriber a, Subscriber b)
			//{
			//	return a.hoTen.CompareTo(b.hoTen);
			//});

			//a.Sort((x, y) => x.hoTen.CompareTo(y.hoTen));
		}

		public void SortDown_ByName()
		{
			a.Sort((x, y) => y.hoTen.CompareTo(x.hoTen));
		}

		public void SortUp_BySubID()
		{
			for (int i = 0; i < a.Count - 1; i++)
				for (int j = i + 1; j < a.Count; j++)
					if (CountSubByID(a[i].soCMND) > CountSubByID(a[j].soCMND))
						Swap(a, i, j);
		}

		public void SortDown_BySubID()
		{
			for (int i = 0; i < a.Count - 1; i++)
				for (int j = i + 1; j < a.Count; j++)
					if (CountSubByID(a[i].soCMND) < CountSubByID(a[j].soCMND))
						Swap(a, i, j);
		}

		public string[] SortUpcity_BySubID()
		{
			string[] cityList = DanhSachThanhPho().ToArray();
			for (int i = 0; i < cityList.Length - 1; i++)
				for (int j = i + 1; j < cityList.Length; j++)
					if (CountSubByCity(cityList[i]) > CountSubByCity(cityList[j]))
					{
						Swap(cityList, i, j);
						if (i > 0)
							i--;
						else
							i = 0;
					}
			return cityList;
		}

		public string[] SortDowncity_BySubID()
		{
			string[] cityList = DanhSachThanhPho().ToArray();
			for (int i = 0; i < cityList.Length - 1; i++)
				for (int j = i + 1; j < cityList.Length; j++)
					if (CountSubByCity(cityList[i]) < CountSubByCity(cityList[j]))
					{
						Swap(cityList, i, j);
						if (i > 0)
							i--;
						else
							i = 0;
					}
			return cityList;
		}

		public List<int> FindMonth_WithoutSub()
		{
			List<int> result = new List<int>();
			List<int> month = new List<int>();
			foreach (var item in a)
				if (!month.Contains(item.ngaySinh.Month))
					month.Add(item.ngaySinh.Month);
			for (int i = 1; i <= 12; i++)
				if (!month.Contains(i))
					result.Add(i);
			return result;
		}

		public List<Subscriber> FindListSub_ByGender(GioiTinh gender)
		{
			List<Subscriber> result = new List<Subscriber>();
			foreach (var item in a)
				if (item.gioiTinh == gender)
					result.Add(item);
			return result;
		}

		public void DelSub_Bycity(string city)
		{
			List<Subscriber> sub = new List<Subscriber>();
			foreach (var item in a)
				if (string.Compare(item.city, city, true) == 0)
					sub.Add(item);
			foreach (var item in sub)
				a.Remove(item);
		}

		public void AddNumberPhone_IfJanuary()
		{
			/*
			List<Subscriber> b = new List<Subscriber>(a);

			foreach (var item in a)
				if (item.ngaySinh.Month == 1)
					b.Add(new Subscriber(item.soCMND, item.hoTen, item.diaChi, item.gioiTinh, item.ngaySinh, item.soCMND));

			a = b;
			*/

			int constLength = a.Count;

			for (int i = 0; i < constLength; i++)
			{
				var item = a[i];
				if (item.ngaySinh.Month == 1)
					a.Add(new Subscriber(item.soCMND, item.hoTen, item.diaChi, item.gioiTinh, item.ngaySinh, item.soCMND));
			}

			//foreach (var item in a)
			//	if (item.ngaySinh.Month == 1)
			//		a.Add(new Subscriber(item.soCMND, item.hoTen, item.diaChi, item.gioiTinh, item.ngaySinh, item.soCMND));
		}

		public List<int> FindDaySub_TheMost()
		{
			List<int> daySub = new List<int>();
			List<int> result = new List<int>();
			for (int i = 1; i <= 31; i++)
				daySub.Add(0);
			foreach (var item in a)
				daySub[item.ngaySinh.Day - 1]++;
			int max = daySub.Max();
			for (int i = 0; i < 31; i++)
				if (daySub[i] == max)
					result.Add(i + 1);
			return result;
		}

		public List<int> FindDaySub_AtLeast()
		{
			List<int> daySub = new List<int>();
			List<int> result = new List<int>();
			for (int i = 1; i <= 31; i++)
				daySub.Add(0);
			foreach (var item in a)
				daySub[item.ngaySinh.Day - 1]++;
			//foreach (var item in daySub)
			//	if (item != 0 && min > item)
			//		min = item;
			int min = daySub.Min() + 1;
			for (int i = 0; i < 31; i++)
				if (daySub[i] == min)
					result.Add(i + 1);
			return result;
		}

		/// Tìm danh sách các tỉnh
		public List<string> FindProvincialList()
		{
			List<string> result = new List<string>();
			foreach (var item in a)
				if (!result.Contains(item.provincial))
					result.Add(item.provincial);
			return result;
		}

		/// Tìm danh sách thành phố thuộc một tỉnh nào đó
		public List<string> FindCityList_ByProvincial(string provincial)
		{
			List<string> result = new List<string>();
			foreach (var item in a)
				if (item.provincial == provincial)
					if (!result.Contains(item.city))
						result.Add(item.city);
			return result;
		}

		/// Tính tổng số thuê bao ở một tỉnh nào đó
		public int SumOfSub_ByProvincial(string provincial)
		{
			List<string> cityList = FindCityList_ByProvincial(provincial);
			int result = 0;
			foreach (var item in cityList)
				result += CountSubByCity(item);
			//result += SumOfContacts_ByCity(item);
			return result;
		}

		/// Xuất chuỗi danh sách khách hàng và thuê bao theo CMND
		public string Out_SubList_ByID(string id, int stt)
		{
			string result = "\t\t";
			foreach (var sub in a)
				if (sub.soCMND == id)
				{
					result += stt + ". Number phone: ";
					foreach (var subs in a)
						if (subs.soCMND == id)
							result += subs.sdt;
					result += "\n";
				}
			return result;
		}

		/// Tìm danh sách thuê bao theo thành phố
		public List<Subscriber> FindSubList_ByCity(string city)
		{
			List<Subscriber> result = new List<Subscriber>();
			foreach (var item in a)
				if (item.city == city)
					result.Add(item);
			return result;
		}

		/// Xuất chuỗi danh sách thống kê theo tỉnh
		public void OutListStatistical_ByProvincial(string provincial)
		{
			string result = "\n";
			int stt = 1;
			List<string> cityList = FindCityList_ByProvincial(provincial);
			List<string> idList = new List<string>();
			result += "The provincial: " + provincial + " - Sum of Subs: " + SumOfSub_ByProvincial(provincial) + "\n";
			foreach (var city in cityList)
			{
				result += "\t" + "City: " + city + " - Sum of Subs: " + CountSubByCity(city) + "\n";
				idList = FindIDList_ByCity(city);
				foreach (var id in idList)
				{
					result += Out_SubList_ByID(id, stt);
					stt++;
				}
			}
			WriteLine(result);
			foreach (var cityOut in cityList)
			{
				WriteLine("".PadRight(120, '=') + "\n");
				foreach (var item in FindSubList_ByCity(cityOut))
					Write(item);
			}
		}
	}
}
