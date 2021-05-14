using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace QuanLyDanhBa
{
	static class Program
	{
		public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> seft) => seft.Select((item, index) => (item, index));
		static void ChayChuongTrinh()
		{
			Menu menuM = new Menu();
			XuLyMenu xuLyMenu = new XuLyMenu();
			XuLyMauSac xuLyMauSac = new XuLyMauSac();
			int menu;
			int soMenu = menuM.input.Length - 1;
			do
			{
				menu = xuLyMenu.ChonMenu(soMenu, menuM.input);
				ResetColor();
				ForegroundColor = xuLyMauSac.ForegroundColor();
				xuLyMenu.XuLy(menu);
			} while (menu > 0);
		}
		static void Main(string[] args)
		{
			OutputEncoding = Encoding.UTF8;
			ChayChuongTrinh();
			return;
		}
	}
}
