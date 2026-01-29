namespace LabProductsSQLInjection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPesquisa = new TextBox();
            btnInseguro = new Button();
            btnSeguro = new Button();
            btnTodos = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar Produto";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 13F);
            txtPesquisa.Location = new Point(97, 66);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(181, 31);
            txtPesquisa.TabIndex = 1;
            // 
            // btnInseguro
            // 
            btnInseguro.BackColor = Color.IndianRed;
            btnInseguro.ForeColor = SystemColors.ButtonHighlight;
            btnInseguro.Location = new Point(12, 131);
            btnInseguro.Name = "btnInseguro";
            btnInseguro.Size = new Size(111, 35);
            btnInseguro.TabIndex = 2;
            btnInseguro.Text = "Pesquisa Insegura";
            btnInseguro.UseVisualStyleBackColor = false;
            btnInseguro.Click += btnInseguro_Click;
            // 
            // btnSeguro
            // 
            btnSeguro.BackColor = Color.YellowGreen;
            btnSeguro.Location = new Point(129, 131);
            btnSeguro.Name = "btnSeguro";
            btnSeguro.Size = new Size(111, 35);
            btnSeguro.TabIndex = 2;
            btnSeguro.Text = "Pesquisa Segura";
            btnSeguro.UseVisualStyleBackColor = false;
            btnSeguro.Click += btnSeguro_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(246, 131);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(111, 54);
            btnTodos.TabIndex = 2;
            btnTodos.Text = "Listar todos os Produtos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 209);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(345, 122);
            dgvProdutos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 350);
            Controls.Add(dgvProdutos);
            Controls.Add(btnTodos);
            Controls.Add(btnSeguro);
            Controls.Add(btnInseguro);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesquisa;
        private Button btnInseguro;
        private Button btnSeguro;
        private Button btnTodos;
        private DataGridView dgvProdutos;
    }
}
