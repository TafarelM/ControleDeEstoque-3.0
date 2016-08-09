using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using DTO;
using System.Data;

namespace DAL
{
    public class ClienteDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDados_SQLServer acessoDadosSqlServer = new AcessoDados_SQLServer();

        public string inserir(ClienteFisico cliente)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona dados
                //Cliente Fisico
                acessoDadosSqlServer.AdicionarParametros("@nome", cliente.pessoaFisica.nome);
                acessoDadosSqlServer.AdicionarParametros("@cpf", cliente.pessoaFisica.cpf);
                acessoDadosSqlServer.AdicionarParametros("@rg", cliente.pessoaFisica.rg);                
                acessoDadosSqlServer.AdicionarParametros("@sexo", cliente.pessoaFisica.sexo);
                acessoDadosSqlServer.AdicionarParametros("@dataNascimento", cliente.pessoaFisica.dataNascimento);
                //Pessoa
                acessoDadosSqlServer.AdicionarParametros("@rua", cliente.pessoaFisica.rua);
                acessoDadosSqlServer.AdicionarParametros("@numero", cliente.pessoaFisica.numero);
                acessoDadosSqlServer.AdicionarParametros("@bairro", cliente.pessoaFisica.bairro);
                acessoDadosSqlServer.AdicionarParametros("@cidade", cliente.pessoaFisica.cidade);
                acessoDadosSqlServer.AdicionarParametros("@cep", cliente.pessoaFisica.cep);
                acessoDadosSqlServer.AdicionarParametros("@estado", cliente.pessoaFisica.estado);
                acessoDadosSqlServer.AdicionarParametros("@celular", cliente.pessoaFisica.celular);
                acessoDadosSqlServer.AdicionarParametros("@telefone", cliente.pessoaFisica.telefone);
                acessoDadosSqlServer.AdicionarParametros("@email", cliente.pessoaFisica.email);

                //executa a manipulção
                //pode aceitar procedure ou comando sql
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_ClienteFisico_Inserir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string alterar(ClienteFisico cliente)
        {
            string retorno = null;
            return retorno;
        }

        public string excluir(int idCliente)
        {
            string retorno = null;
            return retorno;
        }
        
        public ClienteFisicoColecao consultarId(int idCliente)
        {
            ClienteFisicoColecao clienteColecao = new ClienteFisicoColecao();
            return clienteColecao;
        }

        public ClienteFisicoColecao consultarNome(string nome)
        {
            ClienteFisicoColecao clienteColecao = new ClienteFisicoColecao();
            return clienteColecao;
        }
    }
}
