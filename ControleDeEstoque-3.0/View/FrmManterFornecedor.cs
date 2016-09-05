using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmManterFornecedor : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmManterFornecedor(AcaoNaTela acaoNaTela, Fornecedor fornecedor)
        {
            InitializeComponent();

            //
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                this.Text = "Inserir Fornecedor";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Fornecedor";

                txtIDFornecedor.Text = fornecedor.idPessoa.ToString();
                txtNomeFantasia.Text = fornecedor.nomeFantasia;
                mtxtCNPJ.Text = fornecedor.cnpj;
                txtRazaoSocial.Text = fornecedor.razaoSocial;
                dtpDataAbertura.Text = fornecedor.dataAbertura.ToString();
                //contato
                txtIDContato.Text = fornecedor.contato.idContato.ToString();
                txtEmail.Text = fornecedor.contato.email;
                mtxtTelefone.Text = fornecedor.contato.telefone;
                mtxtCelular.Text = fornecedor.contato.celular;
                //endereco
                txtIDEndereco.Text = fornecedor.endereco.idEndereco.ToString();
                txtRua.Text = fornecedor.endereco.rua;
                txtNumero.Text = fornecedor.endereco.numero;
                txtBairro.Text = fornecedor.endereco.bairro;
                txtCidade.Text = fornecedor.endereco.cidade;
                cbEstado.SelectedValue = fornecedor.endereco.estado;
                mtxtCEP.Text = fornecedor.endereco.cep;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Fornecedor";

                txtIDFornecedor.Text = fornecedor.idPessoa.ToString();
                txtNomeFantasia.Text = fornecedor.nomeFantasia;
                mtxtCNPJ.Text = fornecedor.cnpj;
                txtRazaoSocial.Text = fornecedor.razaoSocial;
                dtpDataAbertura.Text = fornecedor.dataAbertura.ToString();
                //contato
                txtIDContato.Text = fornecedor.contato.idContato.ToString();
                txtEmail.Text = fornecedor.contato.email;
                mtxtTelefone.Text = fornecedor.contato.telefone;
                mtxtCelular.Text = fornecedor.contato.celular;
                //endereco
                txtIDEndereco.Text = fornecedor.endereco.idEndereco.ToString();
                txtRua.Text = fornecedor.endereco.rua;
                txtNumero.Text = fornecedor.endereco.numero;
                txtBairro.Text = fornecedor.endereco.bairro;
                txtCidade.Text = fornecedor.endereco.cidade;
                cbEstado.SelectedValue = fornecedor.endereco.estado;
                mtxtCEP.Text = fornecedor.endereco.cep;

                //desabilitando os campos da tela
                //panelPrincipal.Enabled = false;
                txtIDFornecedor.ReadOnly = true;
                txtIDEndereco.ReadOnly = true;
                txtIDContato.ReadOnly = true;
                txtNomeFantasia.ReadOnly = true;
                mtxtCNPJ.ReadOnly = true;
                txtRazaoSocial.ReadOnly = true;
                dtpDataAbertura.Enabled = false;
                txtEmail.ReadOnly = true;
                mtxtTelefone.ReadOnly = true;
                mtxtCelular.ReadOnly = true;
                txtRua.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                cbEstado.Enabled = false;
                mtxtCEP.ReadOnly = true;

                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnFechar.Focus();
            }
        }

        //FRM LOAD
        private void FrmManterFornecedor_Load(object sender, EventArgs e)
        {

        }

        //BTN SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.contato = new Contato();
                fornecedor.endereco = new Endereco();
                //fornecedor.tipoPessoa = new TipoPessoa();

                fornecedor.nomeFantasia = txtNomeFantasia.Text;
                fornecedor.cnpj = mtxtCNPJ.Text;
                fornecedor.razaoSocial= txtRazaoSocial.Text;
                fornecedor.dataAbertura = dtpDataAbertura.Value;
                //contato
                fornecedor.contato.email = txtEmail.Text;
                fornecedor.contato.telefone = mtxtTelefone.Text;
                fornecedor.contato.celular = mtxtCelular.Text;
                //endereco
                fornecedor.endereco.rua = txtRua.Text;
                fornecedor.endereco.numero = txtNumero.Text;
                fornecedor.endereco.bairro = txtBairro.Text;
                fornecedor.endereco.cidade = txtCidade.Text;
                fornecedor.endereco.estado = Convert.ToInt32(cbEstado.SelectedValue);
                fornecedor.endereco.cep = mtxtCEP.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                FornecedorBLL fornecedorBLL = new FornecedorBLL();
                string retorno = fornecedorBLL.Inserir(fornecedor);

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
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.contato = new Contato();
                fornecedor.endereco = new Endereco();
                //fornecedor.tipoPessoa = new TipoPessoa();

                fornecedor.idPessoa = Convert.ToInt32(txtIDFornecedor.Text);
                fornecedor.nomeFantasia = txtNomeFantasia.Text;
                fornecedor.cnpj = mtxtCNPJ.Text;
                fornecedor.razaoSocial = txtRazaoSocial.Text;
                fornecedor.dataAbertura = dtpDataAbertura.Value;
                //contato
                fornecedor.contato.idContato = Convert.ToInt32(txtIDContato.Text);
                fornecedor.contato.email = txtEmail.Text;
                fornecedor.contato.telefone = mtxtTelefone.Text;
                fornecedor.contato.celular = mtxtCelular.Text;
                //endereco
                fornecedor.endereco.idEndereco = Convert.ToInt32(txtIDEndereco.Text);
                fornecedor.endereco.rua = txtRua.Text;
                fornecedor.endereco.numero = txtNumero.Text;
                fornecedor.endereco.bairro = txtBairro.Text;
                fornecedor.endereco.cidade = txtCidade.Text;
                fornecedor.endereco.estado = Convert.ToInt32(cbEstado.SelectedValue);
                fornecedor.endereco.cep = mtxtCEP.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                FornecedorBLL fornecedorBLL = new FornecedorBLL();
                string retorno = fornecedorBLL.Alterar(fornecedor);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo se der errado tem a msg de erro
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

        //BTN FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }
}
