
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
            this.SuspendLayout();
            // 
            // NewReadingButton
            // 
            this.NewReadingButton.Location = new System.Drawing.Point(12, 41);
            this.NewReadingButton.Name = "NewReadingButton";
            this.NewReadingButton.Size = new System.Drawing.Size(128, 23);
            this.NewReadingButton.TabIndex = 0;
            this.NewReadingButton.Text = "New Reading";
            this.NewReadingButton.UseVisualStyleBackColor = true;
            this.NewReadingButton.Click += new System.EventHandler(this.NewReading_Click);
            // 
            // ReadingTextBox
            // 
            this.ReadingTextBox.Location = new System.Drawing.Point(12, 12);
            this.ReadingTextBox.Name = "ReadingTextBox";
            this.ReadingTextBox.Size = new System.Drawing.Size(128, 23);
            this.ReadingTextBox.TabIndex = 1;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 76);
            this.Controls.Add(this.ReadingTextBox);
            this.Controls.Add(this.NewReadingButton);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewReadingButton;
        private System.Windows.Forms.TextBox ReadingTextBox;
    }
}

