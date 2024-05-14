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

namespace ChurchClassesManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();


        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        private void CountStudent()
        {
            Con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTeachers()
        {
            Con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select Count(*) from TeachersTbl", Con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            TLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountEvents()
        {
            Con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter("select Count(*) from EventsTbl", Con);
            DataTable dt = new DataTable();
            Sda.Fill(dt);
            ELbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountFinance()
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
                            int Num = Convert.ToInt32(result);
                            FinTbl.Text = $"{Num}";
                        }
                        else
                        {
                            FinTbl.Text = "0"; // Handle case when there are no records in the table
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CountDownloads()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(download_count) FROM data_file", Con);
                int downloadCount = Convert.ToInt32(cmd.ExecuteScalar());
                DwnTbl.Text = downloadCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Count code
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeachers();
            CountEvents();
            CountFinance();
            CountDownloads();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);


        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            frmAnalytics Obj = new frmAnalytics();
            Obj.Show();
            this.Hide();


        }
        private void btnContactUs_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContactUs.Height;
            PnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            LiveClass Obj = new LiveClass();
            Obj.Show();
            this.Hide();


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void StLbl_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resources Obj = new Resources();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finances Obj = new Finances();
            Obj.Show();
            this.Hide();
        }
    }
}
