using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enumeraciones
{

    enum EstatusOperacion
    {

        Exitoso = 1,
        ClienteNoEncontrado = 2,
        ErrorDeSistema = 5

    }
    class Program
    {
        static void Main(string[] args)
        {

            int estatusOperacion = 5;

            if (estatusOperacion == (int)EstatusOperacion.Exitoso)
            {
                //...

            }
            else if (estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
            {
                //...
            }
            else if (estatusOperacion == (int)EstatusOperacion.ErrorDeSistema)
            {
                //...
            }
            else
            {
                //...
            }

        }
    }

}
