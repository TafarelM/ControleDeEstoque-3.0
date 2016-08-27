using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstadoDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDados_SQLServer acessoDadosSqlServer = new AcessoDados_SQLServer();

        public List<Estado> ComboBox()
        {
            try
            {
                List<Estado> estadoColecao = new List<Estado>();
                //limpar antes de usar

                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Estado_ComboBox");
                //
                foreach (DataRow linha in dataTableAluno.Rows)
                {
                    Estado estado = new Estado();

                    estado.idEstado = Convert.ToInt32(linha["idEstado"]);
                    estado.estado = Convert.ToString(linha["estado"]);
                    estado.sigla = Convert.ToString(linha["sigla"]);

                    //adiciona a coleção
                    estadoColecao.Add(estado);
                }

                return estadoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Estado por Nome. \nDetalhes: " + exception.Message);
            }
        }
    }
}
