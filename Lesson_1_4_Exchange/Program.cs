#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание. Пункт 4 - Обмен
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_4_Exchange
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Замена значений через третью переменную");

			int a = 13;
			int b = 44;
			Console.WriteLine("Первое значение " + a + "\nВторое значение " + b + "\n");

			int с = a;
			a = b;
			b = с;
			Console.WriteLine("Первое значение " + a + "\nВторое значение " + b);

			Console.ReadLine();

			/*****/

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Замена без третьей переменной");

			int g = 13;
			int h = 44;
			g = g + h - (h = g);
			//g = g + h;
			//h = g - h;
			//g = g - h;
			Console.WriteLine("Первое значение " + g + "\nВторое значение " + h);

			Console.ReadKey();
		}
	}
}
