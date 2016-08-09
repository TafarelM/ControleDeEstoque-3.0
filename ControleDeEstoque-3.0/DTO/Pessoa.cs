using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class Pessoa
    {
        public int idPessoa { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
