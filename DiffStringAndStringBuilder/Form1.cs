using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffStringAndStringBuilder
{
    public partial class Form1 : Form
    {
        private List<string> hugeList = Enumerable.Range(1000, 20000).Select(n => n.ToString()).ToList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string concatResult = "";
            foreach (string item  in hugeList)
            {
                concatResult += item;
            }
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string sbResult = "";
            foreach (string item in hugeList)
            {
                sb.Append(item);
            }
            sbResult = sb.ToString();
        }
    }
}
