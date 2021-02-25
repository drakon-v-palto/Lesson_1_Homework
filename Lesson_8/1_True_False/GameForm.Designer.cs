
namespace BelieveOrNotBelieve
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.nudNumber = new System.Windows.Forms.NumericUpDown();
			this.cboxTrue = new System.Windows.Forms.CheckBox();
			this.textQuestion = new System.Windows.Forms.TextBox();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.miNew = new System.Windows.Forms.ToolStripMenuItem();
			this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.navbar = new System.Windows.Forms.ToolStrip();
			this.about = new System.Windows.Forms.ToolStripButton();
			this.btnSaveQuest = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
			this.navbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(30, 230);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 40);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(146, 230);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 40);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// nudNumber
			// 
			this.nudNumber.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudNumber.Location = new System.Drawing.Point(510, 237);
			this.nudNumber.Name = "nudNumber";
			this.nudNumber.Size = new System.Drawing.Size(60, 25);
			this.nudNumber.TabIndex = 4;
			this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
			// 
			// cboxTrue
			// 
			this.cboxTrue.AutoSize = true;
			this.cboxTrue.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cboxTrue.Location = new System.Drawing.Point(586, 53);
			this.cboxTrue.Name = "cboxTrue";
			this.cboxTrue.Size = new System.Drawing.Size(73, 21);
			this.cboxTrue.TabIndex = 5;
			this.cboxTrue.Text = "Правда";
			this.cboxTrue.UseVisualStyleBackColor = true;
			this.cboxTrue.CheckedChanged += new System.EventHandler(this.cboxTrue_CheckedChanged);
			// 
			// textQuestion
			// 
			this.textQuestion.Location = new System.Drawing.Point(30, 53);
			this.textQuestion.Multiline = true;
			this.textQuestion.Name = "textQuestion";
			this.textQuestion.Size = new System.Drawing.Size(540, 150);
			this.textQuestion.TabIndex = 6;
			this.textQuestion.TextChanged += new System.EventHandler(this.textQuestion_TextChanged);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.AutoToolTip = false;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.toolStripSeparator1,
            this.miExit});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
			this.toolStripDropDownButton1.Text = "Меню";
			this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
			// 
			// miNew
			// 
			this.miNew.Image = global::BelieveOrNotBelieve.Properties.Resources.doc_empty_icon_16;
			this.miNew.Name = "miNew";
			this.miNew.Size = new System.Drawing.Size(180, 22);
			this.miNew.Text = "&New";
			this.miNew.Click += new System.EventHandler(this.miNew_Click);
			// 
			// miOpen
			// 
			this.miOpen.Image = global::BelieveOrNotBelieve.Properties.Resources.folder_open_icon_16;
			this.miOpen.Name = "miOpen";
			this.miOpen.Size = new System.Drawing.Size(180, 22);
			this.miOpen.Text = "&Open";
			this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
			// 
			// miSave
			// 
			this.miSave.Image = global::BelieveOrNotBelieve.Properties.Resources.save_icon_16;
			this.miSave.Name = "miSave";
			this.miSave.Size = new System.Drawing.Size(180, 22);
			this.miSave.Text = "&Save";
			this.miSave.Click += new System.EventHandler(this.miSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// miExit
			// 
			this.miExit.Image = global::BelieveOrNotBelieve.Properties.Resources.on_off_icon_16;
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(180, 22);
			this.miExit.Text = "&Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// navbar
			// 
			this.navbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.about});
			this.navbar.Location = new System.Drawing.Point(0, 0);
			this.navbar.Name = "navbar";
			this.navbar.Size = new System.Drawing.Size(684, 25);
			this.navbar.TabIndex = 0;
			this.navbar.Text = "navbar";
			this.navbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.navbar_ItemClicked);
			// 
			// about
			// 
			this.about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
			this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(23, 22);
			this.about.Text = "?";
			this.about.ToolTipText = "О программе";
			this.about.Click += new System.EventHandler(this.about_Click);
			// 
			// btnSaveQuest
			// 
			this.btnSaveQuest.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSaveQuest.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveQuest.FlatAppearance.BorderSize = 0;
			this.btnSaveQuest.Location = new System.Drawing.Point(262, 230);
			this.btnSaveQuest.Name = "btnSaveQuest";
			this.btnSaveQuest.Size = new System.Drawing.Size(200, 40);
			this.btnSaveQuest.TabIndex = 3;
			this.btnSaveQuest.Text = "Сохранить предложение";
			this.btnSaveQuest.UseVisualStyleBackColor = false;
			this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
			// 
			// GameForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 296);
			this.Controls.Add(this.textQuestion);
			this.Controls.Add(this.cboxTrue);
			this.Controls.Add(this.nudNumber);
			this.Controls.Add(this.btnSaveQuest);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.navbar);
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вопросы";
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
			this.navbar.ResumeLayout(false);
			this.navbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.NumericUpDown nudNumber;
		private System.Windows.Forms.CheckBox cboxTrue;
		private System.Windows.Forms.TextBox textQuestion;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem miNew;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStrip navbar;
		private System.Windows.Forms.Button btnSaveQuest;
		private System.Windows.Forms.ToolStripButton about;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

