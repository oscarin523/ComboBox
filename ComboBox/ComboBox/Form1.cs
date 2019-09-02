using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cBalimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = cBalimentos.Items[indice].ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBalimentos.Items.Add("Pozole");
            cBalimentos.Items.Add("Tostadas de Pata");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cBalimentos.Items.Add(textBox1.Text);
        }

        private void BtnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                BtnAgregar_Click(sender, e);
            }
        }
    }
    
}
