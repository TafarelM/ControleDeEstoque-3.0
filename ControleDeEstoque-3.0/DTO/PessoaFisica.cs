using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PessoaFisica : Pessoa
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string sexo { get; set; }
        public DateTime dataNascimento { get; set; }

    }
}
