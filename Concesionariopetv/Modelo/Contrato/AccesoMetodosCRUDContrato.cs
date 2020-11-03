using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {

        //Operacion INSERT
        public int InsertContrato(int idContrato, int idConductor, int idVehiculo)
        {

            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacInsert_contrato();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@idContrato", idContrato);

            _comando.Parameters.AddWithValue("@idConductor", idConductor);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacInsert_contrato(_comando);

        }

        //Operacion SELECT
        public static DataTable ListContrato()
        {

            SqlCommand _comando = MetodosCRUDContrato.CrearComandoSelect_contrato();

            _comando.CommandText = "SELECT * FROM contrato";

            return MetodosCRUDContrato.EjecutarComandoSelect_contrato(_comando);

        }


        //Operacion UPDATE
        public int UpdateContrato(int idContrato, int idConductor, int idVehiculo)
        {

            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacUpdate_contrato();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idContrato", idContrato);

            _comando.Parameters.AddWithValue("@idConductor", idConductor);

            _comando.Parameters.AddWithValue("@idVehiculo", idVehiculo);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacUpdate_contrato(_comando);

        }

        //Operacion DELETE
        public int DeleteContrato(int idContrato)
        {

            SqlCommand _comando = MetodosCRUDContrato.CrearComandoProcAlmacDelete_contrato();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idContrato", idContrato);

            return MetodosCRUDContrato.EjecutarComandoProcAlmacDelete_contrato(_comando);

        }

    }
}
