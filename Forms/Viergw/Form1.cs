using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viergw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public bool player = true;
        int x = 0;
        int y = 300;

        private void label1_Click(object sender, PaintEventArgs e, EventArgs f)
        {
            if (player == true)
            {
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(x, y, 50, 50);
                System.Drawing.Region r = new System.Drawing.Region(gp);
                Graphics gr = e.Graphics;
                gr.FillRegion(Brushes.Teal, r);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Black;

           for (int i = 0; i < 350 ; i = i+50)
            {
                for (int j = 0; j < 300; j = j + 50)
                {
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(i, j, 50, 50);
                    System.Drawing.Region r = new System.Drawing.Region(gp);
                    Graphics gr = e.Graphics;
                    gr.FillRegion(Brushes.White, r);
                }
            }
            


        }
        static void Kreismalen(int x, int y)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
       
    }

 
   
}
