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
    public class clsNivelBLL
    {
        //BUSCAR CON ID
        public NIVEL buscarConId(int id)
        {
            return (new SIGVIDAPS_entidades()).NIVELs.Where(e => e.IDNIVEL == id).First();
        }

    }
}
