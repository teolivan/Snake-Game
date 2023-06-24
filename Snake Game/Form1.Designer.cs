namespace Snake_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startbtn = new System.Windows.Forms.Button();
            this.capturebtn = new System.Windows.Forms.Button();
            this.gamebox = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gamebox)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.LightBlue;
            this.startbtn.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startbtn.Location = new System.Drawing.Point(612, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(92, 42);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.StartGame);
            // 
            // capturebtn
            // 
            this.capturebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.capturebtn.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capturebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.capturebtn.Location = new System.Drawing.Point(612, 60);
            this.capturebtn.Name = "capturebtn";
            this.capturebtn.Size = new System.Drawing.Size(92, 42);
            this.capturebtn.TabIndex = 1;
            this.capturebtn.Text = "Capture the moment";
            this.capturebtn.UseVisualStyleBackColor = false;
            this.capturebtn.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // gamebox
            // 
            this.gamebox.BackColor = System.Drawing.Color.SteelBlue;
            this.gamebox.Location = new System.Drawing.Point(26, 12);
            this.gamebox.Name = "gamebox";
            this.gamebox.Size = new System.Drawing.Size(580, 680);
            this.gamebox.TabIndex = 2;
            this.gamebox.TabStop = false;
            this.gamebox.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(612, 136);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 16);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHighScore.Location = new System.Drawing.Point(612, 167);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(103, 16);
            this.txtHighScore.TabIndex = 4;
            this.txtHighScore.Text = "HighScore: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.gamebox);
            this.Controls.Add(this.capturebtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.gamebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startbtn;
        private Button capturebtn;
        private PictureBox gamebox;
        private Label txtScore;
        private Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}