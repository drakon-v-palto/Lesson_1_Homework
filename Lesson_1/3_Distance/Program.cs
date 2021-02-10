#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание. Пункт 3 - Расстояние
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_3_Distance
{
	class Program
	{
		/*
		static void Main(string[] args)
		{
			double x1 = 5;
			double x2 = 37;
			double y1 = 4;
			double y2 = 49;

			Console.Write($"Начальная точка: x{x1} y{y1}\nКонечная точка: x{x2} y{y2}\n\n");

			double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			Console.WriteLine($"Расстояние = {dist:f}");

			Console.ReadKey();
		}
		*/

		static double dist;

		static double CountDist(int x1, int y1, int x2, int y2)
		{
			Console.Write($"Начальная точка: x{x1} y{y1}\nКонечная точка: x{x2} y{y2}\n\n");
			dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			return dist;
		}

		static void Main(string[] args)
		{
			CountDist(5, 4, 37, 49);
			Console.WriteLine($"Расстояние = {dist:f}");

			Console.ReadKey();
		}
	}
}
