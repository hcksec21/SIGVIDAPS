using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SIGVIDAPS_DAT;
using System.Data.Entity;

namespace SIGVIDAPS_BLL
{
    public class clsCargoBLL
    {
        public List<CARGO> obtenerTodosCargos()
        {
            List<CARGO> lstCargos = (new SIGVIDAPS_entidades()).CARGOes.ToList();
            return lstCargos;
        }

        //BUSCAR CON ID
        public CARGO BuscarConId(int id)
        {
            return (new SIGVIDAPS_entidades()).CARGOes.Where(e => e.IDCARGO == id).First();
        }
    }
}
