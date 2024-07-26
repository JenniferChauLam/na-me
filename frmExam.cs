using GradingSystem.Class_collection;
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

namespace GradingSystem.frm_Collection
{
    public partial class frmExam : Form
    {
        public frmExam()
        {
            InitializeComponent();

            ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
            ListExam.ListViewItemSorter = lvwColumnSorter;
            getTests();

        }

        private void getTests()
        {

            ListExam.Items.Clear();

            using (SqlConnection connection = new(Config.ConnectionString))
            {
                connection.Open();
                string query = "select * from Exams";
                using (SqlCommand command = new(query, connection))
                {
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            System.Windows.Forms.ListViewItem test = new(oReader["exam_id"].ToString());

                            test.SubItems.Add(oReader["exam_name"].ToString());
                            //label1.Text = oReader["exam_name"].ToString();
                            test.SubItems.Add(oReader["start_time"].ToString());
                            test.SubItems.Add(oReader["end_time"].ToString());
                            test.SubItems.Add(oReader["teacher_id"].ToString());
                            test.SubItems.Add(oReader["time_limit_int"].ToString()); //REmember to remove INT

                            ListExam.Items.Add(test);
                        }
                    }
                }

                connection.Close();

            }

        }

        private void ListExam_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (ListExam.ListViewItemSorter == null) return;

            ListViewColumnSorter lvwColumnSorter = (ListViewColumnSorter)ListExam.ListViewItemSorter;

            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            ListExam.Sort();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FrmCreateExam create = new();
            create.ShowDialog();
        }

    }
}
