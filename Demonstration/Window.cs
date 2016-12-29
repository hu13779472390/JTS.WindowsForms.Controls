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
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void launchSelectedDemonstrationButton_Click(object sender, EventArgs e)
        {
            switch (controlSelectionComboBox.Text)
            {
                case "Confirmation Button":
                    // TODO: Create form and open it here.
                    using (ConfirmationButtonDemonstrationDialog confirmationButtonDemonstrationDialog = new Demonstration.ConfirmationButtonDemonstrationDialog())
                    {
                        if (confirmationButtonDemonstrationDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            confirmationText.Text = "Confirmed.";
                            confirmationText.Visible = true;
                        }
                        else
                        {
                            confirmationText.Text = "Canceled.";
                            confirmationText.Visible = true;
                        }
                    }

                    // Get Dialog Result and Confirmation.
                    break;
                case "Switch":
                    break;
                case "Separator":
                    break;
            }
        }
    }
}
