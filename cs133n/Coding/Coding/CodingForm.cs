using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding
{
    public partial class CodingForm : Form
    {
        public CodingForm()
        {
            InitializeComponent();
        }

        private char GetEncodedChar(char normalChar)
        {
            //if it is a letter
            if (Char.IsLetter(normalChar))
            {
                //makes it lowercase
                normalChar = Char.ToLower(normalChar);
                //this refers to the form; controls is a collection; 
                //inside[] constructs a string that combines the input letter with textbox(name of textbox)
                TextBox t = (TextBox)(this.Controls[normalChar + "TextBox"]);
                //if textbox is not empty will return whatever is in that textbox
                
                if (t != null && t.Text.Length > 0)
                    return Char.ToLower(t.Text[0]);
                else
                    return normalChar;
            }
            else
                return normalChar;
        }

        private string encodeString(string inputString)
        {
            //declare new string to hold encoded characters
            string newString = "";
            
            //iterate through input string to encode letters appropriately
            for (int i = 0; i < inputString.Length; i++)
            {
                char a = inputString[i];
                a = GetEncodedChar(inputString[i]);
                newString += a;
            }

            //return new string with encoded characters
            return newString;
        }

        //returns string with decoded characters. Calls decodeChar
        private string decodeString(string inputString)
        {
            //empty string to hold decoded letters appropriately
            string newString = "";

            //for each char in input string replace with decoded char as appropriate
            for (int i = 0; i < inputString.Length; i++)
            {
                char a = inputString[i];
                a = decodeChar(inputString[i]);
                newString += a;

            }

            //return new string with replaced chars
            return newString;
        }

        private char decodeChar(char normalChar)
        {
            //for each char, if char is equal to text box encoded letter, replace w/original char
            if (Char.Equals(normalChar, aTextBox.Text[0]))
            {
                normalChar = 'a';
            }
            else if (char.Equals(normalChar, bTextBox.Text[0]))
            {
                normalChar = 'b';
            }
            else if (char.Equals(normalChar, cTextBox.Text[0]))
            {
                normalChar = 'c';
            }
            else if (char.Equals(normalChar, dTextBox.Text[0]))
            {
                normalChar = 'd';
            }
            else if (char.Equals(normalChar, eTextBox.Text[0]))
            {
                normalChar = 'e';
            }
            //return char with decoded letters
            return normalChar;
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            //call encodeString method
            inputTextBox.Text = encodeString(inputTextBox.Text);
            /*
            //take a single letter out of string and pop it up in message box
            char messageLetter = inputTextBox.Text[0];
            char encodedLetter = GetEncodedChar(messageLetter);
            MessageBox.Show(encodedLetter.ToString());

            //need a loop and decode button and decode method
             */
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            //call decodeString method
            inputTextBox.Text = decodeString(inputTextBox.Text);
        }
    }
}
