using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForStudent;

namespace UniversityActivityManagementSystem
{
    public partial class SearchActivity_Form_Stu : Form
    {
        private int pageSize = 15;
        private int currentPage = 1;
        private int totalRecords;
        private int totalPages;
        private DataTable dataTable;

        public SearchActivity_Form_Stu()
        {
            InitializeComponent();
        }

        private void SearchActivity_Form_Stu_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            LoadData();
        }


        private void LoadData()
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string query = "SELECT ID, ActivityName, DateTime, Location, Organizer, ParticipantLimit, CurrentParticipants, Status FROM dbo.tb_Activity ORDER BY DateTime DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    totalRecords = dataTable.Rows.Count;
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    LoadPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadPage()
        {
            DataTable pageTable = dataTable.Clone();
            int startRecord = (currentPage - 1) * pageSize;
            int endRecord = currentPage * pageSize;
            if (endRecord > totalRecords) endRecord = totalRecords;

            for (int i = startRecord; i < endRecord; i++)
            {
                pageTable.ImportRow(dataTable.Rows[i]);
            }

            ActivitySearch_dataGridView.DataSource = pageTable;
            Label lblPageNumber = (Label)this.Controls.Find("lblPageNumber", true)[0];
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}";

            // 取消所有选中状态
            ActivitySearch_dataGridView.ClearSelection();
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 将某列字体加粗（假设 ActivityName 列索引为 1）
            if (ActivitySearch_dataGridView.Columns[e.ColumnIndex].Name == "ActivityName")
            {
                e.CellStyle.Font = new Font(ActivitySearch_dataGridView.DefaultCellStyle.Font, FontStyle.Bold);
            }

            // 根据状态列设置单元格颜色（假设 Status 列索引为 7）
            if (ActivitySearch_dataGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Completed")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (status == "Registering")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void DataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ActivitySearch_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void DataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ActivitySearch_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public void ClearSelection()
        {
            ActivitySearch_dataGridView.ClearSelection();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ActivitySearch_dataGridView.Rows[e.RowIndex];

                int activityId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string activityName = selectedRow.Cells["ActivityName"].Value.ToString();
                DateTime dateTime = Convert.ToDateTime(selectedRow.Cells["DateTime"].Value);
                string location = selectedRow.Cells["Location"].Value.ToString();
                string organizer = selectedRow.Cells["Organizer"].Value.ToString();
                int participantLimit = Convert.ToInt32(selectedRow.Cells["ParticipantLimit"].Value);
                int currentParticipants = Convert.ToInt32(selectedRow.Cells["CurrentParticipants"].Value);
                string status = selectedRow.Cells["Status"].Value.ToString();
                // 额外的SQL查询获取duration和description
                string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
                string query = "SELECT Duration, Description FROM tb_Activity WHERE ID = @ActivityID";

                string duration = "";
                string description = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ActivityID", activityId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            duration = reader["Duration"].ToString();
                            description = reader["Description"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                }
                ActivityDetails_Form detailsForm = new ActivityDetails_Form();
                detailsForm.LoadActivityDetails(activityId, activityName, dateTime, location, organizer, participantLimit, currentParticipants, status,duration,description);
                detailsForm.ShowDialog();
            }
        }

        private void ParticipateIn_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_TextBox.Text))
            {
                int activityId = Convert.ToInt32(ID_TextBox.Text);

                // 在这里调用方法将学生加入活动
                JoinActivity(PublicClass.loginKeanMail, activityId);
            }
            else
            {
                MessageBox.Show("Please enter activity ID.");
            }
        }

        private void JoinActivity(string studentMail, int activityId)
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string checkActivityQuery = @"
        SELECT 
            COUNT(*) AS ActivityCount, 
            ParticipantLimit, 
            CurrentParticipants 
        FROM tb_Activity 
        WHERE ID = @ActivityID AND Status = 'Registering'
        GROUP BY ParticipantLimit, CurrentParticipants";
            string checkParticipationQuery = "SELECT COUNT(*) FROM tb_StudentActivity WHERE StudentMail = @StudentMail AND ActivityID = @ActivityID";
            string insertParticipationQuery = "INSERT INTO tb_StudentActivity (StudentMail, ActivityID) VALUES (@StudentMail, @ActivityID)";
            string updateParticipantsQuery = "UPDATE tb_Activity SET CurrentParticipants = CurrentParticipants + 1 WHERE ID = @ActivityID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 检查活动是否存在、状态为 'Registering' 且未达到最大参加人数
                    SqlCommand checkActivityCommand = new SqlCommand(checkActivityQuery, connection);
                    checkActivityCommand.Parameters.AddWithValue("@ActivityID", activityId);
                    SqlDataReader reader = checkActivityCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        int activityCount = reader.GetInt32(0);
                        int participantLimit = reader.GetInt32(1);
                        int currentParticipants = reader.GetInt32(2);

                        if (activityCount > 0 && currentParticipants < participantLimit)
                        {
                            reader.Close();

                            // 检查学生是否已经参加了该活动
                            SqlCommand checkParticipationCommand = new SqlCommand(checkParticipationQuery, connection);
                            checkParticipationCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                            checkParticipationCommand.Parameters.AddWithValue("@ActivityID", activityId);
                            int participationCount = (int)checkParticipationCommand.ExecuteScalar();

                            if (participationCount == 0)
                            {
                                // 插入参与记录
                                SqlCommand insertCommand = new SqlCommand(insertParticipationQuery, connection);
                                insertCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                                insertCommand.Parameters.AddWithValue("@ActivityID", activityId);
                                insertCommand.ExecuteNonQuery();

                                // 更新当前参加人数
                                SqlCommand updateCommand = new SqlCommand(updateParticipantsQuery, connection);
                                updateCommand.Parameters.AddWithValue("@ActivityID", activityId);
                                updateCommand.ExecuteNonQuery();

                                MessageBox.Show("Student successfully joined the activity.");

                                // 重新加载数据并刷新表格
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Student has already joined this activity.");
                            }
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("The specified activity has reached the maximum number of participants.");
                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("The specified activity does not exist or is not open for registration.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SearchActivity_Form_Stu_Activated(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
