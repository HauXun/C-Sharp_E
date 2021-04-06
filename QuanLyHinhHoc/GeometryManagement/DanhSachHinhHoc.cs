using System.Collections.Generic;
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
		public DanhSachHinhHoc ListHinhVuong()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc ListHinhTron()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc ListHinhChuNhat()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat)
					result.Them(item);
			return result;
		}
		#endregion

		#region Các hàm chức năng tìm kiếm hình học
		public DanhSachHinhHoc TimHinhVuongDTBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == x)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhVuongCVBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == x)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronDTBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).TinhDienTich() == x)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronCVBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).TinhChuVi() == x)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatDTBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() == x)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatCVBangX(float x)
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() == x)
					result.Them(item);
			return result;
		}

		float TimMinDTHinhVuong()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
				{
					float dt = ((HinhVuong)item).TinhDienTich();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		float TimMinDTHinhTron()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
				{
					float dt = ((HinhTron)item).TinhDienTich();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		float TimMinDTHinhChuNhat()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
				{
					float dt = ((HinhChuNhat)item).TinhDienTich();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		public DanhSachHinhHoc TimHinhVuongMinDT()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinDTHinhVuong();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronMinDT()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinDTHinhTron();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).TinhDienTich() == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatMinDT()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinDTHinhChuNhat();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() == min)
					result.Them(item);
			return result;
		}

		float TimMinCVHinhVuong()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
				{
					float dt = ((HinhVuong)item).TinhChuVi();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		float TimMinCVHinhTron()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
				{
					float dt = ((HinhTron)item).TinhChuVi();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		float TimMinCVHinhChuNhat()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
				{
					float dt = ((HinhChuNhat)item).TinhChuVi();
					if (dt < min)
						min = dt;
				}
			}
			return min;
		}

		public DanhSachHinhHoc TimHinhVuongMinCV()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinCVHinhVuong();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronMinCV()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinCVHinhTron();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).TinhChuVi() == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatMinCV()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinCVHinhChuNhat();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() == min)
					result.Them(item);
			return result;
		}

		float MinCanhHinhVuong()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
				{
					float canh = ((HinhVuong)item).Canh;
					if (canh < min)
						min = canh;
				}
			}
			return min;
		}

		float MinBanKinhHinhTron()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
				{
					float banKinh = ((HinhTron)item).BanKinh;
					if (banKinh < min)
						min = banKinh;
				}
			}
			return min;
		}

		float MinChieuDaiHinhChuNhat()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
				{
					float dai = ((HinhChuNhat)item).TinhChuVi() / ((HinhChuNhat)item).ChieuRong * 2;
					if (dai < min)
						min = dai;
				}
			}
			return min;
		}

		float MaxCanhHinhVuong()
		{
			float max = float.MinValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
				{
					float canh = ((HinhVuong)item).Canh;
					if (max < canh)
						max = canh;
				}
			}
			return max;
		}

		float MaxBanKinhHinhTron()
		{
			float max = float.MinValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
				{
					float banKinh = ((HinhTron)item).BanKinh;
					if (max < banKinh)
						max = banKinh;
				}
			}
			return max;
		}

		float MaxBanKinhHinhChuNhat()
		{
			float max = float.MinValue;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
				{
					float dai = ((HinhChuNhat)item).TinhChuVi() / ((HinhChuNhat)item).ChieuRong * 2;
					if (max < dai)
						max = dai;
				}
			}
			return max;
		}

		public DanhSachHinhHoc TimHinhVuongMinCanh()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = MinCanhHinhVuong();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).Canh == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronMinBanKinh()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = MinBanKinhHinhTron();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).BanKinh == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatMinChieuDai()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = MinChieuDaiHinhChuNhat();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() / ((HinhChuNhat)item).ChieuRong * 2 == min)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhVuongMaxCanh()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float max = MaxCanhHinhVuong();
			foreach (var item in ListHinhHoc)
				if (item is HinhVuong && ((HinhVuong)item).Canh == max)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhTronMaxBanKinh()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float max = MaxBanKinhHinhTron();
			foreach (var item in ListHinhHoc)
				if (item is HinhTron && ((HinhTron)item).BanKinh == max)
					result.Them(item);
			return result;
		}

		public DanhSachHinhHoc TimHinhChuNhatMaxChieuDai()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float max = MaxBanKinhHinhChuNhat();
			foreach (var item in ListHinhHoc)
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() / ((HinhChuNhat)item).ChieuRong * 2 == max)
					result.Them(item);
			return result;
		}

		float TimMaxDT()
		{
			float max = float.MinValue;
			foreach (var item in ListHinhHoc)
			{
				float dt = 0;
				if (item is HinhVuong)
					dt = ((HinhVuong)item).TinhDienTich();
				if (item is HinhTron)
					dt = ((HinhTron)item).TinhDienTich();
				if (item is HinhChuNhat)
					dt = ((HinhChuNhat)item).TinhDienTich();
				if (dt > max)
					max = dt;
			}
			return max;
		}

		float TimMinDT()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				float dt = 0;
				if (item is HinhVuong)
					dt = ((HinhVuong)item).TinhDienTich();
				if (item is HinhTron)
					dt = ((HinhTron)item).TinhDienTich();
				if (item is HinhChuNhat)
					dt = ((HinhChuNhat)item).TinhDienTich();
				if (dt < min)
					min = dt;
			}
			return min;
		}

		float TimMaxCV()
		{
			float max = float.MinValue;
			foreach (var item in ListHinhHoc)
			{
				float dt = 0;
				if (item is HinhVuong)
					dt = ((HinhVuong)item).TinhChuVi();
				if (item is HinhTron)
					dt = ((HinhTron)item).TinhChuVi();
				if (item is HinhChuNhat)
					dt = ((HinhChuNhat)item).TinhChuVi();
				if (dt > max)
					max = dt;
			}
			return max;
		}

		float TimMinCV()
		{
			float min = float.MaxValue;
			foreach (var item in ListHinhHoc)
			{
				float dt = 0;
				if (item is HinhVuong)
					dt = ((HinhVuong)item).TinhChuVi();
				if (item is HinhTron)
					dt = ((HinhTron)item).TinhChuVi();
				if (item is HinhChuNhat)
					dt = ((HinhChuNhat)item).TinhChuVi();
				if (dt < min)
					min = dt;
			}
			return min;
		}

		public DanhSachHinhHoc TimHinhCoMaxDT()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float max = TimMaxDT();
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == max)
					result.Them(item);
				if (item is HinhTron && ((HinhTron)item).TinhDienTich() == max)
					result.Them(item);
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() == max)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc TimHinhCoMinDT()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinDT();
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == min)
					result.Them(item);
				if (item is HinhTron && ((HinhTron)item).TinhDienTich() == min)
					result.Them(item);
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() == min)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc TimHinhCoMaxCV()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float max = TimMaxCV();
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == max)
					result.Them(item);
				if (item is HinhTron && ((HinhTron)item).TinhChuVi() == max)
					result.Them(item);
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() == max)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc TimHinhCoMinCV()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float min = TimMinCV();
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == min)
					result.Them(item);
				if (item is HinhTron && ((HinhTron)item).TinhChuVi() == min)
					result.Them(item);
				if (item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() == min)
					result.Them(item);
			}
			return result;
		}

		public int HinhDTLonNhat()
		{
			float dtHinhVuong = TongDTHinhVuong();
			float dtHinhTron = TongDTHinhTron();
			float dtHinhChuNhat = TongDTHinhChuNhat();
			return dtHinhVuong > dtHinhTron ? (dtHinhVuong > dtHinhChuNhat ? 1 : -1) : (dtHinhTron > dtHinhChuNhat ? 0 : -1);
		}

		public int HinhDTNhoNhat()
		{
			float dtHinhVuong = TongDTHinhVuong();
			float dtHinhTron = TongDTHinhTron();
			float dtHinhChuNhat = TongDTHinhChuNhat();
			return dtHinhVuong < dtHinhTron ? (dtHinhVuong < dtHinhChuNhat ? 1 : -1) : (dtHinhTron < dtHinhChuNhat ? 0 : -1);
		}

		public int HinhCVLonNhat()
		{
			float cvHinhVuong = TongCVHinhVuong();
			float cvHinhTron = TongCVHinhTron();
			float cvHinhChuNhat = TongCVHinhChuNhat();
			return cvHinhVuong > cvHinhTron ? (cvHinhVuong > cvHinhChuNhat ? 1 : -1) : (cvHinhTron > cvHinhChuNhat ? 0 : -1);
		}

		public int HinhCVNhoNhat()
		{
			float cvHinhVuong = TongCVHinhVuong();
			float cvHinhTron = TongCVHinhTron();
			float cvHinhChuNhat = TongCVHinhChuNhat();
			return cvHinhVuong < cvHinhTron ? (cvHinhVuong < cvHinhChuNhat ? 1 : -1) : (cvHinhTron < cvHinhChuNhat ? 0 : -1);
		}
		#endregion

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

		// Hình vuông
		public DanhSachHinhHoc SortListHinhVuongTang_CV()
		{
			DanhSachHinhHoc listHinhVuong = ListHinhVuong();
			listHinhVuong.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
			{
				return (x as HinhVuong).TinhChuVi().CompareTo((y as HinhVuong).TinhChuVi());
			});
			return listHinhVuong;
		}

		public DanhSachHinhHoc SortListHinhVuongGiam_CV()
		{
			DanhSachHinhHoc listHinhVuong = ListHinhVuong();
			listHinhVuong.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhVuong).TinhChuVi().CompareTo((x as HinhVuong).TinhChuVi()));
			return listHinhVuong;
		}

		public DanhSachHinhHoc SortListHinhVuongTang_DT()
		{
			DanhSachHinhHoc listHinhVuong = ListHinhVuong();
			listHinhVuong.ListHinhHoc = listHinhVuong.ListHinhHoc.OrderBy(hinh => (hinh as HinhVuong).TinhDienTich()).ToList();
			return listHinhVuong;
		}

		public DanhSachHinhHoc SortListHinhVuongGiam_DT()
		{
			DanhSachHinhHoc listHinhVuong = ListHinhVuong();
			listHinhVuong.ListHinhHoc.Sort(new SortListHinhVuongGiam_DT());
			return listHinhVuong;
		}

		// Hình tròn
		public DanhSachHinhHoc SortListHinhTronTang_CV()
		{
			DanhSachHinhHoc listHinhTron = ListHinhTron();
			listHinhTron.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
			{
				return (x as HinhTron).TinhChuVi().CompareTo((y as HinhTron).TinhChuVi());
			});
			return listHinhTron;
		}

		public DanhSachHinhHoc SortListHinhTronGiam_CV()
		{
			DanhSachHinhHoc listHinhTron = ListHinhTron();
			listHinhTron.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhTron).TinhChuVi().CompareTo((x as HinhTron).TinhChuVi()));
			return listHinhTron;
		}

		public DanhSachHinhHoc SortListHinhTronTang_DT()
		{
			DanhSachHinhHoc listHinhTron = ListHinhTron();
			listHinhTron.ListHinhHoc = listHinhTron.ListHinhHoc.OrderBy(hinh => (hinh as HinhTron).TinhDienTich()).ToList();
			return listHinhTron;
		}

		public DanhSachHinhHoc SortListHinhTronGiam_DT()
		{
			DanhSachHinhHoc listHinhTron = ListHinhTron();
			listHinhTron.ListHinhHoc = listHinhTron.ListHinhHoc.OrderByDescending(hinh => (hinh as HinhTron).TinhDienTich()).ToList();
			return listHinhTron;
		}

		// Hình Chữ Nhật
		public DanhSachHinhHoc SortListHinhChuNhatTang_CV()
		{
			DanhSachHinhHoc listHinhChuNhat = ListHinhChuNhat();
			listHinhChuNhat.ListHinhHoc.Sort(delegate (HinhHoc x, HinhHoc y)
			{
				return (x as HinhChuNhat).TinhChuVi().CompareTo((y as HinhChuNhat).TinhChuVi());
			});
			return listHinhChuNhat;
		}

		public DanhSachHinhHoc SortListHinhChuNhatGiam_CV()
		{
			DanhSachHinhHoc listHinhChuNhat = ListHinhChuNhat();
			listHinhChuNhat.ListHinhHoc.Sort((HinhHoc x, HinhHoc y) => (y as HinhChuNhat).TinhChuVi().CompareTo((x as HinhChuNhat).TinhChuVi()));
			return listHinhChuNhat;
		}

		public DanhSachHinhHoc SortListHinhChuNhatTang_DT()
		{
			DanhSachHinhHoc listHinhChuNhat = ListHinhChuNhat();
			listHinhChuNhat.ListHinhHoc = listHinhChuNhat.ListHinhHoc.OrderBy(hinh => (hinh as HinhChuNhat).TinhDienTich()).ToList();
			return listHinhChuNhat;
		}

		public DanhSachHinhHoc SortListHinhChuNhatGiam_DT()
		{
			DanhSachHinhHoc listHinhChuNhat = ListHinhChuNhat();
			listHinhChuNhat.ListHinhHoc = listHinhChuNhat.ListHinhHoc.OrderByDescending(hinh => (hinh as HinhChuNhat).TinhDienTich()).ToList();
			return listHinhChuNhat;
		}
		#endregion

		#region Một số chức năng khác
		public float TongDTHinhVuong()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
					sum += ((HinhVuong)item).TinhDienTich();
			}
			return sum;
		}

		public float TongDTHinhTron()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
					sum += ((HinhTron)item).TinhDienTich();
			}
			return sum;
		}

		public float TongDTHinhChuNhat()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
					sum += ((HinhChuNhat)item).TinhDienTich();
			}
			return sum;
		}

		public float TongCVHinhVuong()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong)
					sum += ((HinhVuong)item).TinhChuVi();
			}
			return sum;
		}

		public float TongCVHinhTron()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhTron)
					sum += ((HinhTron)item).TinhChuVi();
			}
			return sum;
		}

		public float TongCVHinhChuNhat()
		{
			float sum = 0;
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhChuNhat)
					sum += ((HinhChuNhat)item).TinhChuVi();
			}
			return sum;
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

		public DanhSachHinhHoc ThemHinhTaiViTri(int location)
		{
			HinhVuong hv = new HinhVuong(3);
			for (int i = ListHinhHoc.Count - 1; i >= location; i--)
				ListHinhHoc[i] = ListHinhHoc[i - 1];
			ListHinhHoc[location] = ListHinhHoc.Add(new HinhHoc())
		}
		#endregion

		#region Các hàm chức năng xóa
		public DanhSachHinhHoc XoaHinhDTLonNhat()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float dtLonNhat = TimMaxDT();
			WriteLine("Dien tich lon nhat la " + dtLonNhat);
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() != dtLonNhat ||
					item is HinhTron && ((HinhTron)item).TinhDienTich() != dtLonNhat ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() != dtLonNhat)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc XoaHinhDTNhoNhat()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float dtNhoNhat = TimMinDT();
			WriteLine("Dien tich nho nhat la " + dtNhoNhat);
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() != dtNhoNhat ||
					item is HinhTron && ((HinhTron)item).TinhDienTich() != dtNhoNhat ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhDienTich() != dtNhoNhat)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc XoaHinhCVLonNhat()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float cvLonNhat = TimMaxCV();
			WriteLine("Chu vi lon nhat la " + cvLonNhat);
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() != cvLonNhat ||
					item is HinhTron && ((HinhTron)item).TinhChuVi() != cvLonNhat ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() != cvLonNhat)
					result.Them(item);
			}
			return result;
		}

		public DanhSachHinhHoc XoaHinhCVNhoNhat()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			float cvNhoNhat = TimMinCV();
			WriteLine("Chu vi nho nhat la " + cvNhoNhat);
			foreach (var item in ListHinhHoc)
			{
				if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() != cvNhoNhat ||
					item is HinhTron && ((HinhTron)item).TinhChuVi() != cvNhoNhat ||
					item is HinhChuNhat && ((HinhChuNhat)item).TinhChuVi() != cvNhoNhat)
					result.Them(item);
			}
			return result;
		}

		public void XoaHinhTaiViTri(int location)
		{
			ListHinhHoc.RemoveAt(location);
		}
		#endregion
	}
}
