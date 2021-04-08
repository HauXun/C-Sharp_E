namespace GeometryManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			ChayChuongTrinh();
		}

		static void ChayChuongTrinh()
		{
			Menu menu1 = new Menu();
			int menu;
			int soMenu = menu1.options.Length - 1;

			do
			{
				menu = menu1.ChonMenu(soMenu);
				menu1.XuLyMenu(menu);
			} while (menu > 0);
		}
	}
}
