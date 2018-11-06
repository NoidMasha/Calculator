namespace Calculator2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.operationTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new Calculator2.MyLabel();
            this.myButton19 = new Calculator2.MyButton(this);
            this.myButton18 = new Calculator2.MyButton(this);
            this.myButton17 = new Calculator2.MyButton(this);
            this.myButton16 = new Calculator2.MyButton(this);
            this.myButton15 = new Calculator2.MyButton(this);
            this.myButton14 = new Calculator2.MyButton(this);
            this.myButton13 = new Calculator2.MyButton(this);
            this.myButton12 = new Calculator2.MyButton(this);
            this.myButton11 = new Calculator2.MyButton(this);
            this.myButton10 = new Calculator2.MyButton(this);
            this.myButton9 = new Calculator2.MyButton(this);
            this.myButton8 = new Calculator2.MyButton(this);
            this.myButton7 = new Calculator2.MyButton(this);
            this.myButton6 = new Calculator2.MyButton(this);
            this.myButton5 = new Calculator2.MyButton(this);
            this.myButton4 = new Calculator2.MyButton(this);
            this.myButton3 = new Calculator2.MyButton(this);
            this.myButton2 = new Calculator2.MyButton(this);
            this.myButton1 = new Calculator2.MyButton(this);
            this.SuspendLayout();
            // 
            // operationTextBox
            // 
            this.operationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operationTextBox.CausesValidation = false;
            this.operationTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.operationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.operationTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.operationTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.operationTextBox.Location = new System.Drawing.Point(7, 28);
            this.operationTextBox.Multiline = true;
            this.operationTextBox.Name = "operationTextBox";
            this.operationTextBox.ReadOnly = true;
            this.operationTextBox.Size = new System.Drawing.Size(270, 79);
            this.operationTextBox.TabIndex = 0;
            this.operationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateOnKeyboard);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(8, 72);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 30);
            this.resultLabel.TabIndex = 20;
            // 
            // myButton19
            // 
            this.myButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton19.Location = new System.Drawing.Point(7, 119);
            this.myButton19.Name = "myButton19";
            this.myButton19.Size = new System.Drawing.Size(60, 50);
            this.myButton19.TabIndex = 19;
            this.myButton19.Text = "<";
            this.myButton19.UseVisualStyleBackColor = true;
            // 
            // myButton18
            // 
            this.myButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton18.Location = new System.Drawing.Point(73, 119);
            this.myButton18.Name = "myButton18";
            this.myButton18.Size = new System.Drawing.Size(60, 50);
            this.myButton18.TabIndex = 18;
            this.myButton18.Text = "()";
            this.myButton18.UseVisualStyleBackColor = true;
            // 
            // myButton17
            // 
            this.myButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton17.Location = new System.Drawing.Point(139, 119);
            this.myButton17.Name = "myButton17";
            this.myButton17.Size = new System.Drawing.Size(60, 50);
            this.myButton17.TabIndex = 17;
            this.myButton17.Text = "C";
            this.myButton17.UseVisualStyleBackColor = true;
            // 
            // myButton16
            // 
            this.myButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton16.Location = new System.Drawing.Point(217, 119);
            this.myButton16.Name = "myButton16";
            this.myButton16.Size = new System.Drawing.Size(60, 50);
            this.myButton16.TabIndex = 16;
            this.myButton16.Text = "/";
            this.myButton16.UseVisualStyleBackColor = true;
            // 
            // myButton15
            // 
            this.myButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton15.Location = new System.Drawing.Point(217, 175);
            this.myButton15.Name = "myButton15";
            this.myButton15.Size = new System.Drawing.Size(60, 50);
            this.myButton15.TabIndex = 15;
            this.myButton15.Text = "x";
            this.myButton15.UseVisualStyleBackColor = true;
            // 
            // myButton14
            // 
            this.myButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton14.Location = new System.Drawing.Point(217, 231);
            this.myButton14.Name = "myButton14";
            this.myButton14.Size = new System.Drawing.Size(60, 50);
            this.myButton14.TabIndex = 14;
            this.myButton14.Text = "-";
            this.myButton14.UseVisualStyleBackColor = true;
            // 
            // myButton13
            // 
            this.myButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton13.Location = new System.Drawing.Point(217, 287);
            this.myButton13.Name = "myButton13";
            this.myButton13.Size = new System.Drawing.Size(60, 50);
            this.myButton13.TabIndex = 13;
            this.myButton13.Text = "+";
            this.myButton13.UseVisualStyleBackColor = true;
            // 
            // myButton12
            // 
            this.myButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton12.Location = new System.Drawing.Point(217, 343);
            this.myButton12.Name = "myButton12";
            this.myButton12.Size = new System.Drawing.Size(60, 50);
            this.myButton12.TabIndex = 12;
            this.myButton12.Text = "=";
            this.myButton12.UseVisualStyleBackColor = true;
            // 
            // myButton11
            // 
            this.myButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton11.Location = new System.Drawing.Point(139, 343);
            this.myButton11.Name = "myButton11";
            this.myButton11.Size = new System.Drawing.Size(60, 50);
            this.myButton11.TabIndex = 11;
            this.myButton11.Text = ".";
            this.myButton11.UseVisualStyleBackColor = true;
            // 
            // myButton10
            // 
            this.myButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton10.Location = new System.Drawing.Point(7, 343);
            this.myButton10.Name = "myButton10";
            this.myButton10.Size = new System.Drawing.Size(126, 50);
            this.myButton10.TabIndex = 10;
            this.myButton10.Text = "0";
            this.myButton10.UseVisualStyleBackColor = true;
            // 
            // myButton9
            // 
            this.myButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton9.Location = new System.Drawing.Point(139, 175);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(60, 50);
            this.myButton9.TabIndex = 9;
            this.myButton9.Text = "9";
            this.myButton9.UseVisualStyleBackColor = true;
            // 
            // myButton8
            // 
            this.myButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton8.Location = new System.Drawing.Point(73, 175);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(60, 50);
            this.myButton8.TabIndex = 8;
            this.myButton8.Text = "8";
            this.myButton8.UseVisualStyleBackColor = true;
            // 
            // myButton7
            // 
            this.myButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton7.Location = new System.Drawing.Point(7, 175);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(60, 50);
            this.myButton7.TabIndex = 7;
            this.myButton7.Text = "7";
            this.myButton7.UseVisualStyleBackColor = true;
            // 
            // myButton6
            // 
            this.myButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton6.Location = new System.Drawing.Point(139, 231);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(60, 50);
            this.myButton6.TabIndex = 6;
            this.myButton6.Text = "6";
            this.myButton6.UseVisualStyleBackColor = true;
            // 
            // myButton5
            // 
            this.myButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton5.Location = new System.Drawing.Point(73, 231);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(60, 50);
            this.myButton5.TabIndex = 5;
            this.myButton5.Text = "5";
            this.myButton5.UseVisualStyleBackColor = true;
            // 
            // myButton4
            // 
            this.myButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton4.Location = new System.Drawing.Point(7, 231);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(60, 50);
            this.myButton4.TabIndex = 4;
            this.myButton4.Text = "4";
            this.myButton4.UseVisualStyleBackColor = true;
            // 
            // myButton3
            // 
            this.myButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton3.Location = new System.Drawing.Point(139, 287);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(60, 50);
            this.myButton3.TabIndex = 3;
            this.myButton3.Text = "3";
            this.myButton3.UseVisualStyleBackColor = true;
            // 
            // myButton2
            // 
            this.myButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.Location = new System.Drawing.Point(73, 287);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(60, 50);
            this.myButton2.TabIndex = 2;
            this.myButton2.Text = "2";
            this.myButton2.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.Location = new System.Drawing.Point(7, 287);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(60, 50);
            this.myButton1.TabIndex = 1;
            this.myButton1.Text = "1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 404);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.myButton19);
            this.Controls.Add(this.myButton18);
            this.Controls.Add(this.myButton17);
            this.Controls.Add(this.myButton16);
            this.Controls.Add(this.myButton15);
            this.Controls.Add(this.myButton14);
            this.Controls.Add(this.myButton13);
            this.Controls.Add(this.myButton12);
            this.Controls.Add(this.myButton11);
            this.Controls.Add(this.myButton10);
            this.Controls.Add(this.myButton9);
            this.Controls.Add(this.myButton8);
            this.Controls.Add(this.myButton7);
            this.Controls.Add(this.myButton6);
            this.Controls.Add(this.myButton5);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.operationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void key(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox operationTextBox;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
        private MyButton myButton4;
        private MyButton myButton5;
        private MyButton myButton6;
        private MyButton myButton7;
        private MyButton myButton8;
        private MyButton myButton9;
        private MyButton myButton10;
        private MyButton myButton11;
        private MyButton myButton12;
        private MyButton myButton13;
        private MyButton myButton14;
        private MyButton myButton15;
        private MyButton myButton16;
        private MyButton myButton17;
        private MyButton myButton18;
        private MyButton myButton19;
        private MyLabel resultLabel;
    }
}

