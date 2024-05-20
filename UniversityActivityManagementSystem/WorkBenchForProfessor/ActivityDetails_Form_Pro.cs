using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    public partial class ActivityDetails_Form : Form
    {
        private string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
        private int activityId;

        public ActivityDetails_Form(int activityId)
        {
            InitializeComponent();
            this.activityId = activityId;
            LoadStudentActivityData();
        }

        private void LoadStudentActivityData()
        {
            string query = "SELECT * FROM tb_StudentActivity WHERE ActivityID = @ActivityID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ActivityID", activityId);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                StudentActivity_dataGridView.DataSource = dataTable;
            }
        }

        private void StudentActivity_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (StudentActivity_dataGridView.Columns[e.ColumnIndex].Name == "AttendanceStatus")
            {
                if (e.Value.ToString() == "Presence")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void StudentActivity_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = StudentActivity_dataGridView.Rows[e.RowIndex];
                int recordId = Convert.ToInt32(selectedRow.Cells["RecordID"].Value);
                string currentStatus = selectedRow.Cells["AttendanceStatus"].Value.ToString();

                string newStatus = currentStatus == "Presence" ? "Absent" : "Presence";
                UpdateAttendanceStatus(recordId, newStatus);
                LoadStudentActivityData();
            }
            StudentActivity_dataGridView.ClearSelection();
        }

        private void UpdateAttendanceStatus(int recordId, string newStatus)
        {
            string query = "UPDATE tb_StudentActivity SET AttendanceStatus = @NewStatus WHERE RecordID = @RecordID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewStatus", newStatus);
                command.Parameters.AddWithValue("@RecordID", recordId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void ActivityDetails_Form_Activated(object sender, EventArgs e)
        {
            StudentActivity_dataGridView.ClearSelection();
        }

        private void ActivityDetails_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
        }
    }
}
