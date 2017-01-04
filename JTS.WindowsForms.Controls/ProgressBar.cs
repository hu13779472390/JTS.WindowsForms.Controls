using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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

        [Browsable(true), Category("Behavior"), Description("Gets or sets the lower bound of the range that this Progress Bar is working with.")]
        public int Minimum { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets the upper bound of the range that this Progress Bar is working with.")]
        public int Maximum { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets the amount to increment the current value of the ProgressBar when the Indicate() method is called.")]
        public int Step { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets the current value of the ProgressBar, in the raneg specified by the Minimum and Maximum properties.")]
        public int Value { get; set; }

        /// <summary>
        /// Initializes a new instance of this control with its default settings.
        /// </summary>
        public ProgressBar() : base()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.UseTextForAccessibility, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.CacheText, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;

                return createParams;
            }
        }

        protected override ImeMode DefaultImeMode
        {
            get
            {
                return ImeMode.Disable;
            }
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

        }
    }
}
