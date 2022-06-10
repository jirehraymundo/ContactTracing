using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;






namespace ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //StreamWriter file = File.AppendText(@"C:\Users\J24\Downloads\test.txt");

            StreamWriter file = new StreamWriter(@"C:\Users\J24\Downloads\test.txt", true);
            file.WriteLine("Name : " + TxtName.Text);
            file.WriteLine("Age : " + TxtAge.Text);
            file.WriteLine("Address : " + TxtAddress.Text);
            file.Close();
        }
    }
}