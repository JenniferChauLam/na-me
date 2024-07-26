namespace GradingSystem.frm_Collection
{
    partial class frmDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            DateLbl = new Label();
            TimeLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox2 = new GroupBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DateLbl
            // 
            DateLbl.AutoSize = true;
            DateLbl.Font = new Font("LCDMono2", 22.2F);
            DateLbl.ForeColor = Color.FromArgb(254, 122, 54);
            DateLbl.Location = new Point(302, 29);
            DateLbl.Name = "DateLbl";
            DateLbl.Size = new Size(204, 32);
            DateLbl.TabIndex = 1;
            DateLbl.Text = "00/00/0000";
            // 
            // TimeLbl
            // 
            TimeLbl.AutoSize = true;
            TimeLbl.Font = new Font("LCDMono2", 22.2F);
            TimeLbl.ForeColor = Color.FromArgb(254, 122, 54);
            TimeLbl.Location = new Point(15, 29);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(166, 32);
            TimeLbl.TabIndex = 1;
            TimeLbl.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(245, 239, 230);
            groupBox2.Controls.Add(DateLbl);
            groupBox2.Controls.Add(TimeLbl);
            groupBox2.Location = new Point(12, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(613, 84);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 607);
            Controls.Add(groupBox2);
            Font = new Font("Bookman Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDashboard";
            Text = "frmDashboard";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label TimeLbl;
        private Label DateLbl;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}