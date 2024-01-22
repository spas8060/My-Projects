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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet1.tblWorker". Sie können sie bei Bedarf verschieben oder entfernen.
            this.tblWorkerTableAdapter.Fill(this.database1DataSet1.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            database1DataSet1.Clear();
            tblWorkerTableAdapter.Fill(this.database1DataSet1.tblWorker);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            tblWorkerBindingSource.EndEdit();
            tblWorkerTableAdapter.Update(database1DataSet1);
            MessageBox.Show("The Worker Table is updated");

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tblWorkerBindingSource.AddNew();
            MessageBox.Show("The Worker Table is updated!");

        }

        private void btnCnacel_Click(object sender, EventArgs e)
        {
            database1DataSet1.Clear();
            tblWorkerTableAdapter.Update(database1DataSet1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblWorkerBindingSource.RemoveCurrent();
            MessageBox.Show("The worker Table is updated ! ");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
            this.Hide();

        }
    }
}
