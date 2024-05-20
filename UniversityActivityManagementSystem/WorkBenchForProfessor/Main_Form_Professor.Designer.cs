namespace UniversityActivityManagementSystem
{
    partial class Main_Form_Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form_Professor));
            this.WelcomeBack_Label = new System.Windows.Forms.Label();
            this.PersonalInfo_Button = new System.Windows.Forms.Button();
            this.ActivityRelease_Button = new System.Windows.Forms.Button();
            this.ActivityManage_Button = new System.Windows.Forms.Button();
            this.ActivityReport_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeBack_Label
            // 
            this.WelcomeBack_Label.AutoSize = true;
            this.WelcomeBack_Label.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBack_Label.Location = new System.Drawing.Point(96, 28);
            this.WelcomeBack_Label.Name = "WelcomeBack_Label";
            this.WelcomeBack_Label.Size = new System.Drawing.Size(314, 47);
            this.WelcomeBack_Label.TabIndex = 7;
            this.WelcomeBack_Label.Text = "Welcome Back, ";
            // 
            // PersonalInfo_Button
            // 
            this.PersonalInfo_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.PersonalInfo_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo_Button.Location = new System.Drawing.Point(12, 108);
            this.PersonalInfo_Button.Name = "PersonalInfo_Button";
            this.PersonalInfo_Button.Size = new System.Drawing.Size(329, 67);
            this.PersonalInfo_Button.TabIndex = 8;
            this.PersonalInfo_Button.Text = "1. Personal Information";
            this.PersonalInfo_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonalInfo_Button.UseVisualStyleBackColor = false;
            this.PersonalInfo_Button.Click += new System.EventHandler(this.PersonalInfo_Button_Click);
            // 
            // ActivityRelease_Button
            // 
            this.ActivityRelease_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.ActivityRelease_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityRelease_Button.Location = new System.Drawing.Point(12, 195);
            this.ActivityRelease_Button.Name = "ActivityRelease_Button";
            this.ActivityRelease_Button.Size = new System.Drawing.Size(329, 67);
            this.ActivityRelease_Button.TabIndex = 9;
            this.ActivityRelease_Button.Text = "2. Activity Release";
            this.ActivityRelease_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActivityRelease_Button.UseVisualStyleBackColor = false;
            this.ActivityRelease_Button.Click += new System.EventHandler(this.ActivityRelease_Button_Click);
            // 
            // ActivityManage_Button
            // 
            this.ActivityManage_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.ActivityManage_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityManage_Button.Location = new System.Drawing.Point(359, 108);
            this.ActivityManage_Button.Name = "ActivityManage_Button";
            this.ActivityManage_Button.Size = new System.Drawing.Size(250, 67);
            this.ActivityManage_Button.TabIndex = 10;
            this.ActivityManage_Button.Text = "3. Activity Manage";
            this.ActivityManage_Button.UseVisualStyleBackColor = false;
            this.ActivityManage_Button.Click += new System.EventHandler(this.ActivityManage_Button_Click);
            // 
            // ActivityReport_Button
            // 
            this.ActivityReport_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.ActivityReport_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityReport_Button.Location = new System.Drawing.Point(359, 195);
            this.ActivityReport_Button.Name = "ActivityReport_Button";
            this.ActivityReport_Button.Size = new System.Drawing.Size(250, 67);
            this.ActivityReport_Button.TabIndex = 11;
            this.ActivityReport_Button.Text = "4. Activity Report";
            this.ActivityReport_Button.UseVisualStyleBackColor = false;
            this.ActivityReport_Button.Click += new System.EventHandler(this.ActivityReport_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityActivityManagementSystem.Properties.Resources.UAMS_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(621, 288);
            this.Controls.Add(this.ActivityReport_Button);
            this.Controls.Add(this.ActivityManage_Button);
            this.Controls.Add(this.ActivityRelease_Button);
            this.Controls.Add(this.PersonalInfo_Button);
            this.Controls.Add(this.WelcomeBack_Label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form_Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkBench - Professor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_Professor_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Professor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeBack_Label;
        private System.Windows.Forms.Button PersonalInfo_Button;
        private System.Windows.Forms.Button ActivityRelease_Button;
        private System.Windows.Forms.Button ActivityManage_Button;
        private System.Windows.Forms.Button ActivityReport_Button;
    }
}