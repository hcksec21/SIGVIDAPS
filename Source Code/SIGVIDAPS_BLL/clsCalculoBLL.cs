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
    public class clsCalculoBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarCalculo(CALCULO calculo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.CALCULOes.Add(calculo);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarCalculo(int indice, CALCULO calculo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objCalculo = modeloEntidades.CALCULOes.Where(qq => qq.IDCALCULO == indice).Single();
                modeloEntidades.Entry(objCalculo).CurrentValues.SetValues(calculo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<CALCULO> obtenerTodosCalculos()
        {
            List<CALCULO> lstCalculos = modeloEntidades.CALCULOes.ToList();
            return lstCalculos;
        }

        //BUSCAR CON ID
        public CALCULO buscarConId(int id)
        {
            return modeloEntidades.CALCULOes.Where(e => e.IDCALCULO == id).First();
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

        //ELIMINAR CALCULO
        public void eliminarCalculo(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                CALCULO objCalculo = buscarConId(indice1);
                modeloEntidades.CALCULOes.Remove(objCalculo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }
    }
}
