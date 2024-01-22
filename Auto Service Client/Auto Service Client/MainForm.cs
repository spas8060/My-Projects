using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Service_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();    
            WorkerForm newForm = new WorkerForm();
            newForm.ShowDialog(this);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            newForm.ShowDialog(this);
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
