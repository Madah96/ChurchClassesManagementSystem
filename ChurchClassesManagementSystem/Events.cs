using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace ChurchClassesManagementSystem
{
    public partial class Events : Form
    {


        public Events()
        {
            InitializeComponent();
            DisplayEvents();

            // Wire up the SelectionChanged event
            EventsDGV.SelectionChanged += EventsDGV_SelectionChanged;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEvents()
        {
            Con.Open();
            string query = "select * from EventsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            EdurationTb.Text = "";
            EDescTb.Text = "";
            EGoogleTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventsTbl(EDesc,EDate,Eduration,GoogleMeetingLink) values (@EvDesc,@EvDate,@EvDur,@GoogleMeetingLink)", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EdurationTb.Text);
                    cmd.Parameters.AddWithValue("@GoogleMeetingLink", EGoogleTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        //Delete an event
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Event");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EventsTbl where EId= @Ekey", Con);
                    cmd.Parameters.AddWithValue("@Ekey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }

        }
        int key = 0;
        private void EventsDGV_SelectionChanged(object? sender, EventArgs e)
        {
            if (EventsDGV.SelectedRows.Count > 0)
            {
                EDescTb.Text = EventsDGV.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                EDate.Text = EventsDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                EdurationTb.Text = EventsDGV.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                EGoogleTb.Text = EventsDGV.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                key = Convert.ToInt32(EventsDGV.SelectedRows[0].Cells[0].Value?.ToString() ?? "");
            }
            else
            {
                // Clear the fields and reset the key if no row is selected
                EDescTb.Text = "";
                EDate.Text = "";
                EdurationTb.Text = "";
                EGoogleTb.Text = "";
                key = 0;
            }
        }

        //Edit event
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventsTbl set EDesc=@EvDesc,EDate=@EvDate,EDuration=@EvDuration, GoogleMeetingLink=@GoogleMeetingLink where EId=@EvID", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDuration", EdurationTb.Text);
                    cmd.Parameters.AddWithValue("@GoogleMeetingLink", EGoogleTb.Text);
                    cmd.Parameters.AddWithValue("@EvID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            UpdateTotalRecordsCount();
        }


        private void UpdateTotalRecordsCount()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EventsTbl", Con))
                    {
                        int totalRecords = (int)cmd.ExecuteScalar();
                        lblTotal.Text = $"Total records: {totalRecords}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Attendances Obj = new Attendances();
            Obj.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiveClass Obj = new LiveClass();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Excel application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Create a new workbook
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Create a new worksheet
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // Copy DataGridView content to an object array
                int rowCnt = EventsDGV.Rows.Count;
                int colCnt = EventsDGV.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = EventsDGV.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = EventsDGV.Rows[i].Cells[j].Value;
                    }
                }

                // Get the Excel range where we want to paste the data
                Excel.Range range = worksheet.Range["A1"].Resize[rowCnt + 1, colCnt];

                // Paste the data
                range.Value = dataArr;

                // Release Excel objects
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resources Obj = new Resources();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmContactUs Obj = new frmContactUs();
            Obj.Show();
            this.Hide();
        }
    }
}

