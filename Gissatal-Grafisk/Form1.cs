using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissatal_Grafisk
{
    public partial class Form1 : Form
    {

        private int rndtal;
        private int antalGuess;

        public Form1()
        {
            InitializeComponent();
            Random rndint = new Random(); // Våran slumpmäsiga int variabel.            
            rndtal = rndint.Next(0, 100); // Här sätts värdet på variablen till ett slumpmässigt tal mellan 0 och 100.
            int antalGuess = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
            
        {
            string strsvar = textBox1.Text;
            int intsvar = Convert.ToInt32(strsvar);
            if (intsvar == rndtal)
            {
                richTextBox1.Text = "Du har gissat rätt, bra jobbat!";
            }
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
