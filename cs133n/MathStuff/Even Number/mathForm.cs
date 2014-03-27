using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Even_Number
{
    public partial class mathForm : Form
    {
        public mathForm()
        {
            InitializeComponent();
        }
        //method to test if number is even
        private bool IsEven(string number)
        {
            int num = int.Parse(number);
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        //method to test if number is odd
        private bool IsOdd(string number)
        {
            int num = int.Parse(number);
            if (num % 2 > 0)
                return true;
            else
                return false;
        }

        //method to test if number is prime
        private bool IsPrime(string number)
        {
            int num = int.Parse(number);
            int count = 0;
            if (num == 1)
                return false;
           
            else 
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        count++;
                }
                if (count == 0)
                    return true;
                else
                    return false;
            }
        }

        //method to test if number is perfect
        private bool IsPerfect(string number)
        {
            int total = 0;
            int num = int.Parse(number);
            int halfNum = num / 2;

            for (int i = 1; i <= halfNum; i++)
            {
                if (num % i == 0)
                {
                    total += i;
                }
            }
            if (total == num)
            {
                return true;
            }
            else
                return false;
        }

        private void evenOrOddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEven(numberTextBox.Text))
                    evenTextBox.Text = "Yes";
                else
                    evenTextBox.Text = "No";
                if (IsOdd(numberTextBox.Text))
                    oddTextBox.Text = "Yes";
                else
                    oddTextBox.Text = "No";
                if (IsPrime(numberTextBox.Text))
                    primeTextBox.Text = "Yes";
                else
                    primeTextBox.Text = "No";
                if (IsPerfect(numberTextBox.Text))
                    perfectTextBox.Text = "Yes";
                else
                    perfectTextBox.Text = "No";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
