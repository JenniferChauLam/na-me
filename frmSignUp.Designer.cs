namespace GradingSystem.frm_Collection
{
    partial class FrmSignup
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            panel3 = new Panel();
            Exit = new Label();
            lblSIGNIN = new Label();
            panel1 = new Panel();
            StudentRbtn = new RadioButton();
            TeacherRbtn = new RadioButton();
            RoleLbl = new Label();
            BackLbl = new Label();
            UsernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            CpwTxt = new Guna.UI2.WinForms.Guna2TextBox();
            EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            SignUpBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(Exit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 40);
            panel3.TabIndex = 48;
            panel3.MouseDown += MovementPanel_MouseDown;
            panel3.MouseMove += MovementPanel_MouseMove;
            panel3.MouseUp += MovementPanel_MouseUp;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ActiveCaptionText;
            Exit.Location = new Point(362, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(24, 21);
            Exit.TabIndex = 49;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.Anchor = AnchorStyles.None;
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(255, 132, 0);
            lblSIGNIN.Location = new Point(108, 54);
            lblSIGNIN.Margin = new Padding(8, 0, 8, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(144, 36);
            lblSIGNIN.TabIndex = 49;
            lblSIGNIN.Text = "SIGN UP";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(StudentRbtn);
            panel1.Controls.Add(TeacherRbtn);
            panel1.Controls.Add(RoleLbl);
            panel1.Location = new Point(32, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 38);
            panel1.TabIndex = 56;
            // 
            // StudentRbtn
            // 
            StudentRbtn.AutoSize = true;
            StudentRbtn.Font = new Font("Bookman Old Style", 10.8F);
            StudentRbtn.ForeColor = Color.Gray;
            StudentRbtn.Location = new Point(227, 7);
            StudentRbtn.Name = "StudentRbtn";
            StudentRbtn.Size = new Size(85, 23);
            StudentRbtn.TabIndex = 42;
            StudentRbtn.TabStop = true;
            StudentRbtn.Text = "student";
            StudentRbtn.UseVisualStyleBackColor = true;
            // 
            // TeacherRbtn
            // 
            TeacherRbtn.AutoSize = true;
            TeacherRbtn.Font = new Font("Bookman Old Style", 10.8F);
            TeacherRbtn.ForeColor = Color.Gray;
            TeacherRbtn.Location = new Point(90, 7);
            TeacherRbtn.Name = "TeacherRbtn";
            TeacherRbtn.Size = new Size(85, 23);
            TeacherRbtn.TabIndex = 41;
            TeacherRbtn.TabStop = true;
            TeacherRbtn.Text = "teacher";
            TeacherRbtn.UseVisualStyleBackColor = true;
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleLbl.ForeColor = Color.Gray;
            RoleLbl.Location = new Point(3, 9);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(42, 19);
            RoleLbl.TabIndex = 43;
            RoleLbl.Text = "Role";
            // 
            // BackLbl
            // 
            BackLbl.Anchor = AnchorStyles.None;
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(127, 536);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(119, 19);
            BackLbl.TabIndex = 50;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // UsernameTxt
            // 
            UsernameTxt.BorderColor = Color.LightGray;
            UsernameTxt.BorderRadius = 20;
            UsernameTxt.CustomizableEdges = customizableEdges1;
            UsernameTxt.DefaultText = "";
            UsernameTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UsernameTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UsernameTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UsernameTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UsernameTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTxt.Font = new Font("Bookman Old Style", 10.8F);
            UsernameTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UsernameTxt.Location = new Point(32, 191);
            UsernameTxt.Margin = new Padding(4);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.PasswordChar = '\0';
            UsernameTxt.PlaceholderForeColor = Color.DarkGray;
            UsernameTxt.PlaceholderText = "Username";
            UsernameTxt.SelectedText = "";
            UsernameTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UsernameTxt.Size = new Size(331, 41);
            UsernameTxt.TabIndex = 57;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BorderColor = Color.LightGray;
            PasswordTxt.BorderRadius = 20;
            PasswordTxt.CustomizableEdges = customizableEdges3;
            PasswordTxt.DefaultText = "";
            PasswordTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTxt.Font = new Font("Bookman Old Style", 10.8F);
            PasswordTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTxt.Location = new Point(32, 245);
            PasswordTxt.Margin = new Padding(4);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '\0';
            PasswordTxt.PlaceholderForeColor = Color.DarkGray;
            PasswordTxt.PlaceholderText = "Password";
            PasswordTxt.SelectedText = "";
            PasswordTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PasswordTxt.Size = new Size(331, 41);
            PasswordTxt.TabIndex = 57;
            // 
            // CpwTxt
            // 
            CpwTxt.BorderColor = Color.LightGray;
            CpwTxt.BorderRadius = 20;
            CpwTxt.CustomizableEdges = customizableEdges5;
            CpwTxt.DefaultText = "";
            CpwTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CpwTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CpwTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CpwTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CpwTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CpwTxt.Font = new Font("Bookman Old Style", 10.8F);
            CpwTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CpwTxt.Location = new Point(32, 302);
            CpwTxt.Margin = new Padding(4);
            CpwTxt.Name = "CpwTxt";
            CpwTxt.PasswordChar = '\0';
            CpwTxt.PlaceholderForeColor = Color.DarkGray;
            CpwTxt.PlaceholderText = "Confirm Password";
            CpwTxt.SelectedText = "";
            CpwTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CpwTxt.Size = new Size(331, 41);
            CpwTxt.TabIndex = 57;
            // 
            // EmailTxt
            // 
            EmailTxt.BorderColor = Color.LightGray;
            EmailTxt.BorderRadius = 20;
            EmailTxt.CustomizableEdges = customizableEdges7;
            EmailTxt.DefaultText = "";
            EmailTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F);
            EmailTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Location = new Point(32, 360);
            EmailTxt.Margin = new Padding(4);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PasswordChar = '\0';
            EmailTxt.PlaceholderForeColor = Color.DarkGray;
            EmailTxt.PlaceholderText = "Email";
            EmailTxt.SelectedText = "";
            EmailTxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            EmailTxt.Size = new Size(331, 41);
            EmailTxt.TabIndex = 57;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BorderColor = Color.FromArgb(255, 132, 0);
            SignUpBtn.BorderRadius = 25;
            SignUpBtn.BorderThickness = 1;
            SignUpBtn.CustomBorderColor = Color.FromArgb(255, 132, 0);
            SignUpBtn.CustomizableEdges = customizableEdges9;
            SignUpBtn.DisabledState.BorderColor = Color.DarkGray;
            SignUpBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SignUpBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SignUpBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            SignUpBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SignUpBtn.FillColor = Color.White;
            SignUpBtn.FillColor2 = Color.White;
            SignUpBtn.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.FromArgb(255, 132, 0);
            SignUpBtn.Location = new Point(108, 422);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SignUpBtn.Size = new Size(159, 43);
            SignUpBtn.TabIndex = 58;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // FrmSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 565);
            Controls.Add(SignUpBtn);
            Controls.Add(EmailTxt);
            Controls.Add(CpwTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Controls.Add(BackLbl);
            Controls.Add(lblSIGNIN);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSignup";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label Exit;
        private Guna.UI2.WinForms.Guna2GradientButton SignUpBtn;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2TextBox CpwTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private Label lblSIGNIN;
        private Panel panel1;
        private RadioButton StudentRbtn;
        private RadioButton TeacherRbtn;
        private Label RoleLbl;
        private Label BackLbl;
    }
}