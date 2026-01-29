namespace LabProductsSQLInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInseguro_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ProductService();
                string pesquisa = txtPesquisa.Text;

                var produtos = service.SearchInseguro(pesquisa);

                dgvProdutos.DataSource = produtos;

                MessageBox.Show($"Encontrados {produtos.Count} produtos (pesquisa vulneravel)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnSeguro_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ProductService();
                string pesquisa = txtPesquisa.Text;

                var produtos = service.SearchSeguro(pesquisa);

                dgvProdutos.DataSource = produtos;

                MessageBox.Show($"Encontrados {produtos.Count} produtos (pesquisa segura)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ProductService();

                var produtos = service.GetAll();

                dgvProdutos.DataSource = produtos;

                MessageBox.Show($"Total: {produtos.Count} produtos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
