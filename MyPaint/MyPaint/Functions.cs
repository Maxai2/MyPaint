﻿using System;
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

        public string ToolsName { get; set; }

        public Color ColorForPanel { get; set; }

        public int ToolsSize { get; set; }
    }
}
