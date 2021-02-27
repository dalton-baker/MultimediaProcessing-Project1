using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcess.Dialogs
{
    public partial class BluescreenDialog : Form
    {
        public double A1 { get; set; }
        public double A2 { get; set; }

        public BluescreenDialog()
        {
            InitializeComponent();
            A1Box.Text = "1";
            A2Box.Text = "0.5";
            A1 = 1;
            A2 = 0.5;
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Ok.Focus();
                e.Handled = true;
            }
        }

        private void LeaveTextBox(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            double actualValue = 0;

            if (double.TryParse(textbox.Text, out double textBoxInt))
            {
                actualValue = textBoxInt;
            }

            if (textbox.Name == A1Box.Name)
            {
                actualValue = Math.Max(1, Math.Min(10, actualValue));
                A1 = actualValue;
                A1Box.Text = A1.ToString();
            }

            if (textbox.Name == A2Box.Name)
            {
                actualValue = Math.Max(0.5, Math.Min(1.5, actualValue));
                A2 = actualValue;
                A2Box.Text = A2.ToString();
            }
        }
    }
}
