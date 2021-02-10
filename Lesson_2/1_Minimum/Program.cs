#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 2.1 - Минимальное число
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_1_Minimum
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите первое число");
			var a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе число");
			var b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите третье число");
			var c = Convert.ToInt32(Console.ReadLine());

			var min = a;

			if (a <= b && a <= c) min = a;
			else if (b <= c && b <= a) min = b;
			else min = c;

			Console.WriteLine($"Минимальное число {min}");
			Console.ReadKey();
		}
	}
}
