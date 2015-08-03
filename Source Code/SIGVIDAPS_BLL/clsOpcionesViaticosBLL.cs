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
    public class clsOpcionesViaticosBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarOpcionViatico(OPCIONES_VIATICOS opcionViatico)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.OPCIONES_VIATICOS.Add(opcionViatico);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarOpcionViatico(int indice, OPCIONES_VIATICOS opcionViatico)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objOpcionViatico = modeloEntidades.OPCIONES_VIATICOS.Where(qq => qq.IDOPCION == indice).Single();
                modeloEntidades.Entry(objOpcionViatico).CurrentValues.SetValues(opcionViatico);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<OPCIONES_VIATICOS> obtenerTodosOpcionViaticos()
        {
            List<OPCIONES_VIATICOS> lstOpcionViaticos = modeloEntidades.OPCIONES_VIATICOS.ToList();
            return lstOpcionViaticos;
        }

        //BUSCAR CON ID
        public OPCIONES_VIATICOS buscarConId(int id)
        {
            return modeloEntidades.OPCIONES_VIATICOS.Where(e => e.IDOPCION == id).First();
        }

        //VERIFICAR DEPENDENCIAS
        public bool verificarDependencias(int? idCargo)
        {
            Boolean retorno = false;
            var lstUsuarios = modeloEntidades.USUARIOs.Where(e => e.IDEMP == idCargo).ToList();
            var lstFormulariosAnticipo = modeloEntidades.FORMULARIO__ANTICIPO.Where(e => e.IDEMP == idCargo).ToList();
            var lstFormulariosLiquidacion = modeloEntidades.FORMULARIO_LIQUIDACION.Where(e => e.IDEMP == idCargo).ToList();

            if (lstUsuarios.Count > 0 || lstFormulariosAnticipo.Count > 0 || lstFormulariosLiquidacion.Count > 0)
            {
                retorno = true; //Si hay dependencias
            }

            return retorno;
        }

        //ELIMINAR OPCION_VIATICO
        public void eliminarOpcionViatico(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                OPCIONES_VIATICOS objOpcionViatico = buscarConId(indice1);
                modeloEntidades.OPCIONES_VIATICOS.Remove(objOpcionViatico);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }




    }
}
