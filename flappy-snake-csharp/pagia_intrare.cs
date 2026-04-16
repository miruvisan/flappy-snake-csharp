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
    public partial class pagia_intrare : Form
    {
        private Timer fadeTimer = new Timer();
        private float opacity = 0f;
        private bool fadeIn = true;

        public pagia_intrare()
        {
            InitializeComponent();
            this.Opacity = 0;

            // Configurare fade timer
            fadeTimer.Interval = 30;
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                opacity += 0.05f;
                if (opacity >= 1f)
                {
                    opacity = 1f;
                    fadeIn = false;
                    fadeTimer.Stop();
                }
            }
            this.Opacity = opacity;
        }

        private void pagia_intrare_Load(object sender, EventArgs e)
        {
            label4.Text = "Bine ai venit, " + username.user + "! 🎮";

            // Incarca best scores din baza de date
            int bestFlappyScore = DatabaseInitializer.GetBestFlappyScore(username.user);
            int bestSnakeScore = DatabaseInitializer.GetBestSnakeScore(username.user);

            scor1.Text = "Best Score Flappy Pig: " + bestFlappyScore;
            scor2.Text = "Best Score Snake: " + bestSnakeScore;

            // Hover effects pentru butoane
            btnflap.MouseEnter += (s, ev) => btnflap.BackColor = Color.FromArgb(213, 184, 255);
            btnflap.MouseLeave += (s, ev) => btnflap.BackColor = Color.Transparent;

            btnsnake.MouseEnter += (s, ev) => btnsnake.BackColor = Color.FromArgb(132, 140, 207);
            btnsnake.MouseLeave += (s, ev) => btnsnake.BackColor = Color.Transparent;

            btnSettings.MouseEnter += (s, ev) => btnSettings.BackColor = Color.FromArgb(200, 100, 100);
            btnSettings.MouseLeave += (s, ev) => btnSettings.BackColor = Color.FromArgb(100, 100, 100);

            btnLogout.MouseEnter += (s, ev) => btnLogout.BackColor = Color.FromArgb(200, 50, 50);
            btnLogout.MouseLeave += (s, ev) => btnLogout.BackColor = Color.FromArgb(150, 50, 50);
        }

        private void btsnake_Click(object sender, EventArgs e)
        {
            frm_flappig s = new frm_flappig();
            s.Show();
            this.Hide();
        }

        private void btnsnake_Click(object sender, EventArgs e)
        {
            frm_difficulty difficulty = new frm_difficulty();
            difficulty.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frm_profile profile = new frm_profile();
            profile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ești sigur că vrei să te deconectezi?", "Confirmare deconectare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                username.user = "";
                frm_intrare intro = new frm_intrare();
                intro.Show();
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void pctspnz_Click(object sender, EventArgs e) { }
        private void pctsnake_Click(object sender, EventArgs e) { }
        private void pctxsi0_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void uname_Click(object sender, EventArgs e) { }
        private void btnclasament_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void lblpunctaj_Click(object sender, EventArgs e) { }
    }
}
