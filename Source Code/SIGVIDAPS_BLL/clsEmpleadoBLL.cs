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

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarEmpleado(EMPLEADO empleado)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
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
                var objEmpleado = modeloEntidades.EMPLEADOes.Where(qq => qq.IDEMP == indice).Single();                
                modeloEntidades.Entry(objEmpleado).CurrentValues.SetValues(empleado);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }            
        }

        public List<EMPLEADO> obtenerTodosEmpleados()
        {
            List<EMPLEADO> lstEmpleados = modeloEntidades.EMPLEADOes.ToList();
            return lstEmpleados;
        }

        //BUSCAR CON ID
        public EMPLEADO buscarConId(int id)
        {
            return modeloEntidades.EMPLEADOes.Where(e => e.IDEMP == id).First();
        }

        //VERIFICAR DEPENDENCIAS
        public bool verificarDependencias(int? idCargo)
        {
            Boolean retorno = false;
            var lstUsuarios = modeloEntidades.USUARIOs.Where(e => e.IDEMP==idCargo).ToList();
            var lstFormulariosAnticipo = modeloEntidades.FORMULARIO__ANTICIPO.Where(e => e.IDEMP == idCargo).ToList();
            var lstFormulariosLiquidacion = modeloEntidades.FORMULARIO_LIQUIDACION.Where(e => e.IDEMP == idCargo).ToList();

            if (lstUsuarios.Count > 0 || lstFormulariosAnticipo.Count > 0 || lstFormulariosLiquidacion.Count > 0)
            {
                retorno = true; //Si hay dependencias
            }

            return retorno;            
        }

        //ELIMINAR EMPLEADO
        public void eliminarEmpleado(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                EMPLEADO objEmpleado = buscarConId(indice1);
                modeloEntidades.EMPLEADOes.Remove(objEmpleado);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }



        
    }
}
