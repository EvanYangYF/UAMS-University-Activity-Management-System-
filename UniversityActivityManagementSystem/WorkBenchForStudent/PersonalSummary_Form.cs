using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace UniversityActivityManagementSystem.WorkBenchForStudent
{
    public partial class PersonalSummary_Form : Form
    {
        private string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";

        public PersonalSummary_Form()
        {
            InitializeComponent();
        }

        private void PersonalSummary_Form_Load(object sender, EventArgs e)
        {
            NetworkManager.Instance.CheckNetworkConnection();
            LoadPersonalSummary();
        }

        private void LoadPersonalSummary()
        {
            string connectionString = "Server=47.115.202.144;Database=db_UAMS;User Id=sa;Password=021014_yyf;";
            string query = @"
                SELECT 
                    u.Name AS StudentName,
                    u.KeanMail AS StudentKeanMail,
                    a.ActivityName,
                    a.DateTime,
                    a.Duration,
                    s.AttendanceStatus,
                    a.Organizer AS OrganizerName,
                    o.KeanMail AS OrganizerKeanMail
                FROM 
                    dbo.tb_StudentActivity s
                JOIN 
                    dbo.tb_Activity a ON s.ActivityID = a.ID
                JOIN 
                    dbo.tb_User u ON s.StudentMail = u.KeanMail
                LEFT JOIN 
                    dbo.tb_User o ON a.Organizer = o.Name
                WHERE 
                    s.StudentMail = @StudentMail
                ORDER BY 
                    a.DateTime DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentMail", PublicClass.loginKeanMail);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                PersonalSummary_dataGridView.DataSource = dataTable;

                // 计算总时长
                decimal totalDuration = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["AttendanceStatus"].ToString().ToLower() == "presence")
                    {
                        totalDuration += Convert.ToDecimal(row["Duration"]);
                    }
                }
                TotalDuration_label.Text = $"Total Personal Activity Duration：\n {totalDuration} hours";
            }
        }

        private void PersonalSummary_dataGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PersonalSummary_dataGridView.Columns[e.ColumnIndex].Name == "Duration")
            {
                DataGridViewRow row = PersonalSummary_dataGridView.Rows[e.RowIndex];
                string attendanceStatus = row.Cells["AttendanceStatus"].Value?.ToString().ToLower();

                if (attendanceStatus == "absent")
                {
                    
                }
                else if (attendanceStatus == "presence")
                {
                    
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void PersonalSummary_Form_Activated(object sender, EventArgs e)
        {
                PersonalSummary_dataGridView.ClearSelection();

        }

        private void PrintSummary_Button_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "PersonalSummary.pdf";
                saveFileDialog.Title = "Save Personal Summary";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportToPdf(filePath);
                }
            }
        }

        private void ExportToPdf(string filePath)
        {
            Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Add Title
            Paragraph title = new Paragraph("UAMS - Personal Activity Summary", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Add Date
            Paragraph date = new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12));
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            // Add Table
            PdfPTable pdfTable = new PdfPTable(PersonalSummary_dataGridView.Columns.Count);
            pdfTable.WidthPercentage = 100;

            // Add Header
            foreach (DataGridViewColumn column in PersonalSummary_dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            // Add Data Rows
            foreach (DataGridViewRow row in PersonalSummary_dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10)));
                    if (PersonalSummary_dataGridView.Columns[cell.ColumnIndex].Name == "Duration")
                    {
                        string attendanceStatus = row.Cells["AttendanceStatus"].Value?.ToString().ToLower();
                        if (attendanceStatus == "absent")
                        {
                            pdfCell.Phrase = new Phrase(cell.Value?.ToString() ?? "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD));
                        }
                        else if (attendanceStatus == "presence")
                        {
                            pdfCell.Phrase = new Phrase(cell.Value?.ToString() ?? "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.RED));
                        }
                    }
                    pdfTable.AddCell(pdfCell);
                }
            }

            document.Add(pdfTable);

            // Add Total Duration
            Paragraph totalDuration = new Paragraph($"Current Total Personal Activity Duration：{TotalDuration_label.Text}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
            totalDuration.Alignment = Element.ALIGN_RIGHT;
            document.Add(totalDuration);

            document.Close();
            writer.Close();

            MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

