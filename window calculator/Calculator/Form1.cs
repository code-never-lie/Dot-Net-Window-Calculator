using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCD_LAB_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String txt = "";
        bool oper_pres = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((txt_output.Text == "0")||(oper_pres))
            {
                txt_output.Clear();            
            
            }
            Button button = (Button)sender;
            txt_output.Text = txt_output.Text + button.Text;




        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_output.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            txt = button.Text;
            value = Double.Parse(txt_output.Text);
            oper_pres = true;

        }

        private void op_res(object sender, EventArgs e)
        {
            switch(txt)
            {

                case "+":
                    txt_output.Text = (value + Double.Parse(txt_output.Text)).ToString();
                    break;
                case "-":
                    txt_output.Text = (value - Double.Parse(txt_output.Text)).ToString();
                    break;
                case "*":
                    txt_output.Text = (value * Double.Parse(txt_output.Text)).ToString();
                    break;
                case "/":
                    txt_output.Text = (value / Double.Parse(txt_output.Text)).ToString();
                    break;
                default:
                    break;
             }

            oper_pres = false ;
        }
    }
}
