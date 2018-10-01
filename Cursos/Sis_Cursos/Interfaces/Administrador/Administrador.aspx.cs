using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
using System.Net.Mail;
using System.Net;
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
            List<E_Usuario> LstUsuario2 = new List<E_Usuario>();
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {

                if (usuario_rol.IdRol == 1)
                {
                    LstUsuario2.Add(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));
                   
                }
            }

            Grid_Estudiantes.DataSource = LstUsuario2;
            Grid_Estudiantes.DataBind();
            pMostrarEstudiantes.Visible = true;
        }
        protected void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            ApagarComponentes();
            List<E_Usuario> LstUsuario2 = new List<E_Usuario>();
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {

                if (usuario_rol.IdRol == 1)
                {
                    LstUsuario2.Add(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));

                }
            }

            Grid_Estudiantes_D.DataSource = LstUsuario2;
            Grid_Estudiantes_D.DataBind();
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
       
            //List <E_Usuario> LstUsuario = new N_Usuarios().LstUsuario();
            List<E_Usuario> LstUsuario2 = new List<E_Usuario>();
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {
                
                if (usuario_rol.IdRol ==2)
                {
                    LstUsuario2.Add(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));
                    //int id = usuario_rol.IdUsuario;
                    //Eliminar usuario
                    /* foreach (E_Usuario usuario in LstUsuario)
                     {
                         if (usuario.IdUsuario == id)
                         {
                             LstUsuario.Remove(usuario);
                         }
                     }*/
                    //  LstUsuario.Remove(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));
                }
            }

            GridView2.DataSource = LstUsuario2;
            GridView2.DataBind();


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
            List<E_Usuario> LstUsuario2 = new List<E_Usuario>();
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {

                if (usuario_rol.IdRol == 2)
                {
                    LstUsuario2.Add(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));
                    //int id = usuario_rol.IdUsuario;
                    //Eliminar usuario
                    /* foreach (E_Usuario usuario in LstUsuario)
                     {
                         if (usuario.IdUsuario == id)
                         {
                             LstUsuario.Remove(usuario);
                         }
                     }*/
                    //  LstUsuario.Remove(new N_Usuarios().BuscarUsuarioPorId(usuario_rol.IdUsuario));
                }
            }

            Grid_Docentes_D.DataSource = LstUsuario2;
            Grid_Docentes_D.DataBind();
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

        protected void Grid_CursosD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UId = Convert.ToString(Grid_CursosD.SelectedDataKey["Nombre"]);
            E_Curso curso = new N_Cursos().BuscarCursoPorNombre(UId);
            int id = curso.IdCurso;
            N_Cursos OBJNC = new N_Cursos();
            //OBJNC.BorrarCurso(id);
            Response.Redirect("Administrador.aspx");
        }

        protected void Grid_Estudiantes_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UId = Convert.ToInt16(Grid_Estudiantes_D.SelectedDataKey["IdUsuario"]);
            N_Usuarios ObjNU = new N_Usuarios();
            
            int id = UId;
            List<E_UsuarioCurso> LstUsuarioCurso = new N_UsuarioCurso().LstUsuarioCurso();
            foreach (E_UsuarioCurso usuario_curso in LstUsuarioCurso)
            {
                if (usuario_curso.IdUsuario == id)
                {
                    N_UsuarioCurso ObjNUC = new N_UsuarioCurso();
                    ObjNUC.BorrarUsuarioCurso(usuario_curso.IdCurso, id);
                }
            }
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {

                if (usuario_rol.IdUsuario == id)
                {
                    N_UsuarioRol ObjNUR = new N_UsuarioRol();
                    ObjNUR.BorrarUsuarioRol(usuario_rol.IdRol,usuario_rol.IdUsuario);

                }
            }
            //ObjNU.BorrarUsuario(id,new N_Usuarios().BuscarUsuarioPorId(id).PasswordUsuario);
            Response.Redirect("Administrador.aspx");
        }

        protected void Grid_Docentes_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UId = Convert.ToInt16(Grid_Docentes_D.SelectedDataKey["IdUsuario"]);
            N_Usuarios ObjNU = new N_Usuarios();

            int id = UId;
            
            List<E_UsuarioRol> LstUsuarioRol = new N_UsuarioRol().LstUsuarioRol();
            foreach (E_UsuarioRol usuario_rol in LstUsuarioRol)
            {

                if (usuario_rol.IdUsuario == id)
                {
                    N_UsuarioRol ObjNUR = new N_UsuarioRol();
                    ObjNUR.BorrarUsuarioRol(usuario_rol.IdRol, usuario_rol.IdUsuario);

                }
            }
            //ObjNU.BorrarUsuario(id,new N_Usuarios().BuscarUsuarioPorId(id).PasswordUsuario);
            Response.Redirect("Administrador.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}