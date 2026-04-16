
namespace Atestat_Visan_Miruna_1
{
    partial class frm_flappig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_flappig));
            this.scorlbl = new System.Windows.Forms.Label();
            this.pig = new System.Windows.Forms.PictureBox();
            this.pamant = new System.Windows.Forms.PictureBox();
            this.pipe_jos = new System.Windows.Forms.PictureBox();
            this.pipe_sus = new System.Windows.Forms.PictureBox();
            this.temporizatorporc = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pamant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_jos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_sus)).BeginInit();
            this.SuspendLayout();
            // 
            // scorlbl
            // 
            this.scorlbl.AutoSize = true;
            this.scorlbl.BackColor = System.Drawing.Color.Transparent;
            this.scorlbl.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.scorlbl.Location = new System.Drawing.Point(8, 7);
            this.scorlbl.Name = "scorlbl";
            this.scorlbl.Size = new System.Drawing.Size(84, 26);
            this.scorlbl.TabIndex = 4;
            this.scorlbl.Text = "Scor: 0";
            // 
            // pig
            // 
            this.pig.Image = ((System.Drawing.Image)(resources.GetObject("pig.Image")));
            this.pig.Location = new System.Drawing.Point(12, 127);
            this.pig.Name = "pig";
            this.pig.Size = new System.Drawing.Size(90, 85);
            this.pig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pig.TabIndex = 5;
            this.pig.TabStop = false;
            // 
            // pamant
            // 
            this.pamant.Image = ((System.Drawing.Image)(resources.GetObject("pamant.Image")));
            this.pamant.Location = new System.Drawing.Point(-13, 558);
            this.pamant.Name = "pamant";
            this.pamant.Size = new System.Drawing.Size(555, 112);
            this.pamant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pamant.TabIndex = 6;
            this.pamant.TabStop = false;
            // 
            // pipe_jos
            // 
            this.pipe_jos.Image = ((System.Drawing.Image)(resources.GetObject("pipe_jos.Image")));
            this.pipe_jos.Location = new System.Drawing.Point(276, 455);
            this.pipe_jos.Name = "pipe_jos";
            this.pipe_jos.Size = new System.Drawing.Size(106, 200);
            this.pipe_jos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_jos.TabIndex = 7;
            this.pipe_jos.TabStop = false;
            this.pipe_jos.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipe_sus
            // 
            this.pipe_sus.Image = ((System.Drawing.Image)(resources.GetObject("pipe_sus.Image")));
            this.pipe_sus.Location = new System.Drawing.Point(436, -65);
            this.pipe_sus.Name = "pipe_sus";
            this.pipe_sus.Size = new System.Drawing.Size(106, 231);
            this.pipe_sus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe_sus.TabIndex = 8;
            this.pipe_sus.TabStop = false;
            // 
            // temporizatorporc
            // 
            this.temporizatorporc.Enabled = true;
            this.temporizatorporc.Interval = 20;
            this.temporizatorporc.Tick += new System.EventHandler(this.timer_joc);
            // 
            // frm_flappig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.pamant);
            this.Controls.Add(this.pipe_sus);
            this.Controls.Add(this.pig);
            this.Controls.Add(this.scorlbl);
            this.Controls.Add(this.pipe_jos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_flappig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Pig";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up);
            ((System.ComponentModel.ISupportInitialize)(this.pig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pamant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_jos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe_sus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scorlbl;
        private System.Windows.Forms.PictureBox pig;
        private System.Windows.Forms.PictureBox pamant;
        private System.Windows.Forms.PictureBox pipe_jos;
        private System.Windows.Forms.PictureBox pipe_sus;
        private System.Windows.Forms.Timer temporizatorporc;
    }
}