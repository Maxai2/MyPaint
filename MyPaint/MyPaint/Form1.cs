using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class fMyPaint : Form
    {
        public fMyPaint()
        {
            InitializeComponent();
        }

        private void rOMINew_Click(object sender, EventArgs e)
        {
            ImageWindow iw = new ImageWindow();
            iw.MdiParent = this;
            iw.Show();
        }

        private void rBPen_Click(object sender, EventArgs e)
        {
            //string path = Application.ExecutablePath;
            //path = path.Remove(path.Length - 12);
            //Cursor.Current = new Cursor(path + @"\Icon\pencil-pointing-up.cur");
            //Cursor myCursor = new Cursor(@"Icon\cursor.png");
            //Cursor.Current = Cursors.UpArrow;
            Cursor.Current = new Cursor(GetType(), @"Icon\cursor.cur");
            Functions.getInstance().ToolsName = "Pen";
        }

        private void rBFill_Click(object sender, EventArgs e)
        {
            Functions.getInstance().ToolsName = "Fill";
        }

        private void rBText_Click(object sender, EventArgs e)
        {
            Functions.getInstance().ToolsName = "Text";
        }

        private void rBEraser_Click(object sender, EventArgs e)
        {
            Functions.getInstance().ToolsName = "Eraser";
        }

        private void rBEyeDropper_Click(object sender, EventArgs e)
        {
            Functions.getInstance().ToolsName = "Eye Dropper";
        }

        private void rCBShapes_TextBoxTextChanged(object sender, EventArgs e)
        {
            switch (rCBShapes.TextBoxText)
            {
                case "Line":
                    Functions.getInstance().ToolsName = "Line";
                    break;
                case "Circle":
                    Functions.getInstance().ToolsName = "Circle";
                    break;
                case "Rectangle":
                    Functions.getInstance().ToolsName = "Rectangle";
                    break;
            }
        }
    }
}
