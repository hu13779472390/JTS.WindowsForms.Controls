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
    public partial class ConfirmationDialog : Form
    {
        public ConfirmationDialog()
        {
            InitializeComponent();
        }

		private void confirmationButton_Confirmed(object sender, Controls.Button.ButtonConfirmedEventArgs e)
		{
			messageText.Text = "You have confirmed that you wish to perform a dangerous or important action.";
		}
	}
}
