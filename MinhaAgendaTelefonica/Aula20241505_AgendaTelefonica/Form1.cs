using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20241505_AgendaTelefonica
{
    public partial class Form1 : Form
    {
        List<Contato> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Contato>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato novo = new Contato(textBox1.ToString(), textBox2.ToString(), textBox3.ToString(), textBox4.ToString());
            lista.Add(novo);

            dataGridView1.DataSource = null;
            // dataGridView1.DataSource = lista;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
