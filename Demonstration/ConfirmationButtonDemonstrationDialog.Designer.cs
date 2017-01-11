namespace Demonstration
{
    partial class ConfirmationButtonDemonstrationDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regularCancelButton = new JTS.WindowsForms.Controls.Button();
            this.confirmationButton = new JTS.WindowsForms.Controls.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to permanently delete this file?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "fakeFile.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type: Text Document";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size: 86 bytes";
            // 
            // regularCancelButton
            // 
            this.regularCancelButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(224)))), ((int)(((byte)(235)))));
            this.regularCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.regularCancelButton.BackgroundImageLayout = null;
            this.regularCancelButton.BackgroundTexture = null;
            this.regularCancelButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.regularCancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(155)))), ((int)(((byte)(190)))));
            this.regularCancelButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.regularCancelButton.BorderThickness = 1F;
            this.regularCancelButton.CheckboxActiveColor = System.Drawing.Color.Empty;
            this.regularCancelButton.CheckboxBackgroundColor = System.Drawing.Color.Empty;
            this.regularCancelButton.CheckboxHighlightColor = System.Drawing.Color.Empty;
            this.regularCancelButton.CheckmarkColor = System.Drawing.Color.Empty;
            this.regularCancelButton.CheckmarkThickness = 0F;
            this.regularCancelButton.ConfirmedBackgroundColor = System.Drawing.Color.Empty;
            this.regularCancelButton.ConfirmedBorderColor = System.Drawing.Color.Empty;
            this.regularCancelButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.Empty;
            this.regularCancelButton.ConfirmedCheckmarkColor = System.Drawing.Color.Empty;
            this.regularCancelButton.DisabledBackgroundColor = System.Drawing.Color.Empty;
            this.regularCancelButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this.regularCancelButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.Empty;
            this.regularCancelButton.DisabledCheckmarkColor = System.Drawing.Color.Empty;
            this.regularCancelButton.DisabledSeparatorColor = System.Drawing.Color.Empty;
            this.regularCancelButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.regularCancelButton.FocusedColor = System.Drawing.Color.Empty;
            this.regularCancelButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.regularCancelButton.Location = new System.Drawing.Point(215, 148);
            this.regularCancelButton.Name = "regularCancelButton";
            this.regularCancelButton.RequiresConfirmation = false;
            this.regularCancelButton.SeparatorDistance = 0;
            this.regularCancelButton.Size = new System.Drawing.Size(85, 27);
            this.regularCancelButton.StyleButtonSeparately = false;
            this.regularCancelButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.regularCancelButton.TabIndex = 5;
            this.regularCancelButton.Text = "Cancel";
            this.regularCancelButton.UsingTexturedBackground = false;
            this.regularCancelButton.Clicked += new System.EventHandler<JTS.WindowsForms.Controls.Button.ButtonClickedEventArgs>(this.regularCancelButton_Clicked);
            // 
            // confirmationButton
            // 
            this.confirmationButton.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.confirmationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.confirmationButton.BackgroundImageLayout = null;
            this.confirmationButton.BackgroundTexture = null;
            this.confirmationButton.BackgroundTextureLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmationButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.confirmationButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.confirmationButton.BorderThickness = 1F;
            this.confirmationButton.CheckboxActiveColor = System.Drawing.Color.Red;
            this.confirmationButton.CheckboxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.confirmationButton.CheckboxHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.confirmationButton.CheckmarkColor = System.Drawing.Color.White;
            this.confirmationButton.CheckmarkThickness = 1F;
            this.confirmationButton.ConfirmedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.confirmationButton.ConfirmedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(189)))), ((int)(((byte)(100)))));
            this.confirmationButton.ConfirmedCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.confirmationButton.ConfirmedCheckmarkColor = System.Drawing.Color.White;
            this.confirmationButton.DisabledBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmationButton.DisabledBorderColor = System.Drawing.Color.Silver;
            this.confirmationButton.DisabledCheckBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmationButton.DisabledCheckmarkColor = System.Drawing.Color.Silver;
            this.confirmationButton.DisabledSeparatorColor = System.Drawing.Color.Silver;
            this.confirmationButton.FocusedBorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.confirmationButton.FocusedColor = System.Drawing.Color.Silver;
            this.confirmationButton.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmationButton.Location = new System.Drawing.Point(306, 148);
            this.confirmationButton.Name = "confirmationButton";
            this.confirmationButton.RequiresConfirmation = true;
            this.confirmationButton.SeparatorDistance = 27;
            this.confirmationButton.Size = new System.Drawing.Size(85, 27);
            this.confirmationButton.StyleButtonSeparately = false;
            this.confirmationButton.SynchronizeCheckMarkWithBorderSettings = false;
            this.confirmationButton.TabIndex = 4;
            this.confirmationButton.Text = "Delete";
            this.confirmationButton.UsingTexturedBackground = false;
            this.confirmationButton.Confirmed += new System.EventHandler<JTS.WindowsForms.Controls.Button.ButtonConfirmedEventArgs>(this.confirmationButton_Confirmed);
            // 
            // ConfirmationButtonDemonstrationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 187);
            this.Controls.Add(this.regularCancelButton);
            this.Controls.Add(this.confirmationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfirmationButtonDemonstrationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationButton Demonstration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private JTS.WindowsForms.Controls.Button confirmationButton;
        private JTS.WindowsForms.Controls.Button regularCancelButton;
    }
}