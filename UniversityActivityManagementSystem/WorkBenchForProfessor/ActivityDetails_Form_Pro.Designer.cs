namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    partial class ActivityDetails_Form
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityDetails_Form));
            this.StudentActivity_dataGridView = new System.Windows.Forms.DataGridView();
            this.Hint_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentActivity_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentActivity_dataGridView
            // 
            this.StudentActivity_dataGridView.AllowUserToAddRows = false;
            this.StudentActivity_dataGridView.AllowUserToDeleteRows = false;
            this.StudentActivity_dataGridView.AllowUserToResizeColumns = false;
            this.StudentActivity_dataGridView.AllowUserToResizeRows = false;
            this.StudentActivity_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentActivity_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentActivity_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentActivity_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentActivity_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentActivity_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.StudentActivity_dataGridView.Name = "StudentActivity_dataGridView";
            this.StudentActivity_dataGridView.RowHeadersVisible = false;
            this.StudentActivity_dataGridView.RowHeadersWidth = 62;
            this.StudentActivity_dataGridView.RowTemplate.Height = 30;
            this.StudentActivity_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentActivity_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.StudentActivity_dataGridView.TabIndex = 0;
            this.StudentActivity_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentActivity_dataGridView_CellDoubleClick);
            this.StudentActivity_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StudentActivity_dataGridView_CellFormatting);
            // 
            // Hint_Label
            // 
            this.Hint_Label.AutoSize = true;
            this.Hint_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint_Label.ForeColor = System.Drawing.Color.IndianRed;
            this.Hint_Label.Location = new System.Drawing.Point(152, 448);
            this.Hint_Label.Name = "Hint_Label";
            this.Hint_Label.Size = new System.Drawing.Size(890, 24);
            this.Hint_Label.TabIndex = 1;
            this.Hint_Label.Text = "Hint: Double-click a row to toggle attendance status between Present and Absent.";
            // 
            // ActivityDetails_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 485);
            this.Controls.Add(this.Hint_Label);
            this.Controls.Add(this.StudentActivity_dataGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActivityDetails_Form";
            this.Text = "Activity Details";
            this.Activated += new System.EventHandler(this.ActivityDetails_Form_Activated);
            this.Load += new System.EventHandler(this.ActivityDetails_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentActivity_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView StudentActivity_dataGridView;
        private System.Windows.Forms.Label Hint_Label;
    }
}
