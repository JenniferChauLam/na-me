using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using GradingSystem.Class_collection;

namespace GradingSystem.frm_Collection
{
    public partial class FrmSignup : Form
    {
        // make movable form 
        bool drag = false;
        Point starting_point = new(0, 0);

        public FrmSignup()
        {
            InitializeComponent();
        }


        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login success");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MovementPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void MovementPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - starting_point.X, p.Y - starting_point.Y);
            }
        }

        private void MovementPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }

        private static bool IsTextboxEmpty(Guna2TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }

        private bool CheckandChange(Guna2TextBox textBox)
        {
            if (IsTextboxEmpty(textBox))
            {
                ChangeBorder(textBox);
                return true;
            }
            return false;
        }

        private string SelectedRole()
        {
            if (TeacherRbtn.Checked) { return "teacher"; } else { return "student"; }
        }

        private static void ChangeBorder(Guna2TextBox textBox)
        {
            textBox.BorderColor = Color.FromArgb(243, 36, 36);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string role = "";
            string username = UsernameTxt.Text.Trim();
            string password = PasswordTxt.Text;
            string confirm_password = CpwTxt.Text;
            string email = EmailTxt.Text;
            bool isAnyTextboxEmpty = false;

            // Check each textbox using the new method
            isAnyTextboxEmpty |= CheckandChange(UsernameTxt);
            isAnyTextboxEmpty |= CheckandChange(PasswordTxt);
            isAnyTextboxEmpty |= CheckandChange(CpwTxt);
            isAnyTextboxEmpty |= CheckandChange(EmailTxt);

            if (isAnyTextboxEmpty) { return; }

            if (confirm_password != password)
            {
                ChangeBorder(CpwTxt);
                return;
            }

            role = SelectedRole();
            IUser newUser = new User(
                "Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True",
                role);
            int result = newUser.Create(username, password, email);

            // thuc thi truy van 
            if (result == 1)
            {
                MessageBox.Show("Sign up success");
            }
            else
            {
                MessageBox.Show("Sign up failed");
            }

            /*
            using (SqlConnection con = new("Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = " insert into Users (username, password, email, role) values (@username, @password, @email, @role)";

                role = SelectedRole();
                using (SqlCommand cmd = new(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@role", role);

                    // thuc thi truy van 
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Sign up success");
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed");
                    }
                }
            }
            */
        }
    }
}
