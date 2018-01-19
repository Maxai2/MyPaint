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
            //Cursor.Current = new Cursor(@"icon\pen-outlined-tool-in-angle.cur");
            Functions.getInstance().ToolsName = "Pen";
        }

        private void fMyPaint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rBShapes_Click(object sender, EventArgs e)
        {

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
