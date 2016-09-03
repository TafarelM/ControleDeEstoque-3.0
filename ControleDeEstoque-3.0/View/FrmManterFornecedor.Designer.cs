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
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblIDFornecedor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.dtpDataAbertura = new System.Windows.Forms.DateTimePicker();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.dtpDataAbertura);
            this.panelPrincipal.Controls.Add(this.maskedTextBox1);
            this.panelPrincipal.Controls.Add(this.gbContato);
            this.panelPrincipal.Controls.Add(this.gbEndereco);
            this.panelPrincipal.Controls.Add(this.txtRazaoSocial);
            this.panelPrincipal.Controls.Add(this.textBox2);
            this.panelPrincipal.Controls.Add(this.lblDataAbertura);
            this.panelPrincipal.Controls.Add(this.lblRazaoSocial);
            this.panelPrincipal.Controls.Add(this.lblCNPJ);
            this.panelPrincipal.Controls.Add(this.lblNome);
            this.panelPrincipal.Controls.Add(this.textBox1);
            this.panelPrincipal.Controls.Add(this.lblIDFornecedor);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(760, 365);
            this.panelPrincipal.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 20);
            this.textBox2.TabIndex = 3;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 116);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBox1.TabIndex = 6;
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
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(187, 99);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 2;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(187, 116);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(288, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // dtpDataAbertura
            // 
            this.dtpDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAbertura.Location = new System.Drawing.Point(334, 74);
            this.dtpDataAbertura.Name = "dtpDataAbertura";
            this.dtpDataAbertura.Size = new System.Drawing.Size(105, 20);
            this.dtpDataAbertura.TabIndex = 7;
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
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 17);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 2;
            this.lblCelular.Text = "Celular";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(13, 33);
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(146, 20);
            this.mtxtCelular.TabIndex = 6;
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
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(184, 33);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(146, 20);
            this.mtxtTelefone.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(346, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Razão Social";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 20);
            this.txtEmail.TabIndex = 3;
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
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(13, 33);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(288, 20);
            this.txtRua.TabIndex = 3;
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
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(307, 33);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(288, 20);
            this.txtBairro.TabIndex = 3;
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
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 74);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(288, 20);
            this.txtCidade.TabIndex = 3;
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
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(601, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(310, 74);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 4;
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
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(437, 74);
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(144, 20);
            this.mtxtCEP.TabIndex = 5;
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
            // FrmManterFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBtn);
            this.Name = "FrmManterFornecedor";
            this.Text = "FrmManterFornecedor";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker dtpDataAbertura;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}