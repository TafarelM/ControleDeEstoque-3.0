using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDados_SQLServer acessoDadosSqlServer = new AcessoDados_SQLServer();

        public string Inserir(Funcionario funcionario)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //pessoa fisica
                acessoDadosSqlServer.AdicionarParametros("@nome", funcionario.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", funcionario.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", funcionario.rg);
                acessoDadosSqlServer.AdicionarParametros("@sexo", funcionario.sexo);
                acessoDadosSqlServer.AdicionarParametros("@dataNascimento", funcionario.dataNascimento);
                //endereco
                acessoDadosSqlServer.AdicionarParametros("@rua", funcionario.endereco.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", funcionario.endereco.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", funcionario.endereco.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", funcionario.endereco.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", funcionario.endereco.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", funcionario.endereco.cep);
                //contato
                acessoDadosSqlServer.AdicionarParametros("@email", funcionario.contato.email);  
                acessoDadosSqlServer.AdicionarParametros("@telefone", funcionario.contato.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", funcionario.contato.celular);
                //funcionario
                acessoDadosSqlServer.AdicionarParametros("@setor", funcionario.setor);
                acessoDadosSqlServer.AdicionarParametros("@cargo", funcionario.cargo);
                acessoDadosSqlServer.AdicionarParametros("@dataEntrada", funcionario.dataEntrada);

                //executa a manipulção
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Funcionario_Inserir").ToString();
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

        public string Alterar(Funcionario funcionario)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //pessoa fisica
                acessoDadosSqlServer.AdicionarParametros("@idPessoa", funcionario.idPessoa);
                acessoDadosSqlServer.AdicionarParametros("@nome", funcionario.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", funcionario.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", funcionario.rg);
                acessoDadosSqlServer.AdicionarParametros("@sexo", funcionario.sexo);
                acessoDadosSqlServer.AdicionarParametros("@dataNascimento", funcionario.dataNascimento);
                //endereco
                acessoDadosSqlServer.AdicionarParametros("@idEndereco", funcionario.endereco.idEndereco);
                acessoDadosSqlServer.AdicionarParametros("@rua", funcionario.endereco.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", funcionario.endereco.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", funcionario.endereco.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", funcionario.endereco.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", funcionario.endereco.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", funcionario.endereco.cep);
                //contato
                acessoDadosSqlServer.AdicionarParametros("@idContato", funcionario.contato.idContato);
                acessoDadosSqlServer.AdicionarParametros("@email", funcionario.contato.email);
                acessoDadosSqlServer.AdicionarParametros("@telefone", funcionario.contato.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", funcionario.contato.celular);
                //funcionario
                acessoDadosSqlServer.AdicionarParametros("@setor", funcionario.setor);
                acessoDadosSqlServer.AdicionarParametros("@cargo", funcionario.cargo);
                acessoDadosSqlServer.AdicionarParametros("@dataEntrada", funcionario.dataEntrada);

                //executa e manipula
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Funcionario_Alterar").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(int idFuncionario)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idFuncionario", idFuncionario);
                //chamar a procedure para manipulação
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Funcionario_Excluir").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Funcionario> ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                List<Funcionario> funcionarioColecao = new List<Funcionario>();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableFuncionario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Funcionario_ConsultarPorNome");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableFuncionario.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Funcionario funcionario = new Funcionario();
                    funcionario.endereco = new Endereco();
                    funcionario.contato = new Contato();
                    funcionario.tipoPessoa = new TipoPessoa();

                    //pessoa
                    funcionario.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    funcionario.tipoPessoa.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    funcionario.tipoPessoa.descricao = Convert.ToString(linha["descricao"]);
                    //pessoa fisica
                    funcionario.nome = Convert.ToString(linha["nome"]);
                    funcionario.cpf = Convert.ToString(linha["cpf"]);
                    funcionario.rg = Convert.ToString(linha["rg"]);
                    funcionario.sexo = Convert.ToString(linha["sexo"]);
                    funcionario.dataNascimento = Convert.ToDateTime(linha["dataNascimento"]);
                    //contato
                    funcionario.contato.idContato = Convert.ToInt32(linha["idContato"]);
                    funcionario.contato.email = Convert.ToString(linha["email"]);
                    funcionario.contato.telefone = Convert.ToString(linha["telefone"]);
                    funcionario.contato.celular = Convert.ToString(linha["celular"]);
                    //endereco
                    funcionario.endereco.idEndereco = Convert.ToInt32(linha["idEndereco"]);
                    funcionario.endereco.rua = Convert.ToString(linha["rua"]);
                    funcionario.endereco.numero = Convert.ToString(linha["numero"]);
                    funcionario.endereco.bairro = Convert.ToString(linha["bairro"]);
                    funcionario.endereco.cidade = Convert.ToString(linha["cidade"]);
                    funcionario.endereco.estado = Convert.ToInt32(linha["estado"]);
                    funcionario.endereco.cep = Convert.ToString(linha["cep"]);
                    //funcionario
                    funcionario.setor = Convert.ToString(linha["setor"]);
                    funcionario.cargo = Convert.ToString(linha["cargo"]);
                    funcionario.dataEntrada = Convert.ToDateTime(linha["dataEntrada"]);

                    //adiciona os dados de cliente na clienteColecao
                    funcionarioColecao.Add(funcionario);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return funcionarioColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Funcionario por nome. \nDetalhes: " + exception.Message);
            }

        }

        public List<Funcionario> ConsultaId(int idFuncionario)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                List<Funcionario> funcionarioColecao = new List<Funcionario>();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@idFuncionario", idFuncionario);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableFuncionario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Funcionario_ConsultarPorID");

                foreach (DataRow linha in dataTableFuncionario.Rows)
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.endereco = new Endereco();
                    funcionario.contato = new Contato();
                    funcionario.tipoPessoa = new TipoPessoa();

                    //pessoa
                    funcionario.idPessoa = Convert.ToInt32(linha["idPessoa"]);
                    funcionario.tipoPessoa.descricao = Convert.ToString(linha["descricao"]);
                    //pessoa fisica
                    funcionario.nome = Convert.ToString(linha["nome"]);
                    funcionario.cpf = Convert.ToString(linha["cpf"]);
                    funcionario.rg = Convert.ToString(linha["rg"]);
                    funcionario.sexo = Convert.ToString(linha["sexo"]);
                    funcionario.dataNascimento = Convert.ToDateTime(linha["dataNascimento"]);
                    //contato
                    funcionario.contato.idContato = Convert.ToInt32(linha["idContato"]);
                    funcionario.contato.email = Convert.ToString(linha["email"]);
                    funcionario.contato.telefone = Convert.ToString(linha["telefone"]);
                    funcionario.contato.celular = Convert.ToString(linha["celular"]);
                    //endereco
                    funcionario.endereco.idEndereco = Convert.ToInt32(linha["idEndereco"]);
                    funcionario.endereco.rua = Convert.ToString(linha["rua"]);
                    funcionario.endereco.numero = Convert.ToString(linha["numero"]);
                    funcionario.endereco.bairro = Convert.ToString(linha["bairro"]);
                    funcionario.endereco.cidade = Convert.ToString(linha["cidade"]);
                    //estado
                    funcionario.endereco.estado = Convert.ToInt32(linha["Estado"]);
                    funcionario.endereco.cep = Convert.ToString(linha["cep"]);                    //funcionario.endereco.estado.estado = Convert.ToString(linha["estado"]);
                    //funcionario.endereco.estado.sigla = Convert.ToString(linha["sigla"]);
                    //funcionario
                    funcionario.setor = Convert.ToString(linha["setor"]);
                    funcionario.cargo = Convert.ToString(linha["cargo"]);
                    funcionario.dataEntrada = Convert.ToDateTime(linha["dataEntrada"]);

                    //adiciona a coleção
                    funcionarioColecao.Add(funcionario);
                }

                return funcionarioColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Funcionario por Código. \nDetalhes: " + exception.Message);
            }
        }

        public string consultarCPF(string cpf)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@cpf", cpf);
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
