
namespace Lesson_8_2_BelieveGame
{
	partial class Game
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.btnNo = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.introText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.IndianRed;
			this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNo.FlatAppearance.BorderSize = 0;
			this.btnNo.Font = new System.Drawing.Font("Tahoma", 11F);
			this.btnNo.ForeColor = System.Drawing.Color.White;
			this.btnNo.Location = new System.Drawing.Point(303, 180);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(100, 40);
			this.btnNo.TabIndex = 3;
			this.btnNo.Text = "Не верю";
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Visible = false;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// btnYes
			// 
			this.btnYes.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnYes.FlatAppearance.BorderSize = 0;
			this.btnYes.Font = new System.Drawing.Font("Tahoma", 11F);
			this.btnYes.ForeColor = System.Drawing.Color.White;
			this.btnYes.Location = new System.Drawing.Point(187, 180);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(100, 40);
			this.btnYes.TabIndex = 2;
			this.btnYes.Text = "Верю";
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Visible = false;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.ForeColor = System.Drawing.Color.White;
			this.btnStart.Location = new System.Drawing.Point(187, 140);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(216, 40);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Начать игру";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// introText
			// 
			this.introText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.introText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.introText.Location = new System.Drawing.Point(98, 40);
			this.introText.Name = "introText";
			this.introText.Size = new System.Drawing.Size(396, 82);
			this.introText.TabIndex = 0;
			this.introText.Text = "Сейчас вы увидите список утверждений, с которыми вам нужно согласиться или не сог" +
    "ласиться.\r\nНажимайте на кнопки ВЕРЮ или НЕ ВЕРЮ.\r\nУдачи!";
			this.introText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.introText.Click += new System.EventHandler(this.introText_Click);
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.introText);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnYes);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Игра \"Верю - не верю\"";
			this.Load += new System.EventHandler(this.Game_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label introText;
	}
}

