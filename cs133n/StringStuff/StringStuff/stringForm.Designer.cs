namespace String_Stuff
{
    partial class stringForm
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
            this.transformButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.switchCaseTextBox = new System.Windows.Forms.TextBox();
            this.reverseTextBox = new System.Windows.Forms.TextBox();
            this.pigLatinTextBox = new System.Windows.Forms.TextBox();
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(28, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(103, 20);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter a word:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(137, 21);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(242, 26);
            this.numberTextBox.TabIndex = 1;
            // 
            // transformButton
            // 
            this.transformButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformButton.Location = new System.Drawing.Point(420, 18);
            this.transformButton.Name = "transformButton";
            this.transformButton.Size = new System.Drawing.Size(117, 32);
            this.transformButton.TabIndex = 2;
            this.transformButton.Text = "Transform";
            this.transformButton.UseVisualStyleBackColor = true;
            this.transformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Switch Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reverse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pig Latin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cypher";
            // 
            // switchCaseTextBox
            // 
            this.switchCaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchCaseTextBox.Location = new System.Drawing.Point(137, 82);
            this.switchCaseTextBox.Name = "switchCaseTextBox";
            this.switchCaseTextBox.ReadOnly = true;
            this.switchCaseTextBox.Size = new System.Drawing.Size(242, 26);
            this.switchCaseTextBox.TabIndex = 7;
            // 
            // reverseTextBox
            // 
            this.reverseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseTextBox.Location = new System.Drawing.Point(137, 120);
            this.reverseTextBox.Name = "reverseTextBox";
            this.reverseTextBox.ReadOnly = true;
            this.reverseTextBox.Size = new System.Drawing.Size(242, 26);
            this.reverseTextBox.TabIndex = 8;
            // 
            // pigLatinTextBox
            // 
            this.pigLatinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigLatinTextBox.Location = new System.Drawing.Point(137, 158);
            this.pigLatinTextBox.Name = "pigLatinTextBox";
            this.pigLatinTextBox.ReadOnly = true;
            this.pigLatinTextBox.Size = new System.Drawing.Size(242, 26);
            this.pigLatinTextBox.TabIndex = 9;
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cypherTextBox.Location = new System.Drawing.Point(137, 196);
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.ReadOnly = true;
            this.cypherTextBox.Size = new System.Drawing.Size(242, 26);
            this.cypherTextBox.TabIndex = 10;
            // 
            // stringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 264);
            this.Controls.Add(this.cypherTextBox);
            this.Controls.Add(this.pigLatinTextBox);
            this.Controls.Add(this.reverseTextBox);
            this.Controls.Add(this.switchCaseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transformButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "stringForm";
            this.Text = "String Stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button transformButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox switchCaseTextBox;
        private System.Windows.Forms.TextBox reverseTextBox;
        private System.Windows.Forms.TextBox pigLatinTextBox;
        private System.Windows.Forms.TextBox cypherTextBox;
    }
}

