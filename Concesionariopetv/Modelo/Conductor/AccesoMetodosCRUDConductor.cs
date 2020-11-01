using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {

        //Operacion INSERT
        public int InsertConductor(int idcond, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacInsert_cond();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@idcond", idcond);

            _comando.Parameters.AddWithValue("@nombre", nombre);

            _comando.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            _comando.Parameters.AddWithValue("@idTipoConductor", idTipoConductor);

             return MetodosCRUDConductor.EjecutarComandoProcAlmacInsert_cond(_comando);

        }

        //Operacion SELECT
        public static DataTable ListConductor()
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect_cond();

            _comando.CommandText = "SELECT * FROM conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect_cond(_comando);

        }

        //Operacion UPDATE
        public int UpdateConductor(int idcond, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacUpdate_cond();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idcond", idcond);

            _comando.Parameters.AddWithValue("@nombre", nombre);

            _comando.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            _comando.Parameters.AddWithValue("@idTipoConductor", idTipoConductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacUpdate_cond(_comando);

        }

        //Operacion DELETE
        public int DeleteConductor(int idcond)
        {

            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacDelete_cond();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idcond", idcond);

            return MetodosCRUDConductor.EjecutarComandoProcAlmacDelete_cond(_comando);

        }


    }
}
