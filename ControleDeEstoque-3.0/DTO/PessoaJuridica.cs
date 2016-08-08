using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PessoaJuridica : Pessoa
    {
        public int idPessoaJuridica { get; set; }
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string inscricaoEstadual { get; set; }
    }
}
