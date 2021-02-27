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
    }
}
