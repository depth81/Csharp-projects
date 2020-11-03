using Controlador.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int idcontrato = Int32.Parse(txtidContrato.Text);

            int idconductor = Int32.Parse(txtidConductor.Text);

            int idve = Int32.Parse(txtidVehiculo.Text);

            logicaControladorContrato negocioAddContrato = new logicaControladorContrato();

            int resultadoAddContrato = negocioAddContrato.NegociarInsertContrato(idcontrato, idconductor, idve);

            if (resultadoAddContrato > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddContrato = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

            //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
            GridView.DataSource = logicaControladorContrato.NegociarSelectContrato();

            //Llenar cada columna con su respectivo valor y va llenando los registros.
            GridView.DataBind();

            //Los que no tengan datos los deja en blanco.
            txtidContrato.Text = "";
            txtidConductor.Text = "";
            txtidVehiculo.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int idcontrato = Int32.Parse(txtidContrato.Text);

            int idconductor = Int32.Parse(txtidConductor.Text);

            int idve = Int32.Parse(txtidVehiculo.Text);

            logicaControladorContrato negocioUpdateContrato = new logicaControladorContrato();

            int resultadoUpdateContrato = negocioUpdateContrato.NegociarUpdateContrato(idcontrato, idconductor, idve);

            if (resultadoUpdateContrato > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateContrato = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int idcontrato = Int32.Parse(txtidContrato.Text);

            logicaControladorContrato negocioDeleteContrato = new logicaControladorContrato();

            int resultadoDeleteContrato = negocioDeleteContrato.NegociarDeleteContrato(idcontrato);

            if (resultadoDeleteContrato > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteContrato = null;
        }
    }
}