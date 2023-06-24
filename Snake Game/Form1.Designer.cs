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
            this.startbtn = new System.Windows.Forms.Button();
            this.capturebtn = new System.Windows.Forms.Button();
            this.gamebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamebox)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.LightBlue;
            this.startbtn.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startbtn.Location = new System.Drawing.Point(628, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(92, 42);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = false;
            // 
            // capturebtn
            // 
            this.capturebtn.BackColor = System.Drawing.Color.SkyBlue;
            this.capturebtn.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capturebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.capturebtn.Location = new System.Drawing.Point(628, 60);
            this.capturebtn.Name = "capturebtn";
            this.capturebtn.Size = new System.Drawing.Size(92, 42);
            this.capturebtn.TabIndex = 1;
            this.capturebtn.Text = "Capture the moment";
            this.capturebtn.UseVisualStyleBackColor = false;
            // 
            // gamebox
            // 
            this.gamebox.BackColor = System.Drawing.Color.SteelBlue;
            this.gamebox.Location = new System.Drawing.Point(25, 12);
            this.gamebox.Name = "gamebox";
            this.gamebox.Size = new System.Drawing.Size(580, 680);
            this.gamebox.TabIndex = 2;
            this.gamebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.gamebox);
            this.Controls.Add(this.capturebtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.gamebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button startbtn;
        private Button capturebtn;
        private PictureBox gamebox;
    }
}