using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForProfessor;

namespace UniversityActivityManagementSystem
{
    public partial class Main_Form_Professor : Form
    {
        public Main_Form_Professor()
        {
            InitializeComponent();
        }

        DataOperator dataoper = new DataOperator();

        private void Main_Form_Professor_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            string sql = "select Name from tb_User where KeanMail='" + PublicClass.loginKeanMail + "'";
            DataSet ds = dataoper.GetDataSet(sql);
            string fullName = ds.Tables[0].Rows[0][0].ToString();
            string firstName = fullName.Split(' ')[0];

            WelcomeBack_Label.Text = "Welcome Back, " + firstName + "!";
        }

        private void Main_Form_Professor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PersonalInfo_Button_Click(object sender, EventArgs e)
        {
            PersonalInfo_Form personalInfo = new PersonalInfo_Form();
            personalInfo.Show();
        }

        private void ActivityRelease_Button_Click(object sender, EventArgs e)
        {
            ActivityRelease_Form_Pro activityRelease_Form_Pro = new ActivityRelease_Form_Pro();
            activityRelease_Form_Pro.Show();
        }

        private void ActivityManage_Button_Click(object sender, EventArgs e)
        {
            ActivityManager_Form activityManager = new ActivityManager_Form();
            activityManager.Show();
        }

        private void ActivityReport_Button_Click(object sender, EventArgs e)
        {
            ActivityReport_Form activityReport_Form = new ActivityReport_Form();
            activityReport_Form.Show();
        }
    }
}
