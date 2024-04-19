namespace лаба_10
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
            label1 = new Label();
            Dlina_a = new Label();
            Shirina_b = new Label();
            Visota_c = new Label();
            Zapusk = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Otvet1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 64);
            label1.TabIndex = 1;
            label1.Text = "Написать программу вычисления площади поверхности прямоугольного параллелепипеда Извне вводятся длина а. ширина b и высота с.";
            label1.Click += label1_Click;
            // 
            // Dlina_a
            // 
            Dlina_a.AutoSize = true;
            Dlina_a.Location = new Point(12, 80);
            Dlina_a.Name = "Dlina_a";
            Dlina_a.Size = new Size(103, 15);
            Dlina_a.TabIndex = 2;
            Dlina_a.Text = "Введите длину (a)";
            Dlina_a.Click += label2_Click;
            // 
            // Shirina_b
            // 
            Shirina_b.AutoSize = true;
            Shirina_b.Location = new Point(12, 109);
            Shirina_b.Name = "Shirina_b";
            Shirina_b.Size = new Size(116, 15);
            Shirina_b.TabIndex = 3;
            Shirina_b.Text = "Введите ширину (b)";
            // 
            // Visota_c
            // 
            Visota_c.AutoSize = true;
            Visota_c.Location = new Point(12, 138);
            Visota_c.Name = "Visota_c";
            Visota_c.Size = new Size(109, 15);
            Visota_c.TabIndex = 4;
            Visota_c.Text = "Введите высоту (c)";
            Visota_c.Click += Visota_c_Click;
            // 
            // Zapusk
            // 
            Zapusk.Location = new Point(12, 177);
            Zapusk.Name = "Zapusk";
            Zapusk.Size = new Size(88, 23);
            Zapusk.TabIndex = 5;
            Zapusk.Text = "Рассчитать";
            Zapusk.UseVisualStyleBackColor = true;
            Zapusk.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Otvet1
            // 
            Otvet1.Location = new Point(150, 177);
            Otvet1.Name = "Otvet1";
            Otvet1.Size = new Size(130, 23);
            Otvet1.TabIndex = 10;
            Otvet1.TextChanged += Otvet1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 220);
            Controls.Add(Otvet1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Zapusk);
            Controls.Add(Visota_c);
            Controls.Add(Shirina_b);
            Controls.Add(Dlina_a);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Dlina_a;
        private Label Shirina_b;
        private Label Visota_c;
        private Button Zapusk;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox Otvet1;
    }
}
