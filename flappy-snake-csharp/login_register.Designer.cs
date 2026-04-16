
namespace Atestat_Visan_Miruna_1
{
    partial class login_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbafisare = new System.Windows.Forms.CheckBox();
            this.btnintrarejoc = new System.Windows.Forms.Button();
            this.btinreg = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumeu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbafisare
            // 
            this.cbafisare.AutoSize = true;
            this.cbafisare.BackColor = System.Drawing.Color.White;
            this.cbafisare.Font = new System.Drawing.Font("Mongolian Baiti", 11.5F);
            this.cbafisare.Location = new System.Drawing.Point(268, 167);
            this.cbafisare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbafisare.Name = "cbafisare";
            this.cbafisare.Size = new System.Drawing.Size(159, 25);
            this.cbafisare.TabIndex = 14;
            this.cbafisare.Text = "Afiseaza parola";
            this.cbafisare.UseVisualStyleBackColor = false;
            // 
            // btnintrarejoc
            // 
            this.btnintrarejoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnintrarejoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnintrarejoc.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.btnintrarejoc.ForeColor = System.Drawing.Color.White;
            this.btnintrarejoc.Location = new System.Drawing.Point(56, 215);
            this.btnintrarejoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnintrarejoc.Name = "btnintrarejoc";
            this.btnintrarejoc.Size = new System.Drawing.Size(337, 59);
            this.btnintrarejoc.TabIndex = 13;
            this.btnintrarejoc.Text = "Intra in joc";
            this.btnintrarejoc.UseVisualStyleBackColor = false;
            this.btnintrarejoc.Click += new System.EventHandler(this.btnintrarejoc_Click);
            // 
            // btinreg
            // 
            this.btinreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btinreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinreg.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.btinreg.ForeColor = System.Drawing.Color.White;
            this.btinreg.Location = new System.Drawing.Point(56, 282);
            this.btinreg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btinreg.Name = "btinreg";
            this.btinreg.Size = new System.Drawing.Size(337, 59);
            this.btinreg.TabIndex = 12;
            this.btinreg.Text = "Inregistreaza-te";
            this.btinreg.UseVisualStyleBackColor = false;
            this.btinreg.Click += new System.EventHandler(this.btinreg_Click);
            // 
            // txtparola
            // 
            this.txtparola.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txtparola.Location = new System.Drawing.Point(39, 124);
            this.txtparola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(368, 32);
            this.txtparola.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola:";
            // 
            // txtnumeu
            // 
            this.txtnumeu.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txtnumeu.Location = new System.Drawing.Point(39, 60);
            this.txtnumeu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumeu.Name = "txtnumeu";
            this.txtnumeu.Size = new System.Drawing.Size(368, 32);
            this.txtnumeu.TabIndex = 9;
            this.txtnumeu.TextChanged += new System.EventHandler(this.txtnumeu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume utilizator:";
            // 
            // login_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(445, 383);
            this.Controls.Add(this.cbafisare);
            this.Controls.Add(this.btnintrarejoc);
            this.Controls.Add(this.btinreg);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumeu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceaza un cont!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbafisare;
        private System.Windows.Forms.Button btnintrarejoc;
        private System.Windows.Forms.Button btinreg;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeu;
        private System.Windows.Forms.Label label1;
    }
}