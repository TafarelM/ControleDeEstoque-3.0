using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstadoBLL
    {
        public List<Estado> ComboBox()
        {
            EstadoDAL dal = new EstadoDAL();
            List<Estado> colecaoDTO = new List<Estado>();
            colecaoDTO = dal.ComboBox();

            return colecaoDTO;
        }
    }
}
