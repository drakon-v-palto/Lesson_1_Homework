#region Author
// Александр Столяров
// Домашнее задание 6.2 - Минимум функции
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_2_Minimum
{
	public delegate double Func(double x);

	class Program
	{
		public static void SaveFunc(string fileName, double a, double b, double h, Func F)
		{
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			while (a <= b)
			{
				bw.Write(F(a));
				a += h;
			}
			bw.Close();
			fs.Close();
		}

		public static double[] Load(string fileName, double min)
		{
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader bw = new BinaryReader(fs);

			double[] array = new double[fs.Length / sizeof(double)];
			min = double.MaxValue;
			double d;

			for (int i = 0; i < fs.Length / sizeof(double); i++)
			{
				// Считываем значение и переходим к следующему
				d = bw.ReadDouble();
				array[i] = d;
				if (d < min) min = d;
			}
			bw.Close();
			fs.Close();
			return array;
		}

		// квадрат
		static double Square(double x)
		{
			return x * x;
		}

		// синус
		static double Sin(double x)
		{
			return Math.Sin(x);
		}

		// проверка на число
		static int Int(int max)
		{
			while (true)
				if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
					Console.Write("Введите число от 0 до {0})", max);
				else return x;
		}

		// интервал чисел
		static void Interval(out double start, out double end)
		{
			string[] interval = Console.ReadLine().Split(' ');
			start = double.Parse(interval[0], CultureInfo.InvariantCulture);
			end = double.Parse(interval[1], CultureInfo.InvariantCulture);
		}

		// таблица результатов вычислений
		static void Result(double a, double b, double h, double[] values)
		{
			Console.WriteLine("------- X ------- Y -----");
			int index = 0;
			while (a <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", a, values[index]);
				a += h;
				index++;
			}
			Console.WriteLine("--------------------------");
		}

		static void Main()
		{
			List<Func> functions = new List<Func> { new Func(Square), new Func(Sin) };
			Console.WriteLine("Выберите функцию\n(1) f(x)=y^2\n(2) f(x)=Sin(y)");
			int user = Int(functions.Count);

			Console.WriteLine("Задайте интервал для нахождения минимума в формате 'х1 х2' через пробел:");

			double a = 0;
			double b = 0;
			Interval(out a, out b);

			Console.WriteLine("Задайте величинау шага:");
			double h = double.Parse(Console.ReadLine());

			SaveFunc("data.bin", a, b, h, functions[user - 1]);
			double min = double.MaxValue;
			Result(a, b, h, Load("data.bin", min));

			Console.ReadKey();
		}
	}
}
