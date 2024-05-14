using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ChurchClassesManagementSystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();

            // Wire up the SelectionChanged event
            StudentDGV.SelectionChanged += StudentDGV_SelectionChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else if (!IsTextOnly(StNameTb.Text))
            {
                MessageBox.Show("Please enter a valid name with text only (no numbers allowed).");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StAdd) values (@Sname,@SGen,@SDob,@SClass,@SAdd)", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static bool IsTextOnly(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void StudentDGV_ColumnHeadersBorderStyleChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            key = 0;
            StNameTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;
        }

        int key = 0;
        private void StudentDGV_SelectionChanged(object? sender, EventArgs e)
        {
            if (StudentDGV.SelectedRows.Count > 0)
            {
                StNameTb.Text = StudentDGV.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                StGenCb.SelectedItem = StudentDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                DOBPicker.Text = StudentDGV.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                ClassCb.SelectedItem = StudentDGV.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                AddressTb.Text = StudentDGV.SelectedRows[0].Cells[5].Value?.ToString() ?? "";

                key = Convert.ToInt32(StudentDGV.SelectedRows[0].Cells[0].Value?.ToString() ?? "");
            }
            else
            {
                // Clear the fields and reset the key if no row is selected
                StNameTb.Text = "";
                StGenCb.SelectedIndex = -1;
                DOBPicker.Text = "";
                ClassCb.SelectedIndex = -1;
                AddressTb.Text = "";
                key = 0;
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTbl where StId= @Stkey", Con);
                    cmd.Parameters.AddWithValue("@Stkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update StudentTbl set StName=@Sname,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StAdd=@SAdd where StId=@SID", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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

        private void btnAnalytics_Click(object sender, EventArgs e)
        {

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

        private void Students_Load(object sender, EventArgs e)
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

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentTbl", Con))
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
        //exporting data to excel
        private void button4_Click_1(object sender, EventArgs e)
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
                int rowCnt = StudentDGV.Rows.Count;
                int colCnt = StudentDGV.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = StudentDGV.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = StudentDGV.Rows[i].Cells[j].Value;
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

