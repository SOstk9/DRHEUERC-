using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_erstmal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FeldErzeugen(int zeilen = 7, int spalten = 6)
        {
            Form2 form2 = new Form2();
            Panel panel = form2.Controls["panel1"] as Panel;

            int anzahl = zeilen * spalten;

            int x = Abstand(panel.Width, spalten);
            int y = Abstand(panel.Height, zeilen);
            int counter = 0;
            //for (int i = 0; i < zeilen; i++)
            //{
            //    for (int j = 0; j < spalten; j++)
            //    {
            //        Button btn = new Button();
            //        btn.Width = x;
            //        btn.Height = y;
            //        btn.Text = $"Button {i * spalten + j + 1}";
            //        btn.Left = j * x;
            //        btn.Top = i * y;
            //        panel1.Controls.Add(btn);
            //    }
            //}

            for (int i = 0; i < spalten; i++)
            {
                for (int j = 0; j < zeilen; j++)
                {
                    Button btn = new Button()
                    {
                        Width = x,
                        Height = y,
                        Text = $"Button {i * zeilen + j +1}",
                        Left = i * x,
                        Top = j * y,
                        Tag = counter++
                    };

                    btn.Click += Button_Click;
                    panel.Controls.Add(btn);
                }
            }
            form2.Show();
        }

        static int Abstand(int maße, int elemente, int marg = 3)
        {
            int gesamtmargin = elemente * marg;
            int länge = maße - gesamtmargin;
            int abstand = länge / elemente;
           
            return abstand;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FeldErzeugen(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

      
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            int buttonIndex = (int)clickedButton.Tag;
            MessageBox.Show($"Button {buttonIndex + 1 } wurde angeklickt!");
        }

    }
}
