using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace person_data_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_save_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("c://user//data//data.text", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            string str = txt_name.Text +"   "+ txt_age.Text + "    " + txt_gender.Text;
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
            txt_name.Clear();
            txt_gender.Clear();
            txt_age.Clear();


        }

        private void but_show_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
             
            FileStream fs = new FileStream("d:\\person_data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                
                f2.setvalue(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
            fs.Close();


            f2.Show();




        }
    }
}
