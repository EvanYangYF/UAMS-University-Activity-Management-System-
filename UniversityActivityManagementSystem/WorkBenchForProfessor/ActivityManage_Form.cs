using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForStudent;

namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    public partial class ActivityManager_Form : Form
    {
        private string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
        private string professorName;

        public ActivityManager_Form()
        {
            InitializeComponent();
        }

        private void ActivityManager_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            LoadProfessorName();
            LoadActivityData();
        }

        private void LoadProfessorName()
        {
            string query = "SELECT Name FROM tb_User WHERE KeanMail = @KeanMail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KeanMail", PublicClass.loginKeanMail);
                connection.Open();
                professorName = command.ExecuteScalar().ToString();
            }
        }

        private void LoadActivityData()
        {
            string query = "SELECT * FROM tb_Activity WHERE Organizer = @Organizer ORDER BY DateTime DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Organizer", GetOrganizerName(PublicClass.loginKeanMail));
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Activity_dataGridView.DataSource = dataTable;
            }
        }


        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int activityId;
            if (int.TryParse(ID_TextBox.Text.Trim(), out activityId))
            {
                DeleteActivity(activityId);
                LoadActivityData();
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteActivity(int activityId)
        {
            // 获取当前登录教授的姓名
            string organizerName = GetOrganizerName(PublicClass.loginKeanMail);

            // 查询活动信息以确认当前登录教授是活动的发布者
            string checkActivityQuery = "SELECT COUNT(*) FROM tb_Activity WHERE ID = @ActivityID AND Organizer = @Organizer";
            string deleteActivityQuery = "DELETE FROM tb_Activity WHERE ID = @ActivityID";
            string deleteStudentActivityQuery = "DELETE FROM tb_StudentActivity WHERE ActivityID = @ActivityID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkActivityCommand = new SqlCommand(checkActivityQuery, connection);
                checkActivityCommand.Parameters.AddWithValue("@ActivityID", activityId);
                checkActivityCommand.Parameters.AddWithValue("@Organizer", organizerName);

                connection.Open();
                int activityCount = (int)checkActivityCommand.ExecuteScalar();

                if (activityCount == 0)
                {
                    MessageBox.Show("You can only delete activities that you have published.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand deleteActivityCommand = new SqlCommand(deleteActivityQuery, connection);
                deleteActivityCommand.Parameters.AddWithValue("@ActivityID", activityId);

                SqlCommand deleteStudentActivityCommand = new SqlCommand(deleteStudentActivityQuery, connection);
                deleteStudentActivityCommand.Parameters.AddWithValue("@ActivityID", activityId);

                SqlTransaction transaction = connection.BeginTransaction();
                deleteActivityCommand.Transaction = transaction;
                deleteStudentActivityCommand.Transaction = transaction;

                try
                {
                    deleteActivityCommand.ExecuteNonQuery();
                    deleteStudentActivityCommand.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Activity deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadActivityData(); // 重新加载活动数据
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 获取当前登录教授的姓名
        private string GetOrganizerName(string keanMail)
        {
            string query = "SELECT Name FROM tb_User WHERE KeanMail = @KeanMail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KeanMail", keanMail);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }


        private void Activity_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Activity_dataGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value.ToString() == "Registering")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void Activity_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Activity_dataGridView.Rows[e.RowIndex];
                int activityId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                ViewActivityDetails(activityId);
            }
        }

        private void ViewDetails_Button_Click(object sender, EventArgs e)
        {
            int activityId;
            if (int.TryParse(ID_TextBox.Text.Trim(), out activityId))
            {
                ViewActivityDetails(activityId);
            }
            else
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewActivityDetails(int activityId)
        {
            ActivityDetails_Form detailsForm = new ActivityDetails_Form(activityId);
            detailsForm.ShowDialog();
        }

        private void ActivityManager_Form_Activated(object sender, EventArgs e)
        {
            Activity_dataGridView.ClearSelection();
        }
    }
}
