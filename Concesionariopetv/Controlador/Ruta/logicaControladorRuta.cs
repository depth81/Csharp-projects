using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Ruta
{
    public class logicaControladorRuta
    {

        //Negociar INSERT
        public int NegociarInsertRuta(int idRuta, string estacion, int idVehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.InsertRuta(idRuta, estacion, idVehiculo);

        }

        //Negociar SELECT
        public static DataTable NegociarSelectRuta()
        {
            return AccesoMetodosCRUDRuta.ListRuta();
        }

        //Negociar UPDATE
        public int NegociarUpdateRuta(int idRuta, string estacion, int idVehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.UpdateRuta(idRuta, estacion, idVehiculo);

        }

        //Negociar DELETE
        public int NegociarDeleteRuta(int idRuta)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();

            return negociarAcceso.DeleteRuta(idRuta);

        }


    }
}
