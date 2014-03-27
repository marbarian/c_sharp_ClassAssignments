namespace Even_Number
{
    partial class mathForm
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.evenOrOddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evenTextBox = new System.Windows.Forms.TextBox();
            this.oddTextBox = new System.Windows.Forms.TextBox();
            this.primeTextBox = new System.Windows.Forms.TextBox();
            this.perfectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(28, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(127, 20);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter an integer:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(161, 22);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(66, 26);
            this.numberTextBox.TabIndex = 1;
            // 
            // evenOrOddButton
            // 
            this.evenOrOddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenOrOddButton.Location = new System.Drawing.Point(262, 18);
            this.evenOrOddButton.Name = "evenOrOddButton";
            this.evenOrOddButton.Size = new System.Drawing.Size(117, 32);
            this.evenOrOddButton.TabIndex = 2;
            this.evenOrOddButton.Text = "Calculate";
            this.evenOrOddButton.UseVisualStyleBackColor = true;
            this.evenOrOddButton.Click += new System.EventHandler(this.evenOrOddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Is it An Even Number?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Is it An Odd Number?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Is it A Prime Number?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Is it A Perfect Number?";
            // 
            // evenTextBox
            // 
            this.evenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenTextBox.Location = new System.Drawing.Point(262, 82);
            this.evenTextBox.Name = "evenTextBox";
            this.evenTextBox.ReadOnly = true;
            this.evenTextBox.Size = new System.Drawing.Size(117, 26);
            this.evenTextBox.TabIndex = 7;
            // 
            // oddTextBox
            // 
            this.oddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddTextBox.Location = new System.Drawing.Point(262, 120);
            this.oddTextBox.Name = "oddTextBox";
            this.oddTextBox.ReadOnly = true;
            this.oddTextBox.Size = new System.Drawing.Size(117, 26);
            this.oddTextBox.TabIndex = 8;
            // 
            // primeTextBox
            // 
            this.primeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeTextBox.Location = new System.Drawing.Point(262, 158);
            this.primeTextBox.Name = "primeTextBox";
            this.primeTextBox.ReadOnly = true;
            this.primeTextBox.Size = new System.Drawing.Size(117, 26);
            this.primeTextBox.TabIndex = 9;
            // 
            // perfectTextBox
            // 
            this.perfectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfectTextBox.Location = new System.Drawing.Point(262, 196);
            this.perfectTextBox.Name = "perfectTextBox";
            this.perfectTextBox.ReadOnly = true;
            this.perfectTextBox.Size = new System.Drawing.Size(117, 26);
            this.perfectTextBox.TabIndex = 10;
            // 
            // mathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 277);
            this.Controls.Add(this.perfectTextBox);
            this.Controls.Add(this.primeTextBox);
            this.Controls.Add(this.oddTextBox);
            this.Controls.Add(this.evenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evenOrOddButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "mathForm";
            this.Text = "Math Stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button evenOrOddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox evenTextBox;
        private System.Windows.Forms.TextBox oddTextBox;
        private System.Windows.Forms.TextBox primeTextBox;
        private System.Windows.Forms.TextBox perfectTextBox;
    }
}

