namespace Atestat_Visan_Miruna_1
{
    partial class frm_profile
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGamesFlappy = new System.Windows.Forms.Label();
            this.lblGamesSnake = new System.Windows.Forms.Label();
            this.lblBestFlappy = new System.Windows.Forms.Label();
            this.lblBestSnake = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblLastDifficulty = new System.Windows.Forms.Label();
            this.lblWinRate = new System.Windows.Forms.Label();
            this.progressBarFlappy = new System.Windows.Forms.ProgressBar();
            this.progressBarSnake = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(30, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 40);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";

            // lblGamesFlappy
            this.lblGamesFlappy.AutoSize = true;
            this.lblGamesFlappy.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblGamesFlappy.ForeColor = System.Drawing.Color.White;
            this.lblGamesFlappy.Location = new System.Drawing.Point(30, 80);
            this.lblGamesFlappy.Name = "lblGamesFlappy";
            this.lblGamesFlappy.Size = new System.Drawing.Size(200, 28);
            this.lblGamesFlappy.TabIndex = 1;
            this.lblGamesFlappy.Text = "Jocuri Flappy Pig: 0";

            // lblGamesSnake
            this.lblGamesSnake.AutoSize = true;
            this.lblGamesSnake.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblGamesSnake.ForeColor = System.Drawing.Color.White;
            this.lblGamesSnake.Location = new System.Drawing.Point(30, 120);
            this.lblGamesSnake.Name = "lblGamesSnake";
            this.lblGamesSnake.Size = new System.Drawing.Size(200, 28);
            this.lblGamesSnake.TabIndex = 2;
            this.lblGamesSnake.Text = "Jocuri Snake: 0";

            // lblBestFlappy
            this.lblBestFlappy.AutoSize = true;
            this.lblBestFlappy.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblBestFlappy.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBestFlappy.Location = new System.Drawing.Point(30, 160);
            this.lblBestFlappy.Name = "lblBestFlappy";
            this.lblBestFlappy.Size = new System.Drawing.Size(200, 28);
            this.lblBestFlappy.TabIndex = 3;
            this.lblBestFlappy.Text = "Best Score Flappy: 0";

            // progressBarFlappy
            this.progressBarFlappy.Location = new System.Drawing.Point(280, 160);
            this.progressBarFlappy.Name = "progressBarFlappy";
            this.progressBarFlappy.Size = new System.Drawing.Size(200, 25);
            this.progressBarFlappy.TabIndex = 11;

            // lblBestSnake
            this.lblBestSnake.AutoSize = true;
            this.lblBestSnake.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblBestSnake.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBestSnake.Location = new System.Drawing.Point(30, 200);
            this.lblBestSnake.Name = "lblBestSnake";
            this.lblBestSnake.Size = new System.Drawing.Size(200, 28);
            this.lblBestSnake.TabIndex = 4;
            this.lblBestSnake.Text = "Best Score Snake: 0";

            // progressBarSnake
            this.progressBarSnake.Location = new System.Drawing.Point(280, 200);
            this.progressBarSnake.Name = "progressBarSnake";
            this.progressBarSnake.Size = new System.Drawing.Size(200, 25);
            this.progressBarSnake.TabIndex = 12;

            // lblTotalPoints
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPoints.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalPoints.Location = new System.Drawing.Point(30, 240);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(250, 28);
            this.lblTotalPoints.TabIndex = 5;
            this.lblTotalPoints.Text = "Total Puncte: 0";

            // lblLastDifficulty
            this.lblLastDifficulty.AutoSize = true;
            this.lblLastDifficulty.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblLastDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblLastDifficulty.Location = new System.Drawing.Point(30, 280);
            this.lblLastDifficulty.Name = "lblLastDifficulty";
            this.lblLastDifficulty.Size = new System.Drawing.Size(250, 28);
            this.lblLastDifficulty.TabIndex = 6;
            this.lblLastDifficulty.Text = "Ultima Dificultate Snake: Medium";

            // lblWinRate
            this.lblWinRate.AutoSize = true;
            this.lblWinRate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWinRate.ForeColor = System.Drawing.Color.Cyan;
            this.lblWinRate.Location = new System.Drawing.Point(30, 320);
            this.lblWinRate.Name = "lblWinRate";
            this.lblWinRate.Size = new System.Drawing.Size(200, 28);
            this.lblWinRate.TabIndex = 7;
            this.lblWinRate.Text = "Rata Succes: ~0%";

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "← Înapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // btnLeaderboard
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(300, 380);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(180, 50);
            this.btnLeaderboard.TabIndex = 9;
            this.btnLeaderboard.Text = "🏆 Clasament";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);

            // frm_profile
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.progressBarSnake);
            this.Controls.Add(this.progressBarFlappy);
            this.Controls.Add(this.lblWinRate);
            this.Controls.Add(this.lblLastDifficulty);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.lblBestSnake);
            this.Controls.Add(this.lblBestFlappy);
            this.Controls.Add(this.lblGamesSnake);
            this.Controls.Add(this.lblGamesFlappy);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil & Statistici";
            this.Load += new System.EventHandler(this.frm_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGamesFlappy;
        private System.Windows.Forms.Label lblGamesSnake;
        private System.Windows.Forms.Label lblBestFlappy;
        private System.Windows.Forms.Label lblBestSnake;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblLastDifficulty;
        private System.Windows.Forms.Label lblWinRate;
        private System.Windows.Forms.ProgressBar progressBarFlappy;
        private System.Windows.Forms.ProgressBar progressBarSnake;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}
