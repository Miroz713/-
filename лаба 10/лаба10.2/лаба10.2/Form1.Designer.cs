namespace Лаба10._2
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
            n = new Label();
            n1 = new TextBox();
            Cikl = new CheckBox();
            Formula = new CheckBox();
            Zapusk = new Button();
            Otvet1 = new TextBox();
            SuspendLayout();
            // 
            // n
            // 
            n.AutoSize = true;
            n.Location = new Point(0, 9);
            n.Name = "n";
            n.Size = new Size(25, 15);
            n.TabIndex = 0;
            n.Text = "n =";
            // 
            // n1
            // 
            n1.Location = new Point(31, 6);
            n1.Name = "n1";
            n1.Size = new Size(100, 23);
            n1.TabIndex = 1;
            // 
            // Cikl
            // 
            Cikl.AutoSize = true;
            Cikl.Location = new Point(0, 35);
            Cikl.Name = "Cikl";
            Cikl.Size = new Size(55, 19);
            Cikl.TabIndex = 2;
            Cikl.Text = "Цикл";
            Cikl.UseVisualStyleBackColor = true;
            // 
            // Formula
            // 
            Formula.AutoSize = true;
            Formula.Location = new Point(0, 60);
            Formula.Name = "Formula";
            Formula.Size = new Size(77, 19);
            Formula.TabIndex = 3;
            Formula.Text = "Формула";
            Formula.UseVisualStyleBackColor = true;
            // 
            // Zapusk
            // 
            Zapusk.Location = new Point(0, 85);
            Zapusk.Name = "Zapusk";
            Zapusk.Size = new Size(82, 23);
            Zapusk.TabIndex = 4;
            Zapusk.Text = "Рассчитать";
            Zapusk.UseVisualStyleBackColor = true;
            Zapusk.Click += Zapusk_Click;
            // 
            // Otvet1
            // 
            Otvet1.Location = new Point(88, 86);
            Otvet1.Name = "Otvet1";
            Otvet1.Size = new Size(164, 23);
            Otvet1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 117);
            Controls.Add(Otvet1);
            Controls.Add(Zapusk);
            Controls.Add(Formula);
            Controls.Add(Cikl);
            Controls.Add(n1);
            Controls.Add(n);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label n;
        private TextBox n1;
        private CheckBox Cikl;
        private CheckBox Formula;
        private Button Zapusk;
        private TextBox Otvet1;
    }
}
