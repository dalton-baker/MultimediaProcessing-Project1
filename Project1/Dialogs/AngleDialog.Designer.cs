
namespace ImageProcess.Dialogs
{
    partial class AngleDialog
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
            this.OkButton = new System.Windows.Forms.Button();
            this.AngleSlider = new System.Windows.Forms.TrackBar();
            this.Cancel = new System.Windows.Forms.Button();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(347, 76);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AngleSlider
            // 
            this.AngleSlider.Location = new System.Drawing.Point(12, 27);
            this.AngleSlider.Maximum = 360;
            this.AngleSlider.Minimum = -360;
            this.AngleSlider.Name = "AngleSlider";
            this.AngleSlider.Size = new System.Drawing.Size(410, 45);
            this.AngleSlider.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(266, 76);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(12, 81);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(37, 13);
            this.AngleLabel.TabIndex = 5;
            this.AngleLabel.Text = "Angle:";
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(55, 78);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(45, 20);
            this.ValueBox.TabIndex = 6;
            this.ValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBox_KeyPress);
            this.ValueBox.Leave += new System.EventHandler(this.ValueBox_Leave);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(12, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(131, 13);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "Selct an angle to rotate by";
            // 
            // AngleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AngleSlider);
            this.Controls.Add(this.OkButton);
            this.Name = "AngleDialog";
            ((System.ComponentModel.ISupportInitialize)(this.AngleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TrackBar AngleSlider;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label promptLabel;
    }
}