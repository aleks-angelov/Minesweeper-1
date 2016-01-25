using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class DifficultyWindow : Form
    {
        public DifficultyWindow()
        {
            InitializeComponent();
        }

        public int Level => difficulty_scale.Value;

        private void difficulty_scale_Scroll(object sender, EventArgs e)
        {
            difficulty_value.Text = difficulty_scale.Value.ToString();
        }

        private void difficulty_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Environment.Exit(0);
        }
    }
}