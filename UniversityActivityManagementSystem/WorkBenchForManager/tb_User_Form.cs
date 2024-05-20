using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem.WorkBenchForManager
{
    public partial class tb_User_Form : Form
    {
        public tb_User_Form()
        {
            InitializeComponent();
        }

        private void tb_User_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            // TODO: 这行代码将数据加载到表“db_UAMSDataSet1.tb_User”中。您可以根据需要移动或移除它。
            this.tb_UserTableAdapter.Fill(this.db_UAMSDataSet1.tb_User);

        }
    }
}
