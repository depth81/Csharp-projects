using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {

        //Operacion INSERT
        public int InsertRuta(int idRuta, string estacion, int idVehiculo)
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacInsert_ruta();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@idRuta", idRuta);

            _comando.Parameters.AddWithValue("@estacion", estacion);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacInsert_ruta(_comando);

        }

        //Operacion SELECT
        public static DataTable ListRuta()
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoSelect_ruta();

            _comando.CommandText = "SELECT * FROM ruta";

            return MetodosCRUDRuta.EjecutarComandoSelect_ruta(_comando);

        }

        //Operacion UPDATE
        public int UpdateRuta(int idRuta, string estacion, int idVehiculo)
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacUpdate_ruta();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idRuta", idRuta);

            _comando.Parameters.AddWithValue("@estacion", estacion);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacUpdate_ruta(_comando);

        }

        //Operacion DELETE
        public int DeleteRuta(int idRuta)
        {

            SqlCommand _comando = MetodosCRUDRuta.CrearComandoProcAlmacDelete_ruta();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idRuta", idRuta);

            return MetodosCRUDRuta.EjecutarComandoProcAlmacDelete_ruta(_comando);

        }

    }
}
