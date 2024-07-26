using GradingSystem.Class_collection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GradingSystem.frm_Collection
{
    public partial class FrmCreateExam : Form
    {

        string connectionString = "Data Source=Data Source=JENLAP\\MSSQLSERVERNO;Initial Catalog=GradingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public FrmCreateExam()
        {
            InitializeComponent();
        }
        private void label1_Click_1(object sender, EventArgs e)
        { 
            setSQL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            label4.Text = ExamName.Text;

        }


        private void setSQL()
        {
            int exam_id = 123333;
            string exam_name = ExamName.Text;
            //label1.Text = teacher_id;
            string teacher_id = "10";
            label4.Text = exam_name;
            int time_limit = Convert.ToInt32(numericUpDown2.Value); ;
            DateTime start_time = guna2DateTimePicker1.Value;
            DateTime end_time = guna2DateTimePicker2.Value;

            using (SqlConnection connection = new(connectionString))
            {
                int result = 0;
                connection.Open();
                string query = "insert into Exams (exam_name, start_time, end_time, teacher_id, time_limit_int) values (@exam_name, @start_time, @end_time, @teacher_id, @time_limit)";
                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@exam_id", exam_id);
                    command.Parameters.AddWithValue("@exam_name", exam_name);
                    command.Parameters.AddWithValue("@start_time", start_time);
                    command.Parameters.AddWithValue("@end_time", end_time);
                    command.Parameters.AddWithValue("@teacher_id", teacher_id);
                    command.Parameters.AddWithValue("@time_limit", time_limit);
                    result = command.ExecuteNonQuery();
                }
            }


            //return result;
        }



        





        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    numericUpDown1.Maximum = 5;
        //    numericUpDown1.Minimum = 0;
        //}

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
            int minutes = Convert.ToInt32(numericUpDown2.Value);
            label1.Text = minutes.ToString();

        }

        //private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        //{
        //    numericUpDown3.Maximum = 59;
        //    numericUpDown3.Minimum = 0;
        //}



        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime end_date = guna2DateTimePicker2.Value;
            DateTime start_date = guna2DateTimePicker1.Value;
            if (end_date < start_date)
            {
                string message = "End date must be the same as or after current date";
                string title = "Invalid end date";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                // end_date = start_date;
                if (result == DialogResult.OK) { guna2DateTimePicker2.Value = guna2DateTimePicker1.Value; return; }
            }
        }

        private void addExam()
        {
            try
            {
                string examName = ExamName.Text;

                if (string.IsNullOrEmpty(examName))
                {
                    MessageBox.Show("Please enter the exam name.");
                    return;
                }

                using (SqlConnection conn = new (Config.ConnectionString))
                {
                    conn.Open();

                    // Retrieve the next examID
                    int newExamID = 1; // Default to 1 if there are no records
                    string getMaxIdQuery = "select ISNULL(MAX(exam_id), 0) + 1 from Exams";

                    using (SqlCommand cmd = new (getMaxIdQuery, conn))
                    {
                        newExamID = (int)cmd.ExecuteScalar();
                    }

                    // Insert the new exam record with the incremented examID
                    string insertQuery = "insert into Exams (exam_id, exam_name) values (@examID, @examName)";

                    using (SqlCommand cmd = new (insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@examID", newExamID);
                        cmd.Parameters.AddWithValue("@examName", examName);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Exam inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert exam.");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

       
        private void QuestionPage_Click(object sender, EventArgs e)
        {
            addExam();
            QuestionDetails create = new();
            create.updateButton.BringToFront();
            create.questionID.ReadOnly = false;
            create.examID.ReadOnly = false;
            create.pointTxt.ReadOnly = false;
            create.QuestionContent.ReadOnly = false;
            create.OptionATxt.ReadOnly = false;
            create.OptionBTxt.ReadOnly = false;
            create.OptionCTxt.ReadOnly = false;
            create.OptionDTxt.ReadOnly = false;
            create.radioButtonA.Visible = true;
            create.radioButtonB.Visible = true;
            create.radioButtonC.Visible = true;
            create.radioButtonD.Visible = true;
            create.ShowDialog();
        }
    }
}
