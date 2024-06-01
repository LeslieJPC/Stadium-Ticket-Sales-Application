using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leslie_ONE
{// Coded by Leslie from Chapter 3
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }
        // Declare variables
        int ATix = 15, BTix = 12, CTix = 9, TotA = 0, TotB = 0, TotC = 0, TotR = 0;
        bool IntegerNum = true;

        private void button1_Click(object sender, EventArgs e)
        {//Codebehind Process Data Button
            try
            {                
                if (GetInput())
                {
                    ProcessData();
                    OutputData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private bool GetInput()
        {
            IntegerNum = true;
            {
                if (!(int.TryParse(textBox1.Text, out ATix)))
                {
                    MessageBox.Show("Please enter a valid number for Ticket A.");
                    IntegerNum = false;
                    //return;
                }
                if (IntegerNum && !int.TryParse(textBox2.Text, out BTix))
                {
                    MessageBox.Show("Please enter a valid number for Ticket B.");
                    IntegerNum = false;
                }
                if (IntegerNum && !int.TryParse(textBox3.Text, out BTix))
                {
                    MessageBox.Show("Please enter a valid number for Ticket C.");
                    IntegerNum = false;
                }
            }

            return IntegerNum;
            
        }
        private void ProcessData()
        { //code to compute end-user input
            try
            {             
                TotA = 15 * ATix;
                TotB = 12 * BTix;
                TotC = 9 * CTix;

                //code to Total end-user ticket request
                TotR = TotA + TotB + TotC;
            }
            catch (Exception)
            {
                MessageBox.Show("Processing Data.");
                throw;
            }
        }
        private void OutputData()
        {//code to turn end-user total in currency and to show in label boxes
            try
            {                
                label1.Text = TotA.ToString("C");
                label2.Text = TotB.ToString("C");
                label3.Text = TotC.ToString("C");
                label4.Text = TotR.ToString("C");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {///code behind the clear all button
            Reset();
        }

        private void Reset()
        {//code to clear end-user input and results that populate in the label boxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {//code behind exit app button
            MessageBox.Show("Enjoy the Game!"); 
            this.Close();            
        }
    }
}
