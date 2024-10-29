using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zadatak14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("wordpad.exe");
        }

        

        private void btnStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe")
            {
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = "http://www.sser.hr"
            };

            Process.Start(startInfo);
        }
    }
}