using Controlador.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int idcond = Int32.Parse(txtidcond.Text);

            string nomcond = txtnombre.Text;

            string tipolic = txttipoLicencia.Text;

            int idve = Int32.Parse(txtidVehiculo.Text);

            int idtc = Int32.Parse(txtidTipoConductor.Text);

            logicaControladorConductor negocioAddConductor = new logicaControladorConductor();

            int resultadoAddConductor = negocioAddConductor.NegociarInsertConductor(idcond, nomcond, tipolic, idve, idtc);

            if (resultadoAddConductor > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddConductor = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

            {
                //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
                GridView.DataSource = logicaControladorConductor.NegociarSelectConductor();

                //Llenar cada columna con su respectivo valor y va llenando los registros.
                GridView.DataBind();

                //Los que no tengan datos los deja en blanco.
                txtidcond.Text = "";
                txtnombre.Text = "";
                txttipoLicencia.Text = "";
                txtidVehiculo.Text = "";
                txtidTipoConductor.Text = "";

            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int idcond = Int32.Parse(txtidcond.Text);

            string nomcond = txtnombre.Text;

            string tipolic = txttipoLicencia.Text;

            int idve = Int32.Parse(txtidVehiculo.Text);

            int idtc = Int32.Parse(txtidTipoConductor.Text);

            logicaControladorConductor negocioUpdateConductor = new logicaControladorConductor();

            int resultadoUpdateConductor = negocioUpdateConductor.NegociarUpdateConductor(idcond, nomcond, tipolic, idve, idtc);

            if (resultadoUpdateConductor > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateConductor = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int idcond = Int32.Parse(txtidcond.Text);

            logicaControladorConductor negocioDeleteConductor = new logicaControladorConductor();

            int resultadoDeleteConductor = negocioDeleteConductor.NegociarDeleteConductor(idcond);

            if (resultadoDeleteConductor > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteConductor = null;

        }
    }
}