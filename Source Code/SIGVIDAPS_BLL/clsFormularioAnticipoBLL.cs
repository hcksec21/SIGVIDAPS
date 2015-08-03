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
    public class clsFormularioAnticipoBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //BUSCAR CON ID
        public List<FORMULARIO__ANTICIPO> buscarFormulariosEmitidosPorFecha()
        {
            return modeloEntidades.FORMULARIO__ANTICIPO.Where(e => e.ESTADOFORMANTICIPO == "EMITIDO").OrderByDescending(e => e.FECFORMANTICIPO).ToList();
        }

        //BUSCAR CON ID
        public List<FORMULARIO__ANTICIPO> buscarFormulariosPorFecha()
        {
            return modeloEntidades.FORMULARIO__ANTICIPO.OrderByDescending(e => e.FECFORMANTICIPO).ToList();
        }

        //INSERTAR 
        public void insertarFormulario_anticipo(FORMULARIO__ANTICIPO formulario_anticipo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.FORMULARIO__ANTICIPO.Add(formulario_anticipo);
                    modeloEntidades.SaveChanges();                    
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarFormulario_anticipo(int indice, FORMULARIO__ANTICIPO formulario_anticipo)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objFormulario_anticipo = modeloEntidades.FORMULARIO__ANTICIPO.Where(qq => qq.IDFORMANTICIPO == indice).Single();
                modeloEntidades.Entry(objFormulario_anticipo).CurrentValues.SetValues(formulario_anticipo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<FORMULARIO__ANTICIPO> obtenerTodosFormulario_anticipos()
        {
            List<FORMULARIO__ANTICIPO> lstFormulario_anticipos = modeloEntidades.FORMULARIO__ANTICIPO.ToList();
            return lstFormulario_anticipos;
        }

        //BUSCAR CON ID
        public FORMULARIO__ANTICIPO buscarConId(int id)
        {
            return modeloEntidades.FORMULARIO__ANTICIPO.Where(e => e.IDFORMANTICIPO == id).First();
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

        //ELIMINAR FORMULARIO__ANTICIPO
        public void eliminarFormulario_anticipo(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                FORMULARIO__ANTICIPO objFormulario_anticipo = buscarConId(indice1);
                modeloEntidades.FORMULARIO__ANTICIPO.Remove(objFormulario_anticipo);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }
    }
}
