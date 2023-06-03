namespace OdevC_
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(491, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "GÖNDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(491, 120);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "BAĞLAN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(623, 120);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "DUR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 237);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "ADIM SAYISI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 123);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 5;
            label2.Text = "COM PORT SEÇİMİ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 28);
            comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
    }
}