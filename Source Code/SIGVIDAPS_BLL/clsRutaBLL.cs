using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGVIDAPS_DAT;
using System.Data.Entity;

namespace SIGVIDAPS_BLL
{
    public class clsRutaBLL
    {
        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        public List<RUTA> obtenerTodasRutas()
        {
            List<RUTA> lstRutas = modeloEntidades.RUTAs.ToList();
            return lstRutas;
        }
    }
}
