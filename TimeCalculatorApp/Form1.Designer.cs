namespace TimeCalculatorApp
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
            lblDay = new Label();
            lblHour = new Label();
            lblMinute = new Label();
            lblSecond = new Label();
            tBDay = new TextBox();
            tBHour = new TextBox();
            tBMinute = new TextBox();
            tBSecond = new TextBox();
            rBAdd = new RadioButton();
            rBSubtract = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(64, 37);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(27, 15);
            lblDay.TabIndex = 0;
            lblDay.Text = "Day";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Location = new Point(170, 37);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(34, 15);
            lblHour.TabIndex = 1;
            lblHour.Text = "Hour";
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(276, 37);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(45, 15);
            lblMinute.TabIndex = 2;
            lblMinute.Text = "Minute";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(382, 37);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(46, 15);
            lblSecond.TabIndex = 3;
            lblSecond.Text = "Second";
            // 
            // tBDay
            // 
            tBDay.Location = new Point(64, 55);
            tBDay.Name = "tBDay";
            tBDay.Size = new Size(100, 23);
            tBDay.TabIndex = 4;
            // 
            // tBHour
            // 
            tBHour.Location = new Point(170, 55);
            tBHour.Name = "tBHour";
            tBHour.Size = new Size(100, 23);
            tBHour.TabIndex = 5;
            // 
            // tBMinute
            // 
            tBMinute.Location = new Point(276, 55);
            tBMinute.Name = "tBMinute";
            tBMinute.Size = new Size(100, 23);
            tBMinute.TabIndex = 6;
            // 
            // tBSecond
            // 
            tBSecond.Location = new Point(382, 55);
            tBSecond.Name = "tBSecond";
            tBSecond.Size = new Size(100, 23);
            tBSecond.TabIndex = 7;
            // 
            // rBAdd
            // 
            rBAdd.AutoSize = true;
            rBAdd.Location = new Point(310, 84);
            rBAdd.Name = "rBAdd";
            rBAdd.Size = new Size(66, 19);
            rBAdd.TabIndex = 8;
            rBAdd.TabStop = true;
            rBAdd.Text = "Add (+)";
            rBAdd.UseVisualStyleBackColor = true;
            // 
            // rBSubtract
            // 
            rBSubtract.AutoSize = true;
            rBSubtract.Location = new Point(397, 84);
            rBSubtract.Name = "rBSubtract";
            rBSubtract.Size = new Size(85, 19);
            rBSubtract.TabIndex = 9;
            rBSubtract.TabStop = true;
            rBSubtract.Text = "Subtract (-)";
            rBSubtract.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(382, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(276, 167);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(170, 167);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(64, 167);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(407, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(rBSubtract);
            Controls.Add(rBAdd);
            Controls.Add(tBSecond);
            Controls.Add(tBMinute);
            Controls.Add(tBHour);
            Controls.Add(tBDay);
            Controls.Add(lblSecond);
            Controls.Add(lblMinute);
            Controls.Add(lblHour);
            Controls.Add(lblDay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDay;
        private Label lblHour;
        private Label lblMinute;
        private Label lblSecond;
        private TextBox tBDay;
        private TextBox tBHour;
        private TextBox tBMinute;
        private TextBox tBSecond;
        private RadioButton rBAdd;
        private RadioButton rBSubtract;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
    }
}
