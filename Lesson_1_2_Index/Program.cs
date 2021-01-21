#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание. Пункт 2 - ИМТ
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_2_Index
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Для расчета ИМТ введите свои данные:\n");

			Console.WriteLine("Вес, кг");
			double m = Double.Parse(Console.ReadLine());
			//var m = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Рост, м");
			double h = Double.Parse(Console.ReadLine());
			//var h = Convert.ToDouble(Console.ReadLine());

			double index = Math.Round((m / (h * h)), 2);
			Console.WriteLine($"\nВаш ИМТ составляет {index}");

			Console.ReadKey();
		}
	}
}
