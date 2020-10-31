using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoConductor
{
    public class logicaControladorTipoConductor
    {

        //Negociar INSERT
        public int NegociarInsertTipoConductor(int idtc, string tipoPersona)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.InsertTipoConductor(idtc, tipoPersona);

        }

        //Negociar SELECT
        public static DataTable NegociarSelectTipoConductor()
        {
            return AccesoMetodosCRUDtipoConductor.ListTipoConductor();
        }

        //Negociar UPDATE
        public int NegociarUpdateTipoConductor(int idtc, string tipoPersona)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.UpdateTipoConductor(idtc, tipoPersona);

        }

        //Negociar DELETE
        public int NegociarDeleteTipoConductor(int idtc)
        {
            AccesoMetodosCRUDtipoConductor negociarAcceso = new AccesoMetodosCRUDtipoConductor();

            return negociarAcceso.DeleteTipoConductor(idtc);

        }

    }
}
