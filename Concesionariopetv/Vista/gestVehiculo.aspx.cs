using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int veId = Int32.Parse(txtId.Text);

            string veMarca = txtMarca.Text;

            string veModelo = txtModelo.Text;

            string vePlaca = txtPlaca.Text;

            int veAnio = Int32.Parse(txtAnio.Text);

            int veIdtv = Int32.Parse(txtIdtv.Text);

            logicaControladorVehiculo negocioAddVehiculo = new logicaControladorVehiculo();

            int resultadoAddVehiculo = negocioAddVehiculo.NegociarInsertVehiculo(veId, veMarca, veModelo, vePlaca, veAnio, veIdtv);

            if (resultadoAddVehiculo > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddVehiculo = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

            //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
            GridView.DataSource = logicaControladorVehiculo.NegociarSelectVehiculo();

            //Llenar cada columna con su respectivo valor y va llenando los registros.
            GridView.DataBind();

            //Los que no tengan datos los deja en blanco.
            txtId.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtAnio.Text = "";
            txtIdtv.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int veId = Int32.Parse(txtId.Text);

            string veMarca = txtMarca.Text;

            string veModelo = txtModelo.Text;

            string vePlaca = txtPlaca.Text;

            int veAnio = Int32.Parse(txtAnio.Text);

            int veIdtv = Int32.Parse(txtIdtv.Text);

            logicaControladorVehiculo negocioUpdateVehiculo = new logicaControladorVehiculo();

            int resultadoUpdateVehiculo = negocioUpdateVehiculo.NegociarUpdateVehiculo(veId, veMarca, veModelo, vePlaca, veAnio, veIdtv);

            if (resultadoUpdateVehiculo > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateVehiculo = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int veId = Int32.Parse(txtId.Text);

            logicaControladorVehiculo negocioDeleteVehiculo = new logicaControladorVehiculo();

            int resultadoDeleteVehiculo = negocioDeleteVehiculo.NegociarDeleteVehiculo(veId);

            if (resultadoDeleteVehiculo > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteVehiculo = null;

        }
    }
}