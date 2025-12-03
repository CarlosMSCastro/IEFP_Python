namespace InserirDadosBD
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

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtNomePais = new System.Windows.Forms.TextBox();
            this.txtISOA3 = new System.Windows.Forms.TextBox();
            this.txtISON = new System.Windows.Forms.TextBox();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.lblNomePais = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblISOA3 = new System.Windows.Forms.Label();
            this.lblISON = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblComunidade = new System.Windows.Forms.Label();
            this.cmbComunidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(61, 78);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPais.TabIndex = 0;
            // 
            // txtNomePais
            // 
            this.txtNomePais.Location = new System.Drawing.Point(61, 130);
            this.txtNomePais.Name = "txtNomePais";
            this.txtNomePais.Size = new System.Drawing.Size(138, 20);
            this.txtNomePais.TabIndex = 0;
            // 
            // txtISOA3
            // 
            this.txtISOA3.Location = new System.Drawing.Point(61, 236);
            this.txtISOA3.Name = "txtISOA3";
            this.txtISOA3.Size = new System.Drawing.Size(100, 20);
            this.txtISOA3.TabIndex = 0;
            // 
            // txtISON
            // 
            this.txtISON.Location = new System.Drawing.Point(61, 294);
            this.txtISON.Name = "txtISON";
            this.txtISON.Size = new System.Drawing.Size(125, 20);
            this.txtISON.TabIndex = 0;
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(58, 62);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(65, 13);
            this.lblCodigoPais.TabIndex = 1;
            this.lblCodigoPais.Text = "Código País";
            // 
            // lblNomePais
            // 
            this.lblNomePais.AutoSize = true;
            this.lblNomePais.Location = new System.Drawing.Point(58, 114);
            this.lblNomePais.Name = "lblNomePais";
            this.lblNomePais.Size = new System.Drawing.Size(75, 13);
            this.lblNomePais.TabIndex = 1;
            this.lblNomePais.Text = "Nome do País";
            this.lblNomePais.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(58, 170);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 1;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblISOA3
            // 
            this.lblISOA3.AutoSize = true;
            this.lblISOA3.Location = new System.Drawing.Point(58, 220);
            this.lblISOA3.Name = "lblISOA3";
            this.lblISOA3.Size = new System.Drawing.Size(38, 13);
            this.lblISOA3.TabIndex = 1;
            this.lblISOA3.Text = "ISOA3";
            this.lblISOA3.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblISON
            // 
            this.lblISON.AutoSize = true;
            this.lblISON.Location = new System.Drawing.Point(58, 278);
            this.lblISON.Name = "lblISON";
            this.lblISON.Size = new System.Drawing.Size(33, 13);
            this.lblISON.TabIndex = 1;
            this.lblISON.Text = "ISON";
            this.lblISON.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(61, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(61, 186);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 3;
            // 
            // lblComunidade
            // 
            this.lblComunidade.AutoSize = true;
            this.lblComunidade.Location = new System.Drawing.Point(58, 342);
            this.lblComunidade.Name = "lblComunidade";
            this.lblComunidade.Size = new System.Drawing.Size(66, 13);
            this.lblComunidade.TabIndex = 1;
            this.lblComunidade.Text = "Comunidade";
            this.lblComunidade.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbComunidade
            // 
            this.cmbComunidade.FormattingEnabled = true;
            this.cmbComunidade.Location = new System.Drawing.Point(61, 358);
            this.cmbComunidade.Name = "cmbComunidade";
            this.cmbComunidade.Size = new System.Drawing.Size(121, 21);
            this.cmbComunidade.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 499);
            this.Controls.Add(this.cmbComunidade);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblISON);
            this.Controls.Add(this.lblISOA3);
            this.Controls.Add(this.lblComunidade);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblNomePais);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.txtISON);
            this.Controls.Add(this.txtISOA3);
            this.Controls.Add(this.txtNomePais);
            this.Controls.Add(this.txtCodigoPais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.TextBox txtNomePais;
        private System.Windows.Forms.TextBox txtISOA3;
        private System.Windows.Forms.TextBox txtISON;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblNomePais;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblISOA3;
        private System.Windows.Forms.Label lblISON;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblComunidade;
        private System.Windows.Forms.ComboBox cmbComunidade;
    }
}

