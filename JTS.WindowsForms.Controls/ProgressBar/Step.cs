using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTS.WindowsForms.Controls.ProgressBar
{
    public interface Step
    {
        int Percentage { get; set; }
        RectangleF StepRectangle { get; set; }
        bool Enabled { get; set; }
    }
}
