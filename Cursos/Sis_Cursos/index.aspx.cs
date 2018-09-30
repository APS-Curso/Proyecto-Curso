using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;
using Negocios;

namespace Sis_Cursos
{
    public partial class index : System.Web.UI.Page
    {
        N_Usuarios ObjNU = new N_Usuarios();
        E_Usuario ObjEU = new E_Usuario();
        N_Rol ObjNR = new N_Rol();
        E_Rol ObjER = new E_Rol();
        N_UsuarioRol ObjNUR = new N_UsuarioRol();
        E_UsuarioRol ObjEUR = new E_UsuarioRol();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Metodos
        protected void Direccionar(E_Usuario ObjEU)
        {
            ObjEUR = ObjNUR.BuscarUsuarioRolPorIdUsuario(ObjEU.IdUsuario);
            if (ObjEUR.IdUsuario == 1)
            {
                Response.Redirect("Interfaces/Estudiante/Estudiante.aspx");
            }
            else
            {
                if (ObjEUR.IdUsuario == 2)
                {
                    Response.Redirect("Interfaces/Docente/Docente.aspx");
                }
                else
                {
                    Response.Redirect("Interfaces/Administrador/Administrador.aspx");
                }
            }
        }
        #endregion

        #region Botones
        protected void btnInicio_Click(object sender, EventArgs e)
        {
            ObjEU = ObjNU.BuscarUsuarioPorCorreo(inputEmail.Text);
            if (ObjEU != null)
            {
                if (ObjEU.Pass == inputPassword.Text)
                {
                    Direccionar(ObjEU);
                }
            }
        }
        #endregion
    }
}