namespace UniversityActivityManagementSystem
{
    partial class ChangePwd_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwd_Form));
            this.OldPwd_Label = new System.Windows.Forms.Label();
            this.NewPwd_Label = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RepeatPwd_Label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ChangePwd_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPwd_Label
            // 
            this.OldPwd_Label.AutoSize = true;
            this.OldPwd_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPwd_Label.Location = new System.Drawing.Point(25, 19);
            this.OldPwd_Label.Name = "OldPwd_Label";
            this.OldPwd_Label.Size = new System.Drawing.Size(225, 37);
            this.OldPwd_Label.TabIndex = 5;
            this.OldPwd_Label.Text = "Old Password:";
            // 
            // NewPwd_Label
            // 
            this.NewPwd_Label.AutoSize = true;
            this.NewPwd_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPwd_Label.Location = new System.Drawing.Point(25, 70);
            this.NewPwd_Label.Name = "NewPwd_Label";
            this.NewPwd_Label.Size = new System.Drawing.Size(225, 37);
            this.NewPwd_Label.TabIndex = 6;
            this.NewPwd_Label.Text = "New Password:";
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(256, 20);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.PasswordChar = '*';
            this.txtBox1.Size = new System.Drawing.Size(261, 35);
            this.txtBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(256, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(261, 35);
            this.textBox2.TabIndex = 8;
            // 
            // RepeatPwd_Label
            // 
            this.RepeatPwd_Label.AutoSize = true;
            this.RepeatPwd_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPwd_Label.Location = new System.Drawing.Point(12, 121);
            this.RepeatPwd_Label.Name = "RepeatPwd_Label";
            this.RepeatPwd_Label.Size = new System.Drawing.Size(238, 32);
            this.RepeatPwd_Label.TabIndex = 9;
            this.RepeatPwd_Label.Text = "Repeat Password:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(256, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(261, 35);
            this.textBox3.TabIndex = 10;
            // 
            // ChangePwd_Button
            // 
            this.ChangePwd_Button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePwd_Button.Location = new System.Drawing.Point(134, 168);
            this.ChangePwd_Button.Name = "ChangePwd_Button";
            this.ChangePwd_Button.Size = new System.Drawing.Size(284, 56);
            this.ChangePwd_Button.TabIndex = 11;
            this.ChangePwd_Button.Text = "Change Password";
            this.ChangePwd_Button.UseVisualStyleBackColor = true;
            this.ChangePwd_Button.Click += new System.EventHandler(this.ChangePwd_Button_Click);
            // 
            // ChangePwd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(543, 240);
            this.Controls.Add(this.ChangePwd_Button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.RepeatPwd_Label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.NewPwd_Label);
            this.Controls.Add(this.OldPwd_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePwd_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePwd_Form";
            this.Load += new System.EventHandler(this.ChangePwd_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPwd_Label;
        private System.Windows.Forms.Label NewPwd_Label;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RepeatPwd_Label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ChangePwd_Button;
    }
}