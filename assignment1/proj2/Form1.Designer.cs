namespace proj2
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
            Calculator = new Button();
            fontDialog1 = new FontDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Calculator
            // 
            Calculator.Location = new Point(293, 376);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(112, 34);
            Calculator.TabIndex = 0;
            Calculator.Text = "Calculator";
            Calculator.UseVisualStyleBackColor = true;
            Calculator.Click += Cl_click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += fiNum_changed;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(539, 87);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += plus_click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(657, 155);
            button2.Name = "button2";
            button2.Size = new Size(112, 68);
            button2.TabIndex = 3;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = true;
            button2.Click += divide_click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(539, 155);
            button3.Name = "button3";
            button3.Size = new Size(112, 68);
            button3.TabIndex = 4;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += times_click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(657, 87);
            button4.Name = "button4";
            button4.Size = new Size(112, 62);
            button4.TabIndex = 5;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += minus_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 246);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 6;
            label1.Text = "operator";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += seNum_changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 171);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 6;
            label2.Text = "firstNum";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 171);
            label3.Name = "label3";
            label3.Size = new Size(114, 24);
            label3.TabIndex = 6;
            label3.Text = "secondNum";
            label3.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 30);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += result;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 291);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 6;
            label4.Text = "result";
            label4.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Calculator);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculator;
        private FontDialog fontDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}