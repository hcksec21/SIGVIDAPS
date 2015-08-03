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
    public class clsFormLiquidacionBLL
    {
        SIGVIDAPS_entidades context = new SIGVIDAPS_entidades();

        //INSERTAR 
        public void crearFormulario(FORMULARIO_LIQUIDACION formulario)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                using (context)
                {
                    context.FORMULARIO_LIQUIDACION.Add(formulario);
                    context.SaveChanges();
                    transaction.Complete();
                }
            }
        }


    }
}
