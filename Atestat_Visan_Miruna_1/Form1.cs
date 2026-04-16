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
    public partial class frm_intrare : Form
    {
        public frm_intrare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buton_logare_Click(object sender, EventArgs e)
        {
            login_register f = new login_register();
            f.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inregistrare f = new inregistrare();
            f.Show();
            this.Hide();
        }
    }
}
