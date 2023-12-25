namespace Sign_upform.Music_toppick
{
    partial class Topartist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topartist));
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Lato", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(23, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 55;
            this.label13.Tag = "blocks";
            this.label13.Text = "Minh";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(6, 6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(78, 78);
            this.pictureBox10.TabIndex = 54;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "blocks";
            // 
            // Topartist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox10);
            this.Name = "Topartist";
            this.Size = new System.Drawing.Size(92, 107);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}
