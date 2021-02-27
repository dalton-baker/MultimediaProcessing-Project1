using ImageProcess.Dialogs;
using System;
using System.Windows.Forms;

/**********************************************************************************
* Mark off what items are complete, and put a P if partially complete. For the 
* categories, name the filter and its points. If you crete more than one per 
* category, list their names and their poitns below the required command for that 
* catagory.
* 
* Total available points:  200 (250 for CSC 692)
* 
*  ✓________ 8pt make a new\open\save image under a File Menu and add Project 1 menu
*  ✓________ 2pt display the current state of the image 
*  ✓________ 10pt A 5X5 square blur filter 
*  ✓________ 15pt A 5X5 Prewit or Sorbel filter 
*  ________ 10pt A rotate about the center (uses a dialog box to set the amount) 
*  ________ 15pt A flip horizontally and translate (x and y) afterwards (uses a dialog box to set the amount) 
*  ________ 20pt A blue or green screen composition. You may use a default image for the mask. 
*  ________ 30pt OPTIONAL for individuals, and required for teams slide show
*  
* ✓________ [Pointilize 30pts] Required Blur\Sharpen\Contrast\Filter
* 
* ✓________ [Sorbel 10pts] Required Feature Extraction
* 
* ________ [?pt] Required Linear warp
* 
* ________ [?pt] Required Non-linear warp
* 
* ________ [?pt] Required Composition
* 
* 
* 
* The grade you compute is the starting point for course staff, who reserve the 
* right to change the grade if they disagree with your assessment and to deduct 
* points for other issues they may encounter, such as errors in the submission 
* process, naming issues, etc.
* 
**********************************************************************************/

namespace ImageProcess
{
    public partial class MainForm : Form
    {
        enum ModelType { None, Generate, Process }; //mode for menu enabling

        Image model;
        ImageEditor editor;


        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true; //stop flicker

            SetMenuOptionEnable(ModelType.None);
        }

        //main Paint function
        protected override void OnPaint(PaintEventArgs e)
        {
            if (model == null)
                return;

            model.OnPaint(e);
        }

        //redraw on resize
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }


        //
        //forward mouse calls
        //

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (model == null)
                return;

            base.OnMouseDown(e);
            editor.MousePress(model, e.X, e.Y);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (model == null)
                return;

            base.OnMouseUp(e);
            editor.MouseRelease();
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (model == null)
                return;

            base.OnMouseMove(e);
            editor.MouseMove(model, e.X, e.Y);
            Invalidate();
        }


        //
        //forward menu calls-------------------------------------------------------------------------
        //
        private void newMenu_Click(object sender, EventArgs e)
        {
            editor = new ImageGenerate();
            model = new Image(menuStrip1.Height);
            ImageGenerate.FillBlack(model);
            SetMenuOptionEnable(ModelType.Generate);
            Invalidate();
        }

        private void drawMenu_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.Draw);

            drawMenu.Checked = editor.MouseMode == ImageEditor.MODE.Draw;

            Invalidate();
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            model.Reset();

            Invalidate();
        }

        private void negativeMenu_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnFilterNegative(model);
            drawMenu.Checked = editor.MouseMode == ImageEditor.MODE.Draw;

            Invalidate();
        }

        private void thresholdMenu_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.Threshold);
            drawMenu.Checked = editor.MouseMode == ImageEditor.MODE.Draw;
        }

        private void warpMenu_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.Warp);
            drawMenu.Checked = editor.MouseMode == ImageEditor.MODE.Draw;
        }

        private void warpBilinearMenu_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.WarpNearest);
            drawMenu.Checked = editor.MouseMode == ImageEditor.MODE.Draw;
        }

        private void fillWhiteMenu_Click(object sender, EventArgs e)
        {
            ImageGenerate.FillWhite(model);
        }

        private void openTestMenu_Click(object sender, EventArgs e)
        {
            model = new Image(menuStrip1.Height);
            model.OnOpenDocument(null);
            editor = new ImageProcess();
            SetMenuOptionEnable(ModelType.Process);
            Invalidate();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                model = new Image(menuStrip1.Height);
                model.OnOpenDocument(openFileDialog1.FileName);
                editor = new ImageProcess();
                SetMenuOptionEnable(ModelType.Process);
                Invalidate();
            }
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            model.Close();
            model = null;
            SetMenuOptionEnable(ModelType.None);
            Invalidate();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                model.OnSaveDocument(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
            }
        }

        private void SetMenuOptionEnable(ModelType mode)
        {
            bool on = true;
            switch (mode)
            {
                case ModelType.None:
                    on = false;
                    fillWhiteMenu.Enabled = on;
                    fillLavenderToolStripMenuItem.Enabled = on;
                    fillGreenToolStripMenuItem.Enabled = on;
                    horizontalGradientToolStripMenuItem.Enabled = on;
                    verticalBlueGradientToolStripMenuItem.Enabled = on;
                    diagonalGradientToolStripMenuItem.Enabled = on;
                    verticalLineToolStripMenuItem.Enabled = on;
                    horizontalLineToolStripMenuItem.Enabled = on;
                    diagonalLineToolStripMenuItem.Enabled = on;
                    copyMenu.Enabled = on;
                    negativeMenu.Enabled = on;
                    thresholdMenu.Enabled = on;
                    dimToolStripMenuItem.Enabled = on;
                    tintToolStripMenuItem.Enabled = on;
                    lowpassFilterToolStripMenuItem.Enabled = on;
                    monochromeToolStripMenuItem.Enabled = on;
                    medianFilterToolStripMenuItem.Enabled = on;
                    warpMenu.Enabled = on;
                    warpBilinearMenu.Enabled = on;
                    drawMenu.Enabled = on;
                    drawMenu.Checked = false;
                    break;
                case ModelType.Generate:
                    drawMenu.Enabled = true;

                    fillWhiteMenu.Enabled = on;
                    fillLavenderToolStripMenuItem.Enabled = on;
                    fillGreenToolStripMenuItem.Enabled = on;
                    horizontalGradientToolStripMenuItem.Enabled = on;
                    verticalBlueGradientToolStripMenuItem.Enabled = on;
                    diagonalGradientToolStripMenuItem.Enabled = on;
                    verticalLineToolStripMenuItem.Enabled = on;
                    horizontalLineToolStripMenuItem.Enabled = on;
                    diagonalLineToolStripMenuItem.Enabled = on;
                    copyMenu.Enabled = !on;
                    negativeMenu.Enabled = !on;
                    thresholdMenu.Enabled = !on;
                    dimToolStripMenuItem.Enabled = !on;
                    tintToolStripMenuItem.Enabled = !on;
                    lowpassFilterToolStripMenuItem.Enabled = !on;
                    monochromeToolStripMenuItem.Enabled = !on;
                    medianFilterToolStripMenuItem.Enabled = !on;
                    warpMenu.Enabled = !on;
                    warpBilinearMenu.Enabled = !on;

                    break;
                case ModelType.Process:
                    drawMenu.Enabled = true;

                    on = !on;
                    fillWhiteMenu.Enabled = on;
                    fillGreenToolStripMenuItem.Enabled = on;
                    fillLavenderToolStripMenuItem.Enabled = on;
                    horizontalGradientToolStripMenuItem.Enabled = on;
                    verticalBlueGradientToolStripMenuItem.Enabled = on;
                    diagonalGradientToolStripMenuItem.Enabled = on;
                    verticalLineToolStripMenuItem.Enabled = on;
                    horizontalLineToolStripMenuItem.Enabled = on;
                    diagonalLineToolStripMenuItem.Enabled = on;
                    copyMenu.Enabled = !on;
                    negativeMenu.Enabled = !on;
                    thresholdMenu.Enabled = !on;
                    dimToolStripMenuItem.Enabled = !on;
                    tintToolStripMenuItem.Enabled = !on;
                    lowpassFilterToolStripMenuItem.Enabled = !on;
                    monochromeToolStripMenuItem.Enabled = !on;
                    medianFilterToolStripMenuItem.Enabled = !on;
                    warpMenu.Enabled = !on;
                    warpBilinearMenu.Enabled = !on;
                    break;
            }
        }

        private void fillGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.FillGreen(model);
        }

        private void dimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnFilterDim(model);

            Invalidate();
        }

        private void tintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnFilterTint(model);

            Invalidate();
        }

        private void lowpassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnFilterLowpass(model);

            Invalidate();
        }

        private void fillLavenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.FillLavender(model);
        }

        private void horizontalGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.HorizontalGradient(model);
        }

        private void verticalBlueGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.VerticalBlueGradient(model);
        }

        private void diagonalGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.DiagonalGradient(model);
        }

        private void horizontalLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.HorizontalLine(model);
        }

        private void verticalLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.VerticalLine(model);
        }

        private void diagonalLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageGenerate.DiagonalLine(model);
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnMedianFilter(model);

            Invalidate();
        }

        private void monochromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnFilterMonochrome(model);

            Invalidate();
        }

        private void sharpen3X3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnSharpen3X3(model);

            Invalidate();
        }

        private void pointillizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnPointillize(model);

            Invalidate();
        }

        private void prewitt5X5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnPrewitt5X5(model);

            Invalidate();
        }

        private void sorbelFilter5X5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SetMode(ImageEditor.MODE.None);
            ImageProcess.OnSorbel5X5(model);

            Invalidate();
        }

        private void centerRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AngleDialog dialog = new AngleDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                editor.SetMode(ImageEditor.MODE.None);
                ImageProcess.OnRotateCenter(model, dialog.Angle);

                Invalidate();
            }
        }
    }
}
