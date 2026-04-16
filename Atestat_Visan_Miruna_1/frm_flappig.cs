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
    public partial class frm_flappig : Form
    {
        int pipespeed = 5;
        int gravity = 8;
        int scor = 0;

        public frm_flappig()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer_joc(object sender, EventArgs e)
        {
            pig.Top += gravity;
            pipe_jos.Left -= pipespeed;
            pipe_sus.Left -= pipespeed;
            scorlbl.Text = "Scor: " + scor.ToString();
            scorul.flap = scor.ToString(); ;

            if(pipe_jos.Left < -150)
            {
                pipe_jos.Left = 350;
                scor += 50;
            }
            if (pipe_sus.Left < -180)
            {
                pipe_sus.Left = 350;
                scor += 50;
            }

            if(pig.Bounds.IntersectsWith(pipe_jos.Bounds) || pig.Bounds.IntersectsWith(pipe_sus.Bounds) || pig.Bounds.IntersectsWith(pamant.Bounds))
            {
                endgame();
            }

            if (scor > 300)
                pipespeed = 15;
            if (pig.Top < 0)
            {
                endgame();
            }
            }

        private void key_down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space )
            {
                gravity = -5;
            }
        }

        private void key_up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endgame()
        {
            temporizatorporc.Stop();
    
            // Incrementare joc jucat și update total points
            DatabaseInitializer.IncrementGamesPlayedFlappy(username.user);
            DatabaseInitializer.UpdateTotalPoints(username.user, scor);
    
            // Salveaza scorul in baza de date
            DatabaseInitializer.UpdateBestFlappyScore(username.user, scor);
    
            // Actualizeaza scorul in clasa statica
            scorul.flap = scor.ToString();
    
            var Result = MessageBox.Show($"Ati pierdut!\nScor final: {scor}", "Ouch!", MessageBoxButtons.OK);
            if(Result == DialogResult.OK)
            {
                pagia_intrare f = new pagia_intrare();
                f.Show();
                this.Hide();
            }
        }
    }
}
