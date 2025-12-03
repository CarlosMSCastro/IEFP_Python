using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirDadosBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable idiomas= new DataTable();
            idiomas.Columns.Add(new DataColumn("CodIdioma", typeof(string)));
            idiomas.Columns.Add(new DataColumn("Idioma", typeof(string)));
            idiomas.Rows.Add("EN", "Inglês");
            idiomas.Rows.Add("ES", "Espanhol");
            idiomas.Rows.Add("FR", "Francês");
            idiomas.Rows.Add("PT", "Português");

            cmbIdioma.DataSource = idiomas;
            cmbIdioma.DisplayMember = "Idioma";
            cmbIdioma.ValueMember = "CodIdioma";
            cmbIdioma.SelectedIndex = 3;

            //cmbIdioma.Items.Add("EN");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
