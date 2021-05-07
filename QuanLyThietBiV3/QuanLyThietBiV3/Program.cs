using System;

namespace QuanLyThietBiV3
{
	class Program
	{
		static void Main(string[] args)
		{
			ChayChuongTrinh();
		}

		static void ChayChuongTrinh()
		{
			Menu menuM = new Menu();
			int menu;
			int soMenu = menuM.options.Length - 1;
			do
			{
				menu = menuM.ChonMenu(soMenu);
				menuM.XuLyMenu(menu);
			} while (menu > 0);
		}
	}
}
