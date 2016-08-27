using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Funcionario : PessoaFisica
    {
        public int idFuncionario { get; set; }
        public String setor { get; set; }
        public String cargo { get; set; }
        public DateTime dataEntrada { get; set; }
    }
}
