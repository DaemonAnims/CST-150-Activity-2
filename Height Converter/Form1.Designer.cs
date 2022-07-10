namespace Height_Converter
{
    partial class Form1
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
            this.explanationLabel = new System.Windows.Forms.Label();
            this.heightFeetLabel = new System.Windows.Forms.Label();
            this.heightInchesLabel = new System.Windows.Forms.Label();
            this.heightFeetTextbox = new System.Windows.Forms.TextBox();
            this.heightInchesTextbox = new System.Windows.Forms.TextBox();
            this.meterConversionButton = new System.Windows.Forms.Button();
            this.meterHeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Location = new System.Drawing.Point(47, 9);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(220, 15);
            this.explanationLabel.TabIndex = 0;
            this.explanationLabel.Text = "Enter how tall you are in feet and inches!";
            // 
            // heightFeetLabel
            // 
            this.heightFeetLabel.AutoSize = true;
            this.heightFeetLabel.Location = new System.Drawing.Point(91, 30);
            this.heightFeetLabel.Name = "heightFeetLabel";
            this.heightFeetLabel.Size = new System.Drawing.Size(32, 15);
            this.heightFeetLabel.TabIndex = 1;
            this.heightFeetLabel.Text = "Feet:";
            // 
            // heightInchesLabel
            // 
            this.heightInchesLabel.AutoSize = true;
            this.heightInchesLabel.Location = new System.Drawing.Point(79, 59);
            this.heightInchesLabel.Name = "heightInchesLabel";
            this.heightInchesLabel.Size = new System.Drawing.Size(44, 15);
            this.heightInchesLabel.TabIndex = 2;
            this.heightInchesLabel.Text = "Inches:";
            // 
            // heightFeetTextbox
            // 
            this.heightFeetTextbox.Location = new System.Drawing.Point(150, 27);
            this.heightFeetTextbox.Name = "heightFeetTextbox";
            this.heightFeetTextbox.Size = new System.Drawing.Size(77, 23);
            this.heightFeetTextbox.TabIndex = 3;
            // 
            // heightInchesTextbox
            // 
            this.heightInchesTextbox.Location = new System.Drawing.Point(150, 56);
            this.heightInchesTextbox.Name = "heightInchesTextbox";
            this.heightInchesTextbox.Size = new System.Drawing.Size(77, 23);
            this.heightInchesTextbox.TabIndex = 4;
            // 
            // meterConversionButton
            // 
            this.meterConversionButton.Location = new System.Drawing.Point(79, 100);
            this.meterConversionButton.Name = "meterConversionButton";
            this.meterConversionButton.Size = new System.Drawing.Size(148, 23);
            this.meterConversionButton.TabIndex = 5;
            this.meterConversionButton.Text = "Convert to Meters!";
            this.meterConversionButton.UseVisualStyleBackColor = true;
            this.meterConversionButton.Click += new System.EventHandler(this.meterConversionButton_Click);
            // 
            // meterHeightLabel
            // 
            this.meterHeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.meterHeightLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.meterHeightLabel.Location = new System.Drawing.Point(47, 126);
            this.meterHeightLabel.Name = "meterHeightLabel";
            this.meterHeightLabel.Size = new System.Drawing.Size(220, 80);
            this.meterHeightLabel.TabIndex = 6;
            this.meterHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 215);
            this.Controls.Add(this.meterHeightLabel);
            this.Controls.Add(this.meterConversionButton);
            this.Controls.Add(this.heightInchesTextbox);
            this.Controls.Add(this.heightFeetTextbox);
            this.Controls.Add(this.heightInchesLabel);
            this.Controls.Add(this.heightFeetLabel);
            this.Controls.Add(this.explanationLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ft-in to m Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label explanationLabel;
        private Label heightFeetLabel;
        private Label heightInchesLabel;
        private TextBox heightFeetTextbox;
        private TextBox heightInchesTextbox;
        private Button meterConversionButton;
        private Label meterHeightLabel;
    }
}