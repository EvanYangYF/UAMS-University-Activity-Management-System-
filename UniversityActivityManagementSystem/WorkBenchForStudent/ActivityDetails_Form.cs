using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem.WorkBenchForStudent
{
    public partial class ActivityDetails_Form : Form
    {
        public ActivityDetails_Form()
        {
            InitializeComponent();
        }

        public void LoadActivityDetails(int activityId, string activityName, DateTime dateTime, string location, string organizer, int participantLimit, int currentParticipants, string status, string duration, string description)
        {
            lblActivityId.Text = activityId.ToString();
            lblActivityName.Text = activityName;
            lblDateTime.Text = dateTime.ToString();
            lblLocation.Text = location;
            lblOrganizer.Text = organizer;
            lblParticipantLimit.Text = participantLimit.ToString();
            lblCurrentParticipants.Text = currentParticipants.ToString();
            lblStatus.Text = status;
            lblDuration.Text = duration;
            lblDescription.Text = description;
        }

        private void ActivityDetails_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }
    }
}
