using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        private string switchCase(string inputString)
        {
            //put string into an array
            //char[] stringReplace = inputString.ToArray();
            string outputString = "";

            //for each item in the array (char)
            for (int i = 0; i < inputString.Length; i++)
            {
                //if char is uppercase, replace w/lowecase
                if (Char.IsUpper(inputString[i]))
                {
                    outputString += char.ToLower(inputString[i]);
                }
                //if char is lowercase, replace w/uppercase
                else if (Char.IsLower(inputString[i]))
                {
                    outputString += char.ToUpper(inputString[i]);
                }
               
            }
            /*
            //iterate through new array and add each char back into a string
            foreach(char a in stringReplace)
            {
                outputString += a;
            }
            //return new string
             */
            return outputString;
        }

        //method returns string in reverse order using array method
        private string reverseString(string inputString)
        {
            string newString = "";
            char[] array = inputString.ToArray();
            Array.Reverse(array);

            foreach (char a in array)
            {
                newString += a;
            }
            return newString;
        }

        //method removes substring and adds nay to end with first char
        private string pigLatin(string inputString)
        {
            string newString = "";
            char[] stringArray = inputString.ToArray();
            int stringLength = inputString.Length;
            char substring = inputString[0];

            newString = inputString.Remove(0,1) + substring + "nay";

            return newString;
        }

        //returns location in alpha array and adds 10 to index
        private string shiftCipher(string inputString)
        {
            inputString = inputString.ToLower();
            string newString = "";
            char[] alphaArray = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                     'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
            char[] stringArray = inputString.ToArray();
            int alphaLength = alphaArray.Length;
            int stringLength = inputString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                if (Char.IsNumber(stringArray[i]))
                {
                    MessageBox.Show("Please enter only letters.");
                    newString = "";
                }
                else
                {
                    int cipherLoc = Array.IndexOf(alphaArray, stringArray[i]);
                    int newLoc = cipherLoc + 10;
                    stringArray[i] = alphaArray[newLoc];
                    newString += stringArray[i];
                }
            }
            
            return newString;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "")
            {
                MessageBox.Show("Please enter text into the text box.");
            }
            else
            {
                switchCaseTextBox.Text = switchCase(numberTextBox.Text);
                reverseTextBox.Text = reverseString(numberTextBox.Text);
                pigLatinTextBox.Text = pigLatin(numberTextBox.Text);
                cypherTextBox.Text = shiftCipher(numberTextBox.Text);
            }
        }
    }
}
