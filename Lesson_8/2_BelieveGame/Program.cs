#region Author
// Александр Столяров
// Домашнее задание 8.2 - Игра "Верю - не верю"
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8_2_BelieveGame
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Game());
		}
	}
}
