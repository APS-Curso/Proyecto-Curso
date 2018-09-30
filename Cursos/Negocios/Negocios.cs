using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entidades;
using DatosSQL;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace Negocios
{
    public class N_Usuarios
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBE_Usuarios";

        #region INSERTAR, BORRAR y MODIFICAR
        // Acciones de Insertar, Borrar y Modificar los datos del Usuario
        public string InsertarUsuario(E_Usuario pEntidades)
        {
            pEntidades.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, pEntidades);
        }

        public string BorrarUsuario(int pIdUsuario)
        {
            E_Usuario Entidad = new E_Usuario { Accion = "BORRAR", IdUsuario = pIdUsuario };
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, Entidad);
        }

        public string ModificarUsuario(E_Usuario pEntidades)
        {
            pEntidades.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, pEntidades);
        }
        #endregion

        #region Listados generales de Usuarios
        // Listado generales de Usuarios en dormato DateTable y List<E_Sistema>
        public DataTable GetDT_Usuarios()
        {
            return ObjLst.DT_ListadoGeneral("Usuarios", "IdUsuario, Apellido");
        }

        public List<E_Usuario> LstUsuario()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Usuario>(GetDT_Usuarios());
        }
        #endregion

        #region Busquedad de Usuarios
        // Busqueda de usuario por diferente Criterio
        public E_Usuario BuscarUsuarioPorId(int pIdUsuario)
        {
            return (from User in LstUsuario() where User.IdUsuario == pIdUsuario select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorCorreo(string pCorreo)
        {
            return (from User in LstUsuario() where User.Correo == pCorreo select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorUsuario(string pUsuaruio)
        {
            return (from User in LstUsuario() where User.Usuario == pUsuaruio select User).FirstOrDefault();
        }

        public int ValidaLogin(string pUsuario, string pPassword)
        {
            if ((from User in LstUsuario() where User.Usuario == pUsuario && User.Pass == pPassword select User).FirstOrDefault() != null) /*&&
                (from User in LstUsuario() where User.Pass == pPassword select User).FirstOrDefault() != null)*/
                return 1;
            return -1;
        }
        #endregion

    }

    public class N_Rol
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_Rol";

        #region INSERTAR, BORRAR y MODIFICAR
        // Acciones de Insertar, Borrar y Modificar los datos del Rol
        public string InsertarRol(E_Rol pEntidades)
        {
            pEntidades.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, pEntidades);
        }

        public string BorrarRol(int pIdRol)
        {
            E_Rol Entidad = new E_Rol { Accion = "BORRAR", IdRol = pIdRol };
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, Entidad);
        }

        public string ModificarRol(E_Rol pEntidades)
        {
            pEntidades.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, pEntidades);
        }
        #endregion

        #region Listados generales de Rol
        // Listado generales de Rols en dormato DateTable y List<E_Sistema>
        public DataTable GetDT_Rol()
        {
            return ObjLst.DT_ListadoGeneral("Rol", "NombreRol, IdRol");
        }

        public List<E_Rol> LstRol()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Rol>(GetDT_Rol());
        }
        #endregion

        #region Busquedad de Roles
        // Busqueda de Rol por diferente Criterio
        public E_Rol BuscarRolPorId(int pIdRol)
        {
            return (from User in LstRol() where User.IdRol == pIdRol select User).FirstOrDefault();
        }
        #endregion
    }

    public class N_UsuarioRol
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBE_UsuarioRol";

        #region INSERTAR, BORRAR y MODIFICAR
        // Acciones de Insertar, Borrar y Modificar los datos del Rol
        public string InsertarUsuarioRol(E_UsuarioRol pEntidades)
        {
            pEntidades.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, pEntidades);
        }

        public string BorrarUsuarioRol(int pIdRol, int pIdUsuario)
        {
            E_UsuarioRol Entidad = new E_UsuarioRol { Accion = "BORRAR", IdRol = pIdRol, IdUsuario = pIdUsuario };
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, Entidad);
        }

        public string ModificarUsuarioRol(E_UsuarioRol pEntidades)
        {
            pEntidades.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, pEntidades);
        }
        #endregion

        #region Listados generales de Rol
        // Listado generales de Rols en dormato DateTable y List<E_Sistema>
        public DataTable GetDT_UsuarioRol()
        {
            return ObjLst.DT_ListadoGeneral("UsuarioRol", "IdUsuario, IdRol");
        }

        public List<E_UsuarioRol> LstUsuarioRol()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_UsuarioRol>(GetDT_UsuarioRol());
        }
        #endregion

        #region Busquedad de Usuario-Roles
        // Busqueda de Rol por diferente Criterio
        public E_UsuarioRol BuscarRolPorIdRol(int pIdRol)
        {
            return (from User in LstUsuarioRol() where User.IdRol == pIdRol select User).FirstOrDefault();
        }
        public E_UsuarioRol BuscarUsuarioRolPorIdUsuario(int pIdUsuario)
        {
            return (from User in LstUsuarioRol() where User.IdUsuario == pIdUsuario select User).FirstOrDefault();
        }
        #endregion
    }

    public class N_Cursos
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBE_Cursos";

        #region INSERTAR, BORRAR y MODIFICAR
        // Acciones de Insertar, Borrar y Modificar los datos del Curso
        public string InsertarCurso(E_Curso pEntidades)
        {
            pEntidades.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Curso>(Sp, pEntidades);
        }

        public string BorrarCurso(int pIdCurso)
        {
            E_Curso Entidad = new E_Curso { Accion = "BORRAR", IdCurso = pIdCurso };
            return ObjIBM.IBM_Entidad<E_Curso>(Sp, Entidad);
        }

        public string ModificarCurso(E_Curso pEntidades)
        {
            pEntidades.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Curso>(Sp, pEntidades);
        }
        #endregion

        #region Listados generales de Curso
        // Listado generales de Usuarios en dormato DateTable y List<E_Sistema>
        public DataTable GetDT_Curso()
        {
            return ObjLst.DT_ListadoGeneral("Curso", "IdCurso, Nombre");
        }

        public List<E_Curso> LstCurso()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Curso>(GetDT_Curso());
        }
        #endregion

        #region Busquedad de Cursos
        // Busqueda de usuario por diferente Criterio
        public E_Curso BuscarCursoPorId(int pIdCurso)
        {
            return (from Curso in LstCurso() where Curso.IdCurso == pIdCurso select Curso).FirstOrDefault();
        }


        public E_Curso BuscarCursoPorNombre(string pNCurso)
        {
            return (from Curso in LstCurso() where Curso.Nombre == pNCurso select Curso).FirstOrDefault();
        }
        #endregion

    }

    public class N_UsuarioCurso
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBE_UsuarioCurso";

        #region INSERTAR, BORRAR y MODIFICAR
        // Acciones de Insertar, Borrar y Modificar los datos del UsuarioCurso
        public string InsertarUsuarioCurso(E_UsuarioCurso pEntidades)
        {
            pEntidades.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_UsuarioCurso>(Sp, pEntidades);
        }

        public string BorrarUsuarioCurso(int pIdCurso, int pIdUsuario)
        {
            E_UsuarioCurso Entidad = new E_UsuarioCurso { Accion = "BORRAR", IdCurso = pIdCurso, IdUsuario = pIdUsuario };
            return ObjIBM.IBM_Entidad<E_UsuarioCurso>(Sp, Entidad);
        }

        public string ModificarUsuarioCurso(E_UsuarioCurso pEntidades)
        {
            pEntidades.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_UsuarioCurso>(Sp, pEntidades);
        }
        #endregion

        #region Listados generales de UsuarioCurso
        // Listado generales de Rols en dormato DateTable y List<E_Sistema>
        public DataTable GetDT_UsuarioCurso()
        {
            return ObjLst.DT_ListadoGeneral("UsuarioCurso", "IdCurso, IdUsuario");
        }

        public List<E_UsuarioCurso> LstUsuarioCurso()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_UsuarioCurso>(GetDT_UsuarioCurso());
        }
        #endregion

        #region Busquedad de Usuario-Curso
        // Busqueda de Rol por diferente Criterio
        public E_UsuarioCurso BuscarCursoPorIdCurso(int pIdCurso)
        {
            return (from User in LstUsuarioCurso() where User.IdCurso == pIdCurso select User).FirstOrDefault();
        }
        public E_UsuarioCurso BuscarUsuarioCursoPorIdUsuario(int pIdUsuario)
        {
            return (from User in LstUsuarioCurso() where User.IdUsuario == pIdUsuario select User).FirstOrDefault();
        }
        #endregion
    }

    public class N_Email
    {
        MailMessage mensaje = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public void EnviarCorreo(E_Email ObjEE)
        {
            try
            {
                mensaje.From = new MailAddress(ObjEE.From);
                mensaje.To.Add(new MailAddress(ObjEE.To));
                mensaje.Body = ObjEE.Msn;
                mensaje.Subject = "Codigo Verificación";

                smtp.Host = "smtp.gmail.com"; //Para enviar correos por gmail
                smtp.Port = 587; //Puerto que utiliza Gmail por defecto
                smtp.Credentials = new NetworkCredential(ObjEE.From, ObjEE.Password);
                smtp.EnableSsl = true;
                smtp.Send(mensaje);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
