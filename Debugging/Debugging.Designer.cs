namespace Debugging
{
    partial class Debugging
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
            this.enterTextLabel = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.letterCountValueLabel = new System.Windows.Forms.Label();
            this.letterCountLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.wordCountValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterTextLabel
            // 
            this.enterTextLabel.AutoSize = true;
            this.enterTextLabel.Location = new System.Drawing.Point(12, 9);
            this.enterTextLabel.Name = "enterTextLabel";
            this.enterTextLabel.Size = new System.Drawing.Size(59, 13);
            this.enterTextLabel.TabIndex = 0;
            this.enterTextLabel.Text = "Enter Text:";
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(12, 238);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(205, 238);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(77, 6);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataTextBox.TabIndex = 3;
            // 
            // letterCountValueLabel
            // 
            this.letterCountValueLabel.AutoSize = true;
            this.letterCountValueLabel.Location = new System.Drawing.Point(110, 66);
            this.letterCountValueLabel.Name = "letterCountValueLabel";
            this.letterCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.letterCountValueLabel.TabIndex = 4;
            this.letterCountValueLabel.Text = "0";
            // 
            // letterCountLabel
            // 
            this.letterCountLabel.AutoSize = true;
            this.letterCountLabel.Location = new System.Drawing.Point(36, 66);
            this.letterCountLabel.Name = "letterCountLabel";
            this.letterCountLabel.Size = new System.Drawing.Size(68, 13);
            this.letterCountLabel.TabIndex = 5;
            this.letterCountLabel.Text = "Letter Count:";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Location = new System.Drawing.Point(36, 91);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(67, 13);
            this.wordCountLabel.TabIndex = 6;
            this.wordCountLabel.Text = "Word Count:";
            // 
            // wordCountValueLabel
            // 
            this.wordCountValueLabel.AutoSize = true;
            this.wordCountValueLabel.Location = new System.Drawing.Point(109, 91);
            this.wordCountValueLabel.Name = "wordCountValueLabel";
            this.wordCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.wordCountValueLabel.TabIndex = 7;
            this.wordCountValueLabel.Text = "0";
            // 
            // Debugging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.wordCountValueLabel);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.letterCountLabel);
            this.Controls.Add(this.letterCountValueLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.enterTextLabel);
            this.Name = "Debugging";
            this.Text = "Debugging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTextLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label letterCountValueLabel;
        private System.Windows.Forms.Label letterCountLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label wordCountValueLabel;
    }
}

