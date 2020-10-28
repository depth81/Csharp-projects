using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {

        //Operacion INSERT
        public int InsertVehiculo(int id, string marca, string modelo, string placa, int anio, int idtv)
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsert_ve();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@id", id);

            _comando.Parameters.AddWithValue("@marca", marca);

            _comando.Parameters.AddWithValue("@modelo", modelo);

            _comando.Parameters.AddWithValue("@placa", placa);

            _comando.Parameters.AddWithValue("@anio", anio);

            _comando.Parameters.AddWithValue("@idtv", idtv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacInsert_ve(_comando);

        }

        //Operacion SELECT
        public static DataTable ListVehiculo()
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelect_ve();

            _comando.CommandText = "SELECT * FROM Vehiculo";

            return MetodosCRUDVehiculo.EjecutarComandoSelect_ve(_comando);

        }

        //Operacion UPDATE
        public int UpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int idtv)
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacUpdate_ve();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@id", id);

            _comando.Parameters.AddWithValue("@marca", marca);

            _comando.Parameters.AddWithValue("@modelo", modelo);

            _comando.Parameters.AddWithValue("@placa", placa);

            _comando.Parameters.AddWithValue("@anio", anio);

            _comando.Parameters.AddWithValue("@idtv", idtv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacUpdate_ve(_comando);

        }

        //Operacion DELETE
        public int DeleteVehiculo(int id)
        {

            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacDelete_ve();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmacDelete_ve(_comando);

        }

    }
}
