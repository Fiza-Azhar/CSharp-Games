
namespace Jack_Run
{
    partial class LevelUp
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
            this.lblName = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Ravie", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(124, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(345, 51);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Jack Run";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.White;
            this.pbPlayer.Image = global::Jack_Run.Properties.Resources.Run__004;
            this.pbPlayer.Location = new System.Drawing.Point(274, 63);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(53, 57);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWin.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Blue;
            this.lblWin.Location = new System.Drawing.Point(150, 149);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(298, 73);
            this.lblWin.TabIndex = 4;
            this.lblWin.Text = "Congratulations!\r\nYou Won...";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(116, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 39);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightCoral;
            this.btnNext.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(361, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 39);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jack_Run.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 403);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblName);
            this.Name = "LevelUp";
            this.Text = "LevelUp";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}