namespace MyPaint
{
    partial class ImageWindow
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
            this.pBPic = new System.Windows.Forms.PictureBox();
            this.pBTempPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTempPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pBPic
            // 
            this.pBPic.BackColor = System.Drawing.Color.White;
            this.pBPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBPic.Location = new System.Drawing.Point(0, 0);
            this.pBPic.Name = "pBPic";
            this.pBPic.Size = new System.Drawing.Size(284, 261);
            this.pBPic.TabIndex = 0;
            this.pBPic.TabStop = false;
            this.pBPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBPic_MouseDown);
            this.pBPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBPic_MouseMove);
            this.pBPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBPic_MouseUp);
            // 
            // pBTempPic
            // 
            this.pBTempPic.BackColor = System.Drawing.Color.White;
            this.pBTempPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBTempPic.Enabled = false;
            this.pBTempPic.Location = new System.Drawing.Point(0, 0);
            this.pBTempPic.Name = "pBTempPic";
            this.pBTempPic.Size = new System.Drawing.Size(284, 261);
            this.pBTempPic.TabIndex = 1;
            this.pBTempPic.TabStop = false;
            // 
            // ImageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pBTempPic);
            this.Controls.Add(this.pBPic);
            this.Name = "ImageWindow";
            this.Text = "ImageWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pBPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTempPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBPic;
        private System.Windows.Forms.PictureBox pBTempPic;
    }
}