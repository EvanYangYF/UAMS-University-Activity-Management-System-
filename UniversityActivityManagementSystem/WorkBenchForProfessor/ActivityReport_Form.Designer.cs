namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    partial class ActivityReport_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView activityReport_dataGridView;
        private System.Windows.Forms.Button printReport_Button;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityReport_Form));
            this.activityReport_dataGridView = new System.Windows.Forms.DataGridView();
            this.printReport_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityReport_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activityReport_dataGridView
            // 
            this.activityReport_dataGridView.AllowUserToAddRows = false;
            this.activityReport_dataGridView.AllowUserToDeleteRows = false;
            this.activityReport_dataGridView.AllowUserToResizeColumns = false;
            this.activityReport_dataGridView.AllowUserToResizeRows = false;
            this.activityReport_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activityReport_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.activityReport_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.activityReport_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activityReport_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityReport_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.activityReport_dataGridView.Name = "activityReport_dataGridView";
            this.activityReport_dataGridView.ReadOnly = true;
            this.activityReport_dataGridView.RowHeadersVisible = false;
            this.activityReport_dataGridView.RowHeadersWidth = 62;
            this.activityReport_dataGridView.RowTemplate.Height = 30;
            this.activityReport_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityReport_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.activityReport_dataGridView.TabIndex = 0;
            // 
            // printReport_Button
            // 
            this.printReport_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.printReport_Button.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReport_Button.Location = new System.Drawing.Point(486, 455);
            this.printReport_Button.Name = "printReport_Button";
            this.printReport_Button.Size = new System.Drawing.Size(236, 75);
            this.printReport_Button.TabIndex = 1;
            this.printReport_Button.Text = "Print Report";
            this.printReport_Button.UseVisualStyleBackColor = false;
            this.printReport_Button.Click += new System.EventHandler(this.printReport_Button_Click);
            // 
            // ActivityReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 543);
            this.Controls.Add(this.printReport_Button);
            this.Controls.Add(this.activityReport_dataGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActivityReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Report";
            this.Load += new System.EventHandler(this.ActivityReport_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityReport_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
