namespace UniversityActivityManagementSystem
{
    partial class SearchActivity_Form_Stu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchActivity_Form_Stu));
            this.ActivitySearch_dataGridView = new System.Windows.Forms.DataGridView();
            this.db_UAMSDataSet = new UniversityActivityManagementSystem.db_UAMSDataSet();
            this.tbActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ActivityTableAdapter = new UniversityActivityManagementSystem.db_UAMSDataSetTableAdapters.tb_ActivityTableAdapter();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.ParticipateIn_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitySearch_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbActivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivitySearch_dataGridView
            // 
            this.ActivitySearch_dataGridView.AllowUserToAddRows = false;
            this.ActivitySearch_dataGridView.AllowUserToDeleteRows = false;
            this.ActivitySearch_dataGridView.AllowUserToResizeColumns = false;
            this.ActivitySearch_dataGridView.AllowUserToResizeRows = false;
            this.ActivitySearch_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActivitySearch_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ActivitySearch_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ActivitySearch_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActivitySearch_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivitySearch_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.ActivitySearch_dataGridView.Name = "ActivitySearch_dataGridView";
            this.ActivitySearch_dataGridView.ReadOnly = true;
            this.ActivitySearch_dataGridView.RowHeadersVisible = false;
            this.ActivitySearch_dataGridView.RowHeadersWidth = 62;
            this.ActivitySearch_dataGridView.RowTemplate.Height = 30;
            this.ActivitySearch_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActivitySearch_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.ActivitySearch_dataGridView.TabIndex = 0;
            this.ActivitySearch_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.ActivitySearch_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.ActivitySearch_dataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseEnter);
            this.ActivitySearch_dataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellMouseLeave);
            // 
            // db_UAMSDataSet
            // 
            this.db_UAMSDataSet.DataSetName = "db_UAMSDataSet";
            this.db_UAMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbActivityBindingSource
            // 
            this.tbActivityBindingSource.DataMember = "tb_Activity";
            this.tbActivityBindingSource.DataSource = this.db_UAMSDataSet;
            // 
            // tb_ActivityTableAdapter
            // 
            this.tb_ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.Location = new System.Drawing.Point(418, 392);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(135, 36);
            this.btnPreviousPage.TabIndex = 1;
            this.btnPreviousPage.Text = "Previous Page";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(670, 392);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(135, 36);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPageNumber.Font = new System.Drawing.Font("Cascadia Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(559, 400);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(72, 20);
            this.lblPageNumber.TabIndex = 3;
            this.lblPageNumber.Text = "Page: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(329, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hints: Use activity ID to participate in specified activities";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(396, 451);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(65, 37);
            this.ID_Label.TabIndex = 5;
            this.ID_Label.Text = "ID:";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ID_TextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TextBox.Location = new System.Drawing.Point(473, 453);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(158, 35);
            this.ID_TextBox.TabIndex = 6;
            // 
            // ParticipateIn_Button
            // 
            this.ParticipateIn_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.ParticipateIn_Button.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipateIn_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ParticipateIn_Button.Location = new System.Drawing.Point(649, 443);
            this.ParticipateIn_Button.Name = "ParticipateIn_Button";
            this.ParticipateIn_Button.Size = new System.Drawing.Size(176, 52);
            this.ParticipateIn_Button.TabIndex = 12;
            this.ParticipateIn_Button.Text = "Participate In";
            this.ParticipateIn_Button.UseVisualStyleBackColor = false;
            this.ParticipateIn_Button.Click += new System.EventHandler(this.ParticipateIn_Button_Click);
            // 
            // SearchActivity_Form_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 543);
            this.Controls.Add(this.ParticipateIn_Button);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.ActivitySearch_dataGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchActivity_Form_Stu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Activity";
            this.Activated += new System.EventHandler(this.SearchActivity_Form_Stu_Activated);
            this.Load += new System.EventHandler(this.SearchActivity_Form_Stu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivitySearch_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_UAMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbActivityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActivitySearch_dataGridView;
        private db_UAMSDataSet db_UAMSDataSet;
        private System.Windows.Forms.BindingSource tbActivityBindingSource;
        private db_UAMSDataSetTableAdapters.tb_ActivityTableAdapter tb_ActivityTableAdapter;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Button ParticipateIn_Button;
    }
}