using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sis_Cursos.Interfaces.Administrador
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Inicio();
            }
        }

        #region Metodos
        protected void ApagarComponentes()
        {
            pMostrarEstudiantes.Visible = false;
            pEliminarEstudiante.Visible = false;
            pAgregarDocente.Visible = false;
            pMostrarDocente.Visible = false;
            pAgregarDocenteCurso.Visible = false;
            pEliminarDocente.Visible = false;
            pAgregarCurso.Visible = false;
            pModificarCurso.Visible = false;
            pMostrarCurso.Visible = false;
            pEliminarCurso.Visible = false;
        }

        protected void Inicio()
        {
            ApagarComponentes();
        }
        #endregion


        #region Botones
        protected void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pMostrarEstudiantes.Visible = true;
        }
        protected void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pEliminarEstudiante.Visible = true;
        }

        protected void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pAgregarDocente.Visible = true;
        }

        protected void btnMostrarDocente_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pMostrarDocente.Visible = true;
        }

        protected void btnAgregarDocenteCurso_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pAgregarDocenteCurso.Visible = true;
        }

        protected void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pEliminarDocente.Visible = true;
        }

        protected void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pAgregarCurso.Visible = true;
        }

        protected void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pMostrarCurso.Visible = true;
        }

        protected void btnModificarCurso_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pModificarCurso.Visible = true;
        }

        protected void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pEliminarCurso.Visible = true;
        }
        #endregion

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView2.Visible=true;

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}