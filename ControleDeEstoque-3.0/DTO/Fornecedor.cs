using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Fornecedor : Pessoa
    {
        public String nomeFantasia { get; set; }
        public String cnpj { get; set; }
        public String razaoSocial { get; set; }
        public DateTime dataAbertura { get; set; }
    }
}
