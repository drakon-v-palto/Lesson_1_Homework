#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание. Пункт 1 - Анкета
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_1_Profile
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ваше имя");
			String name = Console.ReadLine();

			Console.WriteLine("Ваша фамилия");
			String surname = Console.ReadLine();

			Console.WriteLine("Возраст");
			String age = Console.ReadLine();

			Console.WriteLine("Рост");
			String height = Console.ReadLine();

			Console.WriteLine("Вес");
			String weight = Console.ReadLine();

			// а
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(name + ", " + surname + ", " + age + ", " + height + ", " + weight + "\n");

			// б
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Ваши данные: {1} {0}\nВозраст: {2}\nРост: {3}\nВес: {4}\n", name, surname, age, height, weight);

			// в
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Ваши данные: {surname} {name}\nВозраст: {age}\nРост: {height}\nВес: {weight}");

			Console.ReadKey();
		}
	}
}
