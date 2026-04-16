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
    public partial class frm_leaderboard : Form
    {
        public frm_leaderboard()
        {
            InitializeComponent();
        }

        private void frm_leaderboard_Load(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            try
            {
                DataTable dt = DatabaseInitializer.GetLeaderboard(10);
                dataGridView1.DataSource = dt;
                
                // Rename columns
                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Utilizator";
                    dataGridView1.Columns[1].HeaderText = "Best Flappy";
                    dataGridView1.Columns[2].HeaderText = "Best Snake";
                    dataGridView1.Columns[3].HeaderText = "Total Puncte";
                    dataGridView1.Columns[4].HeaderText = "Jocuri Flappy";
                    dataGridView1.Columns[5].HeaderText = "Jocuri Snake";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea clasamentului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_profile profile = new frm_profile();
            profile.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }
    }
}
