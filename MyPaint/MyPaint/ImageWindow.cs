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
        int toolsSize;
        //--------------------------------------------------------------
        public ImageWindow()
        {
            InitializeComponent();

            Functions.getInstance().ImageCreated = true;

            if (Functions.getInstance().OpenFile)
            {
                if (pBPic.Image == null)
                    pBPic.Image = new Bitmap(pBPic.Width, pBPic.Height);

                pBPic.Image = Image.FromFile(Functions.getInstance().PicOpenPath);
            }
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
            //Bitmap bmp = box.Image.Clone() as Bitmap;
            //Color targetColor = bmp.GetPixel(pt.X, pt.Y);
            //if (targetColor.ToArgb().Equals(col.ToArgb()))
            //{
            //    return;
            //}

            //Stack<Point> pixels = new Stack<Point>();

            //pixels.Push(pt);
            //while (pixels.Count != 0)
            //{
            //    Point temp = pixels.Pop();
            //    int y1 = temp.Y;
            //    while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
            //    {
            //        y1--;
            //    }
            //    y1++;
            //    bool spanLeft = false;
            //    bool spanRight = false;
            //    while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
            //    {
            //        bmp.SetPixel(temp.X, y1, col);

            //        if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
            //        {
            //            pixels.Push(new Point(temp.X - 1, y1));
            //            spanLeft = true;
            //        }
            //        else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
            //        {
            //            spanLeft = false;
            //        }
            //        if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
            //        {
            //            pixels.Push(new Point(temp.X + 1, y1));
            //            spanRight = true;
            //        }
            //        else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
            //        {
            //            spanRight = false;
            //        }
            //        y1++;
            //    }

            //}

            //box.Refresh();

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
                        pixels.Push(new Point(a.X - 1, a.Y));
                        bmp.SetPixel(a.X, a.Y, col);
                        pixels.Push(new Point(a.X + 1, a.Y));
                        bmp.SetPixel(a.X, a.Y, col);
                        pixels.Push(new Point(a.X, a.Y - 1));
                        bmp.SetPixel(a.X, a.Y, col);
                        pixels.Push(new Point(a.X, a.Y + 1));
                        bmp.SetPixel(a.X, a.Y, col);
                    }
                }

            }
            box.Image = bmp.Clone() as Image;

            //box.Refresh();
            box.Invalidate();
            //}
        }
        //--------------------------------------------------------------
        private void PutText(PictureBox box, Point p)
        {
            textBox.Location = p;
            textBox.Text = "";
            textBox.Visible = true; 
        }
        //--------------------------------------------------------------
        private void Eraser(PictureBox box, Point p, int size)
        {
            using (Graphics g = Graphics.FromImage(box.Image))
            {
                g.FillRectangle(Brushes.White, p.X, p.Y, size, size);
            }

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

            current = Functions.getInstance().ColorForPanel;
            toolsSize = Functions.getInstance().ToolsSize;

            if (pBPic.Image == null)
                pBPic.Image = new Bitmap(pBPic.Width, pBPic.Height);

            if (Functions.getInstance().ToolsName == "Fill")
                Fill(pBPic, Color.Teal, start);
            else
            if (Functions.getInstance().ToolsName == "Text")
                PutText(pBPic, start);
            else
            if (Functions.getInstance().ToolsName == "Eye Dropper")
                current = Functions.getInstance().ColorForPanel = Eyedropper(pBPic, start);
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
                        DrawLine(pBTempPic, current, toolsSize);
                        break;
                    case "Pen":
                        DrawLine(pBPic, current, 1);
                        start = finish;
                        break;
                    case "Rectangle":
                        DrawRectangle(pBTempPic, current, toolsSize);
                        break;
                    case "Circle":
                        DrawCircle(pBTempPic, current, toolsSize);
                        break;
                    case "Eraser":
                        start = finish;
                        Eraser(pBTempPic, start, toolsSize);
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
                    DrawLine(pBPic, current, toolsSize);
                    break;
                case "Rectangle":
                    DrawRectangle(pBPic, current, toolsSize);
                    break;
                case "Circle":
                    DrawCircle(pBPic, current, toolsSize);
                    break;
                case "Eraser":
                    Eraser(pBPic, start, toolsSize);
                    break;
            }

            pBTempPic.Visible = false;

            Functions.getInstance().LastImage = pBPic.Image.Clone() as Bitmap;

            if (true)
                Functions.getInstance().AddImage(pBPic.Image);
        }
        //--------------------------------------------------------------
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (Graphics g = Graphics.FromImage(pBPic.Image))
                {
                    Font font = new Font("Arial", 16);
                    textBox.Visible = false;

                    SolidBrush brushes = new SolidBrush(current);
                    g.DrawString(textBox.Text, font, brushes, textBox.Location);

                    pBPic.Invalidate();
                }
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                textBox.Visible = false;
            }
        }
    }
}
//--------------------------------------------------------------