using Modelo.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Conductor
{
    public class logicaControladorConductor
    {

        //Negociar INSERT
        public int NegociarInsertConductor(int idcond, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.InsertConductor(idcond, nombre, tipoLicencia, idVehiculo, idTipoConductor);

        }

        //Negociar SELECT
        public static DataTable NegociarSelectConductor()
        {
            return AccesoMetodosCRUDConductor.ListConductor();
        }

        //Negociar UPDATE
        public int NegociarUpdateConductor(int idcond, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.UpdateConductor(idcond, nombre, tipoLicencia, idVehiculo, idTipoConductor);

        }

        //Negociar DELETE
        public int NegociarDeleteConductor(int idcond)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();

            return negociarAcceso.DeleteConductor(idcond);

        }

    }
}
