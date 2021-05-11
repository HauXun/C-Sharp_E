using System;
using System.Linq;

namespace Mang1ChieuSoNguyen
{
	class ProgramColor
	{
		// Xử lý thuộc tính
		static Random random = new Random();
		static ConsoleColor color;
		static int minValueColor = Enum.GetValues(typeof(ConsoleColor)).Cast<int>().Min();
		static int maxValueColor = Enum.GetValues(typeof(ConsoleColor)).Cast<int>().Max();


		// Pick random
		public ConsoleColor ForegroundColor()
		{
			do
			{
				color = (ConsoleColor)random.Next(minValueColor, maxValueColor);
			} while (!ExistColor((int)color) || color == ConsoleColor.Black);
			return color;
		}

		public ConsoleColor BackgroundColor()
		{
			do
			{
				color = (ConsoleColor)random.Next(minValueColor, maxValueColor);
			} while (!ExistColor((int)color) || color == ConsoleColor.Gray || color == ConsoleColor.Cyan);
			return color;
		}


		// Xử lý màu sắc ngoại lệ
		private bool ExistColor(int color) => ConsoleColor.IsDefined(typeof(ConsoleColor), color);

		private bool ExitsColor(Enum @enum)
		{
			var query = from enumVal in Enum.GetNames(typeof(ConsoleColor))
						where enumVal == @enum.ToString()
						select enumVal;

			return query.Count() == 1;
		}
	}
}
