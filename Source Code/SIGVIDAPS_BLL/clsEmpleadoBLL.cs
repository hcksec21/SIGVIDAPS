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
    public class clsEmpleadoBLL
    {

        SIGVIDAPS_entidades modeloEntidades = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void insertarEmpleado(EMPLEADO empleado)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (modeloEntidades)
                {
                    modeloEntidades.EMPLEADOes.Add(empleado);
                    modeloEntidades.SaveChanges();
                    transaction.Complete();
                }
            }
        }

        //ACTUALIZAR
        public void actualizarEmpleado(int indice, EMPLEADO empleado)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var objEmpleado = modeloEntidades.EMPLEADOes.Where(qq => qq.IDEMP == indice).Single();                
                modeloEntidades.Entry(objEmpleado).CurrentValues.SetValues(empleado);
                modeloEntidades.SaveChanges();
                transaction.Complete();
            }            
        }

        public List<EMPLEADO> obtenerTodosEmpleados()
        {
            List<EMPLEADO> lstEmpleados = (new SIGVIDAPS_entidades()).EMPLEADOes.ToList();
            return lstEmpleados;
        }

        //BUSCAR CON ID
        public EMPLEADO buscarConId(int id)
        {
            return (new SIGVIDAPS_entidades()).EMPLEADOes.Where(e => e.IDEMP == id).First();
        }
    }
}
