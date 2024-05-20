namespace UniversityActivityManagementSystem
{
    partial class Main_Form_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form_Manager));
            this.tb1_Button = new System.Windows.Forms.Button();
            this.tb2_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1_Button
            // 
            this.tb1_Button.BackColor = System.Drawing.SystemColors.Menu;
            this.tb1_Button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1_Button.Location = new System.Drawing.Point(103, 28);
            this.tb1_Button.Name = "tb1_Button";
            this.tb1_Button.Size = new System.Drawing.Size(250, 67);
            this.tb1_Button.TabIndex = 3;
            this.tb1_Button.Text = "1. tb_User";
            this.tb1_Button.UseVisualStyleBackColor = false;
            this.tb1_Button.Click += new System.EventHandler(this.tb1_Button_Click);
            // 
            // tb2_button
            // 
            this.tb2_button.BackColor = System.Drawing.SystemColors.Menu;
            this.tb2_button.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2_button.Location = new System.Drawing.Point(103, 124);
            this.tb2_button.Name = "tb2_button";
            this.tb2_button.Size = new System.Drawing.Size(250, 67);
            this.tb2_button.TabIndex = 4;
            this.tb2_button.Text = "2. tb_Activity";
            this.tb2_button.UseVisualStyleBackColor = false;
            this.tb2_button.Click += new System.EventHandler(this.tb2_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Cascadia Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "3. tb_StuActivity";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(462, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb2_button);
            this.Controls.Add(this.tb1_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkBench - Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tb1_Button;
        private System.Windows.Forms.Button tb2_button;
        private System.Windows.Forms.Button button2;
    }
}