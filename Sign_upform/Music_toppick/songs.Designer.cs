namespace Sign_upform.Music_toppick
{
    partial class songs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(songs));
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label30.Font = new System.Drawing.Font("Lato", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(1, 140);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 15);
            this.label30.TabIndex = 102;
            this.label30.Tag = "blocks";
            this.label30.Text = "Từ chối nhẹ nhàng thôi";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label29.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label29.Location = new System.Drawing.Point(1, 158);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 103;
            this.label29.Tag = "blocks";
            this.label29.Text = "Minh";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 8;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(4, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 121);
            this.guna2PictureBox1.TabIndex = 104;
            this.guna2PictureBox1.TabStop = false;
            // 
            // songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Name = "songs";
            this.Size = new System.Drawing.Size(132, 178);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
