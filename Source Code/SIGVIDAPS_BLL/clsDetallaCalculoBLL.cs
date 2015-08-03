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
    public class clsDetalleCalculoBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarDetalleCalculo(DETALLE_CALCULO detalleCalculo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.DETALLE_CALCULO.Add(detalleCalculo);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarDetalleCalculo(int indice, DETALLE_CALCULO detalleCalculo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objDetalleCalculo = modeloEntidades.DETALLE_CALCULO.Where(qq => qq.IDDETALLECALCULO == indice).Single();
                modeloEntidades.Entry(objDetalleCalculo).CurrentValues.SetValues(detalleCalculo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<DETALLE_CALCULO> obtenerTodosDetalleCalculos()
        {
            List<DETALLE_CALCULO> lstDetalleCalculos = modeloEntidades.DETALLE_CALCULO.ToList();
            return lstDetalleCalculos;
        }

        //BUSCAR CON ID
        public DETALLE_CALCULO buscarConId(int id)
        {
            return modeloEntidades.DETALLE_CALCULO.Where(e => e.IDDETALLECALCULO == id).First();
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

        //ELIMINAR DETALLE_CALCULO
        public void eliminarDetalleCalculo(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                DETALLE_CALCULO objDetalleCalculo = buscarConId(indice1);
                modeloEntidades.DETALLE_CALCULO.Remove(objDetalleCalculo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }




    }
}
