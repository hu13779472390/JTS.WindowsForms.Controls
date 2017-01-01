using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTS.WindowsForms.Controls.ProgressBar
{
    public class SuccessfulStep : Step
    {
        public bool Enabled { get; set; }

        public int Percentage { get; set; }

        public RectangleF StepRectangle { get; set; }
    }
}
