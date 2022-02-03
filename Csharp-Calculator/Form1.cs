using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation;//Declaration operaion variable for storing Operator type 
        int value1;   //Declaration of value1 for storing the first input
        int value2;   //Declaration of value1 for storing the second input

        private  void btn_config() //After the user clicks on one of the buttons (btnAddition, tnSubtraction, btnMultiplication, btnDivision), this function run .
                                   //Get value1 from txtInput and
                                   //disables the four buttons and activates the equal button.
        {
            
            value1 = int.Parse(txtInput.Text);
            txtInput.Text = "";
            btnAddition.Visible = false;
            btnSubtraction.Visible = false;
            btnMultiplication.Visible = false;
            btnDivision.Visible = false;
            btnEqual.Visible = true;
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnEqual.Visible = false;   //btnEqual disable by default
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            value2 = int.Parse(txtInput.Text); //get value2 from txtInput
            switch (operation)     //detect the action and perform and show the output as a messagebox
            {
                case "addition":
                    {
                        MessageBox.Show("Equal : " +(value1+value2)); //show the output
                         Application. Restart();  //restart the form
                        
                        break;
                    }
                case "subtraction":
                    {
                        MessageBox.Show("Equal : " + (value1 - value2)); //show output
                         Application. Restart(); //restart the form
                        break;
                    }
                case "division":
                    {
                        MessageBox.Show("Equal : " + (value1 / value2));//show output
                        Application. Restart(); //restart the form
                        break;
                    }
                case "multiplication":
                    {
                        MessageBox.Show("Equal : " + (value1 * value2));//show output
                        Application. Restart(); //restart the form
                        break;
                    }




            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operation = "addition"; //storing type of operator in the operation variable
            btn_config();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operation = "subtraction";//storing type of operator in the operation variable
            btn_config();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operation = "multiplication";//storing type of operator in the operation variable
            btn_config();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operation = "division";//storing type of operator in the operation variable
            btn_config();
        }
    }
}
