using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var interpreterPath = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python37_64\python.exe";
            var scriptPath = @"..\..\..\add\add.py";
            var args = new List<string>
            {
                scriptPath, textBox1.Text, textBox2.Text
            };
            var p = new Process()
            {
                StartInfo = new ProcessStartInfo(interpreterPath)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Join(" ", args),
                },
            };
            p.Start();
            var so = p.StandardOutput;
            var result = so.ReadLine();
            p.WaitForExit();
            p.Close();
            MessageBox.Show(textBox1.Text + "+" + textBox2.Text + "=" + result + "です");
        }
    }
}
