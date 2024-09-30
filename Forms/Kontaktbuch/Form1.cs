using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kontaktbuch
{
    public partial class Form1 : Form
    {
        public struct Person
        {
            public string vorname;
            public string name;
            public string telefonnummer;
        }

        List<Person> personen = new List<Person>();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Neuen Eintrag zufügen
            EintragZufügen();
            Listehinzufügen();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                string indexString = listBox1.Items[index].ToString();
                string[] indexStringSplit = indexString.Split(' ');

                textBox1.Text = indexStringSplit[0];
                textBox2.Text = indexStringSplit[1];


            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == "Vorname")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "Name")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Vorname";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name";
                textBox2.ForeColor = Color.LightGray;
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Wollen Sie wirklich die gesamte Liste leeren?", "Leeren", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                personen.Clear();
                listBox1.Items.Clear();
       
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox1.Items[i]);
                }

                writer.Close();
            }
            dlg.Dispose();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }


        private void EintragZufügen()
        { //Struct mit Eintrag erweitern

            Person p = new Person();

            p.vorname = textBox1.Text;
            p.name = textBox2.Text;
            p.telefonnummer = textBox3.Text;
           
            personen.Add(p);

        }

        private void Listehinzufügen()
        {

            listBox1.Items.Clear();

            string eintrag = string.Empty;

            foreach (var p in personen)
            {
                eintrag = p.vorname + " " + p.name + " " + p.telefonnummer;
                listBox1.Items.Add(eintrag);

            }
        }

        private void eintragLoeschen_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult dialogResult =
                MessageBox.Show("möchten Sie den EIntrag wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int index = listBox1.SelectedIndex;
                    personen.RemoveAt(index);
                    Listehinzufügen();
                }
              
            }
            else
            {
                MessageBox.Show("Bitte den zu löschenden Eintrag auswählen!", "Fatal Error!", MessageBoxButtons.OK);

            }
        }

        private void aendern_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
               

                personen.RemoveAt(index);
                Person p = new Person();

                p.vorname = textBox1.Text;
                p.name = textBox2.Text;
                p.telefonnummer = textBox3.Text;

                personen.Insert(index,p);
                Listehinzufügen();


            }
            else
            {
                MessageBox.Show("Kein Eintrag ausgewählt!", "Fatal Error 69", MessageBoxButtons.OK);
            }

            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Telefonnummer")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Telefonnummer";
                textBox3.ForeColor = Color.LightGray;
            }
        }
    }
}
