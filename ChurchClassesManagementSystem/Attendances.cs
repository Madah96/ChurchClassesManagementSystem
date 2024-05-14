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
using Excel = Microsoft.Office.Interop.Excel;

namespace ChurchClassesManagementSystem
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();

            // Wire up the SelectionChanged event
            AttendanceDGV.SelectionChanged += AttendanceDGV_SelectionChanged;
        }
        private void FillStudId()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    using (SqlCommand cmd = new SqlCommand("select StId from StudentTbl", Con))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("StId", typeof(int));
                            dt.Load(rdr);
                            StIdCb.ValueMember = "StId";
                            StIdCb.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GetStudName()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SID", Con))
                    {
                        cmd.Parameters.AddWithValue("@SID", StIdCb.SelectedValue?.ToString() ?? "");
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }

                        foreach (DataRow dr in dt.Rows)
                        {
                            STNameTb.Text = dr["StName"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAttendance()
        {
            Con.Open();
            string query = "select * from AttendanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            STNameTb.Text = "";
            StIdCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (STNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTbl(AttStId,AttStName,AttDate,AttStatus) values (@StId,@StName,@AttDate,@Status)", Con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Recorded");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void StIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int key = 0;
        private void AttendanceDGV_SelectionChanged(object? sender, EventArgs e)
        {
            if (AttendanceDGV.SelectedRows.Count > 0)
            {
                StIdCb.SelectedValue = AttendanceDGV.SelectedRows[0].Cells[1].Value?.ToString() ?? "";

                // Check for nullability of StIdCb.SelectedValue
                if (StIdCb.SelectedValue != null)
                {
                    STNameTb.Text = AttendanceDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                    AttDatePicker.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                    AttStatusCb.SelectedItem = AttendanceDGV.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                    key = Convert.ToInt32(AttendanceDGV.SelectedRows[0].Cells[0].Value?.ToString() ?? "");
                }
                else
                {
                    // Handle the case when StIdCb.SelectedValue is null
                    STNameTb.Text = "";
                    AttDatePicker.Text = "";
                    AttStatusCb.SelectedIndex = -1;
                    key = 0;
                }
            }
            else
            {
                // Clear the fields and reset the key if no row is selected
                STNameTb.Text = "";
                AttDatePicker.Text = "";
                AttStatusCb.SelectedIndex = -1;
                key = 0;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (STNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update AttendanceTbl set AttStId=@StId,AttStName=@StName,AttDate=@ADate,AttStatus=@AStatus where AttNum=@ANum", Con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue);
                    cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiveClass Obj = new LiveClass();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        //Exporting data to excel
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
                int rowCnt = AttendanceDGV.Rows.Count;
                int colCnt = AttendanceDGV.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = AttendanceDGV.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = AttendanceDGV.Rows[i].Cells[j].Value;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Finances Obj = new Finances();
            Obj.Show();
            this.Hide();
        }
    }
}

