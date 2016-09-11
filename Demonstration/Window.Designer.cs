namespace Demonstration
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Controls.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.button1.BackgroundImageLayout = null;
            this.button1.BackgroundTexture = null;
            this.button1.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(196)))), ((int)(((byte)(218)))));
            this.button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.button1.BorderThickness = 1F;
            this.button1.CheckmarkColor = System.Drawing.Color.Empty;
            this.button1.CheckmarkThickness = 0F;
            this.button1.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.button1.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(228)))), ((int)(((byte)(163)))));
            this.button1.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.button1.Location = new System.Drawing.Point(195, 112);
            this.button1.Name = "button1";
            this.button1.RequiresConfirmation = true;
            this.button1.SeparatorDistance = 27;
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.SynchronizeCheckMarkWithBorderSettings = true;
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UsingTexturedBackground = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 246);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Window";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Button button1;
    }
}

