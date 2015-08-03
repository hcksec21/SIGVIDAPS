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
    public class clsDetalleFormularioBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarDetalleFormulario(DETALLE_FORMULARIO detalleFormulario)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.DETALLE_FORMULARIO.Add(detalleFormulario);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarDetalleFormulario(int indice, DETALLE_FORMULARIO detalleFormulario)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objDetalleFormulario = modeloEntidades.DETALLE_FORMULARIO.Where(qq => qq.IDDETFORM == indice).Single();
                modeloEntidades.Entry(objDetalleFormulario).CurrentValues.SetValues(detalleFormulario);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<DETALLE_FORMULARIO> obtenerTodosDetalleFormularios()
        {
            List<DETALLE_FORMULARIO> lstDetalleFormularios = modeloEntidades.DETALLE_FORMULARIO.ToList();
            return lstDetalleFormularios;
        }

        //BUSCAR CON ID
        public DETALLE_FORMULARIO buscarConId(int id)
        {
            return modeloEntidades.DETALLE_FORMULARIO.Where(e => e.IDDETFORM == id).First();
        }

        //VERIFICAR DEPENDENCIAS
        //public bool verificarDependencias(int? idCargo)
        //{
        //    Boolean retorno = false;
        //    var lstUsuarios = modeloEntidades.USUARIOs.Where(e => e.IDEMP == idCargo).ToList();
        //    var lstFormulariosAnticipo = modeloEntidades.FORMULARIO__ANTICIPO.Where(e => e.IDEMP == idCargo).ToList();
        //    var lstFormulariosLiquidacion = modeloEntidades.FORMULARIO_LIQUIDACION.Where(e => e.IDEMP == idCargo).ToList();

        //    if (lstUsuarios.Count > 0 || lstFormulariosAnticipo.Count > 0 || lstFormulariosLiquidacion.Count > 0)
        //    {
        //        retorno = true; //Si hay dependencias
        //    }

        //    return retorno;
        //}

        //ELIMINAR DETALLE_FORMULARIO
        public void eliminarDetalleFormulario(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                DETALLE_FORMULARIO objDetalleFormulario = buscarConId(indice1);
                modeloEntidades.DETALLE_FORMULARIO.Remove(objDetalleFormulario);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }




    }
}
