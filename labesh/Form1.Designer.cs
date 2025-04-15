namespace labesh
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
            textFirst = new TextBox();
            textSecond = new TextBox();
            textThird = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox2 = new TextBox();
            button1 = new Button();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textFirst
            // 
            textFirst.Location = new Point(169, 30);
            textFirst.Name = "textFirst";
            textFirst.Size = new Size(141, 23);
            textFirst.TabIndex = 0;
            textFirst.TextChanged += textFirst_TextChanged;
            // 
            // textSecond
            // 
            textSecond.Location = new Point(169, 73);
            textSecond.Name = "textSecond";
            textSecond.Size = new Size(141, 23);
            textSecond.TabIndex = 1;
            textSecond.TextChanged += textSecond_TextChanged;
            // 
            // textThird
            // 
            textThird.Location = new Point(78, 119);
            textThird.Name = "textThird";
            textThird.Size = new Size(232, 23);
            textThird.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "+";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(318, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(47, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "м^2";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(318, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(47, 23);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "м^2";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(318, 119);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(47, 23);
            comboBox4.TabIndex = 6;
            comboBox4.Text = "м^2";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 23);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(290, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Сравнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(86, 168);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(47, 23);
            comboBox5.TabIndex = 10;
            comboBox5.Text = "м^2";
            // 
            // comboBox6
            // 
            comboBox6.AutoCompleteCustomSource.AddRange(new string[] { "+", "-" });
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(221, 168);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(47, 23);
            comboBox6.TabIndex = 11;
            comboBox6.Text = "м^2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 23);
            textBox3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 150);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 14;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 150);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 15;
            label2.Text = "2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textThird);
            Controls.Add(textSecond);
            Controls.Add(textFirst);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFirst;
        private TextBox textSecond;
        private TextBox textThird;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
    }
}
