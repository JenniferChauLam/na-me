namespace GradingSystem.frm_Collection
{
    partial class FrmCreateExam
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            QuestionPage = new Button();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            ExamName = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            label4 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(458, 245);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(66, 33);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // QuestionPage
            // 
            QuestionPage.Location = new Point(387, 489);
            QuestionPage.Name = "QuestionPage";
            QuestionPage.Size = new Size(225, 34);
            QuestionPage.TabIndex = 12;
            QuestionPage.Text = "Create questions";
            QuestionPage.UseVisualStyleBackColor = true;
            QuestionPage.Click += QuestionPage_Click;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.BackColor = Color.Transparent;
            guna2DateTimePicker1.BorderRadius = 20;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges1;
            guna2DateTimePicker1.FillColor = Color.FromArgb(255, 132, 0);
            guna2DateTimePicker1.Font = new Font("Tahoma", 10.2F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(458, 305);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2DateTimePicker1.Size = new Size(223, 54);
            guna2DateTimePicker1.TabIndex = 13;
            guna2DateTimePicker1.Value = new DateTime(2024, 6, 3, 16, 26, 39, 822);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(540, 245);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(19, 27);
            guna2HtmlLabel2.TabIndex = 15;
            guna2HtmlLabel2.Text = "m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 314);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 22;
            label6.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 122);
            label7.Name = "label7";
            label7.Size = new Size(209, 25);
            label7.TabIndex = 23;
            label7.Text = "Exam instructions";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(326, 247);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 24;
            label8.Text = "Duration";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(326, 396);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 25;
            label9.Text = "End Date";
            // 
            // guna2DateTimePicker2
            // 
            guna2DateTimePicker2.BackColor = Color.Transparent;
            guna2DateTimePicker2.BorderRadius = 20;
            guna2DateTimePicker2.Checked = true;
            guna2DateTimePicker2.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker2.FillColor = Color.FromArgb(255, 132, 0);
            guna2DateTimePicker2.Font = new Font("Tahoma", 10.2F);
            guna2DateTimePicker2.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker2.Location = new Point(458, 381);
            guna2DateTimePicker2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            guna2DateTimePicker2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker2.Size = new Size(223, 54);
            guna2DateTimePicker2.TabIndex = 26;
            guna2DateTimePicker2.Value = new DateTime(2024, 6, 3, 16, 26, 39, 822);
            guna2DateTimePicker2.ValueChanged += guna2DateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 132, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 47);
            label1.TabIndex = 28;
            label1.Text = "CREATE EXAM";
            // 
            // ExamName
            // 
            ExamName.BackColor = Color.Transparent;
            ExamName.BorderColor = Color.Silver;
            ExamName.BorderRadius = 20;
            ExamName.CustomizableEdges = customizableEdges5;
            ExamName.DefaultText = "";
            ExamName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ExamName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ExamName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ExamName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ExamName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ExamName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExamName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ExamName.Location = new Point(458, 177);
            ExamName.Margin = new Padding(3, 4, 3, 4);
            ExamName.Name = "ExamName";
            ExamName.PasswordChar = '\0';
            ExamName.PlaceholderText = "";
            ExamName.SelectedText = "";
            ExamName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ExamName.Size = new Size(256, 35);
            ExamName.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(877, 81);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 81);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 30;
            label4.Text = "Exam Name";
            // 
            // FrmCreateExam
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 721);
            Controls.Add(QuestionPage);
            Controls.Add(label4);
            Controls.Add(ExamName);
            Controls.Add(label1);
            Controls.Add(guna2DateTimePicker2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCreateExam";
            Text = "Exams";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Button QuestionPage;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Label label1;
        private Label label5;
        private Label label4;
        public Guna.UI2.WinForms.Guna2TextBox ExamName;
    }
}