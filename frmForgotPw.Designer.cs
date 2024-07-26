namespace GradingSystem.frm_Collection
{
    partial class frmForgotPw
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BackLbl = new Label();
            lblSIGNIN = new Label();
            Panel1 = new Panel();
            Exit = new Label();
            Token = new Guna.UI2.WinForms.Guna2TextBox();
            Sendcode = new Guna.UI2.WinForms.Guna2Button();
            Username = new Guna.UI2.WinForms.Guna2TextBox();
            Reset = new Guna.UI2.WinForms.Guna2Button();
            EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            NewPw = new Guna.UI2.WinForms.Guna2TextBox();
            PreviewPw = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackLbl.ForeColor = Color.DarkGray;
            BackLbl.Location = new Point(120, 373);
            BackLbl.Margin = new Padding(4, 0, 4, 0);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(119, 19);
            BackLbl.TabIndex = 52;
            BackLbl.Text = "Back to LOGIN";
            BackLbl.Click += BackLbl_Click;
            // 
            // lblSIGNIN
            // 
            lblSIGNIN.AutoSize = true;
            lblSIGNIN.Font = new Font("Bookman Old Style", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSIGNIN.ForeColor = Color.FromArgb(255, 132, 0);
            lblSIGNIN.Location = new Point(32, 50);
            lblSIGNIN.Margin = new Padding(7, 0, 7, 0);
            lblSIGNIN.Name = "lblSIGNIN";
            lblSIGNIN.Size = new Size(196, 72);
            lblSIGNIN.TabIndex = 43;
            lblSIGNIN.Text = "FORGOT\r\nPASSWORD";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Exit);
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(4, 2, 4, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(350, 27);
            Panel1.TabIndex = 42;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(321, 4);
            Exit.Margin = new Padding(4, 0, 4, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(24, 21);
            Exit.TabIndex = 41;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // Token
            // 
            Token.BorderColor = Color.DarkGray;
            Token.BorderRadius = 20;
            Token.CustomizableEdges = customizableEdges1;
            Token.DefaultText = "";
            Token.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Token.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Token.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Token.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Token.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Token.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Token.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Token.Location = new Point(32, 212);
            Token.Margin = new Padding(4, 3, 4, 3);
            Token.MaxLength = 255;
            Token.Name = "Token";
            Token.PasswordChar = '\0';
            Token.PlaceholderForeColor = Color.DimGray;
            Token.PlaceholderText = "Verification Code";
            Token.SelectedText = "";
            Token.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Token.Size = new Size(290, 31);
            Token.TabIndex = 54;
            Token.TextChanged += Token_TextChanged;
            // 
            // Sendcode
            // 
            Sendcode.BorderColor = Color.FromArgb(255, 152, 0);
            Sendcode.BorderRadius = 20;
            Sendcode.BorderThickness = 1;
            Sendcode.CustomizableEdges = customizableEdges3;
            Sendcode.DisabledState.BorderColor = Color.DarkGray;
            Sendcode.DisabledState.CustomBorderColor = Color.DarkGray;
            Sendcode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Sendcode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Sendcode.FillColor = Color.Transparent;
            Sendcode.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sendcode.ForeColor = Color.Black;
            Sendcode.Location = new Point(230, 175);
            Sendcode.Margin = new Padding(3, 2, 3, 2);
            Sendcode.Name = "Sendcode";
            Sendcode.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Sendcode.Size = new Size(92, 32);
            Sendcode.TabIndex = 55;
            Sendcode.Text = "Send";
            Sendcode.Click += Sendcode_Click;
            // 
            // Username
            // 
            Username.BorderColor = Color.DarkGray;
            Username.BorderRadius = 20;
            Username.CustomizableEdges = customizableEdges5;
            Username.DefaultText = "";
            Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Username.Location = new Point(32, 139);
            Username.Margin = new Padding(4, 3, 4, 3);
            Username.Name = "Username";
            Username.PasswordChar = '\0';
            Username.PlaceholderForeColor = Color.DimGray;
            Username.PlaceholderText = "Username";
            Username.SelectedText = "";
            Username.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Username.Size = new Size(290, 31);
            Username.TabIndex = 54;
            Username.TextChanged += Username_TextChanged;
            // 
            // Reset
            // 
            Reset.BorderColor = Color.FromArgb(255, 152, 0);
            Reset.BorderRadius = 20;
            Reset.BorderThickness = 1;
            Reset.CustomizableEdges = customizableEdges7;
            Reset.DisabledState.BorderColor = Color.DarkGray;
            Reset.DisabledState.CustomBorderColor = Color.DarkGray;
            Reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reset.FillColor = Color.Transparent;
            Reset.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reset.ForeColor = Color.FromArgb(255, 152, 0);
            Reset.Location = new Point(132, 319);
            Reset.Margin = new Padding(3, 2, 3, 2);
            Reset.Name = "Reset";
            Reset.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Reset.Size = new Size(92, 32);
            Reset.TabIndex = 55;
            Reset.Text = "RESET";
            Reset.Click += Reset_Click;
            // 
            // EmailTxt
            // 
            EmailTxt.BorderColor = Color.DarkGray;
            EmailTxt.BorderRadius = 20;
            EmailTxt.CustomizableEdges = customizableEdges9;
            EmailTxt.DefaultText = "";
            EmailTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailTxt.Location = new Point(32, 176);
            EmailTxt.Margin = new Padding(4, 3, 4, 3);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PasswordChar = '\0';
            EmailTxt.PlaceholderForeColor = Color.DimGray;
            EmailTxt.PlaceholderText = "Email";
            EmailTxt.SelectedText = "";
            EmailTxt.ShadowDecoration.CustomizableEdges = customizableEdges10;
            EmailTxt.Size = new Size(192, 31);
            EmailTxt.TabIndex = 54;
            EmailTxt.TextChanged += EmailTxt_TextChanged;
            // 
            // NewPw
            // 
            NewPw.BorderColor = Color.DarkGray;
            NewPw.BorderRadius = 20;
            NewPw.CustomizableEdges = customizableEdges11;
            NewPw.DefaultText = "";
            NewPw.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NewPw.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NewPw.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NewPw.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NewPw.Enabled = false;
            NewPw.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NewPw.Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPw.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NewPw.Location = new Point(32, 249);
            NewPw.Margin = new Padding(4, 3, 4, 3);
            NewPw.Name = "NewPw";
            NewPw.PasswordChar = '*';
            NewPw.PlaceholderForeColor = Color.DimGray;
            NewPw.PlaceholderText = "New password";
            NewPw.SelectedText = "";
            NewPw.ShadowDecoration.CustomizableEdges = customizableEdges12;
            NewPw.Size = new Size(247, 31);
            NewPw.TabIndex = 56;
            NewPw.TextChanged += NewPw_TextChanged;
            // 
            // PreviewPw
            // 
            PreviewPw.CheckedState.Image = Properties.Resources.show_pw;
            PreviewPw.Enabled = false;
            PreviewPw.Image = Properties.Resources.hide_pw;
            PreviewPw.ImageOffset = new Point(0, 0);
            PreviewPw.ImageRotate = 0F;
            PreviewPw.Location = new Point(286, 249);
            PreviewPw.Name = "PreviewPw";
            PreviewPw.ShadowDecoration.CustomizableEdges = customizableEdges13;
            PreviewPw.Size = new Size(24, 31);
            PreviewPw.TabIndex = 57;
            PreviewPw.CheckedChanged += PreviewPw_CheckedChanged;
            // 
            // frmForgotPw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 402);
            Controls.Add(PreviewPw);
            Controls.Add(NewPw);
            Controls.Add(Reset);
            Controls.Add(Sendcode);
            Controls.Add(EmailTxt);
            Controls.Add(Username);
            Controls.Add(Token);
            Controls.Add(BackLbl);
            Controls.Add(lblSIGNIN);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmForgotPw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPw";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NpwTxt;
        private Label BackLbl;
        private TextBox UsernameTxt;
        private TextBox CpwTxt;
        private Label lblSIGNIN;
        private Panel Panel1;
        private Label Exit;
        private Guna.UI2.WinForms.Guna2TextBox Token;
        private Guna.UI2.WinForms.Guna2Button Sendcode;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private Guna.UI2.WinForms.Guna2Button Reset;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2TextBox NewPw;
        private Guna.UI2.WinForms.Guna2ImageCheckBox PreviewPw;
    }
}