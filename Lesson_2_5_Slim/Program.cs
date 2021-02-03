#region Author
// Александр Столяров
#endregion

#region Homework
// Домашнее задание 2.5 - Индекс массы тела
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_5_Slim
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ваш рост (см)");
			double height = double.Parse(Console.ReadLine());
			height /= 100;  // перевод в сантиметры

			Console.WriteLine("Ваш вес (кг)");
			double weight = double.Parse(Console.ReadLine());

			double index = weight / (height * height);

			Console.WriteLine(CheckBMI(index, height));
			Console.ReadKey();
		}

		static string CheckBMI(double index, double height)
		{
			string result = "";
			double norm;

			if (index <= 18.50)
			{
				norm = (18.5 - index) * height * height;
				result = string.Format($"\nИМТ {index:N2} - недостаточная масса тела\nНеобходимо набрать не менее {norm:0} кг");
			}
			else if (index > 18.50 && index <= 25.00)
			{
				result = string.Format($"\nИМТ {index:N2} - нормальная масса тела");
			}
			else if (index > 25.00)
			{
				norm = (index - 25) * height * height;
				result = string.Format($"\nИМТ {index:N2} - избыточная масса тела или ожирение\nНеобходимо сбросить не менее {norm:0} кг");
			}

			#region Точный расчет (нужны правильные формулы)
			/*
			if (index <= 16.50)
			{
				norm = (16.5 - index) * height * height;  // неправильно: считает набор веса до недостаточной
				result = string.Format($"\nИМТ {index:N2} - выраженный дефицит массы тела\nНеобходимо набрать не менее {norm:0} кг");
			}
			else if (index > 16.50 && index <= 18.50)
			{
				norm = (18.5 - index) * height * height;  // правильно
				result = string.Format($"\nИМТ {index:N2} - недостаточная масса тела (дефицит)\nНеобходимо набрать не менее {norm:0} кг");
			}
			else if (index > 18.50 && index <= 25.00)  // правильно
			{
				result = string.Format($"\nИМТ {index:N2} - нормальная масса тела");
			}
			else if (index > 25.00 && index <= 30.00)
			{
				norm = (index - 25) * height * height;  // правильно
				result = string.Format($"\nИМТ {index:N2} - избыточная масса тела (предожирение)\nНеобходимо сбросить не менее {norm:0} кг");
			}
			else if (index > 30.00 && index <= 35.00)
			{
				norm = (index - 30) * height * height;  // неправильно: считает сброс веса до избыточной
				result = string.Format($"\nИМТ {index:N2} - ожирение I степени\nНеобходимо сбросить не менее {norm:0} кг");
			}
			else if (index > 35.00 && index <= 40.00)
			{
				norm = (index - 35) * height * height;  // неправильно: считает сброс веса до 1 степени
				result = string.Format($"\nИМТ {index:N2} - ожирение II степени\nНеобходимо сбросить не менее {norm:0} кг");
			}
			else if (index > 40.00)
			{
				norm = (index - 40) * height * height;  // неправильно: считает сброс веса до 2 степени
				result = string.Format($"\nИМТ {index:N2} - ожирение III степени\nНеобходимо сбросить не менее {norm:0} кг");
			}
			*/
			#endregion

			return result;
		}
	}
}
