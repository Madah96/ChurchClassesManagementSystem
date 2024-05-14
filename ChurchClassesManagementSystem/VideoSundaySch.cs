using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchClassesManagementSystem
{
    public partial class VideoSundaySch : Form
    {
        public VideoSundaySch()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Sunday_School Obj = new Sunday_School();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = " C:\\Users\\user\\source\\repos\\ChurchClassesManagementSystem\\Class videos\\Lesson2.mp4";
            axWindowsMediaPlayer1.URL = f;
        }
    }
}
