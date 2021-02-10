#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 2.2 - Количество цифр
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_2_Count
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите число:");
			string number = GetNumber();

			Console.WriteLine($"\nКоличество цифр: {number.Length}");
			Console.ReadKey();
		}

		static string GetNumber()
		{
			string number = "";
			bool notNumber;

			do
			{
				notNumber = false;
				number = Console.ReadLine();
				for (int i = 0; i < number.Length; i++)
				{
					if (!char.IsNumber(number, i))
					{
						notNumber = true;
						Console.WriteLine("Введите число без пробелов и других символов:");
						break;
					}
				}
			} while (notNumber);

			return number;
		}
	}
}
