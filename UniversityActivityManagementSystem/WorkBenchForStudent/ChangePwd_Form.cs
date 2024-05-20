using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem
{
    public partial class ChangePwd_Form : Form
    {
        public ChangePwd_Form()
        {
            InitializeComponent();
        }
        DataOperator dataoper = new DataOperator();
        private void ChangePwd_Button_Click(object sender, EventArgs e)
        {
            string oldPassword = txtBox1.Text;
            string newPassword = textBox2.Text;
            string repeatPassword = textBox3.Text;

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("The password must only contain letters, numbers, and common symbols (e.g., !@). It must not contain Chinese characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != repeatPassword)
            {
                MessageBox.Show("New password and repeat password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "select Pwd from tb_User where KeanMail = '" + PublicClass.loginKeanMail + "'";
            DataSet ds = dataoper.GetDataSet(sql);
            string RealOldPwd = ds.Tables[0].Rows[0][0].ToString();
            if(RealOldPwd == oldPassword)
            {
                dataoper.ExecSQLResult("update tb_User set Pwd='" + newPassword + "' where KeanMail='" + PublicClass.loginKeanMail + "'");

                DialogResult result = MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Old Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^[a-zA-Z0-9!@#$%^&*()_+={}\[\]:;\""<>,.?/\\|~`-]+$";
            return Regex.IsMatch(password, pattern);
        }

        private void ChangePwd_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }
    }
}
