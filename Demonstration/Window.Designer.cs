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
            this.instructionText = new System.Windows.Forms.Label();
            this.controlSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.launchSelectedDemonstrationButton = new System.Windows.Forms.Button();
            this.confirmationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionText
            // 
            this.instructionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructionText.AutoSize = true;
            this.instructionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionText.Location = new System.Drawing.Point(138, 21);
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
            this.controlSelectionComboBox.Location = new System.Drawing.Point(122, 45);
            this.controlSelectionComboBox.Name = "controlSelectionComboBox";
            this.controlSelectionComboBox.Size = new System.Drawing.Size(203, 21);
            this.controlSelectionComboBox.TabIndex = 2;
            // 
            // launchSelectedDemonstrationButton
            // 
            this.launchSelectedDemonstrationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.launchSelectedDemonstrationButton.Location = new System.Drawing.Point(186, 72);
            this.launchSelectedDemonstrationButton.Name = "launchSelectedDemonstrationButton";
            this.launchSelectedDemonstrationButton.Size = new System.Drawing.Size(75, 23);
            this.launchSelectedDemonstrationButton.TabIndex = 3;
            this.launchSelectedDemonstrationButton.Text = "Go";
            this.launchSelectedDemonstrationButton.UseVisualStyleBackColor = true;
            this.launchSelectedDemonstrationButton.Click += new System.EventHandler(this.launchSelectedDemonstrationButton_Click);
            // 
            // confirmationText
            // 
            this.confirmationText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmationText.AutoSize = true;
            this.confirmationText.ForeColor = System.Drawing.Color.ForestGreen;
            this.confirmationText.Location = new System.Drawing.Point(195, 209);
            this.confirmationText.Name = "confirmationText";
            this.confirmationText.Size = new System.Drawing.Size(57, 13);
            this.confirmationText.TabIndex = 4;
            this.confirmationText.Text = "Canceled.";
            this.confirmationText.Visible = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 231);
            this.Controls.Add(this.confirmationText);
            this.Controls.Add(this.launchSelectedDemonstrationButton);
            this.Controls.Add(this.controlSelectionComboBox);
            this.Controls.Add(this.instructionText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionText;
        private System.Windows.Forms.ComboBox controlSelectionComboBox;
        private System.Windows.Forms.Button launchSelectedDemonstrationButton;
        private System.Windows.Forms.Label confirmationText;
    }
}

