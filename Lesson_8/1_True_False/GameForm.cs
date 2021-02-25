using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
	public partial class GameForm : Form
	{
		// База данных с вопросами
		TrueFalse _database;

		public GameForm()
		{
			InitializeComponent();
			textQuestion.Text = "Откройте файл database.xml";
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnSaveQuest.FlatStyle = FlatStyle.Flat;
			//this.KeyPreview = true;
		}
		/*
		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == (Keys.Control | Keys.N))
			{
				btnAdd.PerformClick();
			}
		}
		*/

		// Меню

		private void navbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void toolStripDropDownButton1_Click(object sender, EventArgs e)
		{
		}

		private void miNew_Click(object sender, EventArgs e)
		{
			// из методички
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				_database = new TrueFalse(sfd.FileName);
				_database.Add("Кошка - друг человека", true);
				_database.Save();

				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
				nudNumber.Value = 1;
			}
		}

		private void miOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				_database = new TrueFalse(ofd.FileName);
				_database.Load();

				nudNumber.Minimum = 1;
				nudNumber.Maximum = _database.Count;
				nudNumber.Value = 1;
			}
		}

		private void miSave_Click(object sender, EventArgs e)
		{
			if (_database != null) _database.Save();
			else MessageBox.Show("База данных не создана");
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void about_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Список вопросов для игры «Верю – не верю»\nАвтор: Александр Столяров\nВерсия 0.0.7beta",
				"О программе");
		}


		// Текст и чекбокс

		private void textQuestion_TextChanged(object sender, EventArgs e)
		{
		}

		private void cboxTrue_CheckedChanged(object sender, EventArgs e)
		{
		}


		// Кнопки

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (_database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			_database.Add((_database.Count + 1).ToString(), true);
			nudNumber.Maximum = _database.Count;
			nudNumber.Value = _database.Count;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Удалить вопрос?", "Подтвердите действие", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				if (nudNumber.Maximum == 1 || _database == null) return;
				_database.Remove((int)nudNumber.Value);
				nudNumber.Maximum--;
				if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
			}
		}

		private void btnSaveQuest_Click(object sender, EventArgs e)
		{
			try
			{
				textQuestion.Text = _database[(int)nudNumber.Value - 1].text;
				cboxTrue.Checked = _database[(int)nudNumber.Value - 1].trueFalse;
			}
			catch (NullReferenceException ex)
			{
				MessageBox.Show($"Подробности: {ex.Message}", "Откройте или создайте файл с вопросами");
			}
		}

		private void nudNumber_ValueChanged(object sender, EventArgs e)
		{
			if (_database != null)
			{
				textQuestion.Text = _database[(int)nudNumber.Value - 1].text;
				cboxTrue.Checked = _database[(int)nudNumber.Value - 1].trueFalse;
			}
		}
		/*
		private void miSaveAs_Click(object sender, EventArgs e)
		{
			SaveAsDialog sad = new SaveAsDialog();

			if (_database == null)
			{
				_database = new TrueFalse(saveFileDialog.FileName);
				_database.Add("Кошка - друг человека", true);
				_database.Save();

				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
				nudNumber.Value = 1;
				MessageBox.Show("Файл сохранен");
			}
			else
			{
				_database.FileName = saveFileDialog.FileName;
				_database.Save();
				MessageBox.Show("Файл сохранен");
			}
		}
		*/
		private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
		}
	}

	internal class SaveAsDialog
	{
	}
}
