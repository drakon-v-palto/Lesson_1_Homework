#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 2.4 - Проверка логина и пароля
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_2_4_Pass
{
	class Program
	{
		static void Main(string[] args)
		{
			string login = "root";
			string password = "GeekBrains";

			int count = 0;
			do
			{
				Console.WriteLine("\nВведите логин:");
				string checkLogin = Console.ReadLine();

				Console.WriteLine("Введите пароль:");
				string checkPassword = Console.ReadLine();

				if (checkLogin == login && checkPassword == password)
				{
					Console.WriteLine("\nДоступ открыт");
					break;
				}
				else if (checkLogin != login && checkPassword == password) Console.WriteLine("Неправильный логин");
				else if (checkLogin == login && checkPassword != password) Console.WriteLine("Неправильный пароль");
				else Console.WriteLine("Неправильный логин или пароль");

				count++;
			} while (count < 3);

			Console.ReadKey();
		}
	}
}
