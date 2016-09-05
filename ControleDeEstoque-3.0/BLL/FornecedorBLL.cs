using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedorBLL
    {
        public string Inserir(Fornecedor fornecedor)
        {
            FornecedorDAL dal = new FornecedorDAL();
            string retorno = dal.Inserir(fornecedor);

            return retorno;
        }

        public string Alterar(Fornecedor fornecedor)
        {
            FornecedorDAL dal = new FornecedorDAL();
            string retorno = dal.Alterar(fornecedor);

            return retorno;
        }

        public string Excluir(int idFornecedor)
        {
            FornecedorDAL dal = new FornecedorDAL();
            string retorno = dal.Excluir(idFornecedor);

            return retorno;
        }

        public List<Fornecedor> ConsultarNome(string nome)
        {
            FornecedorDAL dal = new FornecedorDAL();
            List<Fornecedor> colecaoDTO = new List<Fornecedor>();
            colecaoDTO = dal.ConsultarNome(nome);

            return colecaoDTO;
        }

        public List<Fornecedor> ConsultaId(int idAluno)
        {
            FornecedorDAL dal = new FornecedorDAL();
            List<Fornecedor> colecaoDTO = new List<Fornecedor>();
            colecaoDTO = dal.ConsultaId(idAluno);

            return colecaoDTO;
        }

        public string consultarCPF(string cnpj)
        {
            FornecedorDAL dal = new FornecedorDAL();
            string retorno = dal.consultarCNPJ(cnpj);

            return retorno;
        }
    }
}
