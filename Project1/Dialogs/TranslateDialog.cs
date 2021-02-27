using System;
using System.Windows.Forms;

namespace ImageProcess.Dialogs
{
    public partial class TranslateDialog : Form
    {
        public int X { get; set; }
        public int Y { get; set; }

        public TranslateDialog()
        {
            InitializeComponent();
            XBox.Text = "0";
            YBox.Text = "0";
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

            int actualValue = 0;

            if (int.TryParse(textbox.Text, out int textBoxInt))
            {
                actualValue = textBoxInt;
            }

            if(textbox.Name == XBox.Name)
            {
                X = actualValue;
                XBox.Text = X.ToString();
            }

            if (textbox.Name == YBox.Name)
            {
                Y = actualValue;
                YBox.Text = Y.ToString();
            }
        }
    }
}
