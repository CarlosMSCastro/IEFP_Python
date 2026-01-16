using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp_03
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void frmInicio_Load(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = @"Server=.\SQLEXPRESS;Database=Clientes;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT codigo as [Código], nome as [Nome], morada as [Morada], telefone as [Telefone], contribuinte as [Contribuinte], email as [Email], genero as [Género] FROM clientes";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
        
        int codigo = Convert.ToInt32(linha.Cells["Código"].Value);
        string nome = linha.Cells["Nome"].Value?.ToString() ?? "";
        string morada = linha.Cells["Morada"].Value?.ToString() ?? "";
        string telefone = linha.Cells["Telefone"].Value?.ToString() ?? "";
        string contribuinte = linha.Cells["Contribuinte"].Value?.ToString() ?? "";
        string email = linha.Cells["Email"].Value?.ToString() ?? "";
        string genero = linha.Cells["Género"].Value?.ToString() ?? "";

        frmEditaCliente frmEdita = new frmEditaCliente(codigo, nome, morada, telefone, contribuinte, email, genero);
        
        if (frmEdita.ShowDialog() == DialogResult.OK)
        {
            frmInicio_Load(sender, e);
        }
    }
}
    }
}
