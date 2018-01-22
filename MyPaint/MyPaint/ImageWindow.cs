using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------------------------------------------------------
namespace MyPaint
{
    public partial class ImageWindow : Form
    {
        Point start;
        Point finish;
        Color current;
        //--------------------------------------------------------------
        public ImageWindow()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        private void DrawLine(PictureBox box, Color col, int toolsSize)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Pen pen = new Pen(col, toolsSize);

                g.DrawLine(pen, start, finish);
                pBTempPic.Invalidate();
            }
        }
        //--------------------------------------------------------------
        private void DrawRectangle(PictureBox box, Color col, int toolsSize)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Pen pen = new Pen(col, toolsSize);

                int x = Math.Min(start.X, finish.X);
                int y = Math.Min(start.Y, finish.Y);

                int width = Math.Max(start.X, finish.X) - Math.Min(start.X, finish.X);

                int height = Math.Max(start.Y, finish.Y) - Math.Min(start.Y, finish.Y);

                g.DrawRectangle(pen, x, y, width, height);

                pBTempPic.Invalidate();
            }
        }
        //--------------------------------------------------------------
        private void DrawCircle(PictureBox box, Color col, int toolsSize)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Pen pen = new Pen(col, toolsSize);

                int x = Math.Min(start.X, finish.X);
                int y = Math.Min(start.Y, finish.Y);

                int width = Math.Max(start.X, finish.X) - Math.Min(start.X, finish.X);

                int height = Math.Max(start.Y, finish.Y) - Math.Min(start.Y, finish.Y);

                g.DrawEllipse(pen, x, y, width, height);

                pBTempPic.Invalidate();
            }
        }
        //--------------------------------------------------------------
        private void Fill(PictureBox box, Color col, Point pt)
        {
            Stack<Point> pixels = new Stack<Point>();
            Bitmap bmp = box.Image.Clone() as Bitmap;
            Color targetColor = Color.White;
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                
                if (0 < a.X && a.X < bmp.Width && 0 < a.Y && a.Y < bmp.Height)
                {
                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, col);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }

            box.Refresh();
            box.Invalidate();

        }
        //--------------------------------------------------------------
        private void PutText(PictureBox box, Point p)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                Font font = new Font("Arial", 16);


                g.DrawString("Hello", font, Brushes.Black, p);

                box.Invalidate();
            }
        }
        //--------------------------------------------------------------
        private void Eraser(PictureBox box, Point p)
        {
            Bitmap bit = box.Image.Clone() as Bitmap;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                    bit.SetPixel(p.X + i, p.Y + j, Color.White);
            }

            box.Image = bit.Clone() as Image;

            box.Invalidate();
        }
        //--------------------------------------------------------------
        private Color Eyedropper(PictureBox box, Point p)
        {
            Bitmap bit = box.Image.Clone() as Bitmap;

            Color col = bit.GetPixel(p.X, p.Y);

            box.Image = bit.Clone() as Image;

            return col;
        }
        //--------------------------------------------------------------
        private void pBPic_MouseDown(object sender, MouseEventArgs e)
        {
            start.X = e.X;
            start.Y = e.Y;

            if (pBPic.Image == null)
                pBPic.Image = new Bitmap(pBPic.Width, pBPic.Height);

            if (Functions.getInstance().ToolsName == "Fill")
                Fill(pBPic, Color.Coral, start);
            else
            if (Functions.getInstance().ToolsName == "Text")
                PutText(pBPic, start);
            else
            if (Functions.getInstance().ToolsName == "Eye Dropper")
                Eyedropper(pBPic, start);
            else
            {
                pBTempPic.Image = pBPic.Image.Clone() as Bitmap;

                pBTempPic.Visible = true;
            }
        }
        //--------------------------------------------------------------
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
                        DrawLine(pBPic, Color.Black, 1);
                        start = finish;
                        break;
                    case "Rectangle":
                        DrawRectangle(pBTempPic, Color.Black, 3);
                        break;
                    case "Circle":
                        DrawCircle(pBTempPic, Color.Black, 3);
                        break;
                    case "Eraser":
                        Eraser(pBTempPic, start);
                        break;
                }
            }
        }
        //--------------------------------------------------------------
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
                case "Circle":
                    DrawCircle(pBPic, Color.Black, 3);
                    break;
                case "Eraser":
                    Eraser(pBPic, start);
                    break;
            }

            pBTempPic.Visible = false;
        }
    }
}
//--------------------------------------------------------------