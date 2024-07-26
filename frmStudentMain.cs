using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Core;
using FontAwesome.Sharp;
using GradingSystem.Class_collection;
using Microsoft.Data.SqlClient;

namespace GradingSystem.frm_Collection
{
    public partial class frmStudentMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        bool drag = false;
        Point starting_point = new(0, 0);

        string connectionString = "Data Source=Data Source=JENLAP\\MSSQLSERVERNO;Initial Catalog=GradingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";




        public frmStudentMain()
        {
            InitializeComponent();
            leftBorderBtn = new();
            leftBorderBtn.Size = new(7, 60);
            MenuPanel.Controls.Add(leftBorderBtn);

            //this.MainPanel.Controls.Clear();
            frmDashboard Home = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            Home.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(Home);
            Home.Show();
        }

        // 255, 204, 112
        // mau nen: 255, 250, 221
        private struct RGBColors
        {
            public static Color color1 = Color.Transparent;
        }

        private void ActiveButton(object sender, Color color, string label_name)
        {
            if (sender != null)
            {
                DisableButton(label_name);
                // button
                currentBtn = (IconButton)sender;
                currentBtn.Text = "";
                currentBtn.IconColor = Color.FromArgb(255, 132, 0);
                // left border button
                leftBorderBtn.BackColor = Color.FromArgb(255, 132, 0);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + 10);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton(string label_name)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.Text = label_name;
                currentBtn.ForeColor = Color.FromArgb(147, 142, 166);
                currentBtn.TextAlign = ContentAlignment.BottomCenter;
                currentBtn.IconColor = Color.FromArgb(147, 142, 166);
                currentBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1, "Home");
            this.MainPanel.Controls.Clear();
            frmDashboard frmDashboard = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void QuestionBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1, "Question");

            this.MainPanel.Controls.Clear();
            FrmQuestion frmQuestion = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmQuestion.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmQuestion);
            frmQuestion.Show();
        }

        private void ExamBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1, "Exam");

            this.MainPanel.Controls.Clear();
            FrmDoExam frmExams = new("1","1") //remember to change it!!!!!
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmExams.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmExams);
            frmExams.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit this window?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK) { this.Close(); } else { return; }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1, "View");
            this.MainPanel.Controls.Clear();
            FrmCreateExam frmExams = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmExams.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(frmExams);
            frmExams.Show();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1, "Help");
            string message = "If you have any questions, please contact us: GROUP B" +
                "\tTRUONG TO TRAN - 2059046\tLUU HOANG THUY VAN - 2159015\tLAM DANG BAO CHAU - 2159019";
            string title = "Contact information";
            DialogResult result = MessageBox.Show(message, title);
        }

        private void Reset()
        {
            /*DisableButton();*/
            leftBorderBtn.Visible = false;
        }

        // make taskbar 
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - starting_point.X, p.Y - starting_point.Y);
            }
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        
    }
}
