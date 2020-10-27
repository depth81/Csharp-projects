using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            int carTypeId = Int32.Parse(txtId.Text);

            string typeName = txtName.Text;

            logicaControladorTipoVehiculo negocioAddTipoVehiculo = new logicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(carTypeId, typeName);

            if (resultadoAddTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddTipoVehiculo = null;
        }
    }
}