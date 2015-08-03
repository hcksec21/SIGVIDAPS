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
    public class clsCombinacionViaticosBLL
    {
        SIGVIDAPS_entidades entityContext = new SIGVIDAPS_entidades();

        public List<COMBINACION_VIATICOS> obtenerCombinacionViaticos()
        {
            List<COMBINACION_VIATICOS> lstCombinacionViaticos = entityContext.COMBINACION_VIATICOS.ToList();
            return lstCombinacionViaticos;
        }
    }
}
