namespace WindowsFormsApp06_01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer
        private void InitializeComponent()
        {
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lstFornecedores = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(221, 120);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged_1);
            // 
            // lstFornecedores
            // 
            this.lstFornecedores.Location = new System.Drawing.Point(459, 153);
            this.lstFornecedores.Name = "lstFornecedores";
            this.lstFornecedores.Size = new System.Drawing.Size(120, 95);
            this.lstFornecedores.TabIndex = 1;
            this.lstFornecedores.SelectedIndexChanged += new System.EventHandler(this.lstFornecedores_SelectedIndexChanged_1);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(253, 228);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(818, 392);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lstFornecedores);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ListBox lstFornecedores;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

