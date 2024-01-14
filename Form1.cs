using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noemi_Angeles_CPT_185_A01S_CHAPTER_8
{
    public partial class morseCodeConverter : Form
    {
        char[] mandar = { ' ', ',', '.', '?', '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M',
        'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'}; //'' for char
        string[] morseCodee= { " ","--..--",".-.-.-","..--..","-----",".----","..---","...--","....-",".....","-....","--...","---..","----.",
        ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-",
        "...-",".--","-..-","-.--","--.." };

        public morseCodeConverter()
        {
            InitializeComponent();
        }

        private void morseCode_Load(object sender, EventArgs e)
        {
            morseTextBox.Focus();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            
           //user input
            string text = morseTextBox.Text.ToUpper();//convert user input to uppercase to be able to read array
            string result = " ";

            try
            {

                foreach (char letter in text)
                {

                    int z = Array.IndexOf(mandar, letter); //search the array char mandar
                    if (z>=  0)
                    {
                        string mCode = morseCodee[z];
                        result += mCode;
                    }
                    else { MessageBox.Show("Error! Invalid input!"); }



                }
            }catch (Exception ex)
            
            { MessageBox.Show(ex.Message); }

            //display morse code
            morseCodeDisplayLabelBox.Text = result;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            morseTextBox.Clear();
            morseCodeDisplayLabelBox = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            




    
