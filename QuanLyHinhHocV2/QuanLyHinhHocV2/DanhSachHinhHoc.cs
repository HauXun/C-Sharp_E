using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using static System.Console;

namespace GeometryManagement
{
	internal class SortListHinhVuongGiam_DT : IComparer<HinhHoc>
	{
		public int Compare(HinhHoc x, HinhHoc y)
		{
			return (y as HinhVuong).TinhDienTich().CompareTo((x as HinhVuong).TinhDienTich());
		}
	}

	class DanhSachHinhHoc
	{
		List<HinhHoc> ListHinhHoc = new List<HinhHoc>();
		#region Các hàm chức năng cho lớp HinhHoc
		public void Them(HinhHoc geometry)
		{
			ListHinhHoc.Add(geometry);
		}

		public void Xoa(HinhHoc geometry)
		{
			ListHinhHoc.Remove(geometry);
		}
		#endregion

		#region Các hàm nhập, xuất, định dạng và truy vấn
		public override string ToString()
		{
			string s = "";
			foreach (var item in ListHinhHoc)
			{
				s += "\n" + item;
			}
			return s;
		}

		public void Xuat()
		{
			WriteLine(this.ToString());
		}

		public void ImportFromFile()
		{
			//string path = "E:\\data.txt";
			string path = @"data.txt";
			Write("Nhap ten tap tin de mo >> ");
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
			string s = "";
			while ((s = file.ReadLine()) != null)
			{
				string[] str = s.Split(' ');
				if (str[0] == "HT")
					Them(new HinhTron(float.Parse(str[1])));
				else if (str[0] == "HV")
					Them(new HinhVuong(float.Parse(str[1])));
				else
					Them(new HinhChuNhat(float.Parse(str[1]), float.Parse(str[2])));
			}
		}

		public void Nhap()
		{
			string isContinue = "";
			do
			{
				WriteLine("\nHinh tron >>");
				HinhTron ht = new HinhTron();
				ht.Nhap();
				Them(ht);
				WriteLine("\nHinh Vuong >>");
				HinhVuong hv = new HinhVuong();
				hv.Nhap();
				Them(hv);
				WriteLine("\nHinh chu nhat >>");
				HinhChuNhat hcn = new HinhChuNhat();
				hcn.Nhap();
				Them(hcn);
				WriteLine("\n\tBan co muon nhap nua khong ?");
				Write("Nhan phim bat ki de tiep tuc. Go 'No' neu khong! >> ");
				isContinue = ReadLine().ToUpper();
			} while (isContinue != "NO");
		}
		#endregion

		#region Phân loại danh sách các hình học
		public enum TypeList
		{
			HinhVuong,
			HinhTron,
			HinhChuNhat,
			TatCaHinh
		}
		public DanhSachHinhHoc DanhSachKieuHinh(TypeList typeList)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
			{
				if (TrungKieuHinh(item, typeList))
					result.Them(item);
			}
			return result;
		}
		#endregion

		#region Phân loại tính chu vi, diện tích
		public enum TypeCal
		{
			chuVi,
			dienTich,
			canh,
			banKinh,
			chieuDai
		}
		public enum TypeMinMax
		{
			maxDienTich,
			maxChuVi,
			minDienTich,
			minChuVi,
			maxCanh,
			minCanh,
			maxBanKinh,
			minBanKinh,
			maxChieuDai,
			minChieuDai
		}

		public float TinhDienTich(HinhHoc hh)
		{
			if (hh is HinhVuong)
				return ((HinhVuong)hh).TinhDienTich();
			if (hh is HinhTron)
				return ((HinhTron)hh).TinhDienTich();
			if (hh is HinhChuNhat)
				return ((HinhChuNhat)hh).TinhDienTich();
			return 0;
		}

		public float TinhChuVi(HinhHoc hh)
		{
			if (hh is HinhVuong)
				return ((HinhVuong)hh).TinhChuVi();
			if (hh is HinhTron)
				return ((HinhTron)hh).TinhChuVi();
			if (hh is HinhChuNhat)
				return ((HinhChuNhat)hh).TinhChuVi();
			return 0;
		}

		private bool TrungKieuHinh(HinhHoc hh, TypeList typeList)
		{
			return typeList == TypeList.TatCaHinh
				|| (hh is HinhVuong && typeList == TypeList.HinhVuong)
				 || (hh is HinhTron && typeList == TypeList.HinhTron)
				  || (hh is HinhChuNhat && typeList == TypeList.HinhChuNhat);
		}
		#endregion

		public DanhSachHinhHoc MaxArea(float y)
		{
			DanhSachHinhHoc hinhVuong = DanhSachKieuHinh(TypeList.TatCaHinh);
			//float max = ListHinhHoc.Max(x => x.TinhDienTich());
			hinhVuong.ListHinhHoc = hinhVuong.ListHinhHoc.Where(x => x.TinhDienTich() == y).ToList();
			return hinhVuong;
		}

		public float MinArea()
		{
			float max = ListHinhHoc.Min(x => x.TinhDienTich());
			//hinhVuong.ListHinhHoc = hinhVuong.ListHinhHoc.Where(x => (x as HinhVuong).TinhDienTich() == y).ToList();
			return max;
		}

		#region Các hàm chức năng tìm kiếm hình học
		public DanhSachHinhHoc TimHinhTheoDT_CV(float number, TypeCal typeCal, TypeList typeList)
		{
			DanhSachHinhHoc result = DanhSachKieuHinh(typeList);
			switch (typeCal)
			{
				case TypeCal.chuVi:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => x.TinhChuVi() == number).ToList();
					break;
				case TypeCal.dienTich:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => x.TinhDienTich() == number).ToList();
					break;
				case TypeCal.canh:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhVuong).Canh == number).ToList();
					break;
				case TypeCal.banKinh:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhTron).BanKinh == number).ToList();
					break;
				case TypeCal.chieuDai:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhChuNhat).TinhDienTich() == number).ToList();
					break;
			}
			return result;
		}

		public DanhSachHinhHoc TimHinhMinMaxDT_CV(TypeList typeList, TypeMinMax typeMinMax)
		{
			switch (typeMinMax)
			{
				case TypeMinMax.maxDienTich:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.dienTich, typeList);
				case TypeMinMax.maxChuVi:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.chuVi, typeList);
				case TypeMinMax.minDienTich:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.dienTich, typeList);
				case TypeMinMax.minChuVi:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.chuVi, typeList);
				case TypeMinMax.maxCanh:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.canh, typeList);
				case TypeMinMax.minCanh:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.canh, typeList);
				case TypeMinMax.maxBanKinh:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.banKinh, typeList);
				case TypeMinMax.minBanKinh:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.banKinh, typeList);
				case TypeMinMax.maxChieuDai:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.chieuDai, typeList);
				case TypeMinMax.minChieuDai:
					return TimHinhTheoDT_CV(MinMaxCV_DT_BK_C_CD(typeMinMax, typeList), TypeCal.chieuDai, typeList);
			}
			return null;

		}

		public float MinMaxCV_DT_BK_C_CD(TypeMinMax typeMinMax, TypeList typeList)
		{
			DanhSachHinhHoc hinhVuong = DanhSachKieuHinh(TypeList.HinhVuong);
			DanhSachHinhHoc hinhTron = DanhSachKieuHinh(TypeList.HinhTron);
			DanhSachHinhHoc hinhChuNhat = DanhSachKieuHinh(TypeList.HinhChuNhat);
			float minMax = 0;
			switch (typeList)
			{
				case TypeList.HinhVuong:
					switch (typeMinMax)
					{
						case TypeMinMax.maxDienTich:
							minMax = hinhVuong.ListHinhHoc.Max(x => (x as HinhVuong).TinhDienTich());
							break;
						case TypeMinMax.maxChuVi:
							minMax = hinhVuong.ListHinhHoc.Max(x => (x as HinhVuong).TinhChuVi());
							break;
						case TypeMinMax.minDienTich:
							minMax = hinhVuong.ListHinhHoc.Min(x => (x as HinhVuong).TinhDienTich());
							break;
						case TypeMinMax.minChuVi:
							minMax = hinhVuong.ListHinhHoc.Min(x => (x as HinhVuong).TinhChuVi());
							break;
						case TypeMinMax.maxCanh:
							minMax = hinhVuong.ListHinhHoc.Max(x => (x as HinhVuong).Canh);
							break;
						case TypeMinMax.minCanh:
							minMax = hinhVuong.ListHinhHoc.Min(x => (x as HinhVuong).Canh);
							break;
					}
					break;
				case TypeList.HinhTron:
					switch (typeMinMax)
					{
						case TypeMinMax.maxDienTich:
							minMax = hinhTron.ListHinhHoc.Max(x => (x as HinhTron).TinhDienTich());
							break;
						case TypeMinMax.maxChuVi:
							minMax = hinhTron.ListHinhHoc.Max(x => (x as HinhTron).TinhChuVi());
							break;
						case TypeMinMax.minDienTich:
							minMax = hinhTron.ListHinhHoc.Min(x => (x as HinhTron).TinhDienTich());
							break;
						case TypeMinMax.minChuVi:
							minMax = hinhTron.ListHinhHoc.Min(x => (x as HinhTron).TinhChuVi());
							break;
						case TypeMinMax.maxBanKinh:
							minMax = hinhTron.ListHinhHoc.Max(x => (x as HinhTron).BanKinh);
							break;
						case TypeMinMax.minBanKinh:
							minMax = hinhTron.ListHinhHoc.Min(x => (x as HinhTron).BanKinh);
							break;
					}
					break;
				case TypeList.HinhChuNhat:
					switch (typeMinMax)
					{
						case TypeMinMax.maxDienTich:
							minMax = hinhChuNhat.ListHinhHoc.Max(x => (x as HinhChuNhat).TinhDienTich());
							break;
						case TypeMinMax.maxChuVi:
							minMax = hinhChuNhat.ListHinhHoc.Max(x => (x as HinhChuNhat).TinhChuVi());
							break;
						case TypeMinMax.minDienTich:
							minMax = hinhChuNhat.ListHinhHoc.Min(x => (x as HinhChuNhat).TinhDienTich());
							break;
						case TypeMinMax.minChuVi:
							minMax = hinhChuNhat.ListHinhHoc.Min(x => (x as HinhChuNhat).TinhChuVi());
							break;
						case TypeMinMax.maxChieuDai:
							minMax = hinhChuNhat.ListHinhHoc.Max(x => (x as HinhChuNhat).TinhDienTich());
							break;
						case TypeMinMax.minChieuDai:
							minMax = hinhChuNhat.ListHinhHoc.Min(x => (x as HinhChuNhat).TinhDienTich());
							break;
					}
					break;
				case TypeList.TatCaHinh:
					switch (typeMinMax)
					{
						case TypeMinMax.maxDienTich:
							minMax = ListHinhHoc.Max(x => x.TinhDienTich());
							break;
						case TypeMinMax.maxChuVi:
							minMax = ListHinhHoc.Max(x => x.TinhChuVi());
							break;
						case TypeMinMax.minDienTich:
							minMax = ListHinhHoc.Min(x => x.TinhDienTich());
							break;
						case TypeMinMax.minChuVi:
							minMax = ListHinhHoc.Min(x => x.TinhChuVi());
							break;
					}
					break;
			}
			return minMax;
		}
		#endregion


		public string TongMinMaxCV_DT(TypeMinMax typeMinMax)
		{
			switch (typeMinMax)
			{
				case TypeMinMax.maxDienTich:
					return TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhVuong) > TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhTron) ? (TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhVuong) > TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhChuNhat) ? "Hinh Vuong" : "Hinh Chu Nhat") : (TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhTron) > TongCV_DT(TypeMinMax.maxDienTich, TypeList.HinhChuNhat) ? "Hinh Tron" : "Hinh Chu Nhat");
				// return dtHinhVuong > dtHinhTron ? (dtHinhVuong > dtHinhChuNhat ? 1 : -1) : (dtHinhTron > dtHinhChuNhat ? 0 : -1);
				case TypeMinMax.maxChuVi:
					return TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhVuong) > TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhTron) ? (TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhVuong) > TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhChuNhat) ? "Hinh Vuong" : "Hinh Chu Nhat") : (TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhTron) > TongCV_DT(TypeMinMax.maxChuVi, TypeList.HinhChuNhat) ? "Hinh Tron" : "Hinh Chu Nhat");
				// return cvHinhVuong > cvHinhTron ? (cvHinhVuong > cvHinhChuNhat ? 1 : -1) : (cvHinhTron > cvHinhChuNhat ? 0 : -1);
				case TypeMinMax.minDienTich:
					return TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhVuong) < TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhTron) ? (TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhVuong) < TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhChuNhat) ? "Hinh Vuong" : "Hinh Chu Nhat") : (TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhTron) < TongCV_DT(TypeMinMax.minDienTich, TypeList.HinhChuNhat) ? "Hinh Tron" : "Hinh Chu Nhat");
				// return dtHinhVuong < dtHinhTron ? (dtHinhVuong < dtHinhChuNhat ? 1 : -1) : (dtHinhTron < dtHinhChuNhat ? 0 : -1);
				case TypeMinMax.minChuVi:
					return TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhVuong) < TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhTron) ? (TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhVuong) < TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhChuNhat) ? "Hinh Vuong" : "Hinh Chu Nhat") : (TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhTron) < TongCV_DT(TypeMinMax.minChuVi, TypeList.HinhChuNhat) ? "Hinh Tron" : "Hinh Chu Nhat");
					// return cvHinhVuong < cvHinhTron ? (cvHinhVuong < cvHinhChuNhat ? 1 : -1) : (cvHinhTron < cvHinhChuNhat ? 0 : -1);
			}
			return "Co loi gi do da xay ra !";
		}

		public float TongCV_DT(TypeMinMax typeMinMax, TypeList typeList)
		{
			float sum = 0;
			if (typeMinMax == TypeMinMax.maxDienTich)
				foreach (var item in ListHinhHoc)
				{
					if (TrungKieuHinh(item, typeList))
						sum += TinhDienTich(item);
				}
			if (typeMinMax == TypeMinMax.maxChuVi)
				foreach (var item in ListHinhHoc)
				{
					if (TrungKieuHinh(item, typeList))
						sum += TinhDienTich(item);
				}
			return sum;
		}

		#region Các hàm chức năng sắp xếp

		/// <summary>
		/// Hàm OrderBy là hàm sắp xếp tăng một danh sách List<> sử dụng Linq
		/// Trong OrderBy:
		/// 'hinh' là một đối tượng trong ListHinhHoc có kiểu là HinhHoc
		/// Cần phải chuyển 'hinh' có kiểu là HinhHoc sang HinhVuong, vì trong HinhVuong có hàm TinhChuVi()
		/// Kết quả trả về của OrderBy là IEnumerable<HinhHoc>, do đó cần phải chuyển về List<HinhHoc>
		/// Hàm OrderByDescending là ngược lại
		/// </summary>
		/// <returns></returns>
		/// 

		public enum SortBy
		{
			SortUpByDT,
			SortUpByCV,
			SortDownByDT,
			SortDownByCV
		}

		public DanhSachHinhHoc SortHinhHoc(SortBy sortBy, TypeList typeList)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			switch (sortBy)
			{
				// OrderSort
				case SortBy.SortUpByDT:
					if (typeList == TypeList.HinhVuong)
					{
						result = DanhSachKieuHinh(TypeList.HinhVuong);
						result.ListHinhHoc = result.ListHinhHoc.OrderBy(hinh => (hinh as HinhVuong).TinhDienTich()).ToList();
						return result;
					}
					if (typeList == TypeList.HinhTron)
					{
						result = DanhSachKieuHinh(TypeList.HinhTron);
						result.ListHinhHoc = result.ListHinhHoc.OrderBy(hinh => (hinh as HinhTron).TinhDienTich()).ToList();
						return result;
					}
					if (typeList == TypeList.HinhChuNhat)
					{
						result = DanhSachKieuHinh(TypeList.HinhChuNhat);
						result.ListHinhHoc = result.ListHinhHoc.OrderBy(hinh => (hinh as HinhChuNhat).TinhDienTich()).ToList();
						return result;
					}
					break;
				// Delegate Sort
				case SortBy.SortUpByCV:
					if (typeList == TypeList.HinhVuong)
					{
						result = DanhSachKieuHinh(TypeList.HinhVuong);
						result.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
						{
							return (x as HinhVuong).TinhChuVi().CompareTo((y as HinhVuong).TinhChuVi());
						});
						return result;
					}
					if (typeList == TypeList.HinhTron)
					{
						result = DanhSachKieuHinh(TypeList.HinhTron);
						result.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
						{
							return (x as HinhTron).TinhChuVi().CompareTo((y as HinhTron).TinhChuVi());
						});
						return result;
					}
					if (typeList == TypeList.HinhChuNhat)
					{
						result = DanhSachKieuHinh(TypeList.HinhChuNhat);
						result.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
						{
							return (x as HinhChuNhat).TinhChuVi().CompareTo((y as HinhChuNhat).TinhChuVi());
						});
						return result;
					}
					break;
				// IcomparerSort and OrderByDescending Sort
				case SortBy.SortDownByDT:
					if (typeList == TypeList.HinhVuong)
					{
						result = DanhSachKieuHinh(TypeList.HinhVuong);
						result.ListHinhHoc.Sort(new SortListHinhVuongGiam_DT());
						return result;
					}
					if (typeList == TypeList.HinhTron)
					{
						result = DanhSachKieuHinh(TypeList.HinhTron);
						result.ListHinhHoc = result.ListHinhHoc.OrderByDescending(hinh => (hinh as HinhTron).TinhDienTich()).ToList();
						return result;
					}
					if (typeList == TypeList.HinhChuNhat)
					{
						result = DanhSachKieuHinh(TypeList.HinhChuNhat);
						result.ListHinhHoc = result.ListHinhHoc.OrderByDescending(hinh => (hinh as HinhChuNhat).TinhDienTich()).ToList();
						return result;
					}
					break;
				// Lambda Sort
				case SortBy.SortDownByCV:
					if (typeList == TypeList.HinhVuong)
					{
						result = DanhSachKieuHinh(TypeList.HinhVuong);
						result.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhVuong).TinhChuVi().CompareTo((x as HinhVuong).TinhChuVi()));
						return result;
					}
					if (typeList == TypeList.HinhTron)
					{
						result = DanhSachKieuHinh(TypeList.HinhTron);
						result.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhTron).TinhChuVi().CompareTo((x as HinhTron).TinhChuVi()));
						return result;
					}
					if (typeList == TypeList.HinhChuNhat)
					{
						result = DanhSachKieuHinh(TypeList.HinhChuNhat);
						result.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhChuNhat).TinhChuVi().CompareTo((x as HinhChuNhat).TinhChuVi()));
						return result;
					}
					break;
			}
			return result;
		}

		#endregion

		#region Một số chức năng khác
		public int DemHinhHoc(TypeList typeList)
		{
			foreach (var item in ListHinhHoc)
			{
				if (TrungKieuHinh(item, typeList))
					switch (typeList)
					{
						case TypeList.HinhVuong:
							break;
						case TypeList.HinhTron:
							break;
						case TypeList.HinhChuNhat:
							break;
						case TypeList.TatCaHinh:
							break;
						default:
							break;
					}
			}
			return 0;
		}

		public int DemHinhVuong()
		{
			int sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
					sum++;
			}
			return sum;
		}

		public int DemHinhTron()
		{
			int sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
					sum++;
			}
			return sum;
		}

		public int DemHinhChuNhat()
		{
			int sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
					sum++;
			}
			return sum;
		}

		public int TongHinhHoc() => DemHinhVuong() + DemHinhTron() + DemHinhChuNhat();

		public void ThemHinhTaiViTri(int location, TypeList typeList)
		{

			switch (typeList)
			{
				case TypeList.HinhVuong:
					HinhTron ht = new HinhTron();
					ht.Nhap();
					ListHinhHoc.Insert(location, ht);
					break;
				case TypeList.HinhTron:
					WriteLine("\nHinh Vuong >>");
					HinhVuong hv = new HinhVuong();
					hv.Nhap();
					ListHinhHoc.Insert(location, hv);
					break;
				case TypeList.HinhChuNhat:
					WriteLine("\nHinh chu nhat >>");
					HinhChuNhat hcn = new HinhChuNhat();
					hcn.Nhap();
					ListHinhHoc.Insert(location, hcn);
					break;
				default:
					break;
			}
		}

		#endregion

		#region Các hàm chức năng xóa

		//public void XoaHinh(TypeMinMax typeMinMax)
		//{
		//	List<HinhHoc> isList = new List<HinhHoc>(ListHinhHoc);
		//	foreach (var item in isList)
		//	{
		//		switch (typeMinMax)
		//		{
		//			case TypeMinMax.maxDienTich:
		//				if (TinhDienTich(item).Equals(MinMax_CV_DT(TypeCal.dienTich, TypeMinMax.maxDienTich)))
		//					ListHinhHoc.Remove(item);
		//				break;
		//			case TypeMinMax.maxChuVi:
		//				if (TinhChuVi(item).Equals(MinMax_CV_DT(TypeCal.chuVi, TypeMinMax.maxChuVi)))
		//					ListHinhHoc.Remove(item);
		//				break;
		//			case TypeMinMax.minDienTich:
		//				if (TinhDienTich(item).Equals(MinMax_CV_DT(TypeCal.dienTich, TypeMinMax.minDienTich)))
		//					ListHinhHoc.Remove(item);
		//				break;
		//			case TypeMinMax.minChuVi:
		//				if (TinhChuVi(item).Equals(MinMax_CV_DT(TypeCal.chuVi, TypeMinMax.minChuVi)))
		//					ListHinhHoc.Remove(item);
		//				break;
		//			default:
		//				break;
		//		}
		//	}

		////}

		public void XoaHinhTaiViTri(int location)
		{
			ListHinhHoc.RemoveAt(location);
		}
		#endregion

		#region Các hàm chức năng ghi danh sách các hình xuống file riêng

		//public void GhiFile()
		//{
		//    string str = "\t\t\tBANG TONG HOP THONG TIN\n" +
		//        $"1) Tong so cac doi tuong hinh hoc la: {TongHinhHoc()}\n" +
		//        $"2) Tong so hinh tron la: {DemHinhTron()}\n" +
		//        $"3) Tong so hinh vuong la: {DemHinhVuong()}\n" +
		//        $"4) Tong so hinh chu nhat la {DemHinhChuNhat()}\n" +
		//        $"\nA. Danh sach hinh tron (theo chieu tang dien tich)\n" + ListHinhTron().SortListHinhTronTang_DT() +
		//        $"\n\nB. Danh sach hinh vuong(theo chieu tang dien tich)\n" + ListHinhVuong().SortListHinhVuongTang_DT() +
		//        $"\n\nC. Danh sach hinh chu nhat(theo chieu tang dien tich)\n" + ListHinhChuNhat().SortListHinhChuNhatTang_DT() +
		//        $"\n";
		//    using (StreamWriter file = new StreamWriter(@"hinhhoc.txt", append: false)) // FileMode.Append, FileAccess.Write)
		//    {
		//        file.Write(str);
		//    }
		//}

		//public void GhiFileHinhVuong()
		//{
		//    string str = "\t\t\tBANG TONG HOP THONG TIN\n" +
		//        $"\n\nDanh sach hinh vuong\n" + ListHinhVuong().SortListHinhVuongTang_DT() +
		//        $"\n";
		//    using (StreamWriter file = new StreamWriter(@"hinhvuong.txt", append: false)) // FileMode.Append, FileAccess.Write)
		//    {
		//        file.Write(str);
		//    }
		//}

		//public void GhiFileHinhTron()
		//{
		//    string str = "\t\t\tBANG TONG HOP THONG TIN\n" +
		//        $"\n\nDanh sach hinh tron\n" + ListHinhTron().SortListHinhTronTang_DT() +
		//        $"\n";
		//    using (StreamWriter file = new StreamWriter(@"hinhtron.txt", append: false)) // FileMode.Append, FileAccess.Write)
		//    {
		//        file.Write(str);
		//    }
		//}

		//public void GhiFileHinhChuNhat()
		//{
		//    string str = "\t\t\tBANG TONG HOP THONG TIN\n" +
		//        $"\n\nDanh sach hinh chu nhat\n" + ListHinhChuNhat().SortListHinhChuNhatTang_DT() +
		//        $"\n";
		//    using (StreamWriter file = new StreamWriter(@"hinhchunhat.txt", append: false)) // FileMode.Append, FileAccess.Write)
		//    {
		//        file.Write(str);
		//    }
		//}
		public void GhiFile(TypeList type)
		{
			string str = "";

			switch (type)
			{
				case TypeList.HinhVuong:
					str = "hinh vuong ";
					break;
				case TypeList.HinhTron:
					str = "hinh tron ";
					break;
				case TypeList.HinhChuNhat:
					str = "hinh chu nhat ";
					break;
				case TypeList.TatCaHinh:
					str = "tat ca cac hinh ";
					break;

			}
			string kq = $"\n\nDanh sach \n" + str + DanhSachKieuHinh(type).ToString() + $"\n";
			string fileName = str.Trim() + ".txt";
			using (StreamWriter file = new StreamWriter(fileName, append: false)) // FileMode.Append, FileAccess.Write)
			{
				file.Write(kq);
			}
		}
		#endregion
	}
}
