
namespace Jack_Run
{
    partial class Menu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.btnInstruct = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(305, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jack Run";
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.LightSalmon;
            this.btnS.Font = new System.Drawing.Font("Poor Richard", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(325, 158);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(175, 44);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "Start Game";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // pbPic
            // 
            this.pbPic.BackColor = System.Drawing.Color.Transparent;
            this.pbPic.Image = global::Jack_Run.Properties.Resources.Run__004;
            this.pbPic.Location = new System.Drawing.Point(372, 56);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(61, 74);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 2;
            this.pbPic.TabStop = false;
            // 
            // btnInstruct
            // 
            this.btnInstruct.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInstruct.Font = new System.Drawing.Font("Poor Richard", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstruct.Location = new System.Drawing.Point(325, 220);
            this.btnInstruct.Name = "btnInstruct";
            this.btnInstruct.Size = new System.Drawing.Size(175, 44);
            this.btnInstruct.TabIndex = 3;
            this.btnInstruct.Text = "Instructions";
            this.btnInstruct.UseVisualStyleBackColor = false;
            this.btnInstruct.Click += new System.EventHandler(this.btnInstruct_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClose.Font = new System.Drawing.Font("Poor Richard", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(325, 297);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Menu
            // 
            this.BackgroundImage = global::Jack_Run.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInstruct);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.lblTitle);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Button btnInstruct;
        private System.Windows.Forms.Button btnClose;
    }
}