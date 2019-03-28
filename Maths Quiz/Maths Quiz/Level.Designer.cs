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
            ((System.ComponentModel.ISupportInitialize)(this.tbarCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(59, 56);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(109, 13);
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
            this.cmbDifficulty.Location = new System.Drawing.Point(62, 94);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cmbDifficulty.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(62, 162);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(176, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbarCount
            // 
            this.tbarCount.Location = new System.Drawing.Point(256, 94);
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
            this.lblCount.Location = new System.Drawing.Point(253, 56);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(139, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Select Number of Questions";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(380, 102);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 13);
            this.lblValue.TabIndex = 6;
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbarCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Name = "Level";
            this.Text = "Level";
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
    }
}