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
    public class clsMenuPerfilBLL
    {
        SIGVIDAPS_entidades entityContext = new SIGVIDAPS_entidades();

        public List<MENU_PERFIL> obtenerTodosLosMenuPerfiles()
        {
            List<MENU_PERFIL> lstMenuPerfils = entityContext.MENU_PERFIL.ToList();
            return lstMenuPerfils;
        }

        public List<MENU_PERFIL> obtenerTodosLosMenuPerfilesDeUsuario(USUARIO user)
        {
            PERFIL perfil = (new clsPerfilBLL()).buscarConId(Convert.ToInt32(user.IDPERFIL));
            List<MENU_PERFIL> lstMenuPerfils = entityContext.MENU_PERFIL.Where(e => e.IDPERFIL == perfil.IDPERFIL).ToList();
            return lstMenuPerfils;
        }


        //BUSCAR CON ID
        public MENU_PERFIL buscarConId(int id)
        {
            return entityContext.MENU_PERFIL.Where(e => e.IDMENUPERFIL == id).First();
        }


        //    //BUSCAR CON NOMBRE DE CARGO
        //    public CARGO buscarConNombreCargo(String nombreCargo)
        //    {
        //        return entityContext.CARGOes.Where(e => e.NOMCARGO == nombreCargo).First();
        //    }

        //INSERTAR CARGO
        public void insertarMenuPerfil(MENU_PERFIL menuPerfil)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                entityContext.MENU_PERFIL.Add(menuPerfil);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }

        //ACTUALIZAR
        public void actualizarMenuPerfil(int indice, MENU_PERFIL menuPerfil)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objMenuPerfil = entityContext.MENU_PERFIL.Where(qq => qq.IDMENUPERFIL == indice).Single();
                menuPerfil.IDMENUPERFIL = indice;
                entityContext.Entry(objMenuPerfil).CurrentValues.SetValues(menuPerfil);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }

        //Eliminar
        public void eliminarMenuPerfil(int indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                MENU_PERFIL objCargo = buscarConId(indice);
                entityContext.MENU_PERFIL.Remove(objCargo);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }
    }
}
