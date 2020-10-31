using Controlador.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int idtipocond = Int32.Parse(txtidtc.Text);

            string tipocond = txtTipoConductor.Text;

            logicaControladorTipoConductor negocioAddTipoConductor = new logicaControladorTipoConductor();

            int resultadoAddTipoConductor = negocioAddTipoConductor.NegociarInsertTipoConductor(idtipocond, tipocond);

            if (resultadoAddTipoConductor > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddTipoConductor = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

            //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
            GridView.DataSource = logicaControladorTipoConductor.NegociarSelectTipoConductor();

            //Llenar cada columna con su respectivo valor y va llenando los registros.
            GridView.DataBind();

            //Los que no tengan datos los deja en blanco.
            txtidtc.Text = "";
            txtTipoConductor.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int idtipocond = Int32.Parse(txtidtc.Text);

            string tipocond = txtTipoConductor.Text;

            logicaControladorTipoConductor negocioUpdateTipoConductor = new logicaControladorTipoConductor();

            int resultadoUpdateTipoConductor = negocioUpdateTipoConductor.NegociarUpdateTipoConductor(idtipocond, tipocond);

            if (resultadoUpdateTipoConductor > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateTipoConductor = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int idtipocond = Int32.Parse(txtidtc.Text);

            logicaControladorTipoConductor negocioDeleteTipoConductor = new logicaControladorTipoConductor();

            int resultadoDeleteTipoConductor = negocioDeleteTipoConductor.NegociarDeleteTipoConductor(idtipocond);

            if (resultadoDeleteTipoConductor > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteTipoConductor = null;


        }
    }
}