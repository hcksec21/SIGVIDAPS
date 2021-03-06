﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using SIGVIDAPS_DAT;
using System.Data.Entity;


namespace SIGVIDAPS_BLL
{
    public class clsUsuarioBLL
    {
        SIGVIDAPS_entidades entityContext = new SIGVIDAPS_entidades();

        public List<USUARIO> obtenerTodosLosUsuarios()
        {
            List<USUARIO> lstUsuarios = entityContext.USUARIOs.ToList();
            return lstUsuarios;
        }



        //BUSCAR CON ID
        public USUARIO buscarByNombre(string nombreUsuario)
        {
            return entityContext.USUARIOs.Where(e => e.NOMBREUSUARIO == nombreUsuario).First();
        }

        public bool loggin(string nombreUsuario,string password)
        {
            return entityContext.USUARIOs.Where(e => e.NOMBREUSUARIO == nombreUsuario && e.CONTRASENAUSUARIO == password).Any();
        }

        //BUSCAR CON ID
        public USUARIO buscarConId(int id)
        {
            return entityContext.USUARIOs.Where(e => e.IDUSUARIO == id).First();
        }


        //    //BUSCAR CON NOMBRE DE CARGO
        //    public CARGO buscarConNombreCargo(String nombreCargo)
        //    {
        //        return entityContext.CARGOes.Where(e => e.NOMCARGO == nombreCargo).First();
        //    }

        //INSERTAR CARGO
        public void insertarUsuario(USUARIO usuario)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                entityContext.USUARIOs.Add(usuario);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }

        //ACTUALIZAR
        public void actualizarUsuario(int indice, USUARIO usuario)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objUsuario = entityContext.USUARIOs.Where(qq => qq.IDUSUARIO == indice).Single();
                usuario.IDUSUARIO = indice;
                entityContext.Entry(objUsuario).CurrentValues.SetValues(usuario);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }

        //Eliminar
        public void eliminarUsuario(int indice)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                USUARIO objCargo = buscarConId(indice);
                entityContext.USUARIOs.Remove(objCargo);
                entityContext.SaveChanges();
                transaction.Complete();
            }
        }
    }
}
