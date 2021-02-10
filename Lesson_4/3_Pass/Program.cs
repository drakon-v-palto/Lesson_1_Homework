#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 4.3 - Логин и пароль в массив
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4_3_Pass
{
	class Program
	{
		struct Account
		{
			public string login;
			public string password;

			public void LoadFile(string file)
			{
				if (file is null)
					throw new ArgumentNullException(nameof(file));

				file = "..\\..\\" + file;  // если убрать file, то ищет по пути \bin\Debug\pass.txt
				StreamReader stream = new StreamReader(file);
				login = stream.ReadLine();
				password = stream.ReadLine();
			}
		}

		// чтение данных из файла
		static bool Check(Account check)
		{
			// запрос данных у пользователя
			//Console.Write("Введите логин: ");
			//check.login = Console.ReadLine();

			//Console.Write("Введите пароль: ");
			//check.password = Console.ReadLine();

			if (check.login == "root" && check.password == "GeekBrains")
				return true;
			else
				return false;
		}

		static void Main(string[] args)
		{
			string[] fileName = { "pass.txt" };

			Account pass;
			pass.login = "";
			pass.password = "";

			int count = 0;
			do
			{
				pass.LoadFile(fileName[count]);

				if (Check(pass))
				{
					Console.WriteLine("Доступ открыт");
					break;
				}
				//else if (checkLogin != login && checkPassword == password) Console.WriteLine("Неправильный логин");
				//else if (checkLogin == login && checkPassword != password) Console.WriteLine("Неправильный пароль");
				else Console.WriteLine("Неправильный логин или пароль");

				count++;
			} while (count < 3);

			Console.ReadKey();
		}
	}
}
