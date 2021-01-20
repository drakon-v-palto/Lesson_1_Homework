#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание. Пункт 5 - Текст по центру
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_1_5_Center
{
	class Program
	{
		static void Main(string[] args)
		{
			// эксперимент с размером окна
			Console.SetWindowSize(Console.WindowWidth, 70);
			Console.SetWindowSize(Console.WindowHeight, 30);

			var text = "Александр\nСтоляров\nСанкт-Петербург";

			// массив строк
			var lines = Regex.Split(text, "\n");

			// одинаковое пространство сверху и снизу в видимой части окна, 
			// независимо от количества строк
			int top = Console.WindowHeight / 2 - lines.Length / 2 - 1;
			int center = Console.WindowWidth / 2;
			int left = 0;

			for (var i = 0; i < lines.Length; i++)
			{
				left = center - lines[i].Length / 2;
				Console.SetCursorPosition(left, top);
				Console.WriteLine(lines[i]);
				top = Console.CursorTop;
			}

			Console.ReadKey();
		}
	}
}
