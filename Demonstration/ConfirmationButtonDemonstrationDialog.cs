using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonstration
{
    public partial class ConfirmationButtonDemonstrationDialog : Form
    {
        public ConfirmationButtonDemonstrationDialog()
        {
            InitializeComponent();
        }

        private void regularCancelButton_Clicked(object sender, JTS.WindowsForms.Controls.Button.ButtonClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void confirmationButton_Confirmed(object sender, JTS.WindowsForms.Controls.Button.ButtonConfirmedEventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                confirmationButton.Enabled = false;
            }
            else
            {
                confirmationButton.Enabled = true;
            }
        }
    }
}
