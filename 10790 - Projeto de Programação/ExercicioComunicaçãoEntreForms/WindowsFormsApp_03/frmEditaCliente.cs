using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp_03
{
    public partial class frmEditaCliente : Form
    {
        private int _codigo;

        public frmEditaCliente(int codigo, string nome, string morada, string telefone, string contribuinte, string email, string genero)
        {
            InitializeComponent();
            
            _codigo = codigo;
            
            txtCodigo.Text = codigo.ToString();
            txtNome.Text = nome;
            txtMorada.Text = morada;
            txtTelefone.Text = telefone;
            txtContribuinte.Text = contribuinte;
            txtEmail.Text = email;
            
            if (genero == "M")
                rbMasculino.Checked = true;
            else if (genero == "F")
                rbFeminino.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }

            if (!rbMasculino.Checked && !rbFeminino.Checked)
            {
                MessageBox.Show("Selecione o género!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string genero = rbMasculino.Checked ? "M" : "F";

            string connectionString = @"Server=.\SQLEXPRESS;Database=clientes;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE clientes SET nome = @nome, morada = @morada, telefone = @telefone, contribuinte = @contribuinte, email = @email, genero = @genero WHERE codigo = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", _codigo);
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@morada", txtMorada.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                        cmd.Parameters.AddWithValue("@contribuinte", txtContribuinte.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@genero", genero);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
