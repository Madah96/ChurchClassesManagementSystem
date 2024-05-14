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
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            // database connection string
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30";


            // SQL query
            string Query = "SELECT DISTINCT StClass FROM StudentTbl";

            SqlConnection ConDatabase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, ConDatabase);
            SqlDataReader reader;

            try
            {
                ConDatabase.Open();
                reader = cmdDataBase.ExecuteReader();

                // Ensure the comboBox is cleared before adding items
                comboBox1.Items.Clear();

                while (reader.Read())
                {
                    // method to retrieve column value
                    string className = reader["StClass"].ToString();
                    comboBox1.Items.Add(className);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConDatabase.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();

                    using (DataTable dt = new DataTable("AttendanceTbl"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT A.AttNum, A.AttStId, A.AttStName, A.AttDate, A.AttStatus FROM AttendanceTbl A\r\nINNER JOIN StudentTbl S ON A.AttStId = S.StId WHERE A.AttDate BETWEEN @fromdate AND @todate", Con))
                        {
                            cmd.Parameters.AddWithValue("@fromdate", dtFromDate.Value);
                            cmd.Parameters.AddWithValue("@todate", dtToDate.Value);

                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);

                            // Check if there are any rows before assigning to the DataGridView
                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                                lblTotal.Text = $"Total records: {dt.Rows.Count}";
                            }
                            else
                            {
                                MessageBox.Show("No records found for the selected date range.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();

                    using (DataTable dt = new DataTable("StudentTbl"))
                    {
                        // comboBox1 is the name of the ComboBox
                        string selectedClass = comboBox1.SelectedItem.ToString();

                        using (SqlCommand cmd = new SqlCommand("SELECT StId, StName, StGen, StDOB, StClass, StAdd FROM StudentTbl WHERE StClass = @class AND StDOB BETWEEN @fromdate AND @todate", Con))
                        {
                            cmd.Parameters.AddWithValue("@class", selectedClass);
                            cmd.Parameters.AddWithValue("@fromdate", dtFromDate1.Value);
                            cmd.Parameters.AddWithValue("@todate", dtToDate1.Value);

                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);

                            // Check if there are any rows before assigning to the DataGridView
                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                                lblTotal.Text = $"Total records: {dt.Rows.Count}";
                            }
                            else
                            {
                                MessageBox.Show("No records found for the selected class and date range.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            frmContactUs Obj = new frmContactUs();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
                int rowCnt = dataGridView1.Rows.Count;
                int colCnt = dataGridView1.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = dataGridView1.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = dataGridView1.Rows[i].Cells[j].Value;
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
    }
}

