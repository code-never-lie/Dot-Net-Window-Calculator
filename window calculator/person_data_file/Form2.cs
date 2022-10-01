using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person_data_file
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void setvalue(string output)
        {
            rtb_output.Text = rtb_output.Text + output + "\n";


        }

        private void rtb_output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
