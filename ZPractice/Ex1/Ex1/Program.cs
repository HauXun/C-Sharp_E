using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Ex1
{
	class Program
	{
		static void ChayChuongTrinh()
		{
			Menu menuM = new Menu();
			XuLyChuongTrinh xuLyChuongTrinh = new XuLyChuongTrinh();
			int menu;
			int soMenu = menuM.input.Length - 1;
			do
			{
				menu = xuLyChuongTrinh.ChonMenu(soMenu, menuM.input);
				xuLyChuongTrinh.XuLy(menu);
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
