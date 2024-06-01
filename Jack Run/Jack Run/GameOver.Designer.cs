
namespace Jack_Run
{
    partial class GameOver
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
            this.lblOver = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOver
            // 
            this.lblOver.BackColor = System.Drawing.Color.Transparent;
            this.lblOver.Font = new System.Drawing.Font("Ravie", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOver.Location = new System.Drawing.Point(110, 151);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(445, 98);
            this.lblOver.TabIndex = 0;
            this.lblOver.Text = "GAME OVER";
            this.lblOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(37, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbPic
            // 
            this.pbPic.BackColor = System.Drawing.Color.Transparent;
            this.pbPic.Image = global::Jack_Run.Properties.Resources.Run__004;
            this.pbPic.Location = new System.Drawing.Point(293, 56);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(61, 74);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 4;
            this.pbPic.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(226, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 44);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Jack Run";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::Jack_Run.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 420);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameOver_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOver;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Label lblTitle;
    }
}