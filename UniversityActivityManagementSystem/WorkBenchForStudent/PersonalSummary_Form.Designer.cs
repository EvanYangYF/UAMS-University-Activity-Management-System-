namespace UniversityActivityManagementSystem.WorkBenchForStudent
{
    partial class PersonalSummary_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalSummary_Form));
            this.PersonalSummary_dataGridView = new System.Windows.Forms.DataGridView();
            this.TotalDuration_label = new System.Windows.Forms.Label();
            this.Print_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalSummary_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalSummary_dataGridView
            // 
            this.PersonalSummary_dataGridView.AllowUserToAddRows = false;
            this.PersonalSummary_dataGridView.AllowUserToDeleteRows = false;
            this.PersonalSummary_dataGridView.AllowUserToResizeColumns = false;
            this.PersonalSummary_dataGridView.AllowUserToResizeRows = false;
            this.PersonalSummary_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonalSummary_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PersonalSummary_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonalSummary_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonalSummary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalSummary_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.PersonalSummary_dataGridView.Name = "PersonalSummary_dataGridView";
            this.PersonalSummary_dataGridView.ReadOnly = true;
            this.PersonalSummary_dataGridView.RowHeadersVisible = false;
            this.PersonalSummary_dataGridView.RowHeadersWidth = 62;
            this.PersonalSummary_dataGridView.RowTemplate.Height = 24;
            this.PersonalSummary_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonalSummary_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.PersonalSummary_dataGridView.TabIndex = 0;
            this.PersonalSummary_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PersonalSummary_dataGridView_CellFormatting_1);
            // 
            // TotalDuration_label
            // 
            this.TotalDuration_label.AutoSize = true;
            this.TotalDuration_label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDuration_label.Location = new System.Drawing.Point(775, 455);
            this.TotalDuration_label.Name = "TotalDuration_label";
            this.TotalDuration_label.Size = new System.Drawing.Size(76, 24);
            this.TotalDuration_label.TabIndex = 1;
            this.TotalDuration_label.Text = "******";
            this.TotalDuration_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Print_Button
            // 
            this.Print_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.Print_Button.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Print_Button.Location = new System.Drawing.Point(486, 455);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(236, 75);
            this.Print_Button.TabIndex = 12;
            this.Print_Button.Text = "Print";
            this.Print_Button.UseVisualStyleBackColor = false;
            this.Print_Button.Click += new System.EventHandler(this.PrintSummary_Button_Click);
            // 
            // PersonalSummary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 543);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.TotalDuration_label);
            this.Controls.Add(this.PersonalSummary_dataGridView);
            this.Font = new System.Drawing.Font("Cascadia Mono Light", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalSummary_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Summary";
            this.Activated += new System.EventHandler(this.PersonalSummary_Form_Activated);
            this.Load += new System.EventHandler(this.PersonalSummary_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalSummary_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonalSummary_dataGridView;
        private System.Windows.Forms.Label TotalDuration_label;
        private System.Windows.Forms.Button Print_Button;
    }
}