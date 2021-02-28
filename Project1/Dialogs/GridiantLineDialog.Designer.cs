
namespace ImageProcess.Dialogs
{
    partial class GridiantLineDialog
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.LocationSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationSliderLabel = new System.Windows.Forms.Label();
            this.IsVertCheckbox = new System.Windows.Forms.CheckBox();
            this.ThicknessSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ThicknessValue = new System.Windows.Forms.Label();
            this.LocValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LocationSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(347, 76);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(347, 47);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // LocationSlider
            // 
            this.LocationSlider.Location = new System.Drawing.Point(16, 54);
            this.LocationSlider.Name = "LocationSlider";
            this.LocationSlider.Size = new System.Drawing.Size(130, 45);
            this.LocationSlider.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter the location and width of the line you want to draw";
            // 
            // LocationSliderLabel
            // 
            this.LocationSliderLabel.AutoSize = true;
            this.LocationSliderLabel.Location = new System.Drawing.Point(16, 38);
            this.LocationSliderLabel.Name = "LocationSliderLabel";
            this.LocationSliderLabel.Size = new System.Drawing.Size(117, 13);
            this.LocationSliderLabel.TabIndex = 5;
            this.LocationSliderLabel.Text = "Distance From Top (px)";
            // 
            // IsVertCheckbox
            // 
            this.IsVertCheckbox.AutoSize = true;
            this.IsVertCheckbox.Location = new System.Drawing.Point(338, 12);
            this.IsVertCheckbox.Name = "IsVertCheckbox";
            this.IsVertCheckbox.Size = new System.Drawing.Size(84, 17);
            this.IsVertCheckbox.TabIndex = 3;
            this.IsVertCheckbox.Text = "Vertical Line";
            this.IsVertCheckbox.UseVisualStyleBackColor = true;
            this.IsVertCheckbox.CheckedChanged += new System.EventHandler(this.IsVertCheckbox_CheckedChanged);
            // 
            // ThicknessSlider
            // 
            this.ThicknessSlider.Location = new System.Drawing.Point(189, 54);
            this.ThicknessSlider.Maximum = 300;
            this.ThicknessSlider.Name = "ThicknessSlider";
            this.ThicknessSlider.Size = new System.Drawing.Size(130, 45);
            this.ThicknessSlider.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thickness (px)";
            // 
            // ThicknessValue
            // 
            this.ThicknessValue.AutoSize = true;
            this.ThicknessValue.Location = new System.Drawing.Point(186, 86);
            this.ThicknessValue.Name = "ThicknessValue";
            this.ThicknessValue.Size = new System.Drawing.Size(35, 13);
            this.ThicknessValue.TabIndex = 9;
            this.ThicknessValue.Text = "label4";
            // 
            // LocValue
            // 
            this.LocValue.AutoSize = true;
            this.LocValue.Location = new System.Drawing.Point(16, 89);
            this.LocValue.Name = "LocValue";
            this.LocValue.Size = new System.Drawing.Size(35, 13);
            this.LocValue.TabIndex = 8;
            this.LocValue.Text = "label3";
            // 
            // GridiantLineDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.ThicknessValue);
            this.Controls.Add(this.LocValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThicknessSlider);
            this.Controls.Add(this.LocationSliderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsVertCheckbox);
            this.Controls.Add(this.LocationSlider);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Name = "GridiantLineDialog";
            this.Text = "GridiantLineDialog";
            ((System.ComponentModel.ISupportInitialize)(this.LocationSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TrackBar LocationSlider;
        private System.Windows.Forms.CheckBox IsVertCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LocationSliderLabel;
        private System.Windows.Forms.TrackBar ThicknessSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ThicknessValue;
        private System.Windows.Forms.Label LocValue;
    }
}