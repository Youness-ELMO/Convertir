using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somme1
{
    public partial class convertisseur : Form
    {
        public convertisseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text != "")
            {
               
                float d = float.Parse(textBox1.Text);
                float t = float.Parse(textBox2.Text);

                textBox3.Text = (d * t).ToString();
            }
            else
            {
                MessageBox.Show("remplir tout les cases", "proleme");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.ResetText();
        }

        private void convertisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
