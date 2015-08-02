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
        public CARGO buscarConId(int id)
        {
            return (new SIGVIDAPS_entidades()).CARGOes.Where(e => e.IDCARGO == id).First();
        }

        //BUSCAR CON NOMBRE DE CARGO
        public CARGO buscarConNombreCargo(String nombreCargo)
        {
            return (new SIGVIDAPS_entidades()).CARGOes.Where(e => e.NOMCARGO == nombreCargo).First();
        }
    }
}
