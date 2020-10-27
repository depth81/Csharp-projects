using System;
using System.Collections.Generic;
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

    }
}
