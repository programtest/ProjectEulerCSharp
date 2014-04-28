using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectEulerLibrary;
using System.IO;

namespace ProjectEuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> test = Mathematics.GetPrimeNums(1000);
            //int test = Problem3.Solve();
            long product = Problem6.Solve();
        }
    }
}
