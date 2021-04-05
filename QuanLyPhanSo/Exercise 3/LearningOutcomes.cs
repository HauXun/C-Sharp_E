using System;
using static System.Console;

namespace Exercise_3
{
	class LearningOutcomes
	{
		public int courseCode;
		public string courseName;
		public int numberOfCredits;
		public int marks;

		public void Creat()
		{
			Write("Enter your course code: ");
			courseCode = int.Parse(ReadLine());
			Write("Enter your course name: ");
			courseName = ReadLine();
			Write("Enter your number of credits: ");
			numberOfCredits = int.Parse(ReadLine());
			Write("Enter you marks: ");
			marks = int.Parse(ReadLine());
		}

		public void Output()
		{
			WriteLine("\nYour course code is: " + courseCode);
			WriteLine("Your course name is: " + courseName);
			WriteLine("Your number of credits is: " + numberOfCredits);
			WriteLine("You marks is: " + marks);
		}
	}
}
