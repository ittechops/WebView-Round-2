using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace Launcher
{
    public partial class Form1 : Form
    {
        Operations ops = new Operations();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ops.LaunchUI();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ops.ChangeUrl("https://microsoft.com");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ops.ChangeUrl("https://amazon.com");
        }
    }
}
