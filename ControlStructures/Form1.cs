using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            string first = "Joe";
            string last = "Ortiz";
            //Interpolated string C# 6 feature, 
            //this is same as first + " " + last;
            string full = $"{first} {last}";

            int number = 10;
            switch (number)
            {
                case int n when (n >= 0 && n <= 10):

                    break;
            }


            //this can replace an if-else statement, this is called a Switch Statement
            string grade = "C";

            switch (grade)
            {
                //if statement
                case "A":
                    MessageBox.Show("Excellent");
                    break;
                case "B":
                    MessageBox.Show("Good");
                    break;
                case "C":
                    MessageBox.Show("Okay");
                    break;
                //the else statement
                default:
                    MessageBox.Show("Unhandled");
                    break;
            }


            byte age = 20;
            if (age >= 18)
            {
                //can just type mbox and tab tab for shortcut(Code snippet)
                MessageBox.Show("You are an adult!",
                            "Welcome",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }
    }
}
