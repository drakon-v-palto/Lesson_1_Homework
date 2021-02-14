#region Author
// Александр Столяров
// Домашнее задание 5.1 - Корректность логина
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_5_1_Login
{
	class Program
	{
		// проверка на латиницу
		private static bool IsLatin(char letter)
		{
			int code = letter;
			// коды стандартных символов - 65-90 = A-Z / 97-122 = a-z
			return (code >= 65 && code <= 90) || (code >= 97 && code <= 122);
		}

		// проверка через регулярное выражение
		static bool LoginCheckRegex(string login) => Regex.IsMatch(login, @"^[A-Za-z0-9]+${2,10}");

		// проверка логина
		private static bool LoginCheck(string login)
		{
			int length = login.Length;
			if (length >= 2 && length <= 10)
			{
				bool check = true;
				char letter = login[0];

				if (char.IsDigit(letter))
					return false;

				for (int i = 1; i < length; i++)
				{
					letter = login[i];
					if (!(char.IsDigit(letter) || IsLatin(letter)))
					{
						check = false;
						break;
					}
				}

				if (check) return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			int count = 0;
			do
			{
				Console.Write("Введите логин: ");
				string login = Console.ReadLine();

				if (LoginCheck(login) && LoginCheckRegex(login))
				{
					Console.WriteLine("Логин корректный");
					break;
				}
				else
				{
					Console.WriteLine("Используйте латинские буквы и цифры. Длина должна быть от 2 до 10 символов.");
					count++;
				}
			} while (count < 3);

			Console.ReadKey();
		}
	}
}
