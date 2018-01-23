namespace MyPaint
{
    partial class fMyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMyPaint));
            this.Ribbon = new System.Windows.Forms.Ribbon();
            this.rOMIOpen = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rOMISave = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.rOMIAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rTHome = new System.Windows.Forms.RibbonTab();
            this.rPTools = new System.Windows.Forms.RibbonPanel();
            this.rBPen = new System.Windows.Forms.RibbonButton();
            this.rBFill = new System.Windows.Forms.RibbonButton();
            this.rBText = new System.Windows.Forms.RibbonButton();
            this.rBEraser = new System.Windows.Forms.RibbonButton();
            this.rBEyeDropper = new System.Windows.Forms.RibbonButton();
            this.rPToolsHelp = new System.Windows.Forms.RibbonPanel();
            this.rBBrushes = new System.Windows.Forms.RibbonButton();
            this.rBColor = new System.Windows.Forms.RibbonButton();
            this.rCBShapes = new System.Windows.Forms.RibbonComboBox();
            this.rBLine = new System.Windows.Forms.RibbonButton();
            this.rBRectangle = new System.Windows.Forms.RibbonButton();
            this.rBCircle = new System.Windows.Forms.RibbonButton();
            this.rPZoom = new System.Windows.Forms.RibbonPanel();
            this.rBPlus = new System.Windows.Forms.RibbonButton();
            this.rBMinus = new System.Windows.Forms.RibbonButton();
            this.pColor = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.tBoxToolSize = new System.Windows.Forms.TextBox();
            this.rBBack = new System.Windows.Forms.RibbonButton();
            this.rBForward = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
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
            this.Ribbon.OrbDropDown.MenuItems.Add(this.rOMIOpen);
            this.Ribbon.OrbDropDown.MenuItems.Add(this.rOMISave);
            this.Ribbon.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.Ribbon.OrbDropDown.MenuItems.Add(this.rOMIAbout);
            this.Ribbon.OrbDropDown.Name = "";
            this.Ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 295);
            this.Ribbon.OrbDropDown.TabIndex = 0;
            this.Ribbon.OrbImage = null;
            // 
            // 
            // 
            this.Ribbon.QuickAcessToolbar.Items.Add(this.rBBack);
            this.Ribbon.QuickAcessToolbar.Items.Add(this.rBForward);
            this.Ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Ribbon.Size = new System.Drawing.Size(967, 118);
            this.Ribbon.TabIndex = 0;
            this.Ribbon.Tabs.Add(this.rTHome);
            this.Ribbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.Ribbon.Text = "Ribbon";
            this.Ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // rOMIOpen
            // 
            this.rOMIOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rOMIOpen.Image = ((System.Drawing.Image)(resources.GetObject("rOMIOpen.Image")));
            this.rOMIOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("rOMIOpen.SmallImage")));
            this.rOMIOpen.Text = "Open";
            this.rOMIOpen.Click += new System.EventHandler(this.rOMIOpen_Click);
            // 
            // rOMISave
            // 
            this.rOMISave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rOMISave.Image = ((System.Drawing.Image)(resources.GetObject("rOMISave.Image")));
            this.rOMISave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rOMISave.SmallImage")));
            this.rOMISave.Text = "Save";
            this.rOMISave.Click += new System.EventHandler(this.rOMISave_Click);
            // 
            // rOMIAbout
            // 
            this.rOMIAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.rOMIAbout.Image = ((System.Drawing.Image)(resources.GetObject("rOMIAbout.Image")));
            this.rOMIAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rOMIAbout.SmallImage")));
            this.rOMIAbout.Text = "About";
            // 
            // rTHome
            // 
            this.rTHome.Panels.Add(this.rPTools);
            this.rTHome.Panels.Add(this.rPToolsHelp);
            this.rTHome.Panels.Add(this.rPZoom);
            this.rTHome.Text = "Home";
            // 
            // rPTools
            // 
            this.rPTools.Items.Add(this.rBPen);
            this.rPTools.Items.Add(this.rBFill);
            this.rPTools.Items.Add(this.rBText);
            this.rPTools.Items.Add(this.rBEraser);
            this.rPTools.Items.Add(this.rBEyeDropper);
            this.rPTools.Text = "Tools";
            // 
            // rBPen
            // 
            this.rBPen.Image = ((System.Drawing.Image)(resources.GetObject("rBPen.Image")));
            this.rBPen.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBPen.SmallImage")));
            this.rBPen.Text = "";
            this.rBPen.Click += new System.EventHandler(this.rBPen_Click);
            // 
            // rBFill
            // 
            this.rBFill.Image = ((System.Drawing.Image)(resources.GetObject("rBFill.Image")));
            this.rBFill.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBFill.SmallImage")));
            this.rBFill.Text = "";
            this.rBFill.Click += new System.EventHandler(this.rBFill_Click);
            // 
            // rBText
            // 
            this.rBText.Image = ((System.Drawing.Image)(resources.GetObject("rBText.Image")));
            this.rBText.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBText.SmallImage")));
            this.rBText.Text = "";
            this.rBText.Click += new System.EventHandler(this.rBText_Click);
            // 
            // rBEraser
            // 
            this.rBEraser.Image = ((System.Drawing.Image)(resources.GetObject("rBEraser.Image")));
            this.rBEraser.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBEraser.SmallImage")));
            this.rBEraser.Text = "";
            this.rBEraser.Click += new System.EventHandler(this.rBEraser_Click);
            // 
            // rBEyeDropper
            // 
            this.rBEyeDropper.Image = ((System.Drawing.Image)(resources.GetObject("rBEyeDropper.Image")));
            this.rBEyeDropper.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBEyeDropper.SmallImage")));
            this.rBEyeDropper.Text = "";
            this.rBEyeDropper.Click += new System.EventHandler(this.rBEyeDropper_Click);
            // 
            // rPToolsHelp
            // 
            this.rPToolsHelp.Items.Add(this.rBBrushes);
            this.rPToolsHelp.Items.Add(this.rBColor);
            this.rPToolsHelp.Items.Add(this.rCBShapes);
            this.rPToolsHelp.Text = "Tools help";
            // 
            // rBBrushes
            // 
            this.rBBrushes.Image = ((System.Drawing.Image)(resources.GetObject("rBBrushes.Image")));
            this.rBBrushes.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBBrushes.SmallImage")));
            this.rBBrushes.Text = "";
            // 
            // rBColor
            // 
            this.rBColor.Image = ((System.Drawing.Image)(resources.GetObject("rBColor.Image")));
            this.rBColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBColor.SmallImage")));
            this.rBColor.Text = "";
            this.rBColor.Click += new System.EventHandler(this.rBColor_Click);
            // 
            // rCBShapes
            // 
            this.rCBShapes.DropDownItems.Add(this.rBLine);
            this.rCBShapes.DropDownItems.Add(this.rBRectangle);
            this.rCBShapes.DropDownItems.Add(this.rBCircle);
            this.rCBShapes.Text = "Shapes";
            this.rCBShapes.TextBoxText = "";
            this.rCBShapes.Value = "";
            this.rCBShapes.TextBoxTextChanged += new System.EventHandler(this.rCBShapes_TextBoxTextChanged);
            // 
            // rBLine
            // 
            this.rBLine.Image = ((System.Drawing.Image)(resources.GetObject("rBLine.Image")));
            this.rBLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBLine.SmallImage")));
            this.rBLine.Text = "Line";
            // 
            // rBRectangle
            // 
            this.rBRectangle.Image = ((System.Drawing.Image)(resources.GetObject("rBRectangle.Image")));
            this.rBRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBRectangle.SmallImage")));
            this.rBRectangle.Text = "Rectangle";
            // 
            // rBCircle
            // 
            this.rBCircle.Image = ((System.Drawing.Image)(resources.GetObject("rBCircle.Image")));
            this.rBCircle.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBCircle.SmallImage")));
            this.rBCircle.Text = "Circle";
            // 
            // rPZoom
            // 
            this.rPZoom.Items.Add(this.rBPlus);
            this.rPZoom.Items.Add(this.rBMinus);
            this.rPZoom.Text = "Zoom";
            // 
            // rBPlus
            // 
            this.rBPlus.Image = ((System.Drawing.Image)(resources.GetObject("rBPlus.Image")));
            this.rBPlus.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBPlus.SmallImage")));
            this.rBPlus.Text = "";
            // 
            // rBMinus
            // 
            this.rBMinus.Image = ((System.Drawing.Image)(resources.GetObject("rBMinus.Image")));
            this.rBMinus.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBMinus.SmallImage")));
            this.rBMinus.Text = "";
            // 
            // pColor
            // 
            this.pColor.Location = new System.Drawing.Point(652, 60);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(49, 45);
            this.pColor.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.trackBar.Location = new System.Drawing.Point(515, 60);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 45);
            this.trackBar.TabIndex = 10;
            this.trackBar.TabStop = false;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // tBoxToolSize
            // 
            this.tBoxToolSize.Enabled = false;
            this.tBoxToolSize.Location = new System.Drawing.Point(626, 60);
            this.tBoxToolSize.Name = "tBoxToolSize";
            this.tBoxToolSize.Size = new System.Drawing.Size(20, 20);
            this.tBoxToolSize.TabIndex = 12;
            // 
            // rBBack
            // 
            this.rBBack.Image = ((System.Drawing.Image)(resources.GetObject("rBBack.Image")));
            this.rBBack.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rBBack.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBBack.SmallImage")));
            this.rBBack.Text = "ribbonButton1";
            // 
            // rBForward
            // 
            this.rBForward.Image = ((System.Drawing.Image)(resources.GetObject("rBForward.Image")));
            this.rBForward.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.rBForward.SmallImage = ((System.Drawing.Image)(resources.GetObject("rBForward.SmallImage")));
            this.rBForward.Text = "ribbonButton1";
            // 
            // fMyPaint
            // 
            this.ClientSize = new System.Drawing.Size(967, 613);
            this.Controls.Add(this.tBoxToolSize);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.Ribbon);
            this.IsMdiContainer = true;
            this.Name = "fMyPaint";
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon Ribbon;
        private System.Windows.Forms.RibbonOrbMenuItem rOMINew;
        private System.Windows.Forms.RibbonOrbMenuItem rOMIOpen;
        private System.Windows.Forms.RibbonOrbMenuItem rOMISave;
        private System.Windows.Forms.RibbonOrbMenuItem rOMISaveAs;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem rOMIAbout;
        private System.Windows.Forms.RibbonTab rTHome;
        private System.Windows.Forms.RibbonPanel rPTools;
        private System.Windows.Forms.RibbonPanel rPToolsHelp;
        private System.Windows.Forms.RibbonPanel rPZoom;
        private System.Windows.Forms.RibbonButton rBPen;
        private System.Windows.Forms.RibbonButton rBFill;
        private System.Windows.Forms.RibbonButton rBText;
        private System.Windows.Forms.RibbonButton rBEraser;
        private System.Windows.Forms.RibbonButton rBEyeDropper;
        private System.Windows.Forms.RibbonButton rBBrushes;
        private System.Windows.Forms.RibbonButton rBColor;
        private System.Windows.Forms.RibbonButton rBPlus;
        private System.Windows.Forms.RibbonButton rBMinus;
        private System.Windows.Forms.RibbonComboBox rCBShapes;
        private System.Windows.Forms.RibbonButton rBLine;
        private System.Windows.Forms.RibbonButton rBCircle;
        private System.Windows.Forms.RibbonButton rBRectangle;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox tBoxToolSize;
        private System.Windows.Forms.RibbonButton rBBack;
        private System.Windows.Forms.RibbonButton rBForward;
    }
}

