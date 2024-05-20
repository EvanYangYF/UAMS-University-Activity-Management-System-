using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem
{
    public partial class PersonalInfo_Form : Form
    {
        public PersonalInfo_Form()
        {
            InitializeComponent();
        }

        DataOperator dataoper = new DataOperator();

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            string sql = "select Name,KeanMail,Category,Major,Remember,AutoLogin from tb_User where KeanMail='" + PublicClass.loginKeanMail + "'";
            DataSet ds = dataoper.GetDataSet(sql);
            string Name = ds.Tables[0].Rows[0][0].ToString();
            string KeanMail = ds.Tables[0].Rows[0][1].ToString();
            string Category = ds.Tables[0].Rows[0][2].ToString();
            string Major = ds.Tables[0].Rows[0][3].ToString();

            label1.Text = "Name: " + Name + "\n\n"
                + "Kean Mail: " + KeanMail + "\n\n"
                + "Category: " + Category + "\n\n"
                + "Major: " + Major + "\n";
            if (Convert.ToInt32(ds.Tables[0].Rows[0][4]) == 1)
            {
                RP_CheckBox.Checked = true;
            }
            if (Convert.ToInt32(ds.Tables[0].Rows[0][5]) == 1)
            {
                AL_CheckBox.Checked = true;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (AL_CheckBox.Checked)
            {
                dataoper.ExecSQLResult("update tb_User set Remember=1 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set AutoLogin=1 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set IP='" + PublicClass.IpAddress + "' where KeanMail='" + PublicClass.loginKeanMail + "'");
            }
            else if (RP_CheckBox.Checked)
            {
                dataoper.ExecSQLResult("update tb_User set Remember=1 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set AutoLogin=0 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set IP='" + PublicClass.IpAddress + "' where KeanMail='" + PublicClass.loginKeanMail + "'");
            }
            else
            {
                dataoper.ExecSQLResult("update tb_User set Remember=0 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set AutoLogin=0 where KeanMail='" + PublicClass.loginKeanMail + "'");
                dataoper.ExecSQLResult("update tb_User set IP=0 where KeanMail='" + PublicClass.loginKeanMail + "'");
            }
            this.Close();
        }

        private void AL_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AL_CheckBox.Checked)
            {
                RP_CheckBox.Checked = true;
            }
            else
            {
                RP_CheckBox.Checked = false;
            }
        }

        private void ChangePwd_Button_Click(object sender, EventArgs e)
        {
            ChangePwd_Form changePwd_Form = new ChangePwd_Form();
            changePwd_Form.Show();
        }
    }
}
