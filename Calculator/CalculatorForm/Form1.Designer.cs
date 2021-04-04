
namespace CalculatorForm
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewReadingButton = new System.Windows.Forms.Button();
            this.ReadingTextBox = new System.Windows.Forms.TextBox();
            this.ReadingMinLabel = new System.Windows.Forms.Label();
            this.ReadingRangeMax = new System.Windows.Forms.NumericUpDown();
            this.ReadingRangeMin = new System.Windows.Forms.NumericUpDown();
            this.ReadingRangeGB = new System.Windows.Forms.GroupBox();
            this.ReadingMaxLabel = new System.Windows.Forms.Label();
            this.ReadingGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReadingRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadingRangeMin)).BeginInit();
            this.ReadingRangeGB.SuspendLayout();
            this.ReadingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewReadingButton
            // 
            this.NewReadingButton.Location = new System.Drawing.Point(6, 52);
            this.NewReadingButton.Name = "NewReadingButton";
            this.NewReadingButton.Size = new System.Drawing.Size(128, 23);
            this.NewReadingButton.TabIndex = 3;
            this.NewReadingButton.Text = "New Reading";
            this.NewReadingButton.UseVisualStyleBackColor = true;
            this.NewReadingButton.Click += new System.EventHandler(this.NewReading_Click);
            // 
            // ReadingTextBox
            // 
            this.ReadingTextBox.Location = new System.Drawing.Point(6, 22);
            this.ReadingTextBox.Name = "ReadingTextBox";
            this.ReadingTextBox.ReadOnly = true;
            this.ReadingTextBox.Size = new System.Drawing.Size(128, 23);
            this.ReadingTextBox.TabIndex = 2;
            // 
            // ReadingMinLabel
            // 
            this.ReadingMinLabel.AutoSize = true;
            this.ReadingMinLabel.Location = new System.Drawing.Point(6, 25);
            this.ReadingMinLabel.Name = "ReadingMinLabel";
            this.ReadingMinLabel.Size = new System.Drawing.Size(28, 15);
            this.ReadingMinLabel.TabIndex = 3;
            this.ReadingMinLabel.Text = "Min";
            // 
            // ReadingRangeMax
            // 
            this.ReadingRangeMax.Location = new System.Drawing.Point(40, 54);
            this.ReadingRangeMax.Name = "ReadingRangeMax";
            this.ReadingRangeMax.Size = new System.Drawing.Size(79, 23);
            this.ReadingRangeMax.TabIndex = 1;
            this.ReadingRangeMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ReadingRangeMax.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // ReadingRangeMin
            // 
            this.ReadingRangeMin.Location = new System.Drawing.Point(40, 25);
            this.ReadingRangeMin.Name = "ReadingRangeMin";
            this.ReadingRangeMin.Size = new System.Drawing.Size(79, 23);
            this.ReadingRangeMin.TabIndex = 0;
            this.ReadingRangeMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ReadingRangeMin.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // ReadingRangeGB
            // 
            this.ReadingRangeGB.Controls.Add(this.ReadingMaxLabel);
            this.ReadingRangeGB.Controls.Add(this.ReadingRangeMax);
            this.ReadingRangeGB.Controls.Add(this.ReadingMinLabel);
            this.ReadingRangeGB.Controls.Add(this.ReadingRangeMin);
            this.ReadingRangeGB.Location = new System.Drawing.Point(12, 12);
            this.ReadingRangeGB.Name = "ReadingRangeGB";
            this.ReadingRangeGB.Size = new System.Drawing.Size(133, 88);
            this.ReadingRangeGB.TabIndex = 6;
            this.ReadingRangeGB.TabStop = false;
            this.ReadingRangeGB.Text = "Reading Range";
            // 
            // ReadingMaxLabel
            // 
            this.ReadingMaxLabel.AutoSize = true;
            this.ReadingMaxLabel.Location = new System.Drawing.Point(6, 56);
            this.ReadingMaxLabel.Name = "ReadingMaxLabel";
            this.ReadingMaxLabel.Size = new System.Drawing.Size(30, 15);
            this.ReadingMaxLabel.TabIndex = 6;
            this.ReadingMaxLabel.Text = "Max";
            // 
            // ReadingGB
            // 
            this.ReadingGB.Controls.Add(this.ReadingTextBox);
            this.ReadingGB.Controls.Add(this.NewReadingButton);
            this.ReadingGB.Location = new System.Drawing.Point(151, 12);
            this.ReadingGB.Name = "ReadingGB";
            this.ReadingGB.Size = new System.Drawing.Size(146, 88);
            this.ReadingGB.TabIndex = 7;
            this.ReadingGB.TabStop = false;
            this.ReadingGB.Text = "Reading";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 109);
            this.Controls.Add(this.ReadingGB);
            this.Controls.Add(this.ReadingRangeGB);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.ReadingRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadingRangeMin)).EndInit();
            this.ReadingRangeGB.ResumeLayout(false);
            this.ReadingRangeGB.PerformLayout();
            this.ReadingGB.ResumeLayout(false);
            this.ReadingGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewReadingButton;
        private System.Windows.Forms.TextBox ReadingTextBox;
        private System.Windows.Forms.Label ReadingMinLabel;
        private System.Windows.Forms.NumericUpDown ReadingRangeMax;
        private System.Windows.Forms.NumericUpDown ReadingRangeMin;
        private System.Windows.Forms.GroupBox ReadingRangeGB;
        private System.Windows.Forms.Label ReadingMaxLabel;
        private System.Windows.Forms.GroupBox ReadingGB;
    }
}

