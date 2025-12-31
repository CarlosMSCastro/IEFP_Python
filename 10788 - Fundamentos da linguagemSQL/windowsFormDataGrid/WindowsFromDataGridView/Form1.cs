using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Clientes");
            cmbTipo.Items.Add("Fornecedores");
            cmbTipo.Items.Add("Funcionários");

            cmbTipo.SelectedIndexChanged += CmbTipo_SelectedIndexChanged;
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PRIDEMO;Integrated Security=True;";
            
            if (cmbTipo.SelectedItem == null)
                return;

            string opcaoSelecionada = cmbTipo.SelectedItem.ToString();

            string query = "";

            if (opcaoSelecionada == "Clientes")
            {
                query = "SELECT Cliente, Nome, NumContrib, Pais, TotalDeb FROM Clientes";
            }
            else if (opcaoSelecionada == "Fornecedores")
            {
                query = "SELECT Fornecedor, Nome, NumContrib, Pais, TotalDeb FROM Fornecedores";
            }
            else if (opcaoSelecionada == "Funcionários")
            {
                query = "SELECT Codigo, Nome, Telefone, DataNascimento FROM Funcionarios";
            }

            DataTable dt = new DataTable();

 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dt);

                dgvDados.DataSource = dt;
            }

        }
    }
}
