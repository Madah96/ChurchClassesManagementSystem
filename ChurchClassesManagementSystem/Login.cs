using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChurchClassesManagementSystem
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int loginAttempts = 0;
        DateTime lastFailedLoginTime;
        int maxAttempts = 3; // Maximum number of unsuccessful login attempts
        TimeSpan waitingPeriod = TimeSpan.FromMinutes(5); // Waiting period in minutes
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UnameTb.Text) && !string.IsNullOrEmpty(PasswordTb.Text))
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users INNER JOIN role ON users.userrole = role.roleid WHERE username = @username AND password = @password", Con);
                    cmd.Parameters.AddWithValue("@username", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTb.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string roletype = reader["roletype"].ToString();

                        // Open the appropriate form based on role type
                        if (roletype == "admin")
                        {
                            MessageBox.Show("Welcome Admin!");
                            // Open the Admin Dashboard
                            Dashboard Obj = new Dashboard();
                            Obj.Show();
                            this.Hide();
                        }
                        else if (roletype == "Teacher")
                        {
                            MessageBox.Show("Welcome Teacher!");
                            // Open the Teacher Dashboard
                            MainMenu Obj = new MainMenu();
                            Obj.Show();
                            this.Hide();
                        }
                        else if (roletype == "Student")
                        {
                            MessageBox.Show("Welcome Student!");
                            // Open the Student Dashboard
                            LiveClass Obj = new LiveClass();
                            Obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid user type!");
                        }

                        // Reset login attempts
                        loginAttempts = 0;

                        // Hide the login form
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");

                        // Track unsuccessful login attempts
                        loginAttempts++;
                        lastFailedLoginTime = DateTime.Now;

                        if (loginAttempts >= maxAttempts)
                        {
                            // Disable login button
                            button1.Enabled = false;

                            // Display lockout message
                            MessageBox.Show("You have been locked out. Please wait for 5 minutes before attempting to login again.");

                            // Start countdown timer
                            timer1.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Calculate remaining time
            TimeSpan remainingTime = lastFailedLoginTime.Add(waitingPeriod) - DateTime.Now;

            if (remainingTime <= TimeSpan.Zero)
            {
                // Enable login button and reset attempts
                button1.Enabled = true;
                loginAttempts = 0;
                timer1.Stop();
            }
            else
            {
                // Display remaining time
                MessageBox.Show($"Please wait {remainingTime.TotalMinutes} minutes before trying again.");
            }
        }
    }
}
