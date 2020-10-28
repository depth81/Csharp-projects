using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccesoMetodosCRUDtipoVehiculo
    {

        //Operacion INSERT
        public int InsertTipoVehiculo(int id, string nombre)
        {

            SqlCommand _comando =  MetodosCRUDtipoVehiculo.CrearComandoProcAlmacInsert_tv();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@id",id);
           
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacInsert_tv(_comando);

        }

        //Operacion SELECT
        public static DataTable ListTipoVehiculo()
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoSelect_tv();

            _comando.CommandText = "SELECT * FROM TipoVehiculo";

            return MetodosCRUDtipoVehiculo.EjecutarComandoSelect_tv(_comando);

        }

        //Operacion UPDATE
        public int UpdateTipoVehiculo(int id, string nombre)
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacUpdate_tv();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacUpdate_tv(_comando);

        }

        //Operacion DELETE
        public int DeleteTipoVehiculo(int id)
        {

            SqlCommand _comando = MetodosCRUDtipoVehiculo.CrearComandoProcAlmacDelete_tv();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDtipoVehiculo.EjecutarComandoProcAlmacDelete_tv(_comando);

        }

    }
}
