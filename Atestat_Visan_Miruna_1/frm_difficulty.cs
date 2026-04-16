using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Visan_Miruna_1
{
    public partial class frm_difficulty : Form
    {
        public frm_difficulty()
        {
            InitializeComponent();
        }

        private void frm_difficulty_Load(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            setari.Difficulty = DifficultyLevel.Easy;
            DatabaseInitializer.UpdateDifficultySnake(username.user, "Easy");
            frm_sarpe snake = new frm_sarpe();
            snake.Show();
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            setari.Difficulty = DifficultyLevel.Medium;
            DatabaseInitializer.UpdateDifficultySnake(username.user, "Medium");
            frm_sarpe snake = new frm_sarpe();
            snake.Show();
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            setari.Difficulty = DifficultyLevel.Hard;
            DatabaseInitializer.UpdateDifficultySnake(username.user, "Hard");
            frm_sarpe snake = new frm_sarpe();
            snake.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pagia_intrare intro = new pagia_intrare();
            intro.Show();
            this.Close();
        }
    }
}
