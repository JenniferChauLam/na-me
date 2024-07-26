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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            LstQuestion = new ListView();
            addButton = new Guna.UI2.WinForms.Guna2Button();
            searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            SortBtn = new Guna.UI2.WinForms.Guna2Button();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LstQuestion
            // 
            LstQuestion.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LstQuestion.Location = new Point(12, 147);
            LstQuestion.Name = "LstQuestion";
            LstQuestion.Size = new Size(1129, 562);
            LstQuestion.TabIndex = 0;
            LstQuestion.UseCompatibleStateImageBehavior = false;
            LstQuestion.MouseClick += LstQuestion_MouseClick;
            LstQuestion.MouseDoubleClick += LstQuestion_MouseDoubleClick;
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
            addButton.Location = new Point(1035, 108);
            addButton.Name = "addButton";
            addButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            addButton.Size = new Size(106, 33);
            addButton.TabIndex = 1;
            addButton.Text = "Create";
            addButton.TextAlign = HorizontalAlignment.Right;
            addButton.TextOffset = new Point(2, -1);
            addButton.Click += addButton_Click;
            // 
            // searchBox
            // 
            searchBox.BorderColor = Color.Silver;
            searchBox.BorderRadius = 18;
            searchBox.CustomizableEdges = customizableEdges3;
            searchBox.DefaultText = "";
            searchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.DarkGray;
            searchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchBox.IconRight = (Image)resources.GetObject("searchBox.IconRight");
            searchBox.IconRightOffset = new Point(8, -1);
            searchBox.Location = new Point(379, 104);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PasswordChar = '\0';
            searchBox.PlaceholderForeColor = Color.DarkGray;
            searchBox.PlaceholderText = "Search";
            searchBox.SelectedText = "";
            searchBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchBox.Size = new Size(394, 36);
            searchBox.TabIndex = 2;
            searchBox.TextOffset = new Point(3, -1);
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 132, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 40);
            label1.TabIndex = 4;
            label1.Text = "QUESTION";
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            ContextMenuStrip1.RenderStyle.ColorTable = null;
            ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ContextMenuStrip1.Size = new Size(129, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(128, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // SortBtn
            // 
            SortBtn.BorderColor = Color.Transparent;
            SortBtn.BorderRadius = 5;
            SortBtn.BorderThickness = 1;
            SortBtn.CustomizableEdges = customizableEdges5;
            SortBtn.DisabledState.BorderColor = Color.DarkGray;
            SortBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SortBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SortBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SortBtn.FillColor = Color.Transparent;
            SortBtn.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortBtn.ForeColor = Color.FromArgb(34, 102, 141);
            SortBtn.HoverState.FillColor = Color.Transparent;
            SortBtn.Image = Properties.Resources.icons8_down_24;
            SortBtn.ImageAlign = HorizontalAlignment.Right;
            SortBtn.ImageOffset = new Point(-5, -1);
            SortBtn.ImageSize = new Size(25, 25);
            SortBtn.Location = new Point(948, 108);
            SortBtn.Name = "SortBtn";
            SortBtn.PressedColor = Color.Transparent;
            SortBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SortBtn.Size = new Size(81, 33);
            SortBtn.TabIndex = 1;
            SortBtn.Text = "Sort";
            SortBtn.TextAlign = HorizontalAlignment.Left;
            SortBtn.TextOffset = new Point(-3, -1);
            SortBtn.Click += SortBtn_Click;
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 721);
            Controls.Add(label1);
            Controls.Add(searchBox);
            Controls.Add(SortBtn);
            Controls.Add(addButton);
            Controls.Add(LstQuestion);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmQuestion";
            Text = "Questions";
            Load += FrmQuestion_Load;
            ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LstQuestion;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button SortBtn;
    }
}