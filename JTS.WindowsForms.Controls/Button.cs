﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace JTS.WindowsForms.Controls
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

        [Browsable(true), Category("Appearance"), Description("Gets or sets the background texture for this control.")]
        public Image BackgroundTexture { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the type of Layout to use for this Texture.")]
        public ImageLayout BackgroundTextureLayout { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the checkmark color for this control.")]
        public Color CheckmarkColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the background color of this control's checkbox area when it is disabled.")]
        public Color DisabledCheckBoxBackgroundColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the color of this control's Separator when it is disabled.")]
        public Color DisabledSeparatorColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the color of the check-mark when this control is disabled.")]
        public Color DisabledCheckmarkColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the checkmark color for this control.")]
        public Color ConfirmedCheckmarkColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the ConfirmedCheckBoxBackgroundColor for this control.")]
        public Color ConfirmedCheckBoxBackgroundColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the Border Thickness of the Check-mark.")]
        public float CheckmarkThickness { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Category("Appearance")]
        [Obsolete("In order to use this feature, cast it (not recommended).")]
        public new Image BackgroundImage { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), Category("Appearance")]
        [Obsolete("In order to use this feature, cast it (not recommended).")]
        public new Image BackgroundImageLayout { get; set; }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Advanced), Category("Appearance")]
        public Color CheckboxBackgroundColor { get; set; }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Advanced), Category("Appearance"), Description("")]
        public Color CheckboxHighlightColor { get; set; }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Advanced), Category("Appearance"), Description("")]
        public Color CheckboxActiveColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the color of this control when it is focused (has become the active control of the Form).")]
        public Color FocusedColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the style of the Focus border.")]
        public DashStyle FocusedBorderStyle { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the background color of the control when it is disabled.")]
        public Color DisabledBackgroundColor { get; set; }

        [Browsable(true), Category("Appearance"), Description("Gets or sets the border color of the control when it is disabled.")]
        public Color DisabledBorderColor { get; set; }

        [Browsable(true), Category("Behavior"), Description("Indicates whether this control requires confirmation.")]
        public bool RequiresConfirmation { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets whether to Synchronize the Check-mark Color with Border settings.")]
        public bool SynchronizeCheckMarkWithBorderSettings { get; set; }

        [Browsable(true), Category("Behavior"), Description("Gets or sets whether this control should have a textured background.")]
        public bool UsingTexturedBackground { get; set; }

        //[Obsolete("This feature is now obsolete. A replacement is on its way.", false)]
        [Browsable(true), Category("Behavior"), Description("")]
        public bool StyleButtonSeparately { get; set; }

        [Browsable(true), Category("Separator"), Description("Gets or sets the distance for the separator, in pixels, from the left edge of this control.")]
        // The recommended - and minimum - default distance, is 27 pixels.
        public int SeparatorDistance { get; set; }
        #endregion

        #region Internal Declarations
        protected internal bool mouseButtonIsDown, mouseHasEntered, shouldFillCheckBoxArea, ticked, confirmed, buttonHasFocus;
        protected internal Color defaultBackgroundColor;
        protected internal Color checkMarkColor;
        protected internal Color checkBoxColor;
        protected internal Color backgroundColor;
        protected internal Color separatorColor;
        protected internal Color defBCol;
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

        public new bool Enabled
        {
            get
            {
                return base.Enabled;
            }

            set
            {
                if (!this.Enabled)
                    this.BackColor = DisabledBackgroundColor;
                else
                    this.BackColor = defBCol;

                base.Enabled = value;
            }
        }

        #region Methods

        public void PerformClick()
        {
            Clicked?.Invoke(this, new ButtonClickedEventArgs(null));
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
                            CheckedChanged?.Invoke(this, new ButtonCheckedChangedEventArgs(this, false));

                        }
                        else
                        {
                            ticked = true;

                            CheckedChanged?.Invoke(this, new ButtonCheckedChangedEventArgs((Button)this, true));
                        }
                    }
                    else if (e.Location.X > SeparatorDistance)
                    {
                        if (ticked)
                        {
                            this.Enabled = false;
                            this.BackColor = ConfirmedBackgroundColor;
                            confirmed = true;

                            Confirmed?.Invoke(this, new ButtonConfirmedEventArgs(e));
                        }

                        Clicked?.Invoke(this, new ButtonClickedEventArgs(e));
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
                // If the control is currently Disabled...
                Color borderColor;

                if (!this.Enabled)
                {
                    // Let the user know
                    borderColor = DisabledBorderColor;
                    checkMarkColor = DisabledCheckmarkColor;
                    checkBoxColor = DisabledCheckBoxBackgroundColor;
                    backgroundColor = DisabledBackgroundColor;
                    //separatorColor = DisabledSeparatorColor;
                }
                else
                {
                    // either way...
                    borderColor = BorderColor;
                }

                switch (drawType)
                {
                    case DrawTypes.Border:
                        if (confirmed)
                        {
                            if (buttonHasFocus)
                            {
                                using (Pen borderPen = new Pen(ConfirmedBorderColor, BorderThickness))
                                {
                                    borderPen.DashStyle = FocusedBorderStyle;

                                    paintEventArgs.Graphics.DrawRectangle(
                                        borderPen,
                                        0, 0,
                                        this.Bounds.Width - BorderThickness,
                                        this.Bounds.Height - BorderThickness);
                                }
                            }
                            else
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
                        }
                        else
                        {
                            if (buttonHasFocus)
                            {
                                using (Pen borderPen = new Pen(borderColor, BorderThickness))
                                {
                                    borderPen.DashStyle = FocusedBorderStyle;

                                    paintEventArgs.Graphics.DrawRectangle(
                                        borderPen,
                                        0, 0,
                                        this.Bounds.Width - BorderThickness,
                                        this.Bounds.Height - BorderThickness);
                                }
                            }
                            else
                            {
                                using (Pen borderPen = new Pen(borderColor, BorderThickness))
                                {
                                    borderPen.DashStyle = BorderStyle;

                                    paintEventArgs.Graphics.DrawRectangle(
                                        borderPen,
                                        0, 0,
                                        this.Bounds.Width - BorderThickness,
                                        this.Bounds.Height - BorderThickness);
                                }
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

                        if (confirmed)
                        {
                            checkmarkColor = ConfirmedCheckmarkColor;
                            thickness = CheckmarkThickness;
                        }

                        if(!this.Enabled)
                        {
                            checkmarkColor = DisabledCheckmarkColor;
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
                        break;
                    case DrawTypes.Image:
                        break;
                    case DrawTypes.Separator:
                        if (confirmed)
                            paintEventArgs.Graphics.DrawLine(
                                new Pen(
                                    ConfirmedBorderColor,
                                    BorderThickness
                                    ),
                                SeparatorDistance,
                                0,
                                SeparatorDistance,
                                this.Bounds.Height
                                );
                        else
                        {
                            separatorColor = this.Enabled ? BorderColor : DisabledSeparatorColor;
                            paintEventArgs.Graphics.DrawLine(
                                new Pen(
                                    separatorColor,
                                    BorderThickness
                                    ),
                                SeparatorDistance,
                                0,
                                SeparatorDistance,
                                this.Bounds.Height
                                );
                        }
                        break;
                    case DrawTypes.CheckBoxFiller:
                        Color color;
                        if (StyleButtonSeparately)
                        {
                            if (mouseHasEntered)
                                color = CheckboxHighlightColor;
                            else if (mouseButtonIsDown)
                                color = CheckboxActiveColor;
                            else
                                color = CheckboxBackgroundColor;

                            if (!this.Enabled && !confirmed)
                                color = DisabledCheckBoxBackgroundColor;

                            using (SolidBrush brush = new SolidBrush(color))
                            {
                                paintEventArgs.Graphics.FillRectangle(
                                    brush,
                                    0,
                                    0,
                                    SeparatorDistance,
                                    (this.Bounds.Height - 1)
                                    );
                            }
                        }

                        if (shouldFillCheckBoxArea)
                        {
                            color = this.Enabled ? ActiveColor : DisabledCheckBoxBackgroundColor;

                            using (SolidBrush brush = new SolidBrush(color))
                            {
                                paintEventArgs.Graphics.FillRectangle(
                                    brush,
                                    0,
                                    0,
                                    SeparatorDistance,
                                    this.Bounds.Height
                                    );
                            }

                            shouldFillCheckBoxArea = false;
                        }

                        if(RequiresConfirmation && confirmed)
                        {
                            if(!ConfirmedCheckBoxBackgroundColor.IsEmpty)
                            {
                                using (SolidBrush brush = new SolidBrush(ConfirmedCheckBoxBackgroundColor))
                                {
                                    paintEventArgs.Graphics.FillRectangle(
                                        brush,
                                        0,
                                        0,
                                        SeparatorDistance,
                                        this.Bounds.Height
                                        );
                                }
                            }
                        }
                        break;
                    case DrawTypes.TexturedBackground:
                        if (BackgroundTexture != null)
                        {
                            // Create a mapping of all image layout types to functions that generate rectangles for that type
                            Dictionary<ImageLayout, Func<Rectangle>> LayoutMap = new Dictionary<ImageLayout, Func<Rectangle>>()
                            {
                                {
                                    ImageLayout.None,
                                    () => new Rectangle(
                                        new Point(
                                            (int)BorderThickness,
                                            (int)BorderThickness),
                                        new Size(
                                            BackgroundTexture.Width,
                                            BackgroundTexture.Height
                                            )
                                            )
                                },
                                {
                                    ImageLayout.Stretch,
                                    () => new Rectangle(
                                        new Point(
                                            (int)BorderThickness,
                                            (int)BorderThickness),
                                        new Size(
                                            (Width - (int)BorderThickness),
                                            (Height - (int)BorderThickness)
                                            )
                                            )
                                },
                                {
                                    ImageLayout.Tile,
                                    () => new Rectangle(
                                        new Point(
                                            (int)BorderThickness,
                                            (int)BorderThickness),
                                        new Size(
                                            (Width - (int)BorderThickness),
                                            (Height - (int)BorderThickness)
                                            )
                                            )
                                },
                                {
                                    ImageLayout.Zoom,
                                    () =>
                                    {
                                        throw new NotImplementedException("Zoom is not yet supported for the confirmation button.");
                                    }
                                },
                                {
                                    ImageLayout.Center,
                                    () =>
                                    {
                                        int xLocation = (Width / 2) - (BackgroundTexture.Width / 2) - ((int)BorderThickness * 2);
                                        int yLocation = (Height / 2) - (BackgroundTexture.Height / 2) - ((int)BorderThickness * 2);

                                        return new Rectangle(
                                            new Point(xLocation, yLocation),
                                            new Size(
                                                BackgroundTexture.Width,
                                                BackgroundTexture.Height)
                                                );
                                    }
                                }
                            };

                            // Attempt to get a rectangle generating function from the dictionary defined above.
                            // Because the ImageLayout type is an enum, we don't need a default case (as the default case will be ImageLayout.None)
                            Func<Rectangle> GenerateLayout;
                            if (LayoutMap.TryGetValue(BackgroundTextureLayout, out GenerateLayout))
                            {
                                // If the layout mode is anything other than tile, just draw the image:
                                if (BackgroundTextureLayout != ImageLayout.Tile)
                                {
                                    using (TextureBrush textureBrush = new TextureBrush(BackgroundTexture))
                                    {
                                        paintEventArgs.Graphics.DrawImage(textureBrush.Image, GenerateLayout());
                                    }
                                }
                                // Otherwise, use a tiling brush and fill the rectangle with the texture
                                else
                                {
                                    using (TextureBrush textureBrush = new TextureBrush(BackgroundTexture, WrapMode.Tile))
                                    {
                                        paintEventArgs.Graphics.FillRectangle(textureBrush, GenerateLayout());
                                    }
                                }
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

        private void SetStyles()
        {
            // Caching the text will give us ~1.5% performance boost.
            this.SetStyle(ControlStyles.CacheText, true);

            // Allows the control to be properly redrawn if/when it is resized (physically or dynamically).
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Helps to prevent flickering when the control (or a part of it) is redrawn.
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.SetStyle(ControlStyles.Selectable, true);
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            buttonHasFocus = false;
            this.Refresh();
        }

        private void Button_FontChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Button_ForeColorChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            /* I think this is where we draw a custom rectangle around a 
            * control that has just received focus. */
            if (this.Enabled)
                this.BackColor = defBCol;

            buttonHasFocus = true;
            this.Refresh();
        }
        #endregion

        // Helps to prevent flickering controls on the Form level.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;

                // Turn on WS_EX_COMPOSITED.
                createParams.ExStyle |= 0x02000000;

                return createParams;
            }
        }

        // This is more efficient than setting the Size in the Constructor.
        protected override Size DefaultSize
        {
            get
            {
                return new Size(85, 27);
            }
        }

        #region Constructor
        /// <summary>
        /// Ctor
        /// </summary>
        public Button()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            SetStyles();

            defaultBackgroundColor = this.BackColor;
            defBCol = this.BackColor;
        }
        #endregion

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

                    // Issue #26.
                    Draw(paintEventArgs, DrawTypes.CheckBoxFiller);
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

                    // Issue #26.
                    Draw(paintEventArgs, DrawTypes.CheckBoxFiller);
                    Draw(paintEventArgs, DrawTypes.Separator);
                    Draw(paintEventArgs, DrawTypes.Text);
                }
            }
            else
            {
                Draw(paintEventArgs, DrawTypes.TexturedBackground);
                Draw(paintEventArgs, DrawTypes.Border);

                // Issue #26.
                Draw(paintEventArgs, DrawTypes.CheckBoxFiller);
                Draw(paintEventArgs, DrawTypes.Text);
            }
        }
    }
}