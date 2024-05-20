using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    public partial class ActivityRelease_Form_Pro : Form
    {
        public ActivityRelease_Form_Pro()
        {
            InitializeComponent();
        }

        private void Publish_Button_Click(object sender, EventArgs e)
        {
            // 获取用户输入
            string activityName = ActivityName_TextBox.Text.Trim();
            DateTime dateTime = dateTimePicker.Value;
            string location = Location_TextBox.Text.Trim();
            int participantLimit;
            decimal duration;
            string description = Description_TextBox.Text.Trim();

            // 输入验证
            if (activityName.Length > 25)
            {
                MessageBox.Show("Activity Name cannot exceed 25 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTime < DateTime.Now.AddDays(7))
            {
                MessageBox.Show("Date Time must be at least one week from today.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (location.Length > 20)
            {
                MessageBox.Show("Location cannot exceed 20 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ParticipantLimit_TextBox.Text.Trim(), out participantLimit))
            {
                MessageBox.Show("Participant Limit must be an integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Duration_TextBox.Text.Trim(), out duration) || duration <= 0 || decimal.Round(duration, 1) != duration)
            {
                MessageBox.Show("Duration must be a positive decimal number with at most one decimal place.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (description.Length > 50)
            {
                MessageBox.Show("Description cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 获取当前登录用户的 Name
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string getUserQuery = "SELECT Name FROM tb_User WHERE KeanMail = @KeanMail";
            string organizerName = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand getUserCommand = new SqlCommand(getUserQuery, connection);
                    getUserCommand.Parameters.AddWithValue("@KeanMail", PublicClass.loginKeanMail);

                    SqlDataReader reader = getUserCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        organizerName = reader["Name"].ToString();
                    }
                    reader.Close();

                    if (string.IsNullOrEmpty(organizerName))
                    {
                        MessageBox.Show("Organizer not found.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 插入数据到数据库
                    string insertQuery = @"
                        INSERT INTO tb_Activity (ActivityName, DateTime, Location, ParticipantLimit, Duration, Description, Organizer, Status, CurrentParticipants)
                        VALUES (@ActivityName, @DateTime, @Location, @ParticipantLimit, @Duration, @Description, @Organizer, 'Registering', 0)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@ActivityName", activityName);
                    insertCommand.Parameters.AddWithValue("@DateTime", dateTime);
                    insertCommand.Parameters.AddWithValue("@Location", location);
                    insertCommand.Parameters.AddWithValue("@ParticipantLimit", participantLimit);
                    insertCommand.Parameters.AddWithValue("@Duration", duration);
                    insertCommand.Parameters.AddWithValue("@Description", description);
                    insertCommand.Parameters.AddWithValue("@Organizer", organizerName);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Activity published successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // 关闭当前窗口
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActivityRelease_Form_Pro_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }
    }
}
