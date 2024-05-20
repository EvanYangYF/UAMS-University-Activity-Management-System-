namespace UniversityActivityManagementSystem
{
    partial class Login_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Login_Label = new System.Windows.Forms.Label();
            this.KeanMail_Label = new System.Windows.Forms.Label();
            this.KeanMail_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.RP_CheckBox = new System.Windows.Forms.CheckBox();
            this.AL_CheckBox = new System.Windows.Forms.CheckBox();
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.IP_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Cascadia Mono", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(339, 9);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(415, 58);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Kean UAMS Login";
            // 
            // KeanMail_Label
            // 
            this.KeanMail_Label.AutoSize = true;
            this.KeanMail_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeanMail_Label.Location = new System.Drawing.Point(315, 81);
            this.KeanMail_Label.Name = "KeanMail_Label";
            this.KeanMail_Label.Size = new System.Drawing.Size(179, 40);
            this.KeanMail_Label.TabIndex = 1;
            this.KeanMail_Label.Text = "KeanMail:";
            // 
            // KeanMail_TextBox
            // 
            this.KeanMail_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.KeanMail_TextBox.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeanMail_TextBox.Location = new System.Drawing.Point(514, 86);
            this.KeanMail_TextBox.Name = "KeanMail_TextBox";
            this.KeanMail_TextBox.Size = new System.Drawing.Size(261, 35);
            this.KeanMail_TextBox.TabIndex = 3;
            this.KeanMail_TextBox.TextChanged += new System.EventHandler(this.KeanMail_TextBox_TextChanged);
            this.KeanMail_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeanMail_TextBox_KeyPress);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(315, 145);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(179, 40);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "Password:";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Password_TextBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(514, 145);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(261, 35);
            this.Password_TextBox.TabIndex = 5;
            this.Password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // RP_CheckBox
            // 
            this.RP_CheckBox.AutoSize = true;
            this.RP_CheckBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RP_CheckBox.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_CheckBox.Location = new System.Drawing.Point(349, 204);
            this.RP_CheckBox.Name = "RP_CheckBox";
            this.RP_CheckBox.Size = new System.Drawing.Size(223, 28);
            this.RP_CheckBox.TabIndex = 8;
            this.RP_CheckBox.Text = "Remember Password";
            this.RP_CheckBox.UseVisualStyleBackColor = false;
            // 
            // AL_CheckBox
            // 
            this.AL_CheckBox.AutoSize = true;
            this.AL_CheckBox.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AL_CheckBox.Location = new System.Drawing.Point(608, 204);
            this.AL_CheckBox.Name = "AL_CheckBox";
            this.AL_CheckBox.Size = new System.Drawing.Size(146, 28);
            this.AL_CheckBox.TabIndex = 9;
            this.AL_CheckBox.Text = "Auto Login";
            this.AL_CheckBox.UseVisualStyleBackColor = true;
            this.AL_CheckBox.CheckedChanged += new System.EventHandler(this.AL_CheckBox_CheckedChanged);
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.SignIn_Button.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIn_Button.Location = new System.Drawing.Point(477, 249);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(191, 58);
            this.SignIn_Button.TabIndex = 11;
            this.SignIn_Button.Text = "Sign In";
            this.SignIn_Button.UseVisualStyleBackColor = false;
            this.SignIn_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // IP_Label
            // 
            this.IP_Label.BackColor = System.Drawing.Color.Transparent;
            this.IP_Label.Font = new System.Drawing.Font("Cascadia Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Label.Location = new System.Drawing.Point(66, 284);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(185, 23);
            this.IP_Label.TabIndex = 12;
            this.IP_Label.Text = "ip: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityActivityManagementSystem.Properties.Resources.UAMS_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IP_Label);
            this.Controls.Add(this.SignIn_Button);
            this.Controls.Add(this.AL_CheckBox);
            this.Controls.Add(this.RP_CheckBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.KeanMail_TextBox);
            this.Controls.Add(this.KeanMail_Label);
            this.Controls.Add(this.Login_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label KeanMail_Label;
        private System.Windows.Forms.TextBox KeanMail_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.CheckBox RP_CheckBox;
        private System.Windows.Forms.CheckBox AL_CheckBox;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.Label IP_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

