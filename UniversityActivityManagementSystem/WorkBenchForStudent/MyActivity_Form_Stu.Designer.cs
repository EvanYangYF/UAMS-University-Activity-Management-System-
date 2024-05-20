namespace UniversityActivityManagementSystem
{
    partial class MyActivity_Form_Stu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyActivity_Form_Stu));
            this.MyActivity_dataGridView = new System.Windows.Forms.DataGridView();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblActivityId = new System.Windows.Forms.Label();
            this.txtActivityId = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyActivity_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyActivity_dataGridView
            // 
            this.MyActivity_dataGridView.AllowUserToAddRows = false;
            this.MyActivity_dataGridView.AllowUserToDeleteRows = false;
            this.MyActivity_dataGridView.AllowUserToResizeColumns = false;
            this.MyActivity_dataGridView.AllowUserToResizeRows = false;
            this.MyActivity_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyActivity_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MyActivity_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MyActivity_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyActivity_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyActivity_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.MyActivity_dataGridView.Name = "MyActivity_dataGridView";
            this.MyActivity_dataGridView.ReadOnly = true;
            this.MyActivity_dataGridView.RowHeadersVisible = false;
            this.MyActivity_dataGridView.RowHeadersWidth = 62;
            this.MyActivity_dataGridView.RowTemplate.Height = 28;
            this.MyActivity_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyActivity_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.MyActivity_dataGridView.TabIndex = 0;
            this.MyActivity_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyActivity_dataGridView_CellClick);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPageNumber.Font = new System.Drawing.Font("Cascadia Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(559, 400);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(72, 20);
            this.lblPageNumber.TabIndex = 2;
            this.lblPageNumber.Text = "Page: 0";
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
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
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
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblActivityId
            // 
            this.lblActivityId.AutoSize = true;
            this.lblActivityId.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityId.Location = new System.Drawing.Point(396, 451);
            this.lblActivityId.Name = "lblActivityId";
            this.lblActivityId.Size = new System.Drawing.Size(65, 37);
            this.lblActivityId.TabIndex = 4;
            this.lblActivityId.Text = "ID:";
            // 
            // txtActivityId
            // 
            this.txtActivityId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtActivityId.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityId.Location = new System.Drawing.Point(473, 453);
            this.txtActivityId.Name = "txtActivityId";
            this.txtActivityId.Size = new System.Drawing.Size(158, 35);
            this.txtActivityId.TabIndex = 6;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Menu;
            this.btnWithdraw.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(649, 443);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(176, 52);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHint.Location = new System.Drawing.Point(329, 509);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(549, 20);
            this.lblHint.TabIndex = 4;
            this.lblHint.Text = "Hints: Use activity ID to withdraw from specified activities";
            // 
            // MyActivity_Form_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 543);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtActivityId);
            this.Controls.Add(this.lblActivityId);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.MyActivity_dataGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyActivity_Form_Stu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Activities";
            this.Activated += new System.EventHandler(this.MyActivity_Form_Stu_Activated);
            this.Load += new System.EventHandler(this.MyActivity_Form_Stu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyActivity_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyActivity_dataGridView;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblActivityId;
        private System.Windows.Forms.TextBox txtActivityId;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblHint;
    }
}