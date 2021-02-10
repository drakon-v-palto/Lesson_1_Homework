#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 4.1 - Пары элементов массива
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_3_Pass
{
	class Program
	{
		static int GetPairs(int[] array, int length)
		{
			int pairs = 0;
			// length - 1, чтобы индекс находился в пределах массива
			for (int i = 0; i < length - 1; i++)
				if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
					pairs++;
			return pairs;
		}

		static void Main(string[] args)
		{
			const int arrayLength = 20;
			int[] newArray = new int[arrayLength];
			Random random = new Random();
			int result;

			Console.WriteLine("Массив:\n");
			for (int i = 0; i < arrayLength; i++)
			{
				// проверено на парах от -10 до 10 при кол-ве элементов 5
				newArray[i] = random.Next(-10000, 10000);
				Console.Write(newArray[i] + ", ");
			}
			result = GetPairs(newArray, arrayLength);

			Console.WriteLine($"\n\nКоличество пар: {result}");

			Console.ReadKey();
		}
	}
}
