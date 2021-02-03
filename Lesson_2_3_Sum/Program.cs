#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 2.3 - Сумма нечетных положительных чисел
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 0;
			int sum = 0;

			do
			{
				num = int.Parse(Console.ReadLine());
				if (num > 0 && num % 2 != 0)  // еще вариант получения нечетного числа - num % 2 == 1
					sum += num;

			} while (num != 0);

			Console.WriteLine($"Сумма {sum}");
			Console.ReadKey();
		}
	}
}
