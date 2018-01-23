using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            trackBar.Value = Functions.getInstance().ToolsSize = 1;
            pColor.BackColor = Functions.getInstance().ColorForPanel = Color.Black;
            Functions.getInstance().ToolsName = "Pen";
            Functions.getInstance().ImageCreated = false;
            Functions.getInstance().OpenFile = false;
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
            //Cursor.Current = new Cursor(GetType(), @"Icon\cursor.cur");

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

        private void rBColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
                Functions.getInstance().ColorForPanel = pColor.BackColor = colorDlg.Color;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            Functions.getInstance().ToolsSize = trackBar.Value;
            tBoxToolSize.Text = trackBar.Value.ToString();
        }

        private void rOMIOpen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFile= new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter = "Image Files(*.BMP; *.JPG;)| *.BMP; *.JPG;";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Functions.getInstance().PicOpenPath = openFile.FileName;

                            if (Functions.getInstance().ImageCreated == false)
                            {
                                ImageWindow iw = new ImageWindow();
                                iw.MdiParent = this;
                                iw.Show();

                                Functions.getInstance().OpenFile = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void rOMISave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Image Files(*.BMP; *.JPG;)| *.BMP; *.JPG;";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFile.OpenFile()) != null)
                {
                    (Functions.getInstance().LastImage as Bitmap).Save(saveFile.FileName);

                    myStream.Close();
                }
            }
        }
    }
}
