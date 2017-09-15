using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        //text box will need to be a string that is converted into a float on operand event
        string input_text = "";
        string stored_input = "";
        //string calc_result = "";
        //double num_result = 0;
        string operand = "";
        //List<string> operation = new List<string>();




        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input_text += "1";
            this.textBox1.Text = input_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input_text += "2";
            this.textBox1.Text = input_text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input_text += "3";
            this.textBox1.Text = input_text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input_text += "4";
            this.textBox1.Text = input_text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input_text += "5";
            this.textBox1.Text = input_text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input_text += "6";
            this.textBox1.Text = input_text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input_text += "7";
            this.textBox1.Text = input_text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input_text += "8";
            this.textBox1.Text = input_text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input_text += "9";
            this.textBox1.Text = input_text;
        }


        private void button0_Click(object sender, EventArgs e)
        {
            input_text += "0";
            this.textBox1.Text = input_text;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            bool deciFlag = false;
            for (int i=0; i < input_text.Length; i++)
            {
                if (input_text[i] == '.')
                {
                    //there is already a decimal, throw an error
                    deciFlag = true;
                }
            }

            if (deciFlag == true)
            {
                //throw an error
                //clear all input and display an error
                //this.buttonClear_Click();
                buttonClear.PerformClick();
                this.textBox1.Text = "Error occured, please give valid input.";


            }

            else
            {
                //everything is fine, add to string
                input_text += ".";
                this.textBox1.Text = input_text;
            }

            deciFlag = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear all data
            input_text = "";
            stored_input = "";
            operand = "";
            this.textBox1.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sent_op = "+";
            operandHandler(sent_op);
            sent_op = "";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string sent_op = "-";
            operandHandler(sent_op);
            sent_op = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            string sent_op = "*";
            operandHandler(sent_op);
            sent_op = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string sent_op = "/";
            operandHandler(sent_op);
            sent_op = "";
        }

        private void operandHandler(string op)
        {
            {
                if (operand != "")
                {
                    //non empty operand, trying multiple at once, call clear
                    buttonClear.PerformClick();
                    this.textBox1.Text = "Error occured, please give one operation at a time.";
                }

                else
                {
                    //everything is fine, add to string
                    operand = op;
                    this.textBox1.Text = "";
                    stored_input = input_text;
                    input_text = "";
                }
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = stored_input + " " + operand + " " + input_text;
            //do the operation and then clear the storeinput and operand
            //the the result be the input_text
            double inputFloat = 0.0;
            double storedFloat = 0.0;
            double resultFloat = 0.0;
            //////////////////////////////////////////////////////////
            //if storedinput in empty, there is no second number; throw an error
            if (stored_input == "")
            {
                //throw an error
                buttonClear.PerformClick();
                this.textBox1.Text = "Error occured, Please give a copmplete and valid operation.";
            }

            else
            {
                //no erorrs, do the operation
                if (operand == "+")
                {
                    inputFloat = Convert.ToDouble(input_text);
                    storedFloat = Convert.ToDouble(stored_input);
                    //convert string to double
                    resultFloat = storedFloat + inputFloat;
                    this.textBox1.Text = Convert.ToString(resultFloat);

                }
                else if (operand == "-")
                {
                    inputFloat = Convert.ToDouble(input_text);
                    storedFloat = Convert.ToDouble(stored_input);
                    //convert string to double
                    resultFloat = storedFloat - inputFloat;
                    this.textBox1.Text = Convert.ToString(resultFloat);

                }

                else if (operand == "*")
                {
                    inputFloat = Convert.ToDouble(input_text);
                    storedFloat = Convert.ToDouble(stored_input);
                    //convert string to double
                    resultFloat = storedFloat * inputFloat;
                    this.textBox1.Text = Convert.ToString(resultFloat);

                }

                else if (operand == "/")
                {
                    inputFloat = Convert.ToDouble(input_text);
                    storedFloat = Convert.ToDouble(stored_input);
                    //convert string to double
                    resultFloat = storedFloat / inputFloat;
                    this.textBox1.Text = Convert.ToString(resultFloat);

                }

                else
                {
                    //unknown error, invalid operand
                    buttonClear.PerformClick();
                    this.textBox1.Text = "Error occured, invalid operation.";
                }
            }


            //////////////////////////////////////////////////////////
            // the result will be the input_text
            input_text = Convert.ToString(resultFloat);


            //do the operation and then clear the storeinput and operand

            stored_input = "";
            operand = "";

            inputFloat = 0.0;
            storedFloat = 0.0;
            resultFloat = 0.0;


        }
    }
}
