using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UniversityActivityManagementSystem.WorkBenchForProfessor
{
    public partial class ActivityReport_Form : Form
    {
        private string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";

        public ActivityReport_Form()
        {
            InitializeComponent();
        }

        private void ActivityReport_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            activityReport_dataGridView.ClearSelection();
            LoadActivityReportData();
        }

        private void LoadActivityReportData()
        {
            string query = @"
                SELECT 
                    a.ID AS ActivityID,
                    a.ActivityName,
                    a.Status,
                    ROUND((CAST(a.CurrentParticipants AS FLOAT) / CAST(a.ParticipantLimit AS FLOAT)) * 100, 2) AS ParticipationRate,
                    ROUND(
                        CASE 
                            WHEN a.CurrentParticipants = 0 THEN 0
                            ELSE (SELECT COUNT(*) FROM tb_StudentActivity sa WHERE sa.ActivityID = a.ID AND sa.AttendanceStatus = 'Presence') * 100.0 / a.CurrentParticipants 
                        END, 2
                    ) AS AttendanceRate
                FROM 
                    tb_Activity a
                WHERE 
                    a.Organizer = @Organizer
                ORDER BY 
                    a.DateTime DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Organizer", GetOrganizerName(PublicClass.loginKeanMail));
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                activityReport_dataGridView.DataSource = dataTable;

                // Set colors based on Status
                foreach (DataGridViewRow row in activityReport_dataGridView.Rows)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    if (status == "Registering")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

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

        private string GetProfessorInfo(string keanMail)
        {
            string query = "SELECT Name, KeanMail FROM tb_User WHERE KeanMail = @KeanMail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KeanMail", keanMail);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string email = reader["KeanMail"].ToString();
                        return $"{name}\n{email}";
                    }
                }
            }
            return string.Empty;
        }

        private void printReport_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "ActivityReport.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToPdf(saveFileDialog.FileName);
            }
        }

        private void ExportToPdf(string filePath)
        {
            Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Add Title
            Paragraph title = new Paragraph("UAMS - Activity Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Add Date
            Paragraph date = new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12));
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            // Add Table
            PdfPTable table = new PdfPTable(activityReport_dataGridView.Columns.Count);
            table.WidthPercentage = 100;

            // Add Header
            foreach (DataGridViewColumn column in activityReport_dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                table.AddCell(cell);
            }

            // Add Data Rows
            foreach (DataGridViewRow row in activityReport_dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)));
                    if (activityReport_dataGridView.Columns[cell.ColumnIndex].Name == "ParticipationRate" || activityReport_dataGridView.Columns[cell.ColumnIndex].Name == "AttendanceRate")
                    {
                        pdfCell.Phrase = new Phrase(Convert.ToDecimal(cell.Value).ToString("0.00"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10));
                    }
                    table.AddCell(pdfCell);
                }
            }

            document.Add(table);

            // Add Professor Information
            string professorInfo = GetProfessorInfo(PublicClass.loginKeanMail);
            Paragraph professorParagraph = new Paragraph(professorInfo, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
            professorParagraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(professorParagraph);

            document.Close();
            writer.Close();

            MessageBox.Show("Report exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
