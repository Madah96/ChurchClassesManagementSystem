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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgressBar.Value = startpoint;
            Percentage.Text = startpoint + "%";
            if (MyProgressBar.Value < 30)
            {
                ScriptureLbl.Text = "Matthew 5:8 Blessed are the pure in heart, For they shall see God.";
            }
            if (MyProgressBar.Value > 30 && MyProgressBar.Value < 55)
            {
                ScriptureLbl.Text = "Proverbs 10:12 Hatred stirs up strife, But love covers all sins.";
            }
            if (MyProgressBar.Value >= 55 && MyProgressBar.Value < 80)
            {
                ScriptureLbl.Text = "Luke 6:24 Blessed are you poor, For yours is the kingdom of God.";
            }
            if (MyProgressBar.Value >= 80 && MyProgressBar.Value < 100)
            {
                ScriptureLbl.Text = "Timothy 2:11 For if we died with Him, We shall also live with Him.";
            }
            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
