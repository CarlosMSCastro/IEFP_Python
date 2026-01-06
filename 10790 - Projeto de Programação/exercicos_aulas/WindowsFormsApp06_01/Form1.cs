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

namespace WindowsFormsApp06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cnn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PRIDEMO;Integrated Security=True;";
            using (var conn = new SqlConnection(cnn))
            {
                conn.Open();

                var cmdClientes = new SqlCommand("SELECT cliente, nome FROM clientes", conn);
                var readerClientes = cmdClientes.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (readerClientes.Read())
                {
                    var cliente = new Cliente
                    {
                        codigo = readerClientes["cliente"].ToString(),
                        nome = readerClientes["nome"].ToString(),
                    };
                    clientes.Add(cliente);
                }
                readerClientes.Close();
                cmbClientes.DataSource = clientes;
                cmbClientes.ValueMember = "codigo";
                cmbClientes.DisplayMember = "nome";

                var cmdFornecedores = new SqlCommand("SELECT fornecedor, nome FROM fornecedores", conn);
                var readerFornecedores = cmdFornecedores.ExecuteReader();
                while (readerFornecedores.Read())
                {
                    lstFornecedores.Items.Add(new Fornecedor
                    {
                        codigo = readerFornecedores["fornecedor"].ToString(),
                        nome = readerFornecedores["nome"].ToString()
                    });
                }
            }
        }
        class Cliente
        {
            public string codigo {  get; set; }
            public string nome {  get; set; }
        }
        class Fornecedor
        {
            public string codigo { get; set; }
            public string nome { get; set; }
            public override string ToString()
            {
                return nome;
            }
        }

        private void cmbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1)
            {
                txtResultado.Text = cmbClientes.Text.ToString();
            }
        }

        private void lstFornecedores_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Fornecedor escolhido = lstFornecedores.SelectedItem as Fornecedor;
            txtResultado.Text = escolhido.codigo + " - " + escolhido.nome;
        }
    }
}
