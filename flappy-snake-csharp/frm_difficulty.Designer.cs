namespace Atestat_Visan_Miruna_1
{
    partial class frm_difficulty
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Alege Dificultate 🎮";

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblDesc.ForeColor = System.Drawing.Color.LightGray;
            this.lblDesc.Location = new System.Drawing.Point(50, 80);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(300, 28);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Selectează nivelul de dificultate pentru Snake:";

            // btnEasy
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(50, 140);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(300, 60);
            this.btnEasy.TabIndex = 2;
            this.btnEasy.Text = "🟢 Ușor (Viteză Lentă)";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);

            // btnMedium
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMedium.ForeColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(50, 220);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(300, 60);
            this.btnMedium.TabIndex = 3;
            this.btnMedium.Text = "🟡 Mediu (Viteză Normală)";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);

            // btnHard
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(50, 300);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(300, 60);
            this.btnHard.TabIndex = 4;
            this.btnHard.Text = "🔴 Greu (Viteză Mare)";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(50, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(300, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "← Înapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // frm_difficulty
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alege Dificultate";
            this.Load += new System.EventHandler(this.frm_difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnBack;
    }
}
