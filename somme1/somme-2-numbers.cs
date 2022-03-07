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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculButton_Click(object sender, EventArgs e)
        {
            if (nombre1TextBox.Text!=""&& nombre2TextBox.Text != "")
            {
             float n1 = float.Parse(nombre1TextBox.Text);
             float n2 = float.Parse(nombre2TextBox.Text);

             CalculTextBox.Text = (n1 + n2).ToString();//convertir val a chaine
            }

            else
            {
                MessageBox.Show("remplir tout les champs", "erreur");
            }

           

        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            nombre1TextBox.Text = "";
            nombre2TextBox.ResetText();//pour supp = remove
            CalculTextBox.Clear();
        }
    }
}
