using System;
using System.Collections.Generic;

namespace ThuVienDungChung
{
	public class GeneralLibrary
	{
		public static List<string> dsHang = new List<string>();
		public static void Them<T>(string hang)
		{
			Type t = typeof(T);
			if (!dsHang.Contains(hang))
			{
				if (t.Name == "CPU" && t.Name != "RAM" && t.Name != "HDD" && t.Name != "MAINBOARD" && t.Name != "PSU")
				{
					if (hang.Equals("Intel") || hang.Equals("AMD"))
						dsHang.Add(hang);
				}
				else
					dsHang.Add(hang);
			}
		}
	}
}
