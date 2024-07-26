namespace GradingSystem
{
    partial class FrmQuestion
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
            QuestionPageLbl = new Label();
            SuspendLayout();
            // 
            // QuestionPageLbl
            // 
            QuestionPageLbl.AutoSize = true;
            QuestionPageLbl.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestionPageLbl.Location = new Point(12, 9);
            QuestionPageLbl.Name = "QuestionPageLbl";
            QuestionPageLbl.Size = new Size(317, 40);
            QuestionPageLbl.TabIndex = 0;
            QuestionPageLbl.Text = "Create questions";
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 607);
            Controls.Add(QuestionPageLbl);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmQuestion";
            Text = "Questions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionPageLbl;
    }
}