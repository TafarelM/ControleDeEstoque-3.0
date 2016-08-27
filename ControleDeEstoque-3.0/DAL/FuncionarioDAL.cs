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
                acessoDadosSqlServer.AdicionarParametros("@idPessoaFidica", funcionario.idPessoaFisica);
                acessoDadosSqlServer.AdicionarParametros("@nome", funcionario.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", funcionario.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", funcionario.rg);
                acessoDadosSqlServer.AdicionarParametros("@sexo", funcionario.sexo);
                acessoDadosSqlServer.AdicionarParametros("@dataNascimento", funcionario.dataNascimento);
                //endereco
                acessoDadosSqlServer.AdicionarParametros("@idPessoa", funcionario.endereco.idEndereco);
                acessoDadosSqlServer.AdicionarParametros("@rua", funcionario.endereco.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", funcionario.endereco.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", funcionario.endereco.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", funcionario.endereco.cidade);
                acessoDadosSqlServer.AdicionarParametros("@estado", funcionario.endereco.estado);
                acessoDadosSqlServer.AdicionarParametros("@cep", funcionario.endereco.cep);
                //contato
                acessoDadosSqlServer.AdicionarParametros("@idPessoa", funcionario.contato.idContato);
                acessoDadosSqlServer.AdicionarParametros("@email", funcionario.contato.email);
                acessoDadosSqlServer.AdicionarParametros("@telefone", funcionario.contato.telefone);
                acessoDadosSqlServer.AdicionarParametros("@celular", funcionario.contato.celular);
                //funcionario
                acessoDadosSqlServer.AdicionarParametros("@idPessoa", funcionario.idFuncionario);
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

                    /*
                    funcionario.idAluno = Convert.ToInt32(linha["IDAluno"]);
                    funcionario.nome = Convert.ToString(linha["Nome"]);
                    funcionario.sobrenome = Convert.ToString(linha["Sobrenome"]);
                    funcionario.cpf = Convert.ToString(linha["CPF"]);
                    funcionario.rg = Convert.ToString(linha["RG"]);
                    funcionario.rgExp = Convert.ToString(linha["RGExp"]);
                    funcionario.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    funcionario.email = Convert.ToString(linha["Email"]);
                    funcionario.sexo = Convert.ToString(linha["Sexo"]);
                    funcionario.telefone = Convert.ToString(linha["Telefone"]);
                    funcionario.celular = Convert.ToString(linha["Celular"]);
                    //usuario
                    funcionario.usuario.idUsuario = Convert.ToInt32(linha["IDUsuario"]);
                    funcionario.usuario.usuario = Convert.ToString(linha["Usuario"]);
                    funcionario.usuario.senha = Convert.ToString(linha["Senha"]);*/

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

                    /*
                    funcionario.idAluno = Convert.ToInt32(linha["IDAluno"]);
                    funcionario.nome = Convert.ToString(linha["Nome"]);
                    funcionario.sobrenome = Convert.ToString(linha["Sobrenome"]);
                    funcionario.cpf = Convert.ToString(linha["CPF"]);
                    funcionario.rg = Convert.ToString(linha["RG"]);
                    funcionario.rgExp = Convert.ToString(linha["RGExp"]);
                    funcionario.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    funcionario.email = Convert.ToString(linha["Email"]);
                    funcionario.sexo = Convert.ToString(linha["Sexo"]);
                    funcionario.telefone = Convert.ToString(linha["Telefone"]);
                    funcionario.celular = Convert.ToString(linha["Celular"]);*/

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
