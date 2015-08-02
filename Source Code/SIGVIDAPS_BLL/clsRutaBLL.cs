using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGVIDAPS_DAT;
using System.Data.Entity;
using System.Transactions;

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

        //INSERTAR 
        public void insertarRuta(RUTA ruta)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.RUTAs.Add(ruta);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarRuta(int indice, RUTA ruta)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objRuta = modeloEntidades.RUTAs.Where(qq => qq.IDRUTA == indice).Single();
                modeloEntidades.Entry(objRuta).CurrentValues.SetValues(ruta);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }        

        //ELIMINAR EMPLEADO
        public void eliminarRuta(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                RUTA objRuta = buscarConId(indice1);
                modeloEntidades.RUTAs.Remove(objRuta);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        //BUSCAR CON ID
        public RUTA buscarConId(int id)
        {
            return modeloEntidades.RUTAs.Where(e => e.IDRUTA == id).First();
        }

        //VERIFICAR DEPENDENCIAS
        public bool verificarDependencias(int? idRuta)
        {
            Boolean retorno = false;
            var lstDetalles = modeloEntidades.DETALLE_FORMULARIO.Where(e => e.IDRUTA == idRuta).ToList();            

            if (lstDetalles.Count > 0)
            {
                retorno = true; //Si hay dependencias
            }

            return retorno;
        }


    }
}
