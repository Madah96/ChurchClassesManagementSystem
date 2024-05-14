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
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
            DisplayFinance();

            // Wire up the SelectionChanged event
            FinanceDGV.SelectionChanged += FinanceDGV_SelectionChanged;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayFinance()
        {
            Con.Open();
            string query = "select * from FinanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FinanceDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FinanceDGV_ColumnHeadersBorderStyleChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            key = 0;
            ClassIdCb.SelectedIndex = 0;
            ClassNameCb.SelectedIndex = 0;
            OfferingTb.Text = "";
            TitheTb.Text = "";
        }
        int key = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Resources Obj = new Resources();
            Obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ClassIdCb.SelectedIndex == -1 || ClassNameCb.SelectedIndex == -1 || OfferingTb.Text == "" || TitheTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FinanceTbl(FClassId,FClassName,Offering,Tithe) values (@FClassId,@FClassName,@Offering,@Tithe)", Con);
                    cmd.Parameters.AddWithValue("@FClassId", ClassIdCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FClassName", ClassNameCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Offering", OfferingTb.Text);
                    cmd.Parameters.AddWithValue("@Tithe", TitheTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Added");
                    Con.Close();
                    DisplayFinance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FinanceDGV_SelectionChanged(object? sender, EventArgs e)
        {
            if (FinanceDGV.SelectedRows.Count > 0)
            {
                ClassNameCb.SelectedItem = FinanceDGV.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                ClassIdCb.SelectedItem = FinanceDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                OfferingTb.Text = FinanceDGV.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                TitheTb.Text = FinanceDGV.SelectedRows[0].Cells[4].Value?.ToString() ?? "";


                key = Convert.ToInt32(FinanceDGV.SelectedRows[0].Cells[0].Value?.ToString() ?? "");
            }
            else
            {
                // Clear the fields and reset the key if no row is selected
                key = 0;
                ClassIdCb.SelectedIndex = -1;
                ClassNameCb.SelectedIndex = -1;
                OfferingTb.Text = "";
                TitheTb.Text = "";
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Finance");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from FinanceTbl where FClassId= @Fkey", Con);
                    cmd.Parameters.AddWithValue("@Fkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    Con.Close();
                    DisplayFinance();
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
            if (ClassIdCb.SelectedIndex == -1 || ClassNameCb.SelectedIndex == -1 || OfferingTb.Text == "" || TitheTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FinanceTbl SET FClassId = @FClassId, FClassName = @FClassName, Offering = @Offering, Tithe = @Tithe WHERE FNum = @FNum", Con);
                    cmd.Parameters.AddWithValue("@FClassId", ClassIdCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FClassName", ClassNameCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Offering", OfferingTb.Text);
                    cmd.Parameters.AddWithValue("@Tithe", TitheTb.Text);
                    cmd.Parameters.AddWithValue("@FNum", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Added");
                    Con.Close();
                    DisplayFinance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Finances_Load(object sender, EventArgs e)
        {
            UpdateTotalAmountCount();
        }

        private void UpdateTotalAmountCount()
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();

                    // Use separate SUM functions for each column
                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(Offering) + SUM(Tithe) AS TotalAmount FROM FinanceTbl", Con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int totalAmount = Convert.ToInt32(result);
                            lblTotal.Text = $"Total Amount: {totalAmount}";
                        }
                        else
                        {
                            lblTotal.Text = "Total Amount: 0"; // Handle case when there are no records in the table
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                int rowCnt = FinanceDGV.Rows.Count;
                int colCnt = FinanceDGV.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = FinanceDGV.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = FinanceDGV.Rows[i].Cells[j].Value;
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
