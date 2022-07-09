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

namespace TestLibrary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            InitializeAsync();
        }
        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            //goButton.Left = this.ClientSize.Width - goButton.Width;
            //addressBar.Width = goButton.Left - addressBar.Left;
        }
        public void ChangeURL(string url)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(url);
            }

        }

    }
}
