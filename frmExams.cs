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
    public partial class FrmExams : Form
    {

        string connectionString = "Data Source=JENLAP\\MSSQLSERVERNO;Initial Catalog=GradingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public FrmExams()
        {
            InitializeComponent();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            setSQL("10");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            label4.Text = textBox1.Text;

        }


        private void setSQL(string teacher_id)
        {
            int exam_id = 123333;
            string exam_name = textBox1.Text;
            label1.Text = teacher_id;
            //teacher_id = "10";
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



        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";//file questions what type?
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
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
    }
}
