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

        private void pBPic_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;

            if (e.Button == MouseButtons.Middle)
            {
                Color c = (pBPic.Image as Bitmap).GetPixel(e.X, e.Y);
                MessageBox.Show(c.Name);
            }
        }

        private void pBPic_MouseUp(object sender, MouseEventArgs e)
        {
            finish.X = e.X;
            finish.Y = e.Y;

            if (pBPic.Image == null)
            {
                pBPic.Image = new Bitmap(500, 500);
                Pen pen = new Pen(Color.Azure);
                using (Graphics g = Graphics.FromImage(pBPic.Image))
                {
                    //g.DrawLine(pen, finish.X, finish.Y);
                }
            }

            using (Graphics g = Graphics.FromImage(pBPic.Image))
            {
                Pen pen = new Pen(Color.Azure, 2);
                Brush brush = new SolidBrush(current);
                //g.DrawLine(pen, start, finish);
                g.DrawLine(pen, start.X, start.Y, Math.Abs(finish.X - start.X), Math.Abs(finish.Y - start.Y));
                //g.FillRectangle(brush, start.X, start.Y, Math.Abs(finish.X - start.X), Math.Abs(finish.Y - start.Y));

                pBPic.Invalidate();
            }
        }
    }
}
