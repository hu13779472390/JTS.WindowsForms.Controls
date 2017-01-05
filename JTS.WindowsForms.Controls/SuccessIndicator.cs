using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTS.WindowsForms.Controls
{
    class SuccessIndicator : Indicator
    {
        int Indicator.Identifier { get; set; }
        int Indicator.Value { get; set; }
        string Indicator.Operation { get; set; }
        RectangleF Indicator.Rectangle { get; set; }
        Color Indicator.Color { get; set; }
        bool Indicator.Selectable { get; set; }
    }
}
