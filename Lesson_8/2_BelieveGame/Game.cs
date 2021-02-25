using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8_2_BelieveGame
{
	public partial class Game : Form
	{
		public Game()
		{
			InitializeComponent();
			btnStart.FlatStyle = FlatStyle.Flat;
			btnYes.FlatStyle = FlatStyle.Flat;
			btnNo.FlatStyle = FlatStyle.Flat;
		}

		private void introText_Click(object sender, EventArgs e)
		{
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			btnYes.Visible = true;
			btnNo.Visible = true;
			introText.Visible = false;
			btnStart.Visible = false;
		}

		private void Game_Load(object sender, EventArgs e)
		{
		}

		private void btnYes_Click(object sender, EventArgs e)
		{

		}

		private void btnNo_Click(object sender, EventArgs e)
		{

		}
	}
}
