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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeacher();

            // Wire up the SelectionChanged event
            TeacherDGV.SelectionChanged += TeacherDGV_SelectionChanged;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeacher()
        {
            Con.Open();
            string query = "select * from TeachersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeacherDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TnameTb.Text = "";
            SubCb.SelectedIndex = 0;
            TGenCb.SelectedIndex = 0;
            TPhoneTb.Text = "";
            TAddTb.Text = "";
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeachersTbl(Tname,TGen,TPhone,TSub,TAdd,TDOB) values (@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB)", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added");
                    Con.Close();
                    DisplayTeacher();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeachersTbl where TId= @Tkey", Con);
                    cmd.Parameters.AddWithValue("@Tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted");
                    Con.Close();
                    DisplayTeacher();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        int key = 0;
        private void TeacherDGV_SelectionChanged(object? sender, EventArgs e)
        {
            if (TeacherDGV.SelectedRows.Count > 0)
            {
                TnameTb.Text = TeacherDGV.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                TGenCb.SelectedItem = TeacherDGV.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                TPhoneTb.Text = TeacherDGV.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                SubCb.SelectedItem = TeacherDGV.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                TAddTb.Text = TeacherDGV.SelectedRows[0].Cells[5].Value?.ToString() ?? "";
                TDOB.Text = TeacherDGV.SelectedRows[0].Cells[6].Value?.ToString() ?? "";



                key = Convert.ToInt32(TeacherDGV.SelectedRows[0].Cells[0].Value?.ToString() ?? "");
            }
            else
            {
                // Clear the fields and reset the key if no row is selected
                TnameTb.Text = "";
                TGenCb.SelectedIndex = -1;
                TPhoneTb.Text = "";
                TDOB.Text = "";
                SubCb.SelectedIndex = -1;
                TAddTb.Text = "";
                TDOB.Text = "";
                key = 0;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TeachersTbl set Tname=@Tname,TGen=@TGen,TPhone=@TPhone,TSub=@TSub,TAdd=@TAdd,TDOB=@TDOB where TId=@TeachID", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeacher();
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

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Teachers_Load(object sender, EventArgs e)
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

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TeachersTbl", Con))
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

        private void button2_Click(object sender, EventArgs e)
        {
            LiveClass Obj = new LiveClass();
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
                int rowCnt = TeacherDGV.Rows.Count;
                int colCnt = TeacherDGV.Columns.Count;
                object[,] dataArr = new object[rowCnt + 1, colCnt];

                // Add column headers
                for (int i = 0; i < colCnt; i++)
                {
                    dataArr[0, i] = TeacherDGV.Columns[i].HeaderText;
                }

                // Add data
                for (int i = 0; i < rowCnt; i++)
                {
                    for (int j = 0; j < colCnt; j++)
                    {
                        dataArr[i + 1, j] = TeacherDGV.Rows[i].Cells[j].Value;
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

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
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
