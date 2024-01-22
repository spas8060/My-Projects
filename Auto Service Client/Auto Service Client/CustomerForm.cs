using Autoservice_Client_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Service_Client
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            errCustomForm.SetError(tbCarNo, "");
            errCustomForm.SetError(tbName, "");
            errCustomForm.SetError(tbAdress, "");
            errCustomForm.SetError(tbMake, "");

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if (tbCarNo.Text == "")
            {
                errCustomForm.SetError(tbCarNo, "Please specify a valid car number!");
                flag = false;
            }
            else
                errCustomForm.SetError(tbCarNo, "");

            if (tbCarNo.Text == "")
            {
                errCustomForm.SetError(tbName, "Please specify a valid name!");
                flag = false;
            }
            else
                errCustomForm.SetError(tbName, "");
                 if (tbCarNo.Text == "")
            {
                errCustomForm.SetError(tbAdress, "Please specify a valid adress!");
                flag = false;
            }
            else
                errCustomForm.SetError(tbCarNo, "");
                if (tbCarNo.Text == "")
            {
                errCustomForm.SetError(tbCarNo, "Please specify a valid make");
                flag = false;
            }
            else
                errCustomForm.SetError(tbCarNo, "");

            if (flag == false)
            {
                return;

            }
            else
                MessageBox.Show("Database updated !");



            this.Validate();
            tblCustomerBindingSource.EndEdit();
            tblCustomerTableAdapter.Update(database1DataSet21);
            MessageBox.Show("The Customer Table is updated");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            database1DataSet21.Clear();
            tblCustomerTableAdapter.Fill(this.database1DataSet21.tblCustomer);

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet21.tblCustomer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.tblCustomerTableAdapter.Fill(this.database1DataSet21.tblCustomer);

        }

        private void btnCnacel_Click(object sender, EventArgs e)
        {

            database1DataSet21.Clear();
            tblCustomerTableAdapter.Update(database1DataSet21);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.tblCustomerBindingSource.MovePrevious();
            currentPosition();

        }
        private void currentPosition()
        {
            int CurrentPosition, rowNumber;
            rowNumber = tblCustomerBindingSource.Count;
            CurrentPosition = tblCustomerBindingSource.Position + 1;
            tbContext.Text=CurrentPosition.ToString() +"of" +rowNumber.ToString();
        }
    }
}
