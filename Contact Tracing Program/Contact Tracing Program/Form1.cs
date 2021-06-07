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
                    MessageBox.Show("Please enter your first name.");
                }
                else if (NameBox3.Text == "")
                {
                    MessageBox.Show("Please enter your last name.");
                }
                else if (AgeBox.Text == "")
                {
                    MessageBox.Show("Please enter your age.");
                }
                else if (SexBox.Text == "")
                {
                    MessageBox.Show("Please enter your gender.");
                }
                else if (TempBox.Text == "")
                {
                    MessageBox.Show("Please enter your temperature.");
                }
                else if (ContactBox1.Text == "")
                {
                    MessageBox.Show("Please enter your phone number.");
                }
                else if (HouseBox1.Text == "")
                {
                    MessageBox.Show("Please enter your street and house number.");
                }
                else if (HouseBox2.Text == "")
                {
                    MessageBox.Show("Please enter your barangay / village.");
                }
                else if (HouseBox3.Text == "")
                {
                    MessageBox.Show("Please enter your city / municipality.");
                }
                else if (HouseBox4.Text == "")
                {
                    MessageBox.Show("Please enter your province.");
                }
                else if (HouseBox5.Text == "")
                {
                    MessageBox.Show("Please enter your zip code.");
                }
                else if (DateBox1.Text == "")
                {
                    MessageBox.Show("Please put the current month.");
                }
                else if (DateBox2.Text == "")
                {
                    MessageBox.Show("Please put the current day.");
                }
                else if (DateBox3.Text == "")
                {
                    MessageBox.Show("Please put the current year.");
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
            Button c = (Button)sender;
            SaveButton.Enabled = true;

            NameBox1.Text = "";
            NameBox2.Text = "";
            NameBox3.Text = "";
            AgeBox.Text = "";
            SexBox.Text = "";
            TempBox.Text = "";
            ContactBox1.Text = "";
            ContactBox2.Text = "";
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
