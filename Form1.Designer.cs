namespace Noemi_Angeles_CPT_185_A01S_CHAPTER_8
{
    partial class morseCodeConverter
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
            this.components = new System.ComponentModel.Container();
            this.stringLabel = new System.Windows.Forms.Label();
            this.morLabelBox = new System.Windows.Forms.Label();
            this.morseTextBox = new System.Windows.Forms.TextBox();
            this.morseCodeDisplayLabelBox = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stringLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringLabel.Location = new System.Drawing.Point(70, 133);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(367, 19);
            this.stringLabel.TabIndex = 0;
            this.stringLabel.Text = "Enter a text or phrase to convert to Morse Code:";
            // 
            // morLabelBox
            // 
            this.morLabelBox.AutoSize = true;
            this.morLabelBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.morLabelBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morLabelBox.Location = new System.Drawing.Point(311, 215);
            this.morLabelBox.Name = "morLabelBox";
            this.morLabelBox.Size = new System.Drawing.Size(105, 19);
            this.morLabelBox.TabIndex = 1;
            this.morLabelBox.Text = "Morse Code:";
            // 
            // morseTextBox
            // 
            this.morseTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseTextBox.Location = new System.Drawing.Point(485, 130);
            this.morseTextBox.Name = "morseTextBox";
            this.morseTextBox.Size = new System.Drawing.Size(187, 27);
            this.morseTextBox.TabIndex = 2;
            // 
            // morseCodeDisplayLabelBox
            // 
            this.morseCodeDisplayLabelBox.AutoSize = true;
            this.morseCodeDisplayLabelBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseCodeDisplayLabelBox.Location = new System.Drawing.Point(452, 215);
            this.morseCodeDisplayLabelBox.Name = "morseCodeDisplayLabelBox";
            this.morseCodeDisplayLabelBox.Size = new System.Drawing.Size(0, 19);
            this.morseCodeDisplayLabelBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(138, 388);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(168, 64);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Covert to &Morse Code";
            this.toolTip1.SetToolTip(this.convertButton, "Click to Convert!");
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(455, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 64);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.toolTip3.SetToolTip(this.exitButton, "Click to exit!");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(329, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 64);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.toolTip2.SetToolTip(this.clearButton, "Click to clear!");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Morse Code Converter";
            // 
            // morseCodeConverter
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(772, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.morseCodeDisplayLabelBox);
            this.Controls.Add(this.morseTextBox);
            this.Controls.Add(this.morLabelBox);
            this.Controls.Add(this.stringLabel);
            this.Name = "morseCodeConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noemi Angeles Morse Code Converter";
            this.Load += new System.EventHandler(this.morseCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label morLabelBox;
        private System.Windows.Forms.TextBox morseTextBox;
        private System.Windows.Forms.Label morseCodeDisplayLabelBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
    }
}

