using System;
using System.Drawing;
using System.Linq;

namespace QuanLyDanhBa
{
	class XuLyMauSac
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

		public Color GetContrastColor(Color colorA)
		{
			int nThreshold = 105;
			int bgDelta = Convert.ToInt32((colorA.R * 0.299) + (colorA.G * 0.587) +
										  (colorA.B * 0.114));

			Color foreColor = (255 - bgDelta < nThreshold) ? Color.Black : Color.White;
			return foreColor;
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

		private Color FromColor(ConsoleColor c)
		{
			int[] cColors = {   0x000000, //Black = 0
                        0x000080, //DarkBlue = 1
                        0x008000, //DarkGreen = 2
                        0x008080, //DarkCyan = 3
                        0x800000, //DarkRed = 4
                        0x800080, //DarkMagenta = 5
                        0x808000, //DarkYellow = 6
                        0xC0C0C0, //Gray = 7
                        0x808080, //DarkGray = 8
                        0x0000FF, //Blue = 9
                        0x00FF00, //Green = 10
                        0x00FFFF, //Cyan = 11
                        0xFF0000, //Red = 12
                        0xFF00FF, //Magenta = 13
                        0xFFFF00, //Yellow = 14
                        0xFFFFFF  //White = 15
                    };
			return Color.FromArgb(cColors[(int)c]);
		}
	}
}
