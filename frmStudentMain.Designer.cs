namespace GradingSystem.frm_Collection
{
    partial class frmStudentMain
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
            ExamBtn = new FontAwesome.Sharp.IconButton();
            LogoutBtn = new FontAwesome.Sharp.IconButton();
            ContactBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            QuestionBtn = new FontAwesome.Sharp.IconButton();
            HomeBtn = new FontAwesome.Sharp.IconButton();
            MainPanel = new Panel();
            panel = new Panel();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Black;
            MenuPanel.Controls.Add(ExamBtn);
            MenuPanel.Controls.Add(LogoutBtn);
            MenuPanel.Controls.Add(ContactBtn);
            MenuPanel.Controls.Add(iconButton1);
            MenuPanel.Controls.Add(QuestionBtn);
            MenuPanel.Controls.Add(HomeBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.ForeColor = SystemColors.ControlText;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(86, 760);
            MenuPanel.TabIndex = 1;
            // 
            // ExamBtn
            // 
            ExamBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExamBtn.BackColor = Color.Transparent;
            ExamBtn.FlatAppearance.BorderSize = 0;
            ExamBtn.FlatStyle = FlatStyle.Flat;
            ExamBtn.Font = new Font("Bookman Old Style", 7.20000029F);
            ExamBtn.ForeColor = Color.FromArgb(147, 142, 166);
            ExamBtn.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            ExamBtn.IconColor = Color.FromArgb(147, 142, 166);
            ExamBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExamBtn.IconSize = 30;
            ExamBtn.Location = new Point(3, 249);
            ExamBtn.Name = "ExamBtn";
            ExamBtn.Size = new Size(80, 80);
            ExamBtn.TabIndex = 3;
            ExamBtn.Text = "Exam";
            ExamBtn.TextAlign = ContentAlignment.BottomCenter;
            ExamBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ExamBtn.UseVisualStyleBackColor = false;
            ExamBtn.Click += ExamBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Bookman Old Style", 7.20000029F);
            LogoutBtn.ForeColor = Color.FromArgb(147, 142, 166);
            LogoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            LogoutBtn.IconColor = Color.FromArgb(147, 142, 166);
            LogoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            LogoutBtn.IconSize = 30;
            LogoutBtn.Location = new Point(3, 677);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Rotation = 180D;
            LogoutBtn.Size = new Size(80, 80);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "Log out";
            LogoutBtn.TextAlign = ContentAlignment.BottomCenter;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactBtn.BackColor = Color.Transparent;
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Bookman Old Style", 7.20000029F);
            ContactBtn.ForeColor = Color.FromArgb(147, 142, 166);
            ContactBtn.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            ContactBtn.IconColor = Color.FromArgb(147, 142, 166);
            ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ContactBtn.IconSize = 30;
            ContactBtn.Location = new Point(3, 591);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Size = new Size(80, 80);
            ContactBtn.TabIndex = 5;
            ContactBtn.Text = "Help";
            ContactBtn.TextAlign = ContentAlignment.BottomCenter;
            ContactBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ContactBtn.UseVisualStyleBackColor = false;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Bookman Old Style", 7.20000029F);
            iconButton1.ForeColor = Color.FromArgb(147, 142, 166);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            iconButton1.IconColor = Color.FromArgb(147, 142, 166);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(3, 335);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(80, 80);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "View";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += ViewBtn_Click;
            // 
            // QuestionBtn
            // 
            QuestionBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuestionBtn.BackColor = Color.Transparent;
            QuestionBtn.FlatAppearance.BorderSize = 0;
            QuestionBtn.FlatStyle = FlatStyle.Flat;
            QuestionBtn.Font = new Font("Bookman Old Style", 7.20000029F);
            QuestionBtn.ForeColor = Color.FromArgb(147, 142, 166);
            QuestionBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            QuestionBtn.IconColor = Color.FromArgb(147, 142, 166);
            QuestionBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            QuestionBtn.IconSize = 30;
            QuestionBtn.Location = new Point(3, 163);
            QuestionBtn.Name = "QuestionBtn";
            QuestionBtn.Size = new Size(80, 80);
            QuestionBtn.TabIndex = 2;
            QuestionBtn.Text = "Question";
            QuestionBtn.TextAlign = ContentAlignment.BottomCenter;
            QuestionBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            QuestionBtn.UseVisualStyleBackColor = false;
            QuestionBtn.Click += QuestionBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Bookman Old Style", 7.20000029F);
            HomeBtn.ForeColor = Color.FromArgb(147, 142, 166);
            HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            HomeBtn.IconColor = Color.FromArgb(147, 142, 166);
            HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeBtn.IconSize = 30;
            HomeBtn.Location = new Point(3, 77);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(80, 80);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.TextAlign = ContentAlignment.BottomCenter;
            HomeBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(238, 244, 249);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(86, 39);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1153, 721);
            MainPanel.TabIndex = 3;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(238, 244, 249);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(86, 0);
            panel.Name = "panel";
            panel.Size = new Size(1153, 39);
            panel.TabIndex = 4;
            panel.MouseDown += PanelMove_MouseDown;
            panel.MouseMove += PanelMove_MouseMove;
            panel.MouseUp += PanelMove_MouseUp;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 244, 249);
            ClientSize = new Size(1239, 760);
            Controls.Add(MainPanel);
            Controls.Add(panel);
            Controls.Add(MenuPanel);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton QuestionBtn;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private FontAwesome.Sharp.IconButton LogoutBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private FontAwesome.Sharp.IconButton ExamBtn;
        private Panel panel;
        private FontAwesome.Sharp.IconButton iconButton1;
        public Panel MainPanel;
        //private GroupBox groupBox1;
    }
}