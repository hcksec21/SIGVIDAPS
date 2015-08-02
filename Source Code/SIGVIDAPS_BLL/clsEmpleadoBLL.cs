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
    public class clsEmpleadoBLL
    {
        
        //INSERTAR 
        public void insertarEmpleado(EMPLEADO empleado)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades())
                {
                    modeloEntidades.EMPLEADOes.Add(empleado);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        public List<EMPLEADO> obtenerTodosEmpleados()
        {
            List<EMPLEADO> lstEmpleados = (new SIGVIDAPS_entidades()).EMPLEADOes.ToList();
            return lstEmpleados;
        }
    }
}
