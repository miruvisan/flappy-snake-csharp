using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Atestat_Visan_Miruna_1
{
    public partial class login_register : Form
    {
        public login_register()
        {
            InitializeComponent();
        }

        private void btnintrarejoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumeu.Text) || string.IsNullOrWhiteSpace(txtparola.Text))
            {
                MessageBox.Show("Va rugam introduceti nume de utilizator si parola!", "Campuri obligatorii", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection con = new OleDbConnection(DatabaseInitializer.GetConnectionString()))
                {
                    con.Open();
                    string login = "SELECT username FROM utilizatori WHERE username = @username AND Parola = @parola";
                    using (OleDbCommand cmd = new OleDbCommand(login, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtnumeu.Text);
                        cmd.Parameters.AddWithValue("@parola", txtparola.Text);
                        
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                username.user = txtnumeu.Text;
                                pagia_intrare p = new pagia_intrare();
                                p.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Nume de utilizator sau parola invalide, va rugam reincercati!", "Logare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtnumeu.Text = "";
                                txtparola.Text = "";
                                txtnumeu.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectarea cu baza de date: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btinreg_Click(object sender, EventArgs e)
        {
            inregistrare f = new inregistrare();
            f.Show();
            this.Hide();
        }

        private void txtnumeu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
