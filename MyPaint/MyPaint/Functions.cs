using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Functions
    {
        private static Functions instance;

        private Functions()
        { }

        public static Functions getInstance()
        {
            if (instance == null)
                instance = new Functions();
            return instance;
        }

        List<Image> ImageList = new List<Image>();

        public void AddImage(Image im) => ImageList.Add(im);

        public int ListCount() => ImageList.Count;

        public Font FontName { get; set; }

        public string ToolsName { get; set; }

        public Color ColorForPanel { get; set; }

        public int ToolsSize { get; set; }

        public string PicOpenPath { get; set; }

        public bool ImageCreated { get; set; }

        public bool OpenFile { get; set; }

        public Image LastImage { get; set; }
    }
}
