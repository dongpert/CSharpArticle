using System;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //Result.AppendText("Start" + Environment.NewLine);

            //var s1 = Singleton.Instance;
            //var s2 = Singleton.Instance;

            //s1.Flag = 2;

            //Result.AppendText("flag: " + s2.Flag + Environment.NewLine);

            //if (s1 == s2)
            //{
            //    Result.AppendText("Objects are the same instance");
            //}

            //var n1 = new Normal();
            //var n2 = new Normal();

            //if (n1 == n2)
            //{
            //    Result.AppendText("Objects are the same instance" + Environment.NewLine);
            //}
            //else
            //{
            //    Result.AppendText("Objects are the defference instance" + Environment.NewLine);
            //}

            Result.AppendText(Singleton.SingleInstance.LogMessage("test1") + Environment.NewLine);
            Result.AppendText(Singleton.SingleInstance.LogMessage("test2") + Environment.NewLine);
        }
    }
}