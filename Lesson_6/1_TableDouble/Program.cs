#region Author
// Александр Столяров
// Домашнее задание 6.1 - Таблица функции
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1_TableDouble
{
	public delegate double Func(double a, double x);

	class Program
	{
		// Создаем метод, который принимает делегат
		public static void Table(Func F, double a, double x, double b)
		{
			Console.WriteLine("------ A ------ X ------ Y -------");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
				x += 1;
			}
			Console.WriteLine("----------------------------------");
		}

		// Создаем метод для передачи его в качестве параметра в Table
		public static double MyFunc(double a, double x)
		{
			return a * x * x;
		}

		// Создаем метод получения синуса
		public static double Sin(double a, double x)
		{
			return a * Math.Sin(x);
		}

		static void Main(string[] args)
		{
			// Создаем новый делегат Func и передаем ссылку на него в метод Table
			Console.WriteLine("     Функция a*x^2:\n");
			Table(new Func(MyFunc), -3, -2, 2);

			Console.WriteLine("\n\n     Функция a*sin(x):\n");
			Table(new Func(MyFunc), 4, -2, 2);

			Console.ReadKey();
		}
	}
}
