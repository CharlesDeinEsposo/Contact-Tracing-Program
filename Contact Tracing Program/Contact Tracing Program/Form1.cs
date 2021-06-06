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
            outputfile = File.AppendText("ContactTracing.txt");
            //Name
            outputfile.WriteLine(" ");
            outputfile.Write("Name: " + NameBox1.Text + " ");
            outputfile.Write(NameBox2.Text + " ");
            outputfile.WriteLine(NameBox3.Text);
            //
            outputfile.WriteLine("Age: " + AgeBox.Text);
            outputfile.WriteLine("Sex: " + SexBox.Text);
            outputfile.WriteLine("Temperature: " + TempBox.Text);
            //Address
            outputfile.Write("Address: " + HouseBox1.Text + ", ");
            outputfile.Write(HouseBox2.Text + ", ");
            outputfile.Write(HouseBox3.Text + " City" +  ", ");
            outputfile.Write(HouseBox4.Text + ", ");
            outputfile.WriteLine(HouseBox5.Text);
            //Date
            outputfile.Write("Date: " + DateBox1.Text + " ");
            outputfile.Write(DateBox2.Text + ", ");
            outputfile.WriteLine(DateBox3.Text);

            outputfile.Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NameBox1.Text = "";
            NameBox2.Text = "";
            NameBox3.Text = "";
            AgeBox.Text = "";
            SexBox.Text = "";
            TempBox.Text = "";
            HouseBox1.Text = "";
            HouseBox2.Text = "";
            HouseBox3.Text = "";
            HouseBox4.Text = "";
            HouseBox5.Text = "";
            DateBox1.Text = "";
            DateBox2.Text = "";
            DateBox3.Text = "";
        }
    }
}
