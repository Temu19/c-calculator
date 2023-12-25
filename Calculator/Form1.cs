using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {


        
        // FIRST DECLARE IMPORTANT VARIABLES
        
        double resultValue = 0;
        string opration = "";
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //THE C  BUTTON CLEARS EVERYTHING
        private void button17_Click(object sender, EventArgs e)
        {
            Resultdisplay.Text = "0";
            resultValue = 0;
            lbCurrentOp.Text = "";
        }


        
        private void button_click(object sender, EventArgs e)
        {
            if (Resultdisplay.Text == "0" || (isoperation))
                Resultdisplay.Clear();
            isoperation = false;

            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!Resultdisplay.Text.Contains("."))
                    Resultdisplay.Text += button.Text;
                     
            }
            else
            {
                Resultdisplay.Text += button.Text;

            }
        }
        //USING THE HIDDEN LABEL BROWSE WHICH OPERATOR IS CHOOSE
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            opration = button.Text;
            resultValue = Double.Parse(Resultdisplay.Text);
            lbCurrentOp.Text = resultValue + " " + opration;
            isoperation = true;

        }
        //THE DELETE BUTTON
        private void button19_Click(object sender, EventArgs e)
        {
            if(Resultdisplay.Text.Length > 0)
                Resultdisplay.Text = Resultdisplay.Text.Remove(Resultdisplay.Text.Length - 1, 1);
            if (Resultdisplay.Text == "")
                Resultdisplay.Text = "0";
        }
        //THE CE BUTTON WHICH CLEARS THE RESULT DISPLAY AREA
        private void button18_Click(object sender, EventArgs e)
        {
            Resultdisplay.Text = "0";
           
        }
        //THE EQUALS TO BUTTON
        private void button16_Click(object sender, EventArgs e)
        {
            if(opration == "+")
            {
                Resultdisplay.Text = (resultValue + double.Parse(Resultdisplay.Text)).ToString();
            }
            else if(opration == "-")
            {
                Resultdisplay.Text = (resultValue - double.Parse(Resultdisplay.Text)).ToString();
            }
            else if(opration == "X")
            {
                Resultdisplay.Text = (resultValue * double.Parse(Resultdisplay.Text)).ToString();
            }
            else
            {
                Resultdisplay.Text = (resultValue / double.Parse(Resultdisplay.Text)).ToString();
            }
        }
    }
}
