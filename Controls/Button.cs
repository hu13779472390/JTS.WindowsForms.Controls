using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Controls
{
    public partial class Button : Control
    {
        #region Custom Events
        /// <summary>
        /// Occurs when the user has Confirmed.
        /// </summary>
        public event EventHandler<ButtonConfirmedEventArgs> Confirmed;

        public class ButtonConfirmedEventArgs : EventArgs
        {
            public ButtonConfirmedEventArgs(MouseEventArgs e) { }
        }

        /// <summary>
        /// Occurs when the user clicks the button.
        /// </summary>
        public event EventHandler<ButtonClickedEventArgs> Clicked;

        public class ButtonClickedEventArgs : EventArgs
        {
            public ButtonClickedEventArgs(MouseEventArgs e) { }
        }

        /// <summary>
        /// Occurs when the user has clicked inside the CheckBox.
        /// </summary>
        public event EventHandler<ButtonCheckedChangedEventArgs> CheckedChanged;

        public class ButtonCheckedChangedEventArgs : EventArgs
        {
            private Button button;
            private bool v;
            private bool value;

            public ButtonCheckedChangedEventArgs(Button button, bool v)
            {
                this.button = button;
                this.v = v;
            }

            public ButtonCheckedChangedEventArgs(System.Windows.Forms.Button sender, bool value)
            {
                this.value = value;
            }

            public bool Checked
            {
                get { return value; }
            }
        }
        #endregion

        #region Designer Properties
        [Browsable(true), Category("Appearance"), Description("Gets or sets the HighlightColor for this control.")]
        public Color HighlightColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the BorderStyle for this control.")]
        public DashStyle BorderStyle { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the ActiveColor for this control.")]
        public Color ActiveColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the ConfirmedBackgroundColor for this control.")]
        public Color ConfirmedBackgroundColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the ConfirmedBorderColor for this control.")]
        public Color ConfirmedBorderColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the Border Color for this control.")]
        public Color BorderColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the default border thickness for this control.")]
        public float BorderThickness { get; set; }

        [Browsable(true), Category("Behavior"), Description("Indicates whether this control requires confirmation.")]
        public bool RequiresConfirmation { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets whether to Synchronize the Check-mark Color with Border settings.")]
        public bool SynchronizeCheckMarkWithBorderSettings { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets whether this control should have a textured background.")]
        public bool UsingTexturedBackground { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the background texture for this control.")]
        public Image BackgroundTexture { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the type of Layout to use for this Texture.")]
        public ImageLayout BackgroundTextureLayout { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the checkmark color for this control.")]
        public Color CheckmarkColor { get; set; }

        [Browsable(true), Category("Separator"), Description("Gets or sets the distance for the separator, in pixels, from the left edge of this control.")]
        // The recommended - and minimum - default distance, is 27 pixels.
        public int SeparatorDistance { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the Border Thickness of the Check-mark.")]
        public float CheckmarkThickness { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Category("Appearance")]
        [Obsolete("In order to use this feature, cast it (not recommended).")]
        public new Image BackgroundImage { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Category("Appearance")]
        [Obsolete("In order to use this feature, cast it (not recommended).")]
        public new Image BackgroundImageLayout { get; set; }
        #endregion

        #region Internal Declarations
        protected internal bool mouseButtonIsDown, mouseHasEntered, shouldFillCheckBoxArea, ticked, confirmed;
        protected internal Color defaultBackgroundColor;
        #endregion

        #region Internal Enumerations
        protected internal enum DrawTypes
        {
            Border,
            Text,
            Separator,
            Checkmark,
            CheckBoxFiller,
            Image,
            TexturedBackground
        }

        protected internal static DrawTypes DrawType { get; set; }

        #endregion

        #region Methods
        public void PerformClick()
        {
            if (Clicked != null)
            {
                Clicked(this, new ButtonClickedEventArgs(null));
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            // Change Visual State to reflect the user's action.
            if (!mouseHasEntered)
            {
                mouseHasEntered = true;

                defaultBackgroundColor = this.BackColor;
                this.BackColor = HighlightColor;

                this.Refresh();
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mouseButtonIsDown)
            {
                mouseButtonIsDown = true;

                if (RequiresConfirmation && e.Location.X < SeparatorDistance)
                    shouldFillCheckBoxArea = true;
                else
                {
                    shouldFillCheckBoxArea = false;
                    this.BackColor = ActiveColor;
                }

                this.Refresh();
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseButtonIsDown)
            {
                mouseButtonIsDown = false;

                this.BackColor = HighlightColor;

                // Is the mouse pointer within the bounds of the CheckBox?
                if (!confirmed)
                {
                    if (e.Location.X < SeparatorDistance)
                    {
                        if (ticked)
                        {
                            ticked = false;

                            if (CheckedChanged != null)
                            {
                                CheckedChanged(this, new ButtonCheckedChangedEventArgs(this, false));
                            }
                        }
                        else
                        {
                            ticked = true;

                            if (CheckedChanged != null)
                            {
                                CheckedChanged(this, new ButtonCheckedChangedEventArgs((Button)this, true));
                            }
                        }
                    }
                    else if (e.Location.X > SeparatorDistance)
                    {
                        if (ticked)
                        {
                            this.Enabled = false;
                            this.BackColor = ConfirmedBackgroundColor;
                            confirmed = true;

                            if (Confirmed != null)
                                Confirmed(this, new ButtonConfirmedEventArgs(e));


                        }

                        if (Clicked != null)
                        {
                            Clicked(this, new ButtonClickedEventArgs(e));
                        }
                    }
                }
            }

            this.Refresh();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (mouseHasEntered)
            {
                mouseHasEntered = false;

                if (!confirmed)
                    this.BackColor = defaultBackgroundColor;
                else
                    this.BackColor = ConfirmedBackgroundColor;
            }
        }

        private void Button_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Button_DockChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected internal void Draw(PaintEventArgs paintEventArgs, DrawTypes drawType)
        {
            paintEventArgs.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (paintEventArgs != null)
            {
                switch (drawType)
                {
                    case DrawTypes.Border:
                        if (confirmed)
                        {
                            using (Pen borderPen = new Pen(ConfirmedBorderColor, BorderThickness))
                            {
                                borderPen.DashStyle = BorderStyle;

                                paintEventArgs.Graphics.DrawRectangle(
                                    borderPen,
                                    0, 0,
                                    this.Bounds.Width - BorderThickness,
                                    this.Bounds.Height - BorderThickness);
                            }
                        }
                        else
                        {
                            using (Pen borderPen = new Pen(BorderColor, BorderThickness))
                            {
                                borderPen.DashStyle = BorderStyle;

                                paintEventArgs.Graphics.DrawRectangle(
                                    borderPen,
                                    0, 0,
                                    this.Bounds.Width - BorderThickness,
                                    this.Bounds.Height - BorderThickness);
                            }
                        }
                        break;
                    case DrawTypes.Text:
                        TextFormatFlags textFormatFlags = TextFormatFlags.HorizontalCenter
                        | TextFormatFlags.VerticalCenter
                        | TextFormatFlags.EndEllipsis;

                        if (RequiresConfirmation)
                        {
                            TextRenderer.DrawText(
                                paintEventArgs.Graphics,
                                this.Text, this.Font,
                                new Rectangle(
                                    SeparatorDistance, 0,
                                    this.Bounds.Width - SeparatorDistance, this.Bounds.Height),
                                this.ForeColor,
                                textFormatFlags);
                        }
                        else
                        {
                            TextRenderer.DrawText(
                                paintEventArgs.Graphics,
                                this.Text, this.Font,
                                new Rectangle(0, 0,
                                    this.Bounds.Width, this.Bounds.Height),
                                this.ForeColor,
                                textFormatFlags);
                        }
                        break;
                    case DrawTypes.Checkmark:
                        Color checkmarkColor;
                        float thickness = 1.0f;

                        if (this.SynchronizeCheckMarkWithBorderSettings)
                        {
                            checkmarkColor = this.BorderColor.IsEmpty ? this.ForeColor : this.BorderColor;
                            thickness = this.BorderThickness;
                        }
                        else
                        {
                            checkmarkColor = this.CheckmarkColor.IsEmpty ? this.ForeColor : this.CheckmarkColor;
                            thickness = CheckmarkThickness;
                        }

                        paintEventArgs.Graphics.DrawLine(
                            new Pen(
                                checkmarkColor,
                                thickness),
                            7, 15, 11, 18);
                        paintEventArgs.Graphics.DrawLine(
                            new Pen(
                                checkmarkColor,
                                thickness),
                            11, 18, 18, 10);

                        checkmarkColor = Color.Empty;
                        thickness = 1.0f;

                        // [PENDING DEPRECATION: 11/09/2016]
                        //paintEventArgs.Graphics.DrawLine(new Pen(ForeColor, BorderThickness),
                        //            7, 15, 11, 18);

                        //paintEventArgs.Graphics.DrawLine(new Pen(ForeColor, BorderThickness),
                        //    11, 18, 18, 10);
                        break;
                    case DrawTypes.Image:
                        break;
                    case DrawTypes.Separator:
                        if (confirmed)
                            paintEventArgs.Graphics.DrawLine(new Pen(ConfirmedBorderColor, BorderThickness), SeparatorDistance, 0, SeparatorDistance, this.Bounds.Height);
                        else
                            paintEventArgs.Graphics.DrawLine(new Pen(BorderColor, BorderThickness), SeparatorDistance, 0, SeparatorDistance, this.Bounds.Height);
                        break;
                    case DrawTypes.CheckBoxFiller:
                        if (shouldFillCheckBoxArea)
                        {
                            using (SolidBrush brush = new SolidBrush(ActiveColor))
                            {
                                paintEventArgs.Graphics.FillRectangle(brush, 0, 0, SeparatorDistance, this.Bounds.Height);
                            }

                            shouldFillCheckBoxArea = false;
                        }
                        break;
                    case DrawTypes.TexturedBackground:
                        if(this.BackgroundTexture != null)
                        {
                            Rectangle textureRectangle;

                            switch (BackgroundTextureLayout)
                            {
                                case ImageLayout.None:
                                    textureRectangle = new Rectangle(
                                        new Point((int)this.BorderThickness, (int)this.BorderThickness),
                                        new Size(this.BackgroundTexture.Width, this.BackgroundTexture.Height));

                                    using (TextureBrush textureBrush = new TextureBrush(this.BackgroundTexture))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, textureRectangle);
                                    }
                                    break;
                                case ImageLayout.Center:
                                    int xLocation, yLocation;

                                    xLocation = (((this.Width / 2) - (this.BackgroundTexture.Width / 2) - ((int)this.BorderThickness * 2)));
                                    yLocation = (((this.Height / 2) - (this.BackgroundTexture.Height / 2) - ((int)this.BorderThickness * 2)));

                                    textureRectangle = new Rectangle(
                                        new Point(xLocation, yLocation),
                                        new Size(this.BackgroundTexture.Width, this.BackgroundTexture.Height));

                                    using (TextureBrush textureBrush = new TextureBrush(this.BackgroundTexture))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, textureRectangle);
                                    }
                                    break;
                                case ImageLayout.Stretch:
                                    textureRectangle = new Rectangle(
                                        new Point((int)this.BorderThickness,
                                        (int)this.BorderThickness),
                                        new Size((this.Width - (int)this.BorderThickness),
                                        (this.Height - (int)this.BorderThickness)));

                                    using (TextureBrush textureBrush = new TextureBrush(
                                        this.BackgroundTexture))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, textureRectangle);
                                    }
                                    break;
                                case ImageLayout.Tile:
                                    textureRectangle = new Rectangle(
                                        new Point((int)this.BorderThickness,
                                        (int)this.BorderThickness),
                                        new Size(this.BackgroundTexture.Width, this.BackgroundTexture.Height));

                                    using (TextureBrush textureBrush = new TextureBrush(
                                        this.BackgroundTexture, WrapMode.Tile))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, textureRectangle);
                                    }
                                    break;
                                case ImageLayout.Zoom:
                                    throw new NotImplementedException();
                                default:
                                    textureRectangle = new Rectangle(
                                        new Point((int)this.BorderThickness, (int)this.BorderThickness),
                                        new Size((this.Width - (int)this.BorderThickness), (this.Height - (int)this.BorderThickness)));

                                    using (TextureBrush textureBrush = new TextureBrush(this.BackgroundTexture))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, textureRectangle);
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
        }

        public void Retry()
        {
            mouseButtonIsDown = false;
            shouldFillCheckBoxArea = false;
            ticked = false;
            confirmed = false;

            this.Refresh();
        }
        #endregion

        public Button()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            defaultBackgroundColor = this.BackColor;
        }
        
        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            if (RequiresConfirmation)
            {
                if (ticked)
                {
                    /* Always draw the Texture (Image) first, otherwise it
                     * will just render over the other drawings.
                     */
                    Draw(paintEventArgs, DrawTypes.TexturedBackground);

                    if (shouldFillCheckBoxArea)
                        Draw(paintEventArgs, DrawTypes.CheckBoxFiller);

                    Draw(paintEventArgs, DrawTypes.Border);
                    Draw(paintEventArgs, DrawTypes.Checkmark);
                    Draw(paintEventArgs, DrawTypes.Separator);
                    Draw(paintEventArgs, DrawTypes.Text);
                }
                else
                {
                    Draw(paintEventArgs, DrawTypes.TexturedBackground);

                    if (shouldFillCheckBoxArea)
                        Draw(paintEventArgs, DrawTypes.CheckBoxFiller);

                    Draw(paintEventArgs, DrawTypes.Border);
                    Draw(paintEventArgs, DrawTypes.Separator);
                    Draw(paintEventArgs, DrawTypes.Text);
                }
            }
            else
            {
                Draw(paintEventArgs, DrawTypes.TexturedBackground);

                Draw(paintEventArgs, DrawTypes.Border);
                Draw(paintEventArgs, DrawTypes.Text);
            }
        }
    }
}
