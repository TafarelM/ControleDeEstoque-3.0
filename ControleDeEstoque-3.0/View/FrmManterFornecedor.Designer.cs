namespace View
{
    partial class FrmManterFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.dtpDataAbertura = new System.Windows.Forms.DateTimePicker();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.lblIDFornecedor = new System.Windows.Forms.Label();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblIDContato = new System.Windows.Forms.Label();
            this.txtIDContato = new System.Windows.Forms.TextBox();
            this.lblIDEndereco = new System.Windows.Forms.Label();
            this.txtIDEndereco = new System.Windows.Forms.TextBox();
            this.panelPrincipal.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.dtpDataAbertura);
            this.panelPrincipal.Controls.Add(this.mtxtCNPJ);
            this.panelPrincipal.Controls.Add(this.gbContato);
            this.panelPrincipal.Controls.Add(this.gbEndereco);
            this.panelPrincipal.Controls.Add(this.txtRazaoSocial);
            this.panelPrincipal.Controls.Add(this.txtNomeFantasia);
            this.panelPrincipal.Controls.Add(this.lblDataAbertura);
            this.panelPrincipal.Controls.Add(this.lblRazaoSocial);
            this.panelPrincipal.Controls.Add(this.lblCNPJ);
            this.panelPrincipal.Controls.Add(this.lblNomeFantasia);
            this.panelPrincipal.Controls.Add(this.txtIDEndereco);
            this.panelPrincipal.Controls.Add(this.txtIDContato);
            this.panelPrincipal.Controls.Add(this.txtIDFornecedor);
            this.panelPrincipal.Controls.Add(this.lblIDEndereco);
            this.panelPrincipal.Controls.Add(this.lblIDContato);
            this.panelPrincipal.Controls.Add(this.lblIDFornecedor);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(760, 365);
            this.panelPrincipal.TabIndex = 2;
            // 
            // dtpDataAbertura
            // 
            this.dtpDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAbertura.Location = new System.Drawing.Point(334, 74);
            this.dtpDataAbertura.Name = "dtpDataAbertura";
            this.dtpDataAbertura.Size = new System.Drawing.Size(105, 20);
            this.dtpDataAbertura.TabIndex = 7;
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(16, 116);
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(146, 20);
            this.mtxtCNPJ.TabIndex = 6;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.mtxtTelefone);
            this.gbContato.Controls.Add(this.lblTelefone);
            this.gbContato.Controls.Add(this.mtxtCelular);
            this.gbContato.Controls.Add(this.lblCelular);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Location = new System.Drawing.Point(3, 154);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(752, 100);
            this.gbContato.TabIndex = 5;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(184, 33);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(146, 20);
            this.mtxtTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(184, 17);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(13, 33);
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(146, 20);
            this.mtxtCelular.TabIndex = 6;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 17);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 2;
            this.lblCelular.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(346, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Controls.Add(this.mtxtCEP);
            this.gbEndereco.Controls.Add(this.cbEstado);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.lblEstado);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Location = new System.Drawing.Point(3, 260);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(751, 100);
            this.gbEndereco.TabIndex = 4;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(437, 58);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 6;
            this.lblCEP.Text = "CEP";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(437, 74);
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(144, 20);
            this.mtxtCEP.TabIndex = 5;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(310, 74);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(601, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(601, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 74);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(288, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(309, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 57);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(307, 33);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(288, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(307, 16);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(13, 33);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(288, 20);
            this.txtRua.TabIndex = 3;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(13, 16);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 2;
            this.lblRua.Text = "Rua";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(187, 116);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(288, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(16, 74);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(288, 20);
            this.txtNomeFantasia.TabIndex = 3;
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(331, 57);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(88, 13);
            this.lblDataAbertura.TabIndex = 2;
            this.lblDataAbertura.Text = "Data de Abertura";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(187, 99);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 2;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(16, 100);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(16, 57);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.lblNomeFantasia.TabIndex = 2;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Location = new System.Drawing.Point(16, 30);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.ReadOnly = true;
            this.txtIDFornecedor.Size = new System.Drawing.Size(57, 20);
            this.txtIDFornecedor.TabIndex = 1;
            // 
            // lblIDFornecedor
            // 
            this.lblIDFornecedor.AutoSize = true;
            this.lblIDFornecedor.Location = new System.Drawing.Point(16, 13);
            this.lblIDFornecedor.Name = "lblIDFornecedor";
            this.lblIDFornecedor.Size = new System.Drawing.Size(75, 13);
            this.lblIDFornecedor.TabIndex = 0;
            this.lblIDFornecedor.Text = "ID Fornecedor";
            // 
            // panelBtn
            // 
            this.panelBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBtn.Controls.Add(this.btnSalvar);
            this.panelBtn.Controls.Add(this.btnFechar);
            this.panelBtn.Location = new System.Drawing.Point(12, 383);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(760, 66);
            this.panelBtn.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(525, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 58);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(642, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 58);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblIDContato
            // 
            this.lblIDContato.AutoSize = true;
            this.lblIDContato.Location = new System.Drawing.Point(122, 13);
            this.lblIDContato.Name = "lblIDContato";
            this.lblIDContato.Size = new System.Drawing.Size(58, 13);
            this.lblIDContato.TabIndex = 0;
            this.lblIDContato.Text = "ID Contato";
            // 
            // txtIDContato
            // 
            this.txtIDContato.Location = new System.Drawing.Point(122, 30);
            this.txtIDContato.Name = "txtIDContato";
            this.txtIDContato.ReadOnly = true;
            this.txtIDContato.Size = new System.Drawing.Size(57, 20);
            this.txtIDContato.TabIndex = 1;
            // 
            // lblIDEndereco
            // 
            this.lblIDEndereco.AutoSize = true;
            this.lblIDEndereco.Location = new System.Drawing.Point(220, 13);
            this.lblIDEndereco.Name = "lblIDEndereco";
            this.lblIDEndereco.Size = new System.Drawing.Size(67, 13);
            this.lblIDEndereco.TabIndex = 0;
            this.lblIDEndereco.Text = "ID Endereço";
            // 
            // txtIDEndereco
            // 
            this.txtIDEndereco.Location = new System.Drawing.Point(220, 30);
            this.txtIDEndereco.Name = "txtIDEndereco";
            this.txtIDEndereco.ReadOnly = true;
            this.txtIDEndereco.Size = new System.Drawing.Size(57, 20);
            this.txtIDEndereco.TabIndex = 1;
            // 
            // FrmManterFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBtn);
            this.Name = "FrmManterFornecedor";
            this.Text = "FrmManterFornecedor";
            this.Load += new System.EventHandler(this.FrmManterFornecedor_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dtpDataAbertura;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtIDFornecedor;
        private System.Windows.Forms.Label lblIDFornecedor;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtIDEndereco;
        private System.Windows.Forms.TextBox txtIDContato;
        private System.Windows.Forms.Label lblIDEndereco;
        private System.Windows.Forms.Label lblIDContato;
    }
}