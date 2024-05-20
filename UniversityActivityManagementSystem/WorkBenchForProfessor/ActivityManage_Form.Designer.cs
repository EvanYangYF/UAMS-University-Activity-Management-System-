namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    partial class ActivityManager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityManager_Form));
            this.Activity_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.ViewDetails_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Activity_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Activity_dataGridView
            // 
            this.Activity_dataGridView.AllowUserToAddRows = false;
            this.Activity_dataGridView.AllowUserToDeleteRows = false;
            this.Activity_dataGridView.AllowUserToResizeColumns = false;
            this.Activity_dataGridView.AllowUserToResizeRows = false;
            this.Activity_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Activity_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Activity_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Activity_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Activity_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Activity_dataGridView.Location = new System.Drawing.Point(1, 1);
            this.Activity_dataGridView.Name = "Activity_dataGridView";
            this.Activity_dataGridView.ReadOnly = true;
            this.Activity_dataGridView.RowHeadersVisible = false;
            this.Activity_dataGridView.RowHeadersWidth = 62;
            this.Activity_dataGridView.RowTemplate.Height = 30;
            this.Activity_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Activity_dataGridView.ShowEditingIcon = false;
            this.Activity_dataGridView.Size = new System.Drawing.Size(1187, 432);
            this.Activity_dataGridView.TabIndex = 0;
            this.Activity_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Activity_dataGridView_CellClick);
            this.Activity_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Activity_dataGridView_CellFormatting);
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(396, 451);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(65, 37);
            this.ID_Label.TabIndex = 1;
            this.ID_Label.Text = "ID:";
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ID_TextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TextBox.Location = new System.Drawing.Point(473, 453);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(158, 35);
            this.ID_TextBox.TabIndex = 2;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.Delete_Button.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Location = new System.Drawing.Point(649, 443);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(176, 52);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // ViewDetails_Button
            // 
            this.ViewDetails_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.ViewDetails_Button.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetails_Button.Location = new System.Drawing.Point(850, 443);
            this.ViewDetails_Button.Name = "ViewDetails_Button";
            this.ViewDetails_Button.Size = new System.Drawing.Size(176, 52);
            this.ViewDetails_Button.TabIndex = 4;
            this.ViewDetails_Button.Text = "View Details";
            this.ViewDetails_Button.UseVisualStyleBackColor = false;
            this.ViewDetails_Button.Click += new System.EventHandler(this.ViewDetails_Button_Click);
            // 
            // ActivityManager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 512);
            this.Controls.Add(this.ViewDetails_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.ID_TextBox);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.Activity_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActivityManager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Manager";
            this.Activated += new System.EventHandler(this.ActivityManager_Form_Activated);
            this.Load += new System.EventHandler(this.ActivityManager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Activity_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView Activity_dataGridView;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button ViewDetails_Button;
    }
}
