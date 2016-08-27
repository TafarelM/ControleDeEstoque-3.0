namespace View
{
    partial class FrmManterFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.panelImg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImg = new System.Windows.Forms.Button();
            this.btnExcluirImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.lblIdFuncionario = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.panelBtn.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.Size = new System.Drawing.Size(717, 66);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.dtpDataEntrada);
            this.panelPrincipal.Controls.Add(this.dtpDataNascimento);
            this.panelPrincipal.Controls.Add(this.lblIdFuncionario);
            this.panelPrincipal.Controls.Add(this.txtIDFuncionario);
            this.panelPrincipal.Controls.Add(this.lblDataEntrada);
            this.panelPrincipal.Controls.Add(this.lblCargo);
            this.panelPrincipal.Controls.Add(this.lblSetor);
            this.panelPrincipal.Controls.Add(this.txtCargo);
            this.panelPrincipal.Controls.Add(this.txtSetor);
            this.panelPrincipal.Controls.Add(this.mtxtTelefone);
            this.panelPrincipal.Controls.Add(this.mtxtCelular);
            this.panelPrincipal.Controls.Add(this.label8);
            this.panelPrincipal.Controls.Add(this.label9);
            this.panelPrincipal.Controls.Add(this.txtEmail);
            this.panelPrincipal.Controls.Add(this.label7);
            this.panelPrincipal.Controls.Add(this.btnExcluirImg);
            this.panelPrincipal.Controls.Add(this.btnSelecionarImg);
            this.panelPrincipal.Controls.Add(this.panelImg);
            this.panelPrincipal.Controls.Add(this.mtxtRG);
            this.panelPrincipal.Controls.Add(this.mtxtCPF);
            this.panelPrincipal.Controls.Add(this.gbSexo);
            this.panelPrincipal.Controls.Add(this.gbEndereco);
            this.panelPrincipal.Controls.Add(this.lblDataNascimento);
            this.panelPrincipal.Controls.Add(this.lblRG);
            this.panelPrincipal.Controls.Add(this.lblCPF);
            this.panelPrincipal.Controls.Add(this.txtNome);
            this.panelPrincipal.Controls.Add(this.lblNome);
            this.panelPrincipal.Size = new System.Drawing.Size(717, 365);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(476, 4);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(593, 4);
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 96);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(153, 96);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(13, 135);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Controls.Add(this.label4);
            this.gbEndereco.Controls.Add(this.mtxtCEP);
            this.gbEndereco.Controls.Add(this.cbEstado);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.label2);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Location = new System.Drawing.Point(3, 258);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(709, 102);
            this.gbEndereco.TabIndex = 26;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereco";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(234, 74);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CEP";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(6, 33);
            this.mtxtCEP.Mask = "#####-###";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(105, 20);
            this.mtxtCEP.TabIndex = 1;
            this.mtxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(451, 32);
            this.cbEstado.MaxDropDownItems = 5;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(135, 21);
            this.cbEstado.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(345, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 74);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(222, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(117, 33);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(222, 20);
            this.txtRua.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rua";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtnFeminino);
            this.gbSexo.Controls.Add(this.rbtnMasculino);
            this.gbSexo.Location = new System.Drawing.Point(345, 40);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(170, 52);
            this.gbSexo.TabIndex = 4;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(86, 16);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 16);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(13, 112);
            this.mtxtCPF.Mask = "###.###.###-##";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(134, 20);
            this.mtxtCPF.TabIndex = 6;
            this.mtxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Location = new System.Drawing.Point(153, 112);
            this.mtxtRG.Mask = "###.###.###";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(100, 20);
            this.mtxtRG.TabIndex = 8;
            this.mtxtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panelImg
            // 
            this.panelImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImg.Controls.Add(this.pictureBox1);
            this.panelImg.Location = new System.Drawing.Point(542, 14);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(158, 153);
            this.panelImg.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecionarImg
            // 
            this.btnSelecionarImg.Location = new System.Drawing.Point(542, 173);
            this.btnSelecionarImg.Name = "btnSelecionarImg";
            this.btnSelecionarImg.Size = new System.Drawing.Size(101, 23);
            this.btnSelecionarImg.TabIndex = 18;
            this.btnSelecionarImg.Text = "Selecionar";
            this.btnSelecionarImg.UseVisualStyleBackColor = true;
            this.btnSelecionarImg.Click += new System.EventHandler(this.btnSelecionarImg_Click);
            // 
            // btnExcluirImg
            // 
            this.btnExcluirImg.Location = new System.Drawing.Point(649, 173);
            this.btnExcluirImg.Name = "btnExcluirImg";
            this.btnExcluirImg.Size = new System.Drawing.Size(53, 23);
            this.btnExcluirImg.TabIndex = 19;
            this.btnExcluirImg.Text = "X";
            this.btnExcluirImg.UseVisualStyleBackColor = true;
            this.btnExcluirImg.Click += new System.EventHandler(this.btnExcluirImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefone";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(13, 229);
            this.mtxtCelular.Mask = "(##)#####-####";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(158, 20);
            this.mtxtCelular.TabIndex = 21;
            this.mtxtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(177, 229);
            this.mtxtTelefone.Mask = "(##)####-####";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(153, 20);
            this.mtxtTelefone.TabIndex = 23;
            this.mtxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(361, 143);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(100, 20);
            this.txtSetor.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(361, 180);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 16;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(361, 126);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(32, 13);
            this.lblSetor.TabIndex = 11;
            this.lblSetor.Text = "Setor";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(361, 164);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 15;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(358, 204);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(70, 13);
            this.lblDataEntrada.TabIndex = 24;
            this.lblDataEntrada.Text = "Data Entrada";
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(12, 34);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.ReadOnly = true;
            this.txtIDFuncionario.Size = new System.Drawing.Size(79, 20);
            this.txtIDFuncionario.TabIndex = 1;
            this.txtIDFuncionario.TabStop = false;
            // 
            // lblIdFuncionario
            // 
            this.lblIdFuncionario.AutoSize = true;
            this.lblIdFuncionario.Location = new System.Drawing.Point(12, 14);
            this.lblIdFuncionario.Name = "lblIdFuncionario";
            this.lblIdFuncionario.Size = new System.Drawing.Size(18, 13);
            this.lblIdFuncionario.TabIndex = 0;
            this.lblIdFuncionario.Text = "ID";
            this.lblIdFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(12, 152);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtpDataNascimento.TabIndex = 10;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(361, 221);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEntrada.TabIndex = 25;
            // 
            // FrmManterFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(741, 461);
            this.Name = "FrmManterFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmManterFuncionario_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Button btnExcluirImg;
        private System.Windows.Forms.Button btnSelecionarImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblIdFuncionario;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}
