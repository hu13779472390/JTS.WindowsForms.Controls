using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [Browsable(true), Category("Appearance"), Description("Gets or sets the color of the SuccessIndicator.")]
        Color Indicator.Color { get; set; }

        RectangleF Indicator.Rectangle { get; set; }
        bool Indicator.Selectable { get; set; }
    }
}
