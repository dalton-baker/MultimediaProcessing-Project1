using System;
using System.Windows.Forms;

namespace ImageProcess.Dialogs
{
    public partial class AngleDialog : Form
    {
        public double Angle { get; set; }

        public AngleDialog()
        {
            InitializeComponent();
            ValueBox.DataBindings.Add(new Binding("Text", AngleSlider, "Value"));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Angle = AngleSlider.Value;
        }

        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                AngleSlider.Focus();
                e.Handled = true;
            }
        }

        private void ValueBox_Leave(object sender, EventArgs e)
        {
            int actualValue = 0;

            if(int.TryParse(ValueBox.Text, out int textBoxInt))
            {
                actualValue = Math.Max(-360, Math.Min(360, textBoxInt));
            }

            ValueBox.Text = actualValue.ToString();
        }
    }
}
