using GradingSystem.Class_collection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem.frm_Collection
{
    public partial class frmDashboard : Form
    {
        public string id;

        public frmDashboard()
        {
            InitializeComponent();
            timer1.Start();
            DateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
            QuestionCreated.Text = CountCreated("question_id", "Questions").ToString();
            ExamsCreated.Text = CountCreated("exam_id", "Exams").ToString();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }

        public void GetID(string ID)
        {
            id = ID;
        }

        private int CountCreated(string columnName, string tableName)
        {
            int count = 0;
            string query = $"select count({columnName}) from {tableName}";
            try
            {
                using (SqlConnection connection = new (Config.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new (query, connection))
                    {
                        // Use ExecuteScalar for single value result
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return count;
        }
    }
}
