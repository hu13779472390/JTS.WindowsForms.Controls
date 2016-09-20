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
            this.button1.ActiveColor = System.Drawing.SystemColors.ControlLight;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = null;
            this.button1.BackgroundTexture = null;
            this.button1.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.button1.BorderThickness = 1F;
            this.button1.CheckmarkColor = System.Drawing.Color.Gray;
            this.button1.CheckmarkThickness = 1F;
            this.button1.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(239)))));
            this.button1.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(180)))));
            this.button1.ConfirmedCheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(179)))), ((int)(((byte)(81)))));
            this.button1.HighlightColor = System.Drawing.Color.Empty;
            this.button1.Location = new System.Drawing.Point(214, 91);
            this.button1.Name = "button1";
            this.button1.RequiresConfirmation = true;
            this.button1.SeparatorDistance = 27;
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.SynchronizeCheckMarkWithBorderSettings = false;
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UsingTexturedBackground = true;
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

