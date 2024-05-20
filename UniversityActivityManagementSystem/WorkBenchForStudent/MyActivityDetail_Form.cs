using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem.WorkBenchForStudent
{
    public partial class MyActivityDetail_Form : Form
    {
        public MyActivityDetail_Form()
        {
            InitializeComponent();
        }

        public void LoadStudentActivityDetails(int recordId, string studentMail, int activityId, DateTime participationTime, string attendenceStatus, Decimal duration, string description)
        {
            lblRecordId.Text = recordId.ToString();
            lblStudentMail.Text = studentMail;
            lblActivityId.Text = activityId.ToString();
            lblParticipationTime.Text = participationTime.ToString();
            lblAttendenceStatus.Text = attendenceStatus;
            lblDuration.Text = duration.ToString();
            lblDescription.Text = description;
        }

        private void MyActivityDetail_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }
    }
}
