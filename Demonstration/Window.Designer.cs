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
            this.greetingText = new System.Windows.Forms.Label();
            this.instructionText = new System.Windows.Forms.Label();
            this.controlSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.launchSelectedDemonstrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingText
            // 
            this.greetingText.AutoEllipsis = true;
            this.greetingText.Dock = System.Windows.Forms.DockStyle.Top;
            this.greetingText.Location = new System.Drawing.Point(0, 0);
            this.greetingText.Name = "greetingText";
            this.greetingText.Size = new System.Drawing.Size(446, 62);
            this.greetingText.TabIndex = 0;
            this.greetingText.Text = "Thank you for downloading JTS.WindowsForms.Controls. Inside this solution, you wi" +
    "ll find useful controls for WinForms apps. These controls are both aesthetically" +
    " pleasing, and very customizable.";
            this.greetingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionText
            // 
            this.instructionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructionText.AutoSize = true;
            this.instructionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionText.Location = new System.Drawing.Point(138, 83);
            this.instructionText.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.instructionText.Name = "instructionText";
            this.instructionText.Size = new System.Drawing.Size(171, 21);
            this.instructionText.TabIndex = 1;
            this.instructionText.Text = "Select Control to Demo";
            // 
            // controlSelectionComboBox
            // 
            this.controlSelectionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.controlSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlSelectionComboBox.FormattingEnabled = true;
            this.controlSelectionComboBox.Items.AddRange(new object[] {
            "Confirmation Button",
            "Switch",
            "Separator"});
            this.controlSelectionComboBox.Location = new System.Drawing.Point(122, 107);
            this.controlSelectionComboBox.Name = "controlSelectionComboBox";
            this.controlSelectionComboBox.Size = new System.Drawing.Size(203, 21);
            this.controlSelectionComboBox.TabIndex = 2;
            // 
            // launchSelectedDemonstrationButton
            // 
            this.launchSelectedDemonstrationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.launchSelectedDemonstrationButton.Location = new System.Drawing.Point(186, 134);
            this.launchSelectedDemonstrationButton.Name = "launchSelectedDemonstrationButton";
            this.launchSelectedDemonstrationButton.Size = new System.Drawing.Size(75, 23);
            this.launchSelectedDemonstrationButton.TabIndex = 3;
            this.launchSelectedDemonstrationButton.Text = "Go";
            this.launchSelectedDemonstrationButton.UseVisualStyleBackColor = true;
            this.launchSelectedDemonstrationButton.Click += new System.EventHandler(this.launchSelectedDemonstrationButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 180);
            this.Controls.Add(this.launchSelectedDemonstrationButton);
            this.Controls.Add(this.controlSelectionComboBox);
            this.Controls.Add(this.instructionText);
            this.Controls.Add(this.greetingText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingText;
        private System.Windows.Forms.Label instructionText;
        private System.Windows.Forms.ComboBox controlSelectionComboBox;
        private System.Windows.Forms.Button launchSelectedDemonstrationButton;
    }
}

