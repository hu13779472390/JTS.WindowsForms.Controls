using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTS.WindowsForms.Controls
{
    public partial class ProgressBar : Control
    {
        #region Designer Properties
        [Browsable(true), Category("Appearance"), Description("Gets or sets the color of each step of the progress bar.")]
        public Color DefaultStepColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the border color of this control.")]
        public Color BorderColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the background color of this control.")]
        public Color BackgroundColor { get; set; }

        [Browsable(false), Category("Appearance")]
        public override Color BackColor { get; set; }
        #endregion

        public ProgressBar()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.CacheText, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// Ensures a default size when placed onto a Form at Design-time.
        /// </summary>
        protected override Size DefaultSize
        {
            get
            {
                return new Size(260, 26);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Draw the Border.

            // TODO: Draw the Background.

            // TODO: Draw a Step.
        }
    }
}
