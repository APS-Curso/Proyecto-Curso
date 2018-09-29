using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sis_Cursos.Interfaces.Docente
{
    public partial class Docente : System.Web.UI.Page
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
            pMostrarEstudiante.Visible = false;
            pEliminarEstudiante.Visible = false;
            pMostrarCurso.Visible = false;
            pModificarCurso.Visible = false;
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
            pMostrarEstudiante.Visible = true;
        }

        protected void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pEliminarEstudiante.Visible = true;
        }

        protected void btnMostrarCursos_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pMostrarCurso.Visible = true;
        }

        protected void btnModificarCursos_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pModificarCurso.Visible = true;
        }

        protected void btnEliminarCursos_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            pEliminarCurso.Visible = true;
        }
        #endregion
    }
}