namespace Auto_Service_Client
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.lblCarNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.tbCarNo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCnacel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.bntNext = new System.Windows.Forms.Button();
            this.errCustomForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.database1DataSet21 = new Auto_Service_Client.Database1DataSet2();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new Auto_Service_Client.Database1DataSet2TableAdapters.tblCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errCustomForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarNo
            // 
            this.lblCarNo.AutoSize = true;
            this.lblCarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNo.Location = new System.Drawing.Point(57, 39);
            this.lblCarNo.Name = "lblCarNo";
            this.lblCarNo.Size = new System.Drawing.Size(87, 25);
            this.lblCarNo.TabIndex = 0;
            this.lblCarNo.Text = "Car No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(384, 39);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(87, 25);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adress:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(384, 99);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(72, 25);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // tbCarNo
            // 
            this.tbCarNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CarNo", true));
            this.errCustomForm.SetError(this.tbCarNo, "Error");
            this.tbCarNo.Location = new System.Drawing.Point(159, 43);
            this.tbCarNo.Name = "tbCarNo";
            this.tbCarNo.Size = new System.Drawing.Size(191, 22);
            this.tbCarNo.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Name", true));
            this.errCustomForm.SetError(this.tbName, "Error");
            this.tbName.Location = new System.Drawing.Point(159, 102);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(191, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbAdress
            // 
            this.tbAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Adress", true));
            this.errCustomForm.SetError(this.tbAdress, "Errror");
            this.tbAdress.Location = new System.Drawing.Point(493, 43);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(191, 22);
            this.tbAdress.TabIndex = 6;
            // 
            // tbMake
            // 
            this.tbMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Make", true));
            this.errCustomForm.SetError(this.tbMake, "Error");
            this.tbMake.Location = new System.Drawing.Point(493, 99);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(191, 22);
            this.tbMake.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCnacel
            // 
            this.btnCnacel.Location = new System.Drawing.Point(373, 228);
            this.btnCnacel.Name = "btnCnacel";
            this.btnCnacel.Size = new System.Drawing.Size(98, 46);
            this.btnCnacel.TabIndex = 10;
            this.btnCnacel.Text = "Cancel";
            this.btnCnacel.UseVisualStyleBackColor = true;
            this.btnCnacel.Click += new System.EventHandler(this.btnCnacel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(235, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 46);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(192, 397);
            this.tbContext.Name = "tbContext";
            this.tbContext.Size = new System.Drawing.Size(336, 22);
            this.tbContext.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(46, 385);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(98, 46);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // bntNext
            // 
            this.bntNext.Location = new System.Drawing.Point(567, 385);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(98, 46);
            this.bntNext.TabIndex = 14;
            this.bntNext.Text = "Next";
            this.bntNext.UseVisualStyleBackColor = true;
            // 
            // errCustomForm
            // 
            this.errCustomForm.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(297, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // database1DataSet21
            // 
            this.database1DataSet21.DataSetName = "Database1DataSet2";
            this.database1DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.database1DataSet21;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.bntNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tbContext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCnacel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCarNo);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCarNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errCustomForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox tbCarNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCnacel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbContext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.ErrorProvider errCustomForm;
        private System.Windows.Forms.Button btnUpdate;
        private Database1DataSet2 database1DataSet21;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private Database1DataSet2TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
    }
}