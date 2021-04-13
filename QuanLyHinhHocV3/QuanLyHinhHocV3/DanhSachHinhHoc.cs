using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace GeometryManagement
{
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
			HinhHoc hh = new HinhHoc();
			string isContinue = null;
			do
			{
				Write("\nBan muon nhap hinh gi (1 - HV, 2 - HT, 3 - HCN) >> ");
				int type = int.Parse(ReadLine());
				switch (type)
				{
					case 1:
						WriteLine("\nHinh Vuong >>");
						hh = new HinhTron();
						break;
					case 2:
						WriteLine("\nHinh Vuong >>");
						hh = new HinhVuong();
						break;
					case 3:
						WriteLine("\nHinh chu nhat >>");
						hh = new HinhChuNhat();
						break;
					default:
						WriteLine("Co loi gi do da xay ra! Vui long kiem tra lai");
						break;
				}
				ListHinhHoc.Add(hh.Nhap());
				WriteLine("\n\tBan co muon nhap nua khong ?");
				Write("Nhan phim bat ki de tiep tuc. Go 'No' neu khong! >> ");
				isContinue = ReadLine().ToUpper();
			} while (isContinue != "NO");
		}
		#endregion
		#region Phân loại danh sách các hình học
		public DanhSachHinhHoc DanhSachKieuHinh<T>()
		{
			DanhSachHinhHoc result = new DanhSachHinhHoc();
			result.ListHinhHoc = ListHinhHoc.Where(x => x is T).ToList();
			return result;
		}
		#endregion
		#region Các hàm chức năng tìm kiếm hình học
		public float MinMaxCV_DT_BK_C_CD<T>(int typeMinMax)
		{
			DanhSachHinhHoc hinhHoc = DanhSachKieuHinh<T>();
			switch (typeMinMax)
			{
				case 0:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Max(x => x.TinhChuVi());
				case 1:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Min(x => x.TinhChuVi());
				case 2:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Max(x => x.TinhDienTich());
				case 3:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Min(x => x.TinhDienTich());
				case 4:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Max(x => (x as HinhVuong).Canh);
				case 5:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Min(x => (x as HinhVuong).Canh);
				case 6:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Max(x => (x as HinhTron).BanKinh);
				case 7:
					return hinhHoc.ListHinhHoc.FindAll(p => p is T).Min(x => (x as HinhTron).BanKinh);
			}
			return 0;
		}
		public float TongCV_DTHinhHoc<T>(int typeMinMax)
		{
			if (typeMinMax == 0 || typeMinMax == 2)
				return ListHinhHoc.FindAll(p => p is T).Sum(x => x.TinhDienTich());
			else
				return ListHinhHoc.FindAll(p => p is T).Sum(x => x.TinhChuVi());
		}
		public DanhSachHinhHoc TimHinhTheoDT_CV_C_BK_CD<T>(float number, int typeCal)
		{
			DanhSachHinhHoc result = DanhSachKieuHinh<T>();
			switch (typeCal)
			{
				case 0:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => x.TinhChuVi() == number).ToList();
					break;
				case 1:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => x.TinhDienTich() == number).ToList();
					break;
				case 2:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhVuong).Canh == number).ToList();
					break;
				case 3:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhTron).BanKinh == number).ToList();
					break;
				case 4:
					result.ListHinhHoc = result.ListHinhHoc.Where(x => (x as HinhChuNhat).TinhDienTich() == number).ToList();
					break;
			}
			return result;
		}
		public DanhSachHinhHoc TimHinhMinMaxDT_CV_BK_C_CD<T>(int typeMinMax, int typeCal) => TimHinhTheoDT_CV_C_BK_CD<T>(MinMaxCV_DT_BK_C_CD<T>(typeMinMax), typeCal);
		public string TimHinhTongMinMaxCV_DT(int typeMinMax)
		{
			if (typeMinMax == 0 || typeMinMax == 2)
				return TongCV_DTHinhHoc<HinhVuong>(typeMinMax) > TongCV_DTHinhHoc<HinhTron>(typeMinMax) ?
					(TongCV_DTHinhHoc<HinhVuong>(typeMinMax) > TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax) ?
					$"Hinh Vuong >> Max = {TongCV_DTHinhHoc<HinhVuong>(typeMinMax)}" :
					$"Hinh Chu Nhat >> Max = {TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax)}") :
					(TongCV_DTHinhHoc<HinhTron>(typeMinMax) > TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax) ?
					$"Hinh Tron >> Max = {TongCV_DTHinhHoc<HinhTron>(typeMinMax)}" :
					$"Hinh Chu Nhat >> Max = {TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax)}");
			else if (typeMinMax == 3 || typeMinMax == 1)
				return TongCV_DTHinhHoc<HinhVuong>(typeMinMax) > TongCV_DTHinhHoc<HinhTron>(typeMinMax) ?
					(TongCV_DTHinhHoc<HinhVuong>(typeMinMax) > TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax) ?
					$"Hinh Vuong >> Max = {TongCV_DTHinhHoc<HinhVuong>(typeMinMax)}" :
					$"Hinh Chu Nhat >> Max = {TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax)}") :
					(TongCV_DTHinhHoc<HinhTron>(typeMinMax) > TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax) ?
					$"Hinh Tron >> Max = {TongCV_DTHinhHoc<HinhTron>(typeMinMax)}" :
					$"Hinh Chu Nhat >> Max = {TongCV_DTHinhHoc<HinhChuNhat>(typeMinMax)}");
			else
				return null;
		}
		#endregion
		#region Các hàm chức năng sắp xếp
		public DanhSachHinhHoc SortHinhHoc<T>(int sortBy)
		{
			DanhSachHinhHoc result = DanhSachKieuHinh<T>();
			switch (sortBy)
			{
				case 0:
					result.ListHinhHoc = result.ListHinhHoc.OrderBy(hinh => hinh.TinhChuVi()).ToList();
					return result;
				case 1:
					result.ListHinhHoc = result.ListHinhHoc.OrderBy(hinh => hinh.TinhDienTich()).ToList();
					return result;
				case 2:
					result.ListHinhHoc = result.ListHinhHoc.OrderByDescending(hinh => hinh.TinhChuVi()).ToList();
					return result;
				case 3:
					result.ListHinhHoc = result.ListHinhHoc.OrderByDescending(hinh => hinh.TinhDienTich()).ToList();
					return result;
			}
			return null;
		}
		#endregion
		#region Một số chức năng khác
		public int DemHinhHoc<T>()
		{
			DanhSachHinhHoc result = DanhSachKieuHinh<T>();
			int sum = result.ListHinhHoc.Count();
			return sum;
		}
		public void ThemHinhTaiViTri(int location, int typeList)
		{
			HinhHoc hh = new HinhHoc();
			switch (typeList)
			{
				case 1:
					WriteLine("\nHinh Vuong >>");
					hh = new HinhTron();
					break;
				case 2:
					WriteLine("\nHinh Vuong >>");
					hh = new HinhVuong();
					break;
				case 3:
					WriteLine("\nHinh chu nhat >>");
					hh = new HinhChuNhat();
					break;
				default:
					WriteLine("\nCo loi gi do da xay ra! Out...");
					break;
			}
			ListHinhHoc.Add(hh.Nhap());
			ListHinhHoc.Insert(location, hh);
		}

		#endregion
		#region Các hàm chức năng xóa
		public void XoaHinhMinMaxCV_DT<T>(int typeMinMax)
		{
			List<HinhHoc> isList = new List<HinhHoc>(ListHinhHoc);
			foreach (var item in isList)
			{
				if (typeMinMax == 0 || typeMinMax == 1)
					if (item.TinhChuVi().Equals(MinMaxCV_DT_BK_C_CD<T>(typeMinMax)))
						ListHinhHoc.Remove(item);
				if (typeMinMax == 2 || typeMinMax == 3)
					if (item.TinhDienTich().Equals(MinMaxCV_DT_BK_C_CD<T>(typeMinMax)))
						ListHinhHoc.Remove(item);
			}
		}
		public void XoaHinhTaiViTri(int location)
		{
			ListHinhHoc.RemoveAt(location);
		}
		#endregion
		#region Các hàm chức năng ghi danh sách các hình xuống file riêng
		public void GhiFile<T>(int typeList)
		{
			string str = null;
			string filename = null;
			string kq = null;
			switch (typeList)
			{
				case 0:
					str = "hinhvuong";
					filename = str + ".txt";
					kq = $"\n\n\t\t\tDANH SACH {str.ToUpper()}\n{DanhSachKieuHinh<T>().ToString()}\n";
					break;
				case 1:
					str = "hinhtron";
					filename = str + ".txt";
					kq = $"\n\n\t\t\tDANH SACH {str.ToUpper()}\n{DanhSachKieuHinh<T>().ToString()}\n";
					break;
				case 2:
					str = "hinhchunhat";
					filename = str + ".txt";
					kq = $"\n\n\t\t\tDANH SACH {str.ToUpper()}\n{DanhSachKieuHinh<T>().ToString()}\n";
					break;
				case 3:
					str = "tatcahinh";
					filename = str + ".txt";
					kq = $"\t\t\tBANG TONG HOP THONG TIN\n1) Tong so cac doi tuong hinh hoc la: {DemHinhHoc<HinhHoc>()}\n" +
						$"2) Tong so hinh tron la: {DemHinhHoc<HinhTron>()}\n" +
						$"3) Tong so hinh vuong la: {DemHinhHoc<HinhVuong>()}\n" +
						$"4) Tong so hinh chu nhat la {DemHinhHoc<HinhChuNhat>()}\n" +
						$"\nA. Danh sach hinh tron (theo chieu tang dien tich)\n{DanhSachKieuHinh<HinhTron>().SortHinhHoc<HinhTron>(1)}" +
						$"\n\nB. Danh sach hinh vuong(theo chieu tang dien tich)\n{DanhSachKieuHinh<HinhVuong>().SortHinhHoc<HinhVuong>(1)}" +
						$"\n\nC. Danh sach hinh chu nhat(theo chieu tang dien tich)\n{DanhSachKieuHinh<HinhChuNhat>().SortHinhHoc<HinhChuNhat>(1)}\n";
					break;
			}
			using (StreamWriter file = new StreamWriter(filename, append: false)) // FileMode.Append, FileAccess.Write)
			{
				file.Write(kq);
			}
		}
		#endregion
	}
}
