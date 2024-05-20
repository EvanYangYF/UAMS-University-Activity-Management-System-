namespace UniversityActivityManagementSystem.WorkBenchForManager
{
    partial class tb_User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tb_User_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_UAMSDataSet1 = new UniversityActivityManagementSystem.db_UAMSDataSet1();
            this.dbUAMSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UserTableAdapter = new UniversityActivityManagementSystem.db_UAMSDataSet1TableAdapters.tb_UserTableAdapter();
            this.keanMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rememberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUAMSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keanMailDataGridViewTextBoxColumn,
            this.pwdDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.rememberDataGridViewTextBoxColumn,
            this.autoLoginDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbUserBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_UAMSDataSet1
            // 
            this.db_UAMSDataSet1.DataSetName = "db_UAMSDataSet1";
            this.db_UAMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbUAMSDataSet1BindingSource
            // 
            this.dbUAMSDataSet1BindingSource.DataSource = this.db_UAMSDataSet1;
            this.dbUAMSDataSet1BindingSource.Position = 0;
            // 
            // tbUserBindingSource
            // 
            this.tbUserBindingSource.DataMember = "tb_User";
            this.tbUserBindingSource.DataSource = this.dbUAMSDataSet1BindingSource;
            // 
            // tb_UserTableAdapter
            // 
            this.tb_UserTableAdapter.ClearBeforeFill = true;
            // 
            // keanMailDataGridViewTextBoxColumn
            // 
            this.keanMailDataGridViewTextBoxColumn.DataPropertyName = "KeanMail";
            this.keanMailDataGridViewTextBoxColumn.HeaderText = "KeanMail";
            this.keanMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keanMailDataGridViewTextBoxColumn.Name = "keanMailDataGridViewTextBoxColumn";
            // 
            // pwdDataGridViewTextBoxColumn
            // 
            this.pwdDataGridViewTextBoxColumn.DataPropertyName = "Pwd";
            this.pwdDataGridViewTextBoxColumn.HeaderText = "Pwd";
            this.pwdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pwdDataGridViewTextBoxColumn.Name = "pwdDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // rememberDataGridViewTextBoxColumn
            // 
            this.rememberDataGridViewTextBoxColumn.DataPropertyName = "Remember";
            this.rememberDataGridViewTextBoxColumn.HeaderText = "Remember";
            this.rememberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rememberDataGridViewTextBoxColumn.Name = "rememberDataGridViewTextBoxColumn";
            // 
            // autoLoginDataGridViewTextBoxColumn
            // 
            this.autoLoginDataGridViewTextBoxColumn.DataPropertyName = "AutoLogin";
            this.autoLoginDataGridViewTextBoxColumn.HeaderText = "AutoLogin";
            this.autoLoginDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autoLoginDataGridViewTextBoxColumn.Name = "autoLoginDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // tbUserBindingSource1
            // 
            this.tbUserBindingSource1.DataMember = "tb_User";
            this.tbUserBindingSource1.DataSource = this.db_UAMSDataSet1;
            // 
            // tb_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tb_User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tb_User_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tb_User_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUAMSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbUAMSDataSet1BindingSource;
        private db_UAMSDataSet1 db_UAMSDataSet1;
        private System.Windows.Forms.BindingSource tbUserBindingSource;
        private db_UAMSDataSet1TableAdapters.tb_UserTableAdapter tb_UserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keanMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rememberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbUserBindingSource1;
    }
}