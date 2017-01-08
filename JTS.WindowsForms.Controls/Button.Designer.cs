namespace JTS.WindowsForms.Controls
{
    partial class Button
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Button
            // 
            this.DockChanged += new System.EventHandler(this.Button_DockChanged);
            this.FontChanged += new System.EventHandler(this.Button_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.Button_ForeColorChanged);
            this.SizeChanged += new System.EventHandler(this.Button_SizeChanged);
            this.Enter += new System.EventHandler(this.Button_Enter);
            this.Leave += new System.EventHandler(this.Button_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
