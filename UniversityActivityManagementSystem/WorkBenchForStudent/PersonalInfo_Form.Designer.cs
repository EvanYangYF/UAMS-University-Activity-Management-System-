namespace UniversityActivityManagementSystem
{
    partial class PersonalInfo_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfo_Form));
            this.PersonalInfo_GroupBox = new System.Windows.Forms.GroupBox();
            this.AL_CheckBox = new System.Windows.Forms.CheckBox();
            this.RP_CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.ChangePwd_Button = new System.Windows.Forms.Button();
            this.PersonalInfo_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalInfo_GroupBox
            // 
            this.PersonalInfo_GroupBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PersonalInfo_GroupBox.Controls.Add(this.AL_CheckBox);
            this.PersonalInfo_GroupBox.Controls.Add(this.RP_CheckBox);
            this.PersonalInfo_GroupBox.Controls.Add(this.label1);
            this.PersonalInfo_GroupBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.PersonalInfo_GroupBox.Name = "PersonalInfo_GroupBox";
            this.PersonalInfo_GroupBox.Size = new System.Drawing.Size(426, 343);
            this.PersonalInfo_GroupBox.TabIndex = 0;
            this.PersonalInfo_GroupBox.TabStop = false;
            this.PersonalInfo_GroupBox.Text = "Personal Info";
            // 
            // AL_CheckBox
            // 
            this.AL_CheckBox.AutoSize = true;
            this.AL_CheckBox.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AL_CheckBox.Location = new System.Drawing.Point(262, 300);
            this.AL_CheckBox.Name = "AL_CheckBox";
            this.AL_CheckBox.Size = new System.Drawing.Size(146, 28);
            this.AL_CheckBox.TabIndex = 10;
            this.AL_CheckBox.Text = "Auto Login";
            this.AL_CheckBox.UseVisualStyleBackColor = true;
            this.AL_CheckBox.CheckedChanged += new System.EventHandler(this.AL_CheckBox_CheckedChanged);
            // 
            // RP_CheckBox
            // 
            this.RP_CheckBox.AutoSize = true;
            this.RP_CheckBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RP_CheckBox.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_CheckBox.Location = new System.Drawing.Point(24, 300);
            this.RP_CheckBox.Name = "RP_CheckBox";
            this.RP_CheckBox.Size = new System.Drawing.Size(223, 28);
            this.RP_CheckBox.TabIndex = 9;
            this.RP_CheckBox.Text = "Remember Password";
            this.RP_CheckBox.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 256);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:\r\n\r\nKean Mail:\r\n\r\nCategory:\r\n\r\nMajor:\r\n\r\n";
            // 
            // OK_Button
            // 
            this.OK_Button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(12, 361);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(146, 56);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ChangePwd_Button
            // 
            this.ChangePwd_Button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePwd_Button.Location = new System.Drawing.Point(164, 361);
            this.ChangePwd_Button.Name = "ChangePwd_Button";
            this.ChangePwd_Button.Size = new System.Drawing.Size(284, 56);
            this.ChangePwd_Button.TabIndex = 2;
            this.ChangePwd_Button.Text = "Change Password";
            this.ChangePwd_Button.UseVisualStyleBackColor = true;
            this.ChangePwd_Button.Click += new System.EventHandler(this.ChangePwd_Button_Click);
            // 
            // PersonalInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(455, 430);
            this.Controls.Add(this.ChangePwd_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.PersonalInfo_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalInfo_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalInfo";
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            this.PersonalInfo_GroupBox.ResumeLayout(false);
            this.PersonalInfo_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalInfo_GroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RP_CheckBox;
        private System.Windows.Forms.CheckBox AL_CheckBox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button ChangePwd_Button;
    }
}