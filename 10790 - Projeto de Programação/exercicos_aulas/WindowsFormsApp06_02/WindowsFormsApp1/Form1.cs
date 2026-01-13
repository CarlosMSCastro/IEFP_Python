using System;
using System.Linq;
using System.Windows.Forms;

namespace FormularioUtilizador
{
    public partial class FormRegisto : Form
    {
        public FormRegisto()
        {
            InitializeComponent();
            CarregarPaises();
        }

        private void CarregarPaises()
        {
            cmbBoxPais.Items.Add("Portugal");
            cmbBoxPais.Items.Add("Brasil");
            cmbBoxPais.Items.Add("Espanha");
            cmbBoxPais.Items.Add("França");
            cmbBoxPais.Items.Add("Alemanha");
        }
        private bool ValidarEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        // Função auxiliar para idade ≥ 18
        private bool ValidarIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade >= 18;
        }
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Nome
            if (string.IsNullOrWhiteSpace(txtBoxNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome completo.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxNome.Focus();
                return;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) || !ValidarEmail(txtBoxEmail.Text))
            {
                MessageBox.Show("Por favor, insira um email válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                return;
            }

            // Telefone
            if (string.IsNullOrWhiteSpace(txtBoxTelefone.Text) || txtBoxTelefone.Text.Length < 9 || !txtBoxTelefone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira um telefone válido com pelo menos 9 dígitos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTelefone.Focus();
                return;
            }

            // Password
            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text) || txtBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("A password deve ter pelo menos 6 caracteres.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPassword.Focus();
                return;
            }

            // Confirmar Password
            if (txtBoxPassword.Text != txtBoxConfirmarPassword.Text)
            {
                MessageBox.Show("As passwords não coincidem.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxConfirmarPassword.Focus();
                return;
            }

            // Termos
            if (!checkboxAceito.Checked)
            {
                MessageBox.Show("Deve aceitar os Termos e Condições.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkboxAceito.Focus();
                return;
            }

            // 7Género
            if (!radioBtnMasculino.Checked && !radioBtnFeminino.Checked && !radioBtnOutro.Checked)
            {
                MessageBox.Show("Por favor, selecione o género.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioBtnMasculino.Focus();
                return;
            }

            // Idade 
            if (!ValidarIdade(dateTimePicker.Value))
            {
                MessageBox.Show("O utilizador deve ter pelo menos 18 anos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker.Focus();
                return;
            }
            SalvarDadosTxt();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar TextBoxes
            txtBoxNome.Text = "";
            txtBoxEmail.Text = "";
            txtBoxTelefone.Text = "";
            txtBoxMorada.Text = "";
            txtBoxPassword.Text = "";
            txtBoxConfirmarPassword.Text = "";

            // Limpar ComboBox
            cmbBoxPais.SelectedIndex = -1;

            // Resetar DateTimePicker
            dateTimePicker.Value = DateTime.Today;

            // Limpar CheckBoxes
            checkboxAceito.Checked = false;
            checkBoxDesejo.Checked = false;

            // Resetar RadioButtons
            radioBtnMasculino.Checked = false;
            radioBtnFeminino.Checked = false;
            radioBtnOutro.Checked = false;

            // Dar focus ao primeiro campo
            txtBoxNome.Focus();
        }

        private void SalvarDadosTxt()
        {
            string paisSelecionado = cmbBoxPais.SelectedItem != null ? cmbBoxPais.SelectedItem.ToString() : "Não selecionado";
            string genero = radioBtnMasculino.Checked ? "Masculino" : radioBtnFeminino.Checked ? "Feminino" : radioBtnOutro.Checked ? "Outro" : "Não selecionado";

            string dados = $"Nome: {txtBoxNome.Text}\r\n" +
                           $"Email: {txtBoxEmail.Text}\r\n" +
                           $"Telefone: {txtBoxTelefone.Text}\r\n" +
                           $"Morada: {txtBoxMorada.Text}\r\n" +
                           $"País: {paisSelecionado}\r\n" +
                           $"Género: {genero}\r\n" +
                           $"Data de Nascimento: {dateTimePicker.Value.ToShortDateString()}\r\n" +
                           $"Aceito Termos: {checkboxAceito.Checked}\r\n" +
                           $"Desejo Newsletter: {checkBoxDesejo.Checked}\r\n" +
                           $"------------------------------------\r\n";

            // Gravar no ficheiro
            string caminho = System.IO.Path.Combine(Application.StartupPath, "registos.txt");
            System.IO.File.AppendAllText(caminho, dados);

            MessageBox.Show("Dados guardados com sucesso no ficheiro!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
