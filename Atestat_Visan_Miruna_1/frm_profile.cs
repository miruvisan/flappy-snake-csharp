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
    public partial class frm_profile : Form
    {
        public frm_profile()
        {
            InitializeComponent();
        }

        private void frm_profile_Load(object sender, EventArgs e)
        {
            LoadUserStats();
        }

        private void LoadUserStats()
        {
            try
            {
                var stats = DatabaseInitializer.GetUserStats(username.user);
                
                lblUsername.Text = "Username: " + username.user;
                lblGamesFlappy.Text = "Jocuri Flappy Pig: " + stats.GamesPlayedFlappy;
                lblGamesSnake.Text = "Jocuri Snake: " + stats.GamesPlayedSnake;
                lblBestFlappy.Text = "Best Score Flappy: " + stats.BestFlappyScore;
                lblBestSnake.Text = "Best Score Snake: " + stats.BestSnakeScore;
                lblTotalPoints.Text = "Total Puncte: " + stats.TotalPoints;
                lblLastDifficulty.Text = "Ultima Dificultate Snake: " + stats.LastDifficultySnake;

                // Progres bar-uri
                progressBarFlappy.Value = Math.Min(stats.BestFlappyScore / 10, 100);
                progressBarSnake.Value = Math.Min(stats.BestSnakeScore / 50, 100);

                // Win rate (aproximativ)
                int totalGames = stats.GamesPlayedFlappy + stats.GamesPlayedSnake;
                if (totalGames > 0)
                {
                    int winRate = (stats.TotalPoints / (totalGames * 10)) % 100;
                    lblWinRate.Text = "Rata Succes: ~" + Math.Min(winRate, 100) + "%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea statisticilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pagia_intrare f = new pagia_intrare();
            f.Show();
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            frm_leaderboard leaderboard = new frm_leaderboard();
            leaderboard.Show();
            this.Hide();
        }
    }
}
