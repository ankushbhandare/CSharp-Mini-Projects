using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths_Quiz
{
    public partial class Level : Form
    {

        private int SelectedLevel { get; set; }
        
        public Level()
        {
            InitializeComponent();
            lblValue.Text = tbarCount.Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbarCount_Scroll(object sender, EventArgs e)
        {
            lblValue.Text = tbarCount.Value.ToString();
        }

        private void Level_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectedLevel = cmbDifficulty.SelectedIndex;
            Quiz quiz = new Quiz();
            quiz.Owner = this;
            this.Hide();
            quiz.ShowDialog();
        }
    }
}
