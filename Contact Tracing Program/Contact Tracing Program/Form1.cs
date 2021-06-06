using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.CreateText("ContactTracing.txt");
            outputfile.WriteLine(NameBox1);
            outputfile.WriteLine(NameBox2);
            outputfile.WriteLine(NameBox3);
            outputfile.WriteLine(AgeBox);
            outputfile.WriteLine(SexBox);
            outputfile.WriteLine(TempBox);
            outputfile.WriteLine(HouseBox1);
            outputfile.WriteLine(HouseBox2);
            outputfile.WriteLine(HouseBox3);
            outputfile.WriteLine(HouseBox4);
            outputfile.WriteLine(HouseBox5);
            outputfile.WriteLine(DateBox1);
            outputfile.WriteLine(DateBox2);
            outputfile.WriteLine(DateBox3);

            outputfile.Close();
        }
    }
}
