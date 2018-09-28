using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sis_Cursos.Interfaces.Olvide_Contrasena
{
    public partial class OlvideContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Inicio();
            }
        }

        #region Metodos
        protected void Inicio()
        {
            ApagarComponentes();
            pFase1.Visible = true;
        }
        protected void ApagarComponentes()
        {
            pFase1.Visible = false;
            pFase2.Visible = false;
            pFase3.Visible = false;
        }
        #endregion

        protected void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pFase2.Visible = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pFase3.Visible = true;
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../index.aspx");
        }
    }
}