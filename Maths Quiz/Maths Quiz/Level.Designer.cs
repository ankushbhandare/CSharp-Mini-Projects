namespace Maths_Quiz
{
    partial class Level
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
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbarCount = new System.Windows.Forms.TrackBar();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(47, 80);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(148, 15);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Select Difficulty Level";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(264, 80);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cmbDifficulty.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(105, 195);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(259, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbarCount
            // 
            this.tbarCount.LargeChange = 2;
            this.tbarCount.Location = new System.Drawing.Point(264, 128);
            this.tbarCount.Maximum = 20;
            this.tbarCount.Minimum = 1;
            this.tbarCount.Name = "tbarCount";
            this.tbarCount.Size = new System.Drawing.Size(104, 45);
            this.tbarCount.TabIndex = 4;
            this.tbarCount.Value = 1;
            this.tbarCount.Scroll += new System.EventHandler(this.tbarCount_Scroll);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(47, 135);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(187, 15);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Select Number of Questions";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(377, 136);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 17);
            this.lblValue.TabIndex = 6;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(72, 24);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(313, 18);
            this.lblIntro.TabIndex = 7;
            this.lblIntro.Text = "Welcome To Maths Quiz by Ankush";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maths_Quiz.Properties.Resources.White_light_dot_with_blurs_christmas_background_vector_03;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbarCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Quiz by Ankush";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbarCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar tbarCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblIntro;
    }
}