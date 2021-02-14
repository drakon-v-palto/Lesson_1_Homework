#region Author
// Александр Столяров
// Домашнее задание 5.4 - Задача ЕГЭ
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_4_Grade
{
	struct Element
	{
		public string name;
		public double average;
	}

	class Program
	{
		// сортировка по среднему баллу
		static void Sort(ref Element[] pupils)
		{
			for (int i = 0; i < pupils.Length; i++)
			{
				for (int j = 0; j < pupils.Length - i - 1; j++)
				{
					if (pupils[j].average > pupils[j + 1].average)
					{
						Element tmp = pupils[j + 1];
						pupils[j + 1] = pupils[j];
						pupils[j] = tmp;
					}
				}
			}
		}

		static void Main()
		{
			int worstPupils = 3;
			StreamReader stream = new StreamReader("..\\..\\grade.txt");
			int num = int.Parse(stream.ReadLine());
			Element[] a = new Element[num];

			// читаем файл и парсим оценки
			for (int i = 0; i < num; i++)
			{
				string[] s = stream.ReadLine().Split(' ');
				a[i].name = s[0] + " " + s[1];
				a[i].average = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
			}
			stream.Close();  // освобождаем системные ресурсы

			string result = "";
			Sort(ref a);
			Element prev = a[0];

			for (int i = 0; i < worstPupils; i++)
			{
				if (i > 0)
				{
					if (prev.average == a[i].average)
						worstPupils++;
					prev = a[i];
				}
				result += string.Format("{0,-20} {1,-15:f2}\n", a[i].name, a[i].average);
			}

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
