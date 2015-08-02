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
    public class clsPerfilBLL
    {
        SIGVIDAPS_entidades entityContext = new SIGVIDAPS_entidades();

        public List<PERFIL> obtenerTodosPerfiles()
        {
            List<PERFIL> lstPerfiles = entityContext.PERFILs.ToList();
            return lstPerfiles;
        }

        //public list<perfil> obtenertodosperfilesagrupados()
        //{
        //    list<perfil> lstperfiles = entitycontext.perfils;
        //    return lstperfiles;
        //}

        //BUSCAR CON ID
        public PERFIL buscarConId(int id)
        {
            return entityContext.PERFILs.Where(e => e.IDPERFIL == id).First();
        }


        //    //BUSCAR CON NOMBRE DE CARGO
        //    public CARGO buscarConNombreCargo(String nombreCargo)
        //    {
        //        return entityContext.CARGOes.Where(e => e.NOMCARGO == nombreCargo).First();
        //    }

        //    //INSERTAR CARGO
        //    public void insertarCargo(CARGO cargo)
        //    {
        //        using (TransactionScope transaction = new TransactionScope())
        //        {
        //            using (SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades())
        //            {
        //                modeloEntidades.CARGOes.Add(cargo);
        //                modeloEntidades.SaveChanges();
        //                transaction.Complete();
        //            }
        //        }
        //    }

        //    //ACTUALIZAR
        //    public void actualizarCargo(int indice, CARGO cargo)
        //    {
        //        using (TransactionScope transaction = new TransactionScope())
        //        {
        //                cargo.IDCARGO = indice;
        //                CARGO objCargo = buscarConId(indice);
        //                entityContext.Entry(objCargo).CurrentValues.SetValues(cargo);                    
        //                entityContext.SaveChanges();
        //                transaction.Complete();
        //        }
        //    }

        //    //Eliminar
        //    public void eliminarCargo(int indice)
        //    {
        //        using (TransactionScope transaction = new TransactionScope())
        //        {
        //                CARGO objCargo = buscarConId(indice);
        //                entityContext.CARGOes.Remove(objCargo);
        //                entityContext.SaveChanges();
        //                transaction.Complete();
        //        }
        //    }
        //}
    }
}
