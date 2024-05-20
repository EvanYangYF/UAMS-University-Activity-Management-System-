using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityActivityManagementSystem.WorkBenchForStudent;

namespace UniversityActivityManagementSystem
{
    public partial class MyActivity_Form_Stu : Form
    {
        private DataTable dataTable;
        private int pageSize = 15;
        private int totalRecords;
        private int totalPages;
        private int currentPage = 1;

        public MyActivity_Form_Stu()
        {
            InitializeComponent();
        }

        private void MyActivity_Form_Stu_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string query = "SELECT A.ID, A.ActivityName, A.DateTime, A.Location, A.Organizer, A.ParticipantLimit, A.CurrentParticipants, A.Status " +
                           "FROM tb_Activity A " +
                           "JOIN tb_StudentActivity SA ON A.ID = SA.ActivityID " +
                           "WHERE SA.StudentMail = @StudentMail " +
                           "ORDER BY A.DateTime DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StudentMail", PublicClass.loginKeanMail);
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

            MyActivity_dataGridView.DataSource = pageTable;
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}";

            // 取消所有选中状态
            MyActivity_dataGridView.ClearSelection();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int activityId;
            if (int.TryParse(txtActivityId.Text, out activityId))
            {
                WithdrawFromActivity(PublicClass.loginKeanMail, activityId);
            }
            else
            {
                MessageBox.Show("Please enter a valid activity ID.");
            }
        }

        private void WithdrawFromActivity(string studentMail, int activityId)
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string checkActivityQuery = "SELECT Status FROM tb_Activity WHERE ID = @ActivityID";
            string deleteParticipationQuery = "DELETE FROM tb_StudentActivity WHERE StudentMail = @StudentMail AND ActivityID = @ActivityID";
            string updateParticipantsQuery = "UPDATE tb_Activity SET CurrentParticipants = CurrentParticipants - 1 WHERE ID = @ActivityID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 检查活动状态
                    SqlCommand checkActivityCommand = new SqlCommand(checkActivityQuery, connection);
                    checkActivityCommand.Parameters.AddWithValue("@ActivityID", activityId);
                    string status = (string)checkActivityCommand.ExecuteScalar();

                    if (status == "Registering")
                    {
                        // 删除参与记录
                        SqlCommand deleteCommand = new SqlCommand(deleteParticipationQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@StudentMail", studentMail);
                        deleteCommand.Parameters.AddWithValue("@ActivityID", activityId);
                        deleteCommand.ExecuteNonQuery();

                        // 更新当前参加人数
                        SqlCommand updateCommand = new SqlCommand(updateParticipantsQuery, connection);
                        updateCommand.Parameters.AddWithValue("@ActivityID", activityId);
                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Successfully withdrawn from the activity.");

                        // 重新加载数据并刷新表格
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("The specified activity is not open for withdrawal.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void MyActivity_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MyActivity_dataGridView.Rows[e.RowIndex];
                int activityId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                LoadStudentActivityDetails(activityId);
            }
        }

        DataOperator dataoper = new DataOperator();
        private void LoadStudentActivityDetails(int activityId)
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            int recordId;
            string studentMail;
            DateTime participationTime;
            string attendenceStatus;
            Decimal duration;
            string description;

            // 获取 tb_StudentActivity 表中的信息
            string queryStudentActivity = @"
        SELECT RecordID, StudentMail, ParticipationTime, AttendanceStatus 
        FROM tb_StudentActivity 
        WHERE ActivityID = "+activityId;

            DataSet ds1 = new DataSet();
            ds1 = dataoper.GetDataSet(queryStudentActivity);
            recordId = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);
            studentMail = ds1.Tables[0].Rows[0][1].ToString();
            participationTime = Convert.ToDateTime(ds1.Tables[0].Rows[0][2]);
            attendenceStatus = ds1.Tables[0].Rows[0][3].ToString();

            // 获取 tb_Activity 表中的信息
            string queryActivity = @"
        SELECT Duration, Description 
        FROM tb_Activity 
        WHERE ID = "+activityId;

            DataSet ds2 = new DataSet();
            ds2 = dataoper.GetDataSet(queryActivity);
            duration = Convert.ToDecimal(ds2.Tables[0].Rows[0][0]);
            description = ds2.Tables[0].Rows[0][1].ToString();


            MyActivityDetail_Form detailsForm = new MyActivityDetail_Form();
            detailsForm.LoadStudentActivityDetails(recordId, studentMail, activityId, participationTime, attendenceStatus, duration, description);
            detailsForm.ShowDialog();
        }

        private void MyActivity_Form_Stu_Activated(object sender, EventArgs e)
        {
            MyActivity_dataGridView.ClearSelection();
        }
    }
}
