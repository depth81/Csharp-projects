using Modelo.Contrato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Contrato
{
    public class logicaControladorContrato
    {

        //Negociar INSERT
        public int NegociarInsertContrato(int idContrato, int idConductor, int idVehiculo)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.InsertContrato(idContrato, idConductor, idVehiculo);

        }

        //Negociar SELECT
        public static DataTable NegociarSelectContrato()
        {
            return AccesoMetodosCRUDContrato.ListContrato();
        }

        //Negociar UPDATE
        public int NegociarUpdateContrato(int idContrato, int idConductor, int idVehiculo)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.UpdateContrato(idContrato, idConductor, idVehiculo);

        }

        //Negociar DELETE
        public int NegociarDeleteContrato(int idContrato)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();

            return negociarAcceso.DeleteContrato(idContrato);

        }


    }
}
