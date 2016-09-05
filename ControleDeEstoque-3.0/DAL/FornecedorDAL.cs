using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDados_SQLServer acessoDadosSqlServer = new AcessoDados_SQLServer();

        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //pessoa fisica
                acessoDadosSqlServer.AdicionarParametros("@nomeFatansia", fornecedor.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", fornecedor.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@dataAbertura", fornecedor.dataAbertura);
                //endereco
                acessoDadosSqlServer.AdicionarParametros("@rua", fornecedor.endereco.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", fornecedor.endereco.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", fornecedor.endereco.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", fornecedor.endereco.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", fornecedor.endereco.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", fornecedor.endereco.cep);
                //contato
                acessoDadosSqlServer.AdicionarParametros("@email", fornecedor.contato.email);
                acessoDadosSqlServer.AdicionarParametros("@telefone", fornecedor.contato.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", fornecedor.contato.celular);


                //executa a manipulção
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Fornecedor_Inserir").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Fornecedor fornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //pessoa fisica
                acessoDadosSqlServer.AdicionarParametros("@idPessoa", fornecedor.idPessoa);
                acessoDadosSqlServer.AdicionarParametros("@nomeFatansia", fornecedor.nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParametros("@razaoSocial", fornecedor.razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@dataAbertura", fornecedor.dataAbertura);
                //endereco
                acessoDadosSqlServer.AdicionarParametros("@idEndereco", fornecedor.endereco.idEndereco);
                acessoDadosSqlServer.AdicionarParametros("@rua", fornecedor.endereco.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", fornecedor.endereco.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", fornecedor.endereco.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", fornecedor.endereco.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", fornecedor.endereco.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", fornecedor.endereco.cep);
                //contato
                acessoDadosSqlServer.AdicionarParametros("@idContato", fornecedor.contato.idContato);
                acessoDadosSqlServer.AdicionarParametros("@email", fornecedor.contato.email);
                acessoDadosSqlServer.AdicionarParametros("@telefone", fornecedor.contato.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", fornecedor.contato.celular);

                //executa e manipula
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Fornecedor_Alterar").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(int idFornecedor)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", idFornecedor);
                //chamar a procedure para manipulação
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Fornecedor_Excluir").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Fornecedor> ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                List<Fornecedor> fornecedorColecao = new List<Fornecedor>();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Fornecedor_ConsultarPorNome");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.endereco = new Endereco();
                    fornecedor.contato = new Contato();
                    fornecedor.tipoPessoa = new TipoPessoa();

                    //pessoa
                    fornecedor.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    fornecedor.tipoPessoa.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    fornecedor.tipoPessoa.descricao = Convert.ToString(linha["descricao"]);
                    //Fornecedor
                    fornecedor.nomeFantasia = Convert.ToString(linha["nomeFatansia"]);
                    fornecedor.cnpj = Convert.ToString(linha["cnpj"]);
                    fornecedor.razaoSocial= Convert.ToString(linha["razaoSocial"]);
                    fornecedor.dataAbertura = Convert.ToDateTime(linha["dataAbertura"]);
                    //contato
                    fornecedor.contato.idContato = Convert.ToInt32(linha["idContato"]);
                    fornecedor.contato.email = Convert.ToString(linha["email"]);
                    fornecedor.contato.telefone = Convert.ToString(linha["telefone"]);
                    fornecedor.contato.celular = Convert.ToString(linha["celular"]);
                    //endereco
                    fornecedor.endereco.idEndereco = Convert.ToInt32(linha["idEndereco"]);
                    fornecedor.endereco.rua = Convert.ToString(linha["rua"]);
                    fornecedor.endereco.numero = Convert.ToString(linha["numero"]);
                    fornecedor.endereco.bairro = Convert.ToString(linha["bairro"]);
                    fornecedor.endereco.cidade = Convert.ToString(linha["cidade"]);
                    fornecedor.endereco.estado = Convert.ToInt32(linha["estado"]);
                    fornecedor.endereco.cep = Convert.ToString(linha["cep"]);

                    //adiciona os dados de cliente na clienteColecao
                    fornecedorColecao.Add(fornecedor);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return fornecedorColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Fornecedor por nome. \nDetalhes: " + exception.Message);
            }

        }

        public List<Fornecedor> ConsultaId(int idFornecedor)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                List<Fornecedor> fornecedorColecao = new List<Fornecedor>();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", idFornecedor);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableFornecedor = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Fornecedor_ConsultarPorID");

                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.endereco = new Endereco();
                    fornecedor.contato = new Contato();
                    fornecedor.tipoPessoa = new TipoPessoa();

                    //pessoa
                    fornecedor.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    fornecedor.tipoPessoa.descricao = Convert.ToString(linha["descricao"]);
                    //Fornecedor
                    fornecedor.nomeFantasia = Convert.ToString(linha["nomeFatansia"]);
                    fornecedor.cnpj = Convert.ToString(linha["cnpj"]);
                    fornecedor.razaoSocial = Convert.ToString(linha["razaoSocial"]);
                    fornecedor.dataAbertura = Convert.ToDateTime(linha["dataAbertura"]);
                    //contato
                    fornecedor.contato.idContato = Convert.ToInt32(linha["idContato"]);
                    fornecedor.contato.email = Convert.ToString(linha["email"]);
                    fornecedor.contato.telefone = Convert.ToString(linha["telefone"]);
                    fornecedor.contato.celular = Convert.ToString(linha["celular"]);
                    //endereco
                    fornecedor.endereco.idEndereco = Convert.ToInt32(linha["idEndereco"]);
                    fornecedor.endereco.rua = Convert.ToString(linha["rua"]);
                    fornecedor.endereco.numero = Convert.ToString(linha["numero"]);
                    fornecedor.endereco.bairro = Convert.ToString(linha["bairro"]);
                    fornecedor.endereco.cidade = Convert.ToString(linha["cidade"]);
                    fornecedor.endereco.estado = Convert.ToInt32(linha["Estado"]);
                    fornecedor.endereco.cep = Convert.ToString(linha["cep"]);

                    //adiciona a coleção
                    fornecedorColecao.Add(fornecedor);
                }

                return fornecedorColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Funcionario por Código. \nDetalhes: " + exception.Message);
            }
        }

        public string consultarCNPJ(string cnpj)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@cnpj", cnpj);
                //chamar a procedure para manipulação
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Funcionario_ConsultarPorCPF").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
    }
}
