using System;
using static System.Console;

namespace Exercise_2
{
	class Course
	{
		public int courseCode;
		public string courseName;
		public int numberOfCredits;
		public int obligatoryCourse;
		public int electiveCourse;

		public void Creat()
		{
			Write("Enter your course code: ");
			courseCode = int.Parse(ReadLine());
			Write("Enter your course name: ");
			courseName = ReadLine();
			Write("Enter your number of credits: ");
			numberOfCredits = int.Parse(ReadLine());
			Write("Enter the obligatory course: ");
			obligatoryCourse = int.Parse(ReadLine());
			Write("Enter your elective course: ");
			electiveCourse = int.Parse(ReadLine());
		}

		public void Output()
		{
			WriteLine("\nYour course code is: " + courseCode);
			WriteLine("Your course name is: " + courseName);
			WriteLine("Your number of credits is: " + numberOfCredits);
			WriteLine("Yhe obligatory course is: " + obligatoryCourse);
			WriteLine("Your elective course is: " + electiveCourse);
		}
	}
}
