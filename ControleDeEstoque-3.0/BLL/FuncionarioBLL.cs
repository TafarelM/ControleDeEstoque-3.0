using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncionarioBLL
    {
        public string Inserir(Funcionario funcionario)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            string retorno = dal.Inserir(funcionario);

            return retorno;
        }

        public string Alterar(Funcionario funcionario)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            string retorno = dal.Alterar(funcionario);

            return retorno;
        }

        public string Excluir(int idFuncionario)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            string retorno = dal.Excluir(idFuncionario);

            return retorno;
        }

        public List<Funcionario> ConsultarNome(string nome)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            List<Funcionario> colecaoDTO = new List<Funcionario>();
            colecaoDTO = dal.ConsultarNome(nome);

            return colecaoDTO;
        }

        public List<Funcionario> ConsultaId(int idAluno)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            List<Funcionario> colecaoDTO = new List<Funcionario>();
            colecaoDTO = dal.ConsultaId(idAluno);

            return colecaoDTO;
        }

        public string consultarCPF(string cpf)
        {
            FuncionarioDAL dal = new FuncionarioDAL();
            string retorno = dal.consultarCPF(cpf);

            return retorno;
        }
    }
}
