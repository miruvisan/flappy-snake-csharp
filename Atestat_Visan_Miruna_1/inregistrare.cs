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
    public partial class inregistrare : Form
    {
        public inregistrare()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            return DatabaseInitializer.GetConnectionString();
        }

        private void inregistrare_Load(object sender, EventArgs e)
        {

        }

        private void cbafisare_CheckedChanged(object sender, EventArgs e)
        {
            if (cbafisare.Checked)
            {
                txtparola.PasswordChar = '\0';
                txtcfparola.PasswordChar = '\0';
            }
            else
            {
                txtparola.PasswordChar = '*';
                txtcfparola.PasswordChar = '*';
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Validare campuri necompletate
            if (string.IsNullOrWhiteSpace(txtnumeu.Text) || string.IsNullOrWhiteSpace(txtparola.Text) || 
                string.IsNullOrWhiteSpace(txtnume.Text) || string.IsNullOrWhiteSpace(txtprenume.Text) || 
                string.IsNullOrWhiteSpace(txtcfparola.Text))
            {
                MessageBox.Show("Spatiile sunt necompletate. Va rugam completati toate campurile!", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validare parolele identice
            if (txtparola.Text != txtcfparola.Text)
            {
                MessageBox.Show("Parolele introduse nu sunt identice, reincercati", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtparola.Text = "";
                txtcfparola.Text = "";
                txtparola.Focus();
                return;
            }

            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();

                    // Verificare daca username-ul exista deja
                    string checkQuery = "SELECT COUNT(*) FROM utilizatori WHERE username = @username";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", txtnumeu.Text);
                        int count = (int)checkCmd.ExecuteScalar();
                        
                        if (count > 0)
                        {
                            MessageBox.Show("Acest nume de utilizator exista deja! Va rugam alegeti alt username.", "Inregistrare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtnumeu.Text = "";
                            txtnumeu.Focus();
                            con.Close();
                            return;
                        }
                    }

                    // Inserare utilizator nou
                    string inreg = "INSERT INTO utilizatori(username, Nume, Prenume, Parola) VALUES (@username, @nume, @prenume, @parola)";
                    using (OleDbCommand cmd = new OleDbCommand(inreg, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtnumeu.Text);
                        cmd.Parameters.AddWithValue("@nume", txtnume.Text);
                        cmd.Parameters.AddWithValue("@prenume", txtprenume.Text);
                        cmd.Parameters.AddWithValue("@parola", txtparola.Text);
                        
                        cmd.ExecuteNonQuery();
                    }

                    con.Close();

                    // Curatare campuri
                    txtnumeu.Text = "";
                    txtnume.Text = "";
                    txtprenume.Text = "";
                    txtparola.Text = "";
                    txtcfparola.Text = "";

                    MessageBox.Show("Contul dumneavoastra a fost creat cu succes!", "Inregistrare reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_register f = new login_register();
                    f.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inregistrare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
