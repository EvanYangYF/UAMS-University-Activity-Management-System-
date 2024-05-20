using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForManager;

namespace UniversityActivityManagementSystem
{
    public partial class Main_Form_Manager : Form
    {
        public Main_Form_Manager()
        {
            InitializeComponent();
        }

        private void Main_Form_Manager_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }

        private void tb1_Button_Click(object sender, EventArgs e)
        {
            tb_User_Form tb_User_Form = new tb_User_Form();
            tb_User_Form.ShowDialog();
        }

        private void tb2_button_Click(object sender, EventArgs e)
        {
            tb_Activity_Form tb_Activity_Form = new tb_Activity_Form();
            tb_Activity_Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_StuActivity_Form tb_StuActivity_Form = new tb_StuActivity_Form();
            tb_StuActivity_Form.ShowDialog();
        }

        private void Main_Form_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
