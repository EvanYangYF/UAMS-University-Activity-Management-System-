using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForStudent;

namespace UniversityActivityManagementSystem
{
    public partial class Main_Form_Student : Form
    {
        public Main_Form_Student()
        {
            InitializeComponent();
        }

        DataOperator dataoper = new DataOperator();

        private void Main_Form_Student_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            string sql = "select Name from tb_User where KeanMail='" + PublicClass.loginKeanMail + "'";
            DataSet ds = dataoper.GetDataSet(sql);
            string fullName = ds.Tables[0].Rows[0][0].ToString();
            string firstName = fullName.Split(' ')[0];

            WelcomeBack_Label.Text = "Welcome Back, " + firstName + "!";
        }

        private void Main_Form_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PersonalInfo_Button_Click(object sender, EventArgs e)
        {
            PersonalInfo_Form personalInfo = new PersonalInfo_Form();
            personalInfo.Show();
        }

        private void SearchActivity_Button_Click(object sender, EventArgs e)
        {
            SearchActivity_Form_Stu searchActivity_Form_Stu = new SearchActivity_Form_Stu();
            searchActivity_Form_Stu.Show();
        }

        private void MyActivity_Button_Click(object sender, EventArgs e)
        {
            MyActivity_Form_Stu myActivity_Form_Stu = new MyActivity_Form_Stu();
            myActivity_Form_Stu.Show();
        }

        private void PersonalSum_Button_Click(object sender, EventArgs e)
        {
            PersonalSummary_Form personalSummary_Form = new PersonalSummary_Form();
            personalSummary_Form.Show();
        }
    }
}
