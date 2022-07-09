using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form1 : Form
    {
        string assemblyPath = string.Empty;
        object ops = null;
        Assembly assembly = null;
        Type type = null;

        public Form1()
        {
            InitializeComponent();
            //assemblyPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\TestLibrary.dll";
            //assembly = Assembly.LoadFrom(assemblyPath);
            assembly = Assembly.LoadFrom("C:\\Users\\christopherday\\source\\repos\\WebView Round 2\\TestLibrary\\bin\\Debug\\TestLibrary.dll");
            type = assembly.GetType("TestLibrary.Operations");
            ops = Activator.CreateInstance(type);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodInfo myMethod = type.GetMethod("LaunchUI");
            myMethod.Invoke(ops, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MethodInfo myMethod = type.GetMethod("ChangeUrl");
            myMethod.Invoke(ops, new object[] {"https://microsoft.com"});
            //ops.ChangeUrl("https://microsoft.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MethodInfo myMethod = type.GetMethod("ChangeUrl");
            myMethod.Invoke(ops, new object[] { "https://amazon.com" });
            //ops.ChangeUrl("https://amazon.com");
        }
    }
}
