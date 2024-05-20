namespace UniversityActivityManagementSystem
{
    partial class Main_Form_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form_Student));
            this.WelcomeBack_Label = new System.Windows.Forms.Label();
            this.PersonalInfo_Button = new System.Windows.Forms.Button();
            this.MyActivity_Button = new System.Windows.Forms.Button();
            this.PersonalSum_Button = new System.Windows.Forms.Button();
            this.SearchActivity_Button = new System.Windows.Forms.Button();
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
            this.WelcomeBack_Label.TabIndex = 0;
            this.WelcomeBack_Label.Text = "Welcome Back, ";
            // 
            // PersonalInfo_Button
            // 
            this.PersonalInfo_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.PersonalInfo_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo_Button.Location = new System.Drawing.Point(12, 108);
            this.PersonalInfo_Button.Name = "PersonalInfo_Button";
            this.PersonalInfo_Button.Size = new System.Drawing.Size(329, 67);
            this.PersonalInfo_Button.TabIndex = 1;
            this.PersonalInfo_Button.Text = "1. Personal Information";
            this.PersonalInfo_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonalInfo_Button.UseVisualStyleBackColor = false;
            this.PersonalInfo_Button.Click += new System.EventHandler(this.PersonalInfo_Button_Click);
            // 
            // MyActivity_Button
            // 
            this.MyActivity_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.MyActivity_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyActivity_Button.Location = new System.Drawing.Point(359, 108);
            this.MyActivity_Button.Name = "MyActivity_Button";
            this.MyActivity_Button.Size = new System.Drawing.Size(250, 67);
            this.MyActivity_Button.TabIndex = 2;
            this.MyActivity_Button.Text = "3. My Activity";
            this.MyActivity_Button.UseVisualStyleBackColor = false;
            this.MyActivity_Button.Click += new System.EventHandler(this.MyActivity_Button_Click);
            // 
            // PersonalSum_Button
            // 
            this.PersonalSum_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.PersonalSum_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalSum_Button.Location = new System.Drawing.Point(359, 195);
            this.PersonalSum_Button.Name = "PersonalSum_Button";
            this.PersonalSum_Button.Size = new System.Drawing.Size(250, 67);
            this.PersonalSum_Button.TabIndex = 3;
            this.PersonalSum_Button.Text = "4. Personal Summary";
            this.PersonalSum_Button.UseVisualStyleBackColor = false;
            this.PersonalSum_Button.Click += new System.EventHandler(this.PersonalSum_Button_Click);
            // 
            // SearchActivity_Button
            // 
            this.SearchActivity_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.SearchActivity_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchActivity_Button.Location = new System.Drawing.Point(12, 195);
            this.SearchActivity_Button.Name = "SearchActivity_Button";
            this.SearchActivity_Button.Size = new System.Drawing.Size(329, 67);
            this.SearchActivity_Button.TabIndex = 4;
            this.SearchActivity_Button.Text = "2. Search Activity";
            this.SearchActivity_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchActivity_Button.UseVisualStyleBackColor = false;
            this.SearchActivity_Button.Click += new System.EventHandler(this.SearchActivity_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityActivityManagementSystem.Properties.Resources.UAMS_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(621, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchActivity_Button);
            this.Controls.Add(this.PersonalSum_Button);
            this.Controls.Add(this.MyActivity_Button);
            this.Controls.Add(this.PersonalInfo_Button);
            this.Controls.Add(this.WelcomeBack_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkBench - Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_Student_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeBack_Label;
        private System.Windows.Forms.Button PersonalInfo_Button;
        private System.Windows.Forms.Button MyActivity_Button;
        private System.Windows.Forms.Button PersonalSum_Button;
        private System.Windows.Forms.Button SearchActivity_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}