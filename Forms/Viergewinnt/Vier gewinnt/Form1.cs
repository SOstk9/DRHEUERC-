using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vier_gewinnt
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }


        

        

        private void reihe1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form2 settingsform = new Form2(this);

            //settingsform.Show();
        }

        private void reihe2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            if(textBox2.BackColor == Color.Red)
            {
                textBox9.BackColor = Color.Red;
            }
        }

        private void reihe3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
        }

        private void reihe4_Click(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Red;
        }

        private void reihe5_Click(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Red;
        }

        private void reihe6_Click(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Red;
        }

        private void reihe7_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Red;
        }
    }
}
