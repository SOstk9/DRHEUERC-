using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vier_gewinnt.Form1;

namespace Vier_gewinnt
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        
        private void user1Eingabe_Click(object sender, EventArgs e)
        {
            string user1 = textBox1.Text;
            MessageBox.Show(string.Format("Dein Username lautet: {0}",user1),  "User1", MessageBoxButtons.OK);
        }

        private void user2Eingabe_Click(object sender, EventArgs e)
        {
            string user2 = textBox2.Text;
            MessageBox.Show(string.Format("Dein Username lautet: {0}", user2), "User2", MessageBoxButtons.OK);
              
        }

        
    }
}
