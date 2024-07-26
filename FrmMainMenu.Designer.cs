namespace GradingSystem.frm_Collection
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            MenuPanel = new Panel();
            LogoutBtn = new FontAwesome.Sharp.IconButton();
            ContactBtn = new FontAwesome.Sharp.IconButton();
            ScoreBtn = new FontAwesome.Sharp.IconButton();
            ExamsBtn = new FontAwesome.Sharp.IconButton();
            DashboardBtn = new FontAwesome.Sharp.IconButton();
            QuestionsBtn = new FontAwesome.Sharp.IconButton();
            MainPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            MenuPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(34, 102, 141);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(ScoreBtn);
            MenuPanel.Controls.Add(ExamsBtn);
            MenuPanel.Controls.Add(DashboardBtn);
            MenuPanel.Controls.Add(QuestionsBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(214, 650);
            MenuPanel.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Dock = DockStyle.Bottom;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.FromArgb(255, 250, 221);
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            LogoutBtn.IconColor = Color.FromArgb(255, 250, 221);
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 35;
            LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.Location = new Point(0, 590);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Padding = new Padding(10, 0, 20, 0);
            LogoutBtn.Rotation = 180D;
            LogoutBtn.Size = new Size(214, 60);
            LogoutBtn.TabIndex = 9;
            LogoutBtn.Text = "  Logout";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ContactBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ContactBtn.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            ContactBtn.IconColor = Color.FromArgb(255, 250, 221);
            ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ContactBtn.IconSize = 38;
            ContactBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ContactBtn.Location = new Point(0, 419);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Padding = new Padding(10, 0, 20, 0);
            ContactBtn.Size = new Size(214, 60);
            ContactBtn.TabIndex = 8;
            ContactBtn.Text = "  Contact us";
            ContactBtn.TextAlign = ContentAlignment.MiddleLeft;
            ContactBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ContactBtn.UseVisualStyleBackColor = true;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // ScoreBtn
            // 
            ScoreBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreBtn.FlatAppearance.BorderSize = 0;
            ScoreBtn.FlatStyle = FlatStyle.Flat;
            ScoreBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ScoreBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ScoreBtn.IconChar = FontAwesome.Sharp.IconChar.Star;
            ScoreBtn.IconColor = Color.FromArgb(255, 250, 221);
            ScoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ScoreBtn.IconSize = 40;
            ScoreBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.Location = new Point(0, 332);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Padding = new Padding(10, 0, 20, 0);
            ScoreBtn.Size = new Size(214, 60);
            ScoreBtn.TabIndex = 5;
            ScoreBtn.Text = "  Score";
            ScoreBtn.TextAlign = ContentAlignment.MiddleLeft;
            ScoreBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ScoreBtn.UseVisualStyleBackColor = true;
            ScoreBtn.Click += ScoreBtn_Click;
            // 
            // ExamsBtn
            // 
            ExamsBtn.AccessibleDescription = "Insert, view or delete questions in exams";
            ExamsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExamsBtn.FlatAppearance.BorderSize = 0;
            ExamsBtn.FlatStyle = FlatStyle.Flat;
            ExamsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            ExamsBtn.ForeColor = Color.FromArgb(255, 250, 221);
            ExamsBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            ExamsBtn.IconColor = Color.FromArgb(255, 250, 221);
            ExamsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExamsBtn.IconSize = 35;
            ExamsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.Location = new Point(0, 245);
            ExamsBtn.Name = "ExamsBtn";
            ExamsBtn.Padding = new Padding(10, 0, 20, 0);
            ExamsBtn.Size = new Size(214, 60);
            ExamsBtn.TabIndex = 3;
            ExamsBtn.Text = "   Exams";
            ExamsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ExamsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExamsBtn.UseVisualStyleBackColor = true;
            ExamsBtn.Click += ExamsBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.FromArgb(255, 250, 221);
            DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            DashboardBtn.IconColor = Color.FromArgb(255, 250, 221);
            DashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DashboardBtn.IconSize = 38;
            DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.Location = new Point(0, 71);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Padding = new Padding(10, 0, 20, 0);
            DashboardBtn.Size = new Size(214, 60);
            DashboardBtn.TabIndex = 2;
            DashboardBtn.Text = "  Dashboard";
            DashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            DashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardBtn.UseVisualStyleBackColor = true;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // QuestionsBtn
            // 
            QuestionsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuestionsBtn.FlatAppearance.BorderSize = 0;
            QuestionsBtn.FlatStyle = FlatStyle.Flat;
            QuestionsBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold);
            QuestionsBtn.ForeColor = Color.FromArgb(255, 250, 221);
            QuestionsBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            QuestionsBtn.IconColor = Color.FromArgb(255, 250, 221);
            QuestionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuestionsBtn.IconSize = 40;
            QuestionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.Location = new Point(0, 158);
            QuestionsBtn.Name = "QuestionsBtn";
            QuestionsBtn.Padding = new Padding(10, 0, 20, 0);
            QuestionsBtn.Size = new Size(214, 60);
            QuestionsBtn.TabIndex = 2;
            QuestionsBtn.Text = "  Questions";
            QuestionsBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuestionsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuestionsBtn.UseVisualStyleBackColor = true;
            QuestionsBtn.Click += QuestionsBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(214, 283);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1025, 367);
            MainPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 162);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(214, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 283);
            panel1.TabIndex = 4;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 650);
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Controls.Add(MenuPanel);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            MenuPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton QuestionsBtn;
        private FontAwesome.Sharp.IconButton ScoreBtn;
        private FontAwesome.Sharp.IconButton ExamsBtn;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private Panel MainPanel;
        private Label label1;
    }
}