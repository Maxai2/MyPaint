namespace MyPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ribbon = new System.Windows.Forms.Ribbon();
            this.rTHome = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // Ribbon
            // 
            this.Ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.Minimized = false;
            this.Ribbon.Name = "Ribbon";
            // 
            // 
            // 
            this.Ribbon.OrbDropDown.BorderRoundness = 8;
            this.Ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.OrbDropDown.Name = "";
            this.Ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.Ribbon.OrbDropDown.TabIndex = 0;
            this.Ribbon.OrbImage = null;
            this.Ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            // 
            // 
            // 
            this.Ribbon.QuickAcessToolbar.Items.Add(this.ribbonButton3);
            this.Ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Ribbon.Size = new System.Drawing.Size(983, 168);
            this.Ribbon.TabIndex = 0;
            this.Ribbon.Tabs.Add(this.rTHome);
            this.Ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.Ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // rTHome
            // 
            this.rTHome.Panels.Add(this.ribbonPanel1);
            this.rTHome.Panels.Add(this.ribbonPanel2);
            this.rTHome.Text = "Home";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.DropDownItems.Add(this.ribbonButton2);
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.Text = "Load";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 525);
            this.Controls.Add(this.Ribbon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon Ribbon;
        private System.Windows.Forms.RibbonTab rTHome;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton2;
    }
}

