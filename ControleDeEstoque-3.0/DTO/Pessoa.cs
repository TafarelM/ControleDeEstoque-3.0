using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pessoa
    {
        public int idPessoa { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public Contato contato { get; set; }
        public Endereco endereco { get; set; }
    }
}
