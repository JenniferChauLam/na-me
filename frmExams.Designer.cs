namespace GradingSystem.frm_Collection
{
    partial class FrmExams
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 29);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 3;
            label1.Text = "Create Exam";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 33);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(259, 261);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(66, 33);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(208, 382);
            button1.Name = "button1";
            button1.Size = new Size(225, 34);
            button1.TabIndex = 11;
            button1.Text = "Upload from file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(533, 382);
            button2.Name = "button2";
            button2.Size = new Size(225, 34);
            button2.TabIndex = 12;
            button2.Text = "Create questions";
            button2.UseVisualStyleBackColor = true;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges1;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(681, 178);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2DateTimePicker1.Size = new Size(181, 54);
            guna2DateTimePicker1.TabIndex = 13;
            guna2DateTimePicker1.Value = new DateTime(2024, 6, 3, 16, 26, 39, 822);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(341, 261);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(19, 27);
            guna2HtmlLabel2.TabIndex = 15;
            guna2HtmlLabel2.Text = "m";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 20F);
            label4.Location = new Point(167, 90);
            label4.Name = "label4";
            label4.Size = new Size(287, 45);
            label4.TabIndex = 17;
            label4.Text = "Default Exam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 126);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 187);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 22;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(171, 144);
            label7.Name = "label7";
            label7.Size = new Size(209, 25);
            label7.TabIndex = 23;
            label7.Text = "Exam instructions";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 263);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 24;
            label8.Text = "Duration";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(533, 269);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 25;
            label9.Text = "End Date";
            // 
            // guna2DateTimePicker2
            // 
            guna2DateTimePicker2.Checked = true;
            guna2DateTimePicker2.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker2.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker2.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker2.Location = new Point(681, 261);
            guna2DateTimePicker2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            guna2DateTimePicker2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker2.Size = new Size(181, 54);
            guna2DateTimePicker2.TabIndex = 26;
            guna2DateTimePicker2.Value = new DateTime(2024, 6, 3, 16, 26, 39, 822);
            guna2DateTimePicker2.ValueChanged += guna2DateTimePicker2_ValueChanged;
            // 
            // FrmExams
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 475);
            Controls.Add(guna2DateTimePicker2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmExams";
            Text = "Exams";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
    }
}