using System.Text;
using static System.Console;

namespace Mang1ChieuSoNguyen
{
	class Program
	{
		static void ChayChuongTrinh()
		{
			Menu menuM = new Menu();
			XuLyChuongTrinh xuLyChuongTrinh = new XuLyChuongTrinh();
			ProgramColor programColor = new ProgramColor();
			int menu;
			int soMenu = menuM.input.Length - 1;
			do
			{
				menu = xuLyChuongTrinh.ChonMenu(soMenu, menuM.input);
				ResetColor();
				ForegroundColor = programColor.ForegroundColor();
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