using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Transactions;
using SIGVIDAPS_DAT;

namespace SIGVIDAPS_BLL
{
    public class clsTipoTransporteBLL
    {
        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        public List<TIPO_TRANSPORTE> obtenerTodasTipoTrasnportes()
        {
            List<TIPO_TRANSPORTE> lstTipoTrasnportes = modeloEntidades.TIPO_TRANSPORTE.ToList();
            return lstTipoTrasnportes;
        }

        //INSERTAR 
        public void insertarTipoTrasnporte(TIPO_TRANSPORTE tipoTransporte)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.TIPO_TRANSPORTE.Add(tipoTransporte);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarTipoTrasnporte(int indice, TIPO_TRANSPORTE tipoTransporte)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objTipoTrasnporte = modeloEntidades.TIPO_TRANSPORTE.Where(qq => qq.IDTIPOTRANSPORTE == indice).Single();
                modeloEntidades.Entry(objTipoTrasnporte).CurrentValues.SetValues(tipoTransporte);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        //ELIMINAR EMPLEADO
        public void eliminarTipoTrasnporte(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                TIPO_TRANSPORTE objTipoTrasnporte = buscarConId(indice1);
                modeloEntidades.TIPO_TRANSPORTE.Remove(objTipoTrasnporte);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        //BUSCAR CON ID
        public TIPO_TRANSPORTE buscarConId(int id)
        {
            return modeloEntidades.TIPO_TRANSPORTE.Where(e => e.IDTIPOTRANSPORTE == id).First();
        }

        //VERIFICAR DEPENDENCIAS
        public bool verificarDependencias(int? idTipoTrasnporte)
        {
            Boolean retorno = false;
            var lstDetalles = modeloEntidades.DETALLE_FORMULARIO.Where(e => e.IDTIPOTRANSPORTE == idTipoTrasnporte).ToList();

            if (lstDetalles.Count > 0)
            {
                retorno = true; //Si hay dependencias
            }

            return retorno;
        }


    }
}
