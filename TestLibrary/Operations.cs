using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Operations
    {
        frmMain frm = new frmMain();
        public void LaunchUI()
        {
            frm.Show();
        }
        public void ChangeUrl(string url)
        {
            frm.ChangeURL(url);
        }
    }
}
