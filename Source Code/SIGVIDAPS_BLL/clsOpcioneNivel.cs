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
    public class clsOpcionNivelBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarOpcionNivel(OPCION_NIVEL opcionNivel)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.OPCION_NIVEL.Add(opcionNivel);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarOpcionNivel(int indice, OPCION_NIVEL opcionNivel)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objOpcionNivel = modeloEntidades.OPCION_NIVEL.Where(qq => qq.IDOPCIONN == indice).Single();
                modeloEntidades.Entry(objOpcionNivel).CurrentValues.SetValues(opcionNivel);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }

        public List<OPCION_NIVEL> obtenerTodosOpcionNivels()
        {
            List<OPCION_NIVEL> lstOpcionNivels = modeloEntidades.OPCION_NIVEL.ToList();
            return lstOpcionNivels;
        }

        //BUSCAR CON IDOPCION y IDNIVEL
        public OPCION_NIVEL buscarConOpcionNivel(int idOpcion, int idNivel)
        {
            return modeloEntidades.OPCION_NIVEL.Where(e => e.IDOPCION == idOpcion && e.IDNIVEL == idNivel).First();
        }

        //BUSCAR CON ID
        public OPCION_NIVEL buscarConId(int id)
        {
            return modeloEntidades.OPCION_NIVEL.Where(e => e.IDOPCIONN == id).First();
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

        //ELIMINAR OPCION_NIVEL
        public void eliminarOpcionNivel(int? indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                int indice1 = (int)indice;
                OPCION_NIVEL objOpcionNivel = buscarConId(indice1);
                modeloEntidades.OPCION_NIVEL.Remove(objOpcionNivel);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }
        }




    }
}
