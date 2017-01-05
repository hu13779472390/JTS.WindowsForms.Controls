using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTS.WindowsForms.Controls
{
    interface Indicator
    {
        int Identifier { get; set; }
        int Value { get; set; }
        string Operation { get; set; }
        RectangleF Rectangle { get; set; }
        Color Color { get; set; }
        bool Selectable { get; set; }
    }
}
