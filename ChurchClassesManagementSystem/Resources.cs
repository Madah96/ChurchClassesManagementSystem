using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.IO;
using System.Data.SqlClient;
using Spire.Pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChurchClassesManagementSystem
{
    public partial class Resources : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        public Resources()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            // database connection string
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30";


            // SQL query
            string Query = "SELECT * FROM data_file";

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
                    string SName = reader["name"].ToString();
                    comboBox1.Items.Add(SName);
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

        private void Resources_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                // Path.GetFileName to get only the file name
                string fn = Path.GetFileName(file);

                // Path.Combine to combine paths in a platform-independent way
                string destFolder = @"C:\Users\user\source\repos\ChurchClassesManagementSystem\files";
                string dest = Path.Combine(destFolder, fn);

                // string dest = Path.Combine(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30", fn);

                // File.Copy to copy the file to the destination folder
                File.Copy(file, dest, true);

              
                string q = "INSERT INTO [data_file] (name,loc) VALUES (@FileName, @Destination)";
                cmd = new SqlCommand(q, Con);
                cmd.Parameters.AddWithValue("@FileName", fn);
                cmd.Parameters.AddWithValue("@Destination", dest);


                try
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
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

        }

        private void button2_Click(object sender, EventArgs e)

        {
            string fn = comboBox1.Text;

            if (!string.IsNullOrEmpty(fn))
            {
                try
                {
                    string q = "SELECT [loc],[download_count] FROM [data_file] WHERE [name]=@FileName";
                    cmd = new SqlCommand(q, Con);
                    cmd.Parameters.AddWithValue("@FileName", fn);

                    Con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string loc = reader["loc"].ToString();
                        int downloadCount = Convert.ToInt32(reader["download_count"]);

                        // axAcropdf1 is the PDF viewer control
                        axAcropdf1.LoadFile(loc);

                        // Increment the download count
                        downloadCount++;

                        // Update the database with the new download count
                        reader.Close(); // Close the previous reader
                        string updateQuery = "UPDATE [data_file] SET [download_count] = @DownloadCount WHERE [name]=@FileName";
                        cmd = new SqlCommand(updateQuery, Con);
                        cmd.Parameters.AddWithValue("@DownloadCount", downloadCount);
                        cmd.Parameters.AddWithValue("@FileName", fn);
                        cmd.ExecuteNonQuery();
                    }

                    // Using ExecuteScalar to get a single value from the database
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string loc = result.ToString();

                        // axAcropdf2 is the PDF viewer control
                        axAcropdf2.LoadFile(loc);
                    }
                    else
                    {
                        MessageBox.Show("opened");
                    }
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LiveClass Obj = new LiveClass();
            Obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resources Obj = new Resources();
            Obj.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmContactUs Obj = new frmContactUs();
            Obj.Show();
            this.Hide();
        }
    }
}






