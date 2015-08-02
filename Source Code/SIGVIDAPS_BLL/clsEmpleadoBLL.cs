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

        //ACTUALIZAR
        public void actualizarEmpleado(int indice, EMPLEADO empleado)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades())
                {
                    EMPLEADO objEmpleado = buscarConId(indice);                    

                    modeloEntidades.Entry(objEmpleado).Property(u => u.NOMBREEMP).CurrentValue = empleado.NOMBREEMP;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.APELLIDOEMP).CurrentValue = empleado.APELLIDOEMP;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.CEDULAEMP).CurrentValue = empleado.CEDULAEMP;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.DIREMP).CurrentValue = empleado.DIREMP;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.ESTEMP).CurrentValue = empleado.ESTEMP;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.IDCARGO).CurrentValue = empleado.IDCARGO;
                    modeloEntidades.Entry(objEmpleado).Property(u => u.CEDULAEMP).CurrentValue = empleado.CEDULAEMP;

                    modeloEntidades.SaveChanges();

                }
            }
        }

        public List<EMPLEADO> obtenerTodosEmpleados()
        {
            List<EMPLEADO> lstEmpleados = (new SIGVIDAPS_entidades()).EMPLEADOes.ToList();
            return lstEmpleados;
        }

        //BUSCAR CON ID
        public EMPLEADO buscarConId(int id)
        {
            return (new SIGVIDAPS_entidades()).EMPLEADOes.Where(e => e.IDEMP == id).First();
        }
    }
}
