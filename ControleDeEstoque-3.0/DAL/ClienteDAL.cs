using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using DTO;

namespace DAL
{
    public class ClienteDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDados_SQLServer acessoDadosSqlServer = new AcessoDados_SQLServer();

        public string inserir(Cliente cliente)
        {
            string retorno = null;
            return retorno;
        }

        public string alterar(Cliente cliente)
        {
            string retorno = null;
            return retorno;
        }

        public string excluir(int idCliente)
        {
            string retorno = null;
            return retorno;
        }
        
        public ClienteColecao consultarId(int idCliente)
        {
            ClienteColecao clienteColecao = new ClienteColecao();
            return clienteColecao;
        }

        public ClienteColecao consultarNome(string nome)
        {
            ClienteColecao clienteColecao = new ClienteColecao();
            return clienteColecao;
        }
    }
}
