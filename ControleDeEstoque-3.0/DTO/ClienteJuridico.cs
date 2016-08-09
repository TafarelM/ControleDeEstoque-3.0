using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class ClienteJuridico : Pessoa
    {
        public PessoaJuridica pessoaJurica { get; set; }
    }
}
