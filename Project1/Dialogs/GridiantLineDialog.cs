using System;
using System.Windows.Forms;

namespace ImageProcess.Dialogs
{
    public partial class GridiantLineDialog : Form
    {
        Image _image;

        public bool IsVertical { get; set; }
        public int LineLocation { get; set; }
        public int LineThickness { get; set; }

        public GridiantLineDialog(Image image)
        {
            _image = image;

            InitializeComponent();

            LocationSlider.Maximum = _image.Height;
            LocValue.DataBindings.Add(new Binding("Text", LocationSlider, "Value"));
            ThicknessValue.DataBindings.Add(new Binding("Text", ThicknessSlider, "Value"));

            LocationSlider.Value = LocationSlider.Maximum / 2;
            ThicknessSlider.Value = 20;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            IsVertical = IsVertCheckbox.Checked;
            LineLocation = LocationSlider.Value;
            LineThickness = ThicknessSlider.Value;
        }

        private void IsVertCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox)sender).Checked;

            if(isChecked)
            {
                LocationSlider.Maximum = _image.Width;
                LocationSlider.Value = LocationSlider.Maximum / 2;
            }
            else
            {
                LocationSlider.Maximum = _image.Height;
                LocationSlider.Value = LocationSlider.Maximum / 2;
            }
        }
    }
}
