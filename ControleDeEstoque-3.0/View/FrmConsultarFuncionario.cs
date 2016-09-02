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
    public partial class FrmConsultarFuncionario : Form
    {
        public FrmConsultarFuncionario()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            //dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {
            //O METODO É O BOTÃO PESQUISAR
            //  PESQUISAR
            FuncionarioBLL funcionario = new FuncionarioBLL();
            List<Funcionario> funcionarioColecao = new List<Funcionario>();

            //PASSA COMO PARAMETRO OQUE FOR DIGITADO NO CAMPO TXTPESQUISAR PARA O METODO CONSULTARNOME E OQUE FOR ENCONTRADO ELE VAI JOGAR NA COLEÇÃO DE CLIENTES
            funcionarioColecao = funcionario.ConsultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridViewPrincipal.DataSource = null;
            //usando a coleção de cliente como fonte de dados para o dataGrid
            dataGridViewPrincipal.DataSource = funcionarioColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //criei o metodo com o codigo do botão para reutilizar codigo
            AtualizarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmManterFuncionario manterFuncionario = new FrmManterFuncionario(AcaoNaTela.Inserir, null);

            DialogResult dialogResult = manterFuncionario.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);

            FrmManterFuncionario manterCadastrar = new FrmManterFuncionario(AcaoNaTela.Alterar, funcionarioSelecionado);

            DialogResult dialogResult = manterCadastrar.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado no grid
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);

            FrmManterFuncionario manterFuncionario = new FrmManterFuncionario(AcaoNaTela.Consultar, funcionarioSelecionado);
            manterFuncionario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }
            //perguntar se ele tem certeza que excluir o registro
            DialogResult resultado = MessageBox.Show("Tem Certeza que deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //pegar o Funcionario selecionado
            Funcionario funcionarioSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Funcionario);

            //Instanciar  a regra de negocioas
            FuncionarioBLL funcionarioBLL = new FuncionarioBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = funcionarioBLL.Excluir(funcionarioSelecionado.idPessoa);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idFuncionario = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                //se der erro
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
