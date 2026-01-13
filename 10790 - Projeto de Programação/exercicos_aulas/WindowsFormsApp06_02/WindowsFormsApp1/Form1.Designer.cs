namespace FormularioUtilizador
{
    partial class FormRegisto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblAniversario = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxMorada = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmarPassword = new System.Windows.Forms.TextBox();
            this.cmbBoxPais = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnFeminino = new System.Windows.Forms.RadioButton();
            this.radioBtnOutro = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkboxAceito = new System.Windows.Forms.CheckBox();
            this.checkBoxDesejo = new System.Windows.Forms.CheckBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(104, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registo de Utilizador";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(27, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(112, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(27, 174);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(27, 218);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(60, 17);
            this.lblMorada.TabIndex = 1;
            this.lblMorada.Text = "Morada:";
            // 
            // lblAniversario
            // 
            this.lblAniversario.AutoSize = true;
            this.lblAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAniversario.Location = new System.Drawing.Point(265, 174);
            this.lblAniversario.Name = "lblAniversario";
            this.lblAniversario.Size = new System.Drawing.Size(140, 17);
            this.lblAniversario.TabIndex = 1;
            this.lblAniversario.Text = "Data de Nascimento:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(27, 265);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 1;
            this.lblPais.Text = "País:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 312);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarPassword.Location = new System.Drawing.Point(265, 312);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(138, 17);
            this.lblConfirmarPassword.TabIndex = 1;
            this.lblConfirmarPassword.Text = "Confirmar Password:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(30, 105);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(448, 20);
            this.txtBoxNome.TabIndex = 2;
            // 
            // txtBoxMorada
            // 
            this.txtBoxMorada.Location = new System.Drawing.Point(30, 238);
            this.txtBoxMorada.Name = "txtBoxMorada";
            this.txtBoxMorada.Size = new System.Drawing.Size(448, 20);
            this.txtBoxMorada.TabIndex = 2;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(30, 149);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(448, 20);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(30, 194);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(210, 20);
            this.txtBoxTelefone.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(30, 332);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(210, 20);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxConfirmarPassword
            // 
            this.txtBoxConfirmarPassword.Location = new System.Drawing.Point(268, 332);
            this.txtBoxConfirmarPassword.Name = "txtBoxConfirmarPassword";
            this.txtBoxConfirmarPassword.Size = new System.Drawing.Size(210, 20);
            this.txtBoxConfirmarPassword.TabIndex = 2;
            this.txtBoxConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // cmbBoxPais
            // 
            this.cmbBoxPais.FormattingEnabled = true;
            this.cmbBoxPais.Location = new System.Drawing.Point(30, 288);
            this.cmbBoxPais.Name = "cmbBoxPais";
            this.cmbBoxPais.Size = new System.Drawing.Size(210, 21);
            this.cmbBoxPais.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(268, 193);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioBtnFeminino);
            this.groupBox.Controls.Add(this.radioBtnOutro);
            this.groupBox.Controls.Add(this.radioBtnMasculino);
            this.groupBox.Controls.Add(this.lblGenero);
            this.groupBox.Location = new System.Drawing.Point(30, 371);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(210, 100);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            // 
            // radioBtnFeminino
            // 
            this.radioBtnFeminino.AutoSize = true;
            this.radioBtnFeminino.Location = new System.Drawing.Point(6, 68);
            this.radioBtnFeminino.Name = "radioBtnFeminino";
            this.radioBtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioBtnFeminino.TabIndex = 6;
            this.radioBtnFeminino.TabStop = true;
            this.radioBtnFeminino.Text = "Feminino";
            this.radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // radioBtnOutro
            // 
            this.radioBtnOutro.AutoSize = true;
            this.radioBtnOutro.Location = new System.Drawing.Point(117, 45);
            this.radioBtnOutro.Name = "radioBtnOutro";
            this.radioBtnOutro.Size = new System.Drawing.Size(51, 17);
            this.radioBtnOutro.TabIndex = 6;
            this.radioBtnOutro.TabStop = true;
            this.radioBtnOutro.Text = "Outro";
            this.radioBtnOutro.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(6, 45);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMasculino.TabIndex = 6;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(3, 16);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 17);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Género";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(147, 416);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Outro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkboxAceito
            // 
            this.checkboxAceito.AutoSize = true;
            this.checkboxAceito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAceito.Location = new System.Drawing.Point(36, 490);
            this.checkboxAceito.Name = "checkboxAceito";
            this.checkboxAceito.Size = new System.Drawing.Size(219, 21);
            this.checkboxAceito.TabIndex = 7;
            this.checkboxAceito.Text = "Aceito os Termos e Condições";
            this.checkboxAceito.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesejo
            // 
            this.checkBoxDesejo.AutoSize = true;
            this.checkBoxDesejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDesejo.Location = new System.Drawing.Point(36, 517);
            this.checkBoxDesejo.Name = "checkBoxDesejo";
            this.checkBoxDesejo.Size = new System.Drawing.Size(204, 21);
            this.checkBoxDesejo.TabIndex = 7;
            this.checkBoxDesejo.Text = "Desejo receber a newsletter";
            this.checkBoxDesejo.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistar.Location = new System.Drawing.Point(30, 559);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(210, 59);
            this.btnRegistar.TabIndex = 8;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(268, 559);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(210, 59);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 661);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.checkBoxDesejo);
            this.Controls.Add(this.checkboxAceito);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cmbBoxPais);
            this.Controls.Add(this.txtBoxMorada);
            this.Controls.Add(this.txtBoxConfirmarPassword);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblConfirmarPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.lblAniversario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRegisto";
            this.Text = "Formulário de Registo de Utilizador";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblAniversario;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxMorada;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmarPassword;
        private System.Windows.Forms.ComboBox cmbBoxPais;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton radioBtnFeminino;
        private System.Windows.Forms.RadioButton radioBtnOutro;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkboxAceito;
        private System.Windows.Forms.CheckBox checkBoxDesejo;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

