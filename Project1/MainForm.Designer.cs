﻿namespace ImageProcess
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillWhiteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.drawMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thresholdMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.warpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.warpBilinearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fillGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowpassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillLavenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.verticalBlueGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.verticalLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monochromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.mouseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openTestMenu,
            this.openMenu,
            this.closeMenu,
            this.saveMenu,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(180, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openTestMenu
            // 
            this.openTestMenu.Name = "openTestMenu";
            this.openTestMenu.Size = new System.Drawing.Size(180, 22);
            this.openTestMenu.Text = "Open Test";
            this.openTestMenu.Click += new System.EventHandler(this.openTestMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(180, 22);
            this.openMenu.Text = "Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(180, 22);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(180, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillWhiteMenu,
            this.fillGreenToolStripMenuItem,
            this.fillLavenderToolStripMenuItem,
            this.toolStripSeparator3,
            this.horizontalGradientToolStripMenuItem,
            this.verticalBlueGradientToolStripMenuItem,
            this.diagonalGradientToolStripMenuItem,
            this.toolStripSeparator4,
            this.horizontalLineToolStripMenuItem,
            this.verticalLineToolStripMenuItem,
            this.diagonalLineToolStripMenuItem,
            this.toolStripSeparator2,
            this.drawMenu});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // fillWhiteMenu
            // 
            this.fillWhiteMenu.Name = "fillWhiteMenu";
            this.fillWhiteMenu.Size = new System.Drawing.Size(186, 22);
            this.fillWhiteMenu.Text = "Fill White";
            this.fillWhiteMenu.Click += new System.EventHandler(this.fillWhiteMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // drawMenu
            // 
            this.drawMenu.Name = "drawMenu";
            this.drawMenu.Size = new System.Drawing.Size(186, 22);
            this.drawMenu.Text = "Draw";
            this.drawMenu.Click += new System.EventHandler(this.drawMenu_Click);
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenu,
            this.negativeMenu,
            this.dimToolStripMenuItem,
            this.tintToolStripMenuItem,
            this.lowpassFilterToolStripMenuItem,
            this.monochromeToolStripMenuItem,
            this.medianFilterToolStripMenuItem,
            this.toolStripSeparator1,
            this.thresholdMenu,
            this.warpMenu,
            this.warpBilinearMenu});
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.mouseToolStripMenuItem.Text = "Process";
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(180, 22);
            this.copyMenu.Text = "Copy";
            this.copyMenu.Click += new System.EventHandler(this.copyMenu_Click);
            // 
            // negativeMenu
            // 
            this.negativeMenu.Name = "negativeMenu";
            this.negativeMenu.Size = new System.Drawing.Size(180, 22);
            this.negativeMenu.Text = "Negative";
            this.negativeMenu.Click += new System.EventHandler(this.negativeMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // thresholdMenu
            // 
            this.thresholdMenu.Name = "thresholdMenu";
            this.thresholdMenu.Size = new System.Drawing.Size(180, 22);
            this.thresholdMenu.Text = "Threshold";
            this.thresholdMenu.Click += new System.EventHandler(this.thresholdMenu_Click);
            // 
            // warpMenu
            // 
            this.warpMenu.Name = "warpMenu";
            this.warpMenu.Size = new System.Drawing.Size(180, 22);
            this.warpMenu.Text = "Warp Nearest";
            this.warpMenu.Click += new System.EventHandler(this.warpMenu_Click);
            // 
            // warpBilinearMenu
            // 
            this.warpBilinearMenu.Name = "warpBilinearMenu";
            this.warpBilinearMenu.Size = new System.Drawing.Size(180, 22);
            this.warpBilinearMenu.Text = "Warp Bilinear";
            this.warpBilinearMenu.Click += new System.EventHandler(this.warpBilinearMenu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|BMP File" +
    "s (*.bmp)| *p.bmp|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|BMP File" +
    "s (*.bmp)| *.bmp";
            // 
            // fillGreenToolStripMenuItem
            // 
            this.fillGreenToolStripMenuItem.Name = "fillGreenToolStripMenuItem";
            this.fillGreenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fillGreenToolStripMenuItem.Text = "Fill Green";
            this.fillGreenToolStripMenuItem.Click += new System.EventHandler(this.fillGreenToolStripMenuItem_Click);
            // 
            // dimToolStripMenuItem
            // 
            this.dimToolStripMenuItem.Name = "dimToolStripMenuItem";
            this.dimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dimToolStripMenuItem.Text = "Dim";
            this.dimToolStripMenuItem.Click += new System.EventHandler(this.dimToolStripMenuItem_Click);
            // 
            // tintToolStripMenuItem
            // 
            this.tintToolStripMenuItem.Name = "tintToolStripMenuItem";
            this.tintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tintToolStripMenuItem.Text = "Tint";
            this.tintToolStripMenuItem.Click += new System.EventHandler(this.tintToolStripMenuItem_Click);
            // 
            // lowpassFilterToolStripMenuItem
            // 
            this.lowpassFilterToolStripMenuItem.Name = "lowpassFilterToolStripMenuItem";
            this.lowpassFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowpassFilterToolStripMenuItem.Text = "Lowpass Filter";
            this.lowpassFilterToolStripMenuItem.Click += new System.EventHandler(this.lowpassFilterToolStripMenuItem_Click);
            // 
            // fillLavenderToolStripMenuItem
            // 
            this.fillLavenderToolStripMenuItem.Name = "fillLavenderToolStripMenuItem";
            this.fillLavenderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fillLavenderToolStripMenuItem.Text = "Fill Lavender";
            this.fillLavenderToolStripMenuItem.Click += new System.EventHandler(this.fillLavenderToolStripMenuItem_Click);
            // 
            // horizontalGradientToolStripMenuItem
            // 
            this.horizontalGradientToolStripMenuItem.Name = "horizontalGradientToolStripMenuItem";
            this.horizontalGradientToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.horizontalGradientToolStripMenuItem.Text = "Horizontal Gradient";
            this.horizontalGradientToolStripMenuItem.Click += new System.EventHandler(this.horizontalGradientToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // verticalBlueGradientToolStripMenuItem
            // 
            this.verticalBlueGradientToolStripMenuItem.Name = "verticalBlueGradientToolStripMenuItem";
            this.verticalBlueGradientToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verticalBlueGradientToolStripMenuItem.Text = "Vertical Blue Gradient";
            this.verticalBlueGradientToolStripMenuItem.Click += new System.EventHandler(this.verticalBlueGradientToolStripMenuItem_Click);
            // 
            // diagonalGradientToolStripMenuItem
            // 
            this.diagonalGradientToolStripMenuItem.Name = "diagonalGradientToolStripMenuItem";
            this.diagonalGradientToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.diagonalGradientToolStripMenuItem.Text = "Diagonal Gradient";
            this.diagonalGradientToolStripMenuItem.Click += new System.EventHandler(this.diagonalGradientToolStripMenuItem_Click);
            // 
            // horizontalLineToolStripMenuItem
            // 
            this.horizontalLineToolStripMenuItem.Name = "horizontalLineToolStripMenuItem";
            this.horizontalLineToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.horizontalLineToolStripMenuItem.Text = "Horizontal Line";
            this.horizontalLineToolStripMenuItem.Click += new System.EventHandler(this.horizontalLineToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // verticalLineToolStripMenuItem
            // 
            this.verticalLineToolStripMenuItem.Name = "verticalLineToolStripMenuItem";
            this.verticalLineToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verticalLineToolStripMenuItem.Text = "Vertical Line";
            this.verticalLineToolStripMenuItem.Click += new System.EventHandler(this.verticalLineToolStripMenuItem_Click);
            // 
            // diagonalLineToolStripMenuItem
            // 
            this.diagonalLineToolStripMenuItem.Name = "diagonalLineToolStripMenuItem";
            this.diagonalLineToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.diagonalLineToolStripMenuItem.Text = "Diagonal Line";
            this.diagonalLineToolStripMenuItem.Click += new System.EventHandler(this.diagonalLineToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // monochromeToolStripMenuItem
            // 
            this.monochromeToolStripMenuItem.Name = "monochromeToolStripMenuItem";
            this.monochromeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monochromeToolStripMenuItem.Text = "Monochrome";
            this.monochromeToolStripMenuItem.Click += new System.EventHandler(this.monochromeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image Process: Baker Dalton";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem fillWhiteMenu;
        private System.Windows.Forms.ToolStripMenuItem openTestMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem negativeMenu;
        private System.Windows.Forms.ToolStripMenuItem thresholdMenu;
        private System.Windows.Forms.ToolStripMenuItem warpMenu;
        private System.Windows.Forms.ToolStripMenuItem drawMenu;
        private System.Windows.Forms.ToolStripMenuItem warpBilinearMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fillGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowpassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillLavenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem horizontalGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalBlueGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem horizontalLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monochromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
    }
}
