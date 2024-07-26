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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            timer1.Start();
            DateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }

    }
}
