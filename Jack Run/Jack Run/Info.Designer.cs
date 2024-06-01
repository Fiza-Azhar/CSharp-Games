
namespace Jack_Run
{
    partial class Info
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
            this.lblINfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblINfo
            // 
            this.lblINfo.BackColor = System.Drawing.Color.Wheat;
            this.lblINfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINfo.ForeColor = System.Drawing.Color.Black;
            this.lblINfo.Location = new System.Drawing.Point(0, 134);
            this.lblINfo.Name = "lblINfo";
            this.lblINfo.Size = new System.Drawing.Size(650, 229);
            this.lblINfo.TabIndex = 0;
            this.lblINfo.Text = "Instructions:\r\n1- Press SpaceBar to Jump.\r\n2- Press B to kill Enemy.\r\n3- Collect " +
    "More coins to increase score.";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(257, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(345, 51);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Jack Run";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.White;
            this.pbPlayer.Image = global::Jack_Run.Properties.Resources.Run__004;
            this.pbPlayer.Location = new System.Drawing.Point(396, 63);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(53, 57);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jack_Run.Properties.Resources.Foreground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 485);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblINfo);
            this.DoubleBuffered = true;
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblINfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnExit;
    }
}