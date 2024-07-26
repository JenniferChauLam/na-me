namespace GradingSystem.frm_Collection
{
    partial class frmExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ListExam = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            addButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // ListExam
            // 
            ListExam.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            ListExam.Font = new Font("Tahoma", 10.2F);
            ListExam.FullRowSelect = true;
            ListExam.Location = new Point(13, 180);
            ListExam.Margin = new Padding(4, 3, 4, 3);
            ListExam.Name = "ListExam";
            ListExam.Size = new Size(1127, 529);
            ListExam.TabIndex = 3;
            ListExam.UseCompatibleStateImageBehavior = false;
            ListExam.View = View.Details;
            ListExam.ColumnClick += ListExam_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Exam Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Start Time";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "End Time";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Teacher ID";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Time Limit";
            columnHeader6.Width = 96;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 132, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(216, 40);
            label2.TabIndex = 5;
            label2.Text = "LIST EXAM";
            // 
            // addButton
            // 
            addButton.BorderColor = Color.Transparent;
            addButton.BorderRadius = 5;
            addButton.BorderThickness = 1;
            addButton.CustomizableEdges = customizableEdges1;
            addButton.DisabledState.BorderColor = Color.DarkGray;
            addButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addButton.FillColor = Color.FromArgb(13, 127, 242);
            addButton.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageAlign = HorizontalAlignment.Left;
            addButton.ImageOffset = new Point(0, -1);
            addButton.ImageSize = new Size(15, 15);
            addButton.Location = new Point(1034, 141);
            addButton.Name = "addButton";
            addButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            addButton.Size = new Size(106, 33);
            addButton.TabIndex = 6;
            addButton.Text = "Create";
            addButton.TextAlign = HorizontalAlignment.Right;
            addButton.TextOffset = new Point(2, -1);
            addButton.Click += addButton_Click;
            // 
            // frmExam
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 721);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(ListExam);
            Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmExam";
            Text = "frmExam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        public ListView ListExam;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button addButton;
    }
}