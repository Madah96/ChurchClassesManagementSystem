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
    public partial class VideoYapadela : Form
    {
        public VideoYapadela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = " C:\\Users\\user\\source\\repos\\ChurchClassesManagementSystem\\Class videos\\lesson1.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Yapadela Obj = new Yapadela();
            Obj.Show();
            this.Hide();
        }
    }
}
