namespace UniversityActivityManagementSystem.WorkBenchForManager
{
    partial class tb_StuActivity_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tb_StuActivity_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_UAMSDataSet = new UniversityActivityManagementSystem.db_UAMSDataSet();
            this.dbUAMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_UAMSDataSet1 = new UniversityActivityManagementSystem.db_UAMSDataSet1();
            this.tbStudentActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_StudentActivityTableAdapter = new UniversityActivityManagementSystem.db_UAMSDataSet1TableAdapters.tb_StudentActivityTableAdapter();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUAMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentActivityBindingSource)).BeginInit();
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
            this.recordIDDataGridViewTextBoxColumn,
            this.studentMailDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.participationTimeDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbStudentActivityBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 593);
            this.dataGridView1.TabIndex = 0;
            // 
            // db_UAMSDataSet
            // 
            this.db_UAMSDataSet.DataSetName = "db_UAMSDataSet";
            this.db_UAMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbUAMSDataSetBindingSource
            // 
            this.dbUAMSDataSetBindingSource.DataSource = this.db_UAMSDataSet;
            this.dbUAMSDataSetBindingSource.Position = 0;
            // 
            // db_UAMSDataSet1
            // 
            this.db_UAMSDataSet1.DataSetName = "db_UAMSDataSet1";
            this.db_UAMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStudentActivityBindingSource
            // 
            this.tbStudentActivityBindingSource.DataMember = "tb_StudentActivity";
            this.tbStudentActivityBindingSource.DataSource = this.db_UAMSDataSet1;
            // 
            // tb_StudentActivityTableAdapter
            // 
            this.tb_StudentActivityTableAdapter.ClearBeforeFill = true;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            // 
            // studentMailDataGridViewTextBoxColumn
            // 
            this.studentMailDataGridViewTextBoxColumn.DataPropertyName = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.HeaderText = "StudentMail";
            this.studentMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentMailDataGridViewTextBoxColumn.Name = "studentMailDataGridViewTextBoxColumn";
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            // 
            // participationTimeDataGridViewTextBoxColumn
            // 
            this.participationTimeDataGridViewTextBoxColumn.DataPropertyName = "ParticipationTime";
            this.participationTimeDataGridViewTextBoxColumn.HeaderText = "ParticipationTime";
            this.participationTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.participationTimeDataGridViewTextBoxColumn.Name = "participationTimeDataGridViewTextBoxColumn";
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
            // 
            // tb_StuActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 593);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tb_StuActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tb_StuActivity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tb_StuActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUAMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentActivityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbUAMSDataSetBindingSource;
        private db_UAMSDataSet db_UAMSDataSet;
        private db_UAMSDataSet1 db_UAMSDataSet1;
        private System.Windows.Forms.BindingSource tbStudentActivityBindingSource;
        private db_UAMSDataSet1TableAdapters.tb_StudentActivityTableAdapter tb_StudentActivityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
    }
}