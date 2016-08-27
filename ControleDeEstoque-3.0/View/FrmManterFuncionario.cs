using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class FrmManterFuncionario : View.FrmManter
    {
        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterFuncionario(AcaoNaTela acaoNaTela, Funcionario funcionario)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                //muda o nome da tela
                this.Text = "Inserir Funcionario";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Funcionario";

                //grava o conteudo no campo da tela
                /*
                txtCod.Text = aluno.idAluno.ToString();
                txtNome.Text = aluno.nome;
                txtSobrenome.Text = aluno.sobrenome;
                txtmCpf.Text = aluno.cpf;
                txtmRg.Text = aluno.rg;
                cbRgExp.Text = aluno.rgExp;
                dateTimeDataNasc.Text = aluno.dataNascimento.ToString();
                txtEmail.Text = aluno.email;
                if (aluno.sexo == "Masculino")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                }
                txtmTelefone.Text = aluno.telefone;
                txtCel.Text = aluno.celular;
                txtUsuario.Text = aluno.usuario.usuario;
                txtSenha.Text = aluno.usuario.senha;*/

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Funcionario";

                //grava o conteudo no campo da tela
                
                txtIDFuncionario.Text = funcionario.idFuncionario.ToString();
                txtNome.Text = funcionario.nome;
                mtxtCPF.Text = funcionario.cpf;
                mtxtRG.Text = funcionario.rg;                
                if (funcionario.sexo == "M")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                }
                dtpDataNascimento.Text = funcionario.dataNascimento.ToString();
                //contato
                mtxtTelefone.Text = funcionario.contato.telefone;
                mtxtCelular.Text = funcionario.contato.celular;
                txtEmail.Text = funcionario.contato.email;
                //endereco
                

                //desabilitando os campos da tela
                txtIDFuncionario.ReadOnly = true;
                txtNome.ReadOnly = true;
                mtxtCPF.ReadOnly = true;
                mtxtRG.ReadOnly = true;
                dtpDataNascimento.Enabled = false;
                txtEmail.ReadOnly = true;
                rbtnMasculino.Enabled = false;
                rbtnFeminino.Enabled = false;
                mtxtTelefone.ReadOnly = true;
                mtxtCelular.ReadOnly = true;


                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnFechar.Focus();
            }
        }

        private void FrmManterFuncionario_Load(object sender, EventArgs e)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            cbEstado.DataSource = estadoBLL.ComboBox();
            cbEstado.DisplayMember = "estado";
            cbEstado.ValueMember = "idEstado";
        }

        //SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Funcionario funcionario = new Funcionario();
                funcionario.contato = new Contato();
                funcionario.endereco = new Endereco();
                funcionario.tipoPessoa = new TipoPessoa();

                funcionario.nome = txtNome.Text;
                funcionario.cpf = mtxtCPF.Text;
                funcionario.rg = mtxtRG.Text;                
                if (rbtnMasculino.Checked == true)
                {
                    funcionario.sexo = "Masculino";//masculino
                }
                else
                {
                    funcionario.sexo = "Feminino";//feminino
                }
                funcionario.dataNascimento = dtpDataNascimento.Value;
                //contato
                funcionario.contato.email = txtEmail.Text;
                funcionario.contato.telefone = mtxtTelefone.Text;
                funcionario.contato.celular = mtxtCelular.Text;
                //endereco
                funcionario.endereco.rua = txtRua.Text;
                funcionario.endereco.numero = txtNumero.Text;
                funcionario.endereco.bairro = txtBairro.Text;
                funcionario.endereco.cidade = txtCidade.Text;
                funcionario.endereco.estado = cbEstado.SelectedIndex+1;
                funcionario.endereco.cep = mtxtCEP.Text;
                //funcionario
                funcionario.setor = txtSetor.Text;
                funcionario.cargo = txtCargo.Text;
                funcionario.dataEntrada = dtpDataEntrada.Value;

                //envia para o metodo tudo q foi colocado na classe cliente
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
                string retorno = funcionarioBLL.Inserir(funcionario);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idFuncionario.ToString());
                    //
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Inserir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Alterar))
            {
                //ALTERAR

                Funcionario funcionario = new Funcionario();
                funcionario.contato = new Contato();
                funcionario.endereco = new Endereco();
                funcionario.tipoPessoa = new TipoPessoa();

                funcionario.idFuncionario = Convert.ToInt32(txtIDFuncionario.Text);
                funcionario.nome = txtNome.Text;
                funcionario.cpf = mtxtCPF.Text;
                funcionario.rg = mtxtRG.Text;
                if (rbtnMasculino.Checked == true)
                {
                    funcionario.sexo = "Masculino";//masculino
                }
                else
                {
                    funcionario.sexo = "Feminino";//feminino
                }
                funcionario.dataNascimento = dtpDataNascimento.Value;
                //contato
                funcionario.contato.email = txtEmail.Text;
                funcionario.contato.telefone = mtxtTelefone.Text;
                funcionario.contato.celular = mtxtCelular.Text;
                //endereco
                funcionario.endereco.rua = txtRua.Text;
                funcionario.endereco.numero = txtNumero.Text;
                funcionario.endereco.cidade = txtCidade.Text;
                funcionario.endereco.estado = cbEstado.SelectedIndex + 1;
                funcionario.endereco.cep = mtxtCEP.Text;
                //funcionario
                funcionario.setor = txtSetor.Text;
                funcionario.cargo = txtCargo.Text;
                funcionario.dataEntrada = dtpDataEntrada.Value;

                //envia para o metodo tudo q foi colocado na classe cliente
                FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
                string retorno = funcionarioBLL.Alterar(funcionario);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Alterar o registro. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.DialogResult = DialogResult.No;
                }

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSelecionarImg_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirImg_Click(object sender, EventArgs e)
        {

        }
    }
}
