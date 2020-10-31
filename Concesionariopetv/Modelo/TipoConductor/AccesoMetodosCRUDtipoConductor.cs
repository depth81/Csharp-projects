using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDtipoConductor
    {

        //Operacion INSERT
        public int InsertTipoConductor(int idtc, string tipoPersona)
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacInsert_tc();

            //insertar de a un registro en la tabla.
            _comando.Parameters.AddWithValue("@idtc", idtc);

            _comando.Parameters.AddWithValue("@tipoPersona", tipoPersona);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacInsert_tc(_comando);

        }

        //Operacion SELECT
        public static DataTable ListTipoConductor()
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoSelect_tc();

            _comando.CommandText = "SELECT * FROM TipoConductor";

            return MetodosCRUDtipoConductor.EjecutarComandoSelect_tc(_comando);

        }

        //Operacion UPDATE
        public int UpdateTipoConductor(int idtc, string tipoPersona)
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacUpdate_tc();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idtc", idtc);

            _comando.Parameters.AddWithValue("@tipoPersona", tipoPersona);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacUpdate_tc(_comando);

        }

        //Operacion DELETE
        public int DeleteTipoConductor(int idtc)
        {

            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacDelete_tc();

            //Actualizar un registro en la tabla.
            _comando.Parameters.AddWithValue("@idtc", idtc);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmacDelete_tc(_comando);

        }

    }
}
