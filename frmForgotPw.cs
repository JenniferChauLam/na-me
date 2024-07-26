using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

using GradingSystem.Class_collection;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace GradingSystem.frm_Collection
{
    public partial class frmForgotPw : Form
    {
        string verifyCode;
        public static string to;

        private string connectionString = "Data Source=TRANTRUONG;Initial Catalog=GradingSystem;Integrated Security=True;Trust Server Certificate=True";

        public frmForgotPw()
        {
            InitializeComponent();
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

        private static void ChangeBorder(Guna2TextBox textBox)
        {
            textBox.BorderColor = Color.FromArgb(243, 36, 36);
        }

        private static void ResetBorderChange(Guna2TextBox textBox)
        {
            textBox.BorderColor = Color.DarkGray;
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

        private string GenerateVerificationCode()
        {
            Random rnd = new();
            int random_code = rnd.Next(999999);
            return random_code.ToString();
        }

        private bool IsEmailBelongToUsername(string username, string email)
        {
            string emailFromUser = User.GetEmailFromUsername(connectionString, username);
            if (emailFromUser != email)
            {
                MessageBox.Show($"User does not exist or email does not belong to user. Please check and try again later.", "Error");
                return false;
            }
            return true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            bool areRequiredTextboxesEmpty =
                CheckandChange(Username)
                || CheckandChange(EmailTxt)
                || CheckandChange(Token);

            if (areRequiredTextboxesEmpty)
            {
                MessageBox.Show($"Please fill out all required fields.", "Error");
                return;
            }

            if (verifyCode.IsNullOrEmpty() ||
                verifyCode != Token.Text)
            {
                MessageBox.Show("Incorrect Verification Code. " +
                    "Make sure the Verification Code you typed is the one that has been sent to your email.", "Invalid Code");
                return;
            }

            if (CheckandChange(NewPw))
            {
                return;
            }

            string username = Username.Text.Trim();
            string email = EmailTxt.Text;
            string newpw = NewPw.Text;
            if (IsEmailBelongToUsername(username, email))
            {
                string userId = User.GetIdFromUsername(connectionString, username);
                string role = User.GetRoleFromUsername(connectionString, username);

                if (userId.IsNullOrEmpty())
                {
                    MessageBox.Show("User not found.");
                    return;
                }
                IUser user = new User(connectionString, role);
                bool success = user.Update(userId, password: newpw);

                if (success)
                {
                    MessageBox.Show($"Successfully updated password for user: {username}\n" +
                        "You can now log in using your new password.", "Success");
                    NewPw.Clear();
                    Token.Clear();
                    verifyCode = "";
                }
                else
                {
                    MessageBox.Show("Unable to change password.", "Error");
                }
            }
        }

        private void Sendcode_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show($"This is a password for {email} " +
                $"Your new password is {code}. Do not share to anyone");
            */

            bool areRequiredTextBoxesEmpty = CheckandChange(Username) || CheckandChange(EmailTxt);

            if (areRequiredTextBoxesEmpty)
            {
                return;
            }

            string username = Username.Text.Trim();
            string email = EmailTxt.Text;

            if (IsEmailBelongToUsername(username, email))
            {
                string code = GenerateVerificationCode();
                bool success = SendVerifyEmail(email, code);

                if (success)
                {
                    this.verifyCode = code;
                    MessageBox.Show($"Verification Code has been sent to {email}\n" +
                        $"Remember to check both your inbox and spam folder.", "Verification Sent");
                }
            }

        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool SendVerifyEmail(string email, string code)
        {
            // !! CẢNH BÁO !! Đừng up email và App Password lên Github!
            // Email dùng để gửi password mới cho User
            string senderEmail = "example@email.com";
            // App Password
            /*
             * To get App Password, sign into Google with the email you want to use.
             * Make sure it has 2-factor Authentication (xác thực bảo mật 2 chiều) enabled.
             * Go to "Manage your Google Account" (Quản Lý Tài Khoản Google)
             * Search "App Passwords" (Mật khẩu ứng dụng)
             * Make one, copy and paste it here. These passwords typically has 19 letters, space included.
             */
            string appPassword = "abcd efgh ijkl mnop";
            // DO NOT PUSH APP PASSWORD INTO GITHUB, STORE IT SOMEWHERE ELSE

            if (!ValidateEmail(email))
            {
                MessageBox.Show($"Invalid email format");
                return false;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(email);
                mail.Subject = "Grading System password recovery";
                mail.Body = $"Hello! You have recently requested to recover your account.\n" +
                    $"Do not share the contents of this email to anyone.\n\n" +
                    $"Here is your Verification Code: {code}";
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, appPassword);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                Trace.WriteLine("Mail sent");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot send email: " + ex.Message);
                MessageBox.Show($"An error occurred while sending email.", "Error");
                return false;
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            ResetBorderChange(Username);
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            ResetBorderChange(EmailTxt);
        }

        private void Token_TextChanged(object sender, EventArgs e)
        {
            ResetBorderChange(Token);
            if (verifyCode.IsNullOrEmpty() ||
                verifyCode != Token.Text)
            {
                PreviewPw.Checked = false;
                PreviewPw.Enabled = false;
                NewPw.Enabled = false;
            }
            else
            {
                PreviewPw.Enabled = true;
                NewPw.Enabled = true;
                ResetBorderChange(NewPw);
            }
        }

        private void NewPw_TextChanged(object sender, EventArgs e)
        {
            ResetBorderChange(NewPw);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PreviewPw_CheckedChanged(object sender, EventArgs e)
        {
            if (PreviewPw.Checked)
            {
                NewPw.PasswordChar = '\0';
            } else
            {
                NewPw.PasswordChar = '*';
            }
        }
    }
}
