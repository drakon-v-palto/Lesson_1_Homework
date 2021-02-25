#region Author
// Александр Столяров
// Домашнее задание 8.1 - Вопросы для игры
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
	static class Program
	{
		// однопоточное приложение, начало
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new GameForm());
		}
	}
}
