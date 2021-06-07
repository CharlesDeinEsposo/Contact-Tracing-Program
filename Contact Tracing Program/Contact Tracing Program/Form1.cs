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

            {
                if (NameBox1.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (NameBox3.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (AgeBox.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (SexBox.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (TempBox.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (ContactBox1.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (HouseBox1.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (HouseBox2.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (HouseBox3.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (HouseBox4.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (HouseBox5.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (DateBox1.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (DateBox2.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else if (DateBox3.Text == "")
                {
                    MessageBox.Show("Please put an input on the required fields.");
                }
                else
                {
                    Button b = (Button)sender;
                    b.Enabled = false;

                    MessageBox.Show("Thank you for your participation.");

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
                    //Contact
                    outputfile.WriteLine("Phone Number: " + ContactBox1.Text);
                    outputfile.WriteLine("Email Address: " + ContactBox2.Text);
                    //Address
                    outputfile.Write("Address: " + HouseBox1.Text + ", ");
                    outputfile.Write(HouseBox2.Text + ", ");
                    outputfile.Write(HouseBox3.Text + ", ");
                    outputfile.Write(HouseBox4.Text + ", ");
                    outputfile.WriteLine(HouseBox5.Text);
                    //Date
                    outputfile.Write("Date: " + DateBox1.Text + " ");
                    outputfile.Write(DateBox2.Text + ", ");
                    outputfile.WriteLine(DateBox3.Text);

                    outputfile.Close();

                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;

            NameBox1.Clear();
            NameBox2.Clear();
            NameBox3.Clear();
            AgeBox.Clear();
            TempBox.Clear();
            ContactBox1.Clear();
            ContactBox2.Clear();
            HouseBox1.Clear();
            HouseBox2.Clear();
            HouseBox3.Clear();
            HouseBox4.Clear();
            HouseBox5.Clear();
            DateBox2.Clear();
            DateBox3.Clear();
            //SexBox Reset
            SexBox.Items.Clear();
            SexBox.Items.Add("Male");
            SexBox.Items.Add("Female");
            //DateBox Reset
            DateBox1.Items.Clear();
            DateBox1.Items.Add("January");
            DateBox1.Items.Add("February");
            DateBox1.Items.Add("March");
            DateBox1.Items.Add("April");
            DateBox1.Items.Add("May");
            DateBox1.Items.Add("June");
            DateBox1.Items.Add("July");
            DateBox1.Items.Add("August");
            DateBox1.Items.Add("September");
            DateBox1.Items.Add("October");
            DateBox1.Items.Add("November");
            DateBox1.Items.Add("December");
        }
    }
}
