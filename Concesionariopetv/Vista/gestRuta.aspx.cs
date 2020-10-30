using Controlador.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int idru = Int32.Parse(txtidRuta.Text);

            string nomestacion = txtEstacion.Text;

            int idve = Int32.Parse(txtidVehiculo.Text);

            logicaControladorRuta negocioAddRuta = new logicaControladorRuta();

            int resultadoAddRuta = negocioAddRuta.NegociarInsertRuta(idru, nomestacion, idve);

            if (resultadoAddRuta > 0)
            {
                lblMensaje.Text = "Registro insertado";
            }
            else
            {
                lblMensaje.Text = "No se pudo registrar";
            }

            negocioAddRuta = null;

        }

        protected void btnList_Click(object sender, EventArgs e)
        {

            //Cuando se le de click al boton "List" debe recibir los datos que neogcio el controlador y despues enviarlos a la grilla (ID=GridView).
            GridView.DataSource = logicaControladorRuta.NegociarSelectRuta();

            //Llenar cada columna con su respectivo valor y va llenando los registros.
            GridView.DataBind();

            //Los que no tengan datos los deja en blanco.
            txtidRuta.Text = "";
            txtEstacion.Text = "";
            txtidVehiculo.Text = "";

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idru = Int32.Parse(txtidRuta.Text);

            string nomestacion = txtEstacion.Text;

            int idve = Int32.Parse(txtidVehiculo.Text);

            logicaControladorRuta negocioUpdateRuta = new logicaControladorRuta();

            int resultadoUpdateRuta = negocioUpdateRuta.NegociarUpdateRuta(idru, nomestacion, idve);

            if (resultadoUpdateRuta > 0)
            {
                lblMensaje.Text = "Registro actualizado";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar";
            }

            negocioUpdateRuta = null;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int idru = Int32.Parse(txtidRuta.Text);

            logicaControladorRuta negocioDeleteRuta = new logicaControladorRuta();

            int resultadoDeleteRuta = negocioDeleteRuta.NegociarDeleteRuta(idru);

            if (resultadoDeleteRuta > 0)
            {
                lblMensaje.Text = "Registro eliminado";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar";
            }

            negocioDeleteRuta = null;
        }
    }
}