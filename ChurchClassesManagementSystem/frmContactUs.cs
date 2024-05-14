using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace ChurchClassesManagementSystem
{
    public partial class frmContactUs : Form
    {
        public frmContactUs()
        {
            InitializeComponent();
        }




        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://forms.gle/HLN2x21utWFjF89p8/");
        }

        private void frmContactUs_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            LiveClass Obj = new LiveClass();
            Obj.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            Resources Obj = new Resources();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContactUs Obj = new frmContactUs();
            Obj.Show();
            this.Hide();
        }
    }
}

