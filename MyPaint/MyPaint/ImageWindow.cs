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
    public partial class ImageWindow : Form
    {
        Point start;
        Point finish;
        Color current;

        public ImageWindow()
        {
            InitializeComponent();
        }

        private void DrawLine(PictureBox box, Color col, int toolsSize)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Pen pen = new Pen(col, toolsSize);

                g.DrawLine(pen, start, finish);
                pBTempPic.Invalidate();
            }
        }

        private void DrawRectangle(PictureBox box, Color col, int toolsSize)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Pen pen = new Pen(col, toolsSize);
                int weight = finish.X - start.X, height = finish.Y - start.Y, x = start.X, y = start.Y;


                if (finish.X < start.X)
                    g.DrawRectangle(pen, start.X, start.Y, start.X - finish.X, start.Y - finish.Y);
                else
                    g.DrawRectangle(pen, start.X, start.Y, finish.X - start.X, finish.Y - start.Y);

                pBTempPic.Invalidate();
            }
        }

        private void pBPic_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;

            if (pBPic.Image == null)
                pBPic.Image = new Bitmap(pBPic.Width, pBPic.Height);

            pBTempPic.Image = pBPic.Image.Clone() as Bitmap;

            pBTempPic.Visible = true;
        }

        private void pBPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                finish.X = e.X;
                finish.Y = e.Y;

                pBTempPic.Image = pBPic.Image.Clone() as Bitmap;

                if (pBTempPic.Image == null)
                    pBTempPic.Image = new Bitmap(pBTempPic.Width, pBTempPic.Height);

                switch (Functions.getInstance().ToolsName)
                {
                    case "Line":
                        DrawLine(pBTempPic, Color.Black, 3);
                        break;
                    case "Pen":
                        DrawLine(pBPic, Color.Black, 2);
                        start = finish;
                        break;
                    case "Rectangle":
                        DrawRectangle(pBTempPic, Color.Black, 3);
                        break;
                }
            }
        }

        private void pBPic_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Functions.getInstance().ToolsName)
            {
                case "Pen":
                case "Line":
                    DrawLine(pBPic, Color.Black, 3);
                    break;
                case "Rectangle":
                    DrawRectangle(pBPic, Color.Black, 3);
                    break;
            }

            pBTempPic.Visible = false;
        }
    }
}
