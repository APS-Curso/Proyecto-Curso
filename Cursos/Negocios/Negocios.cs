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
        private string Sp = "IBM_Usuarios";

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
            return ObjLst.DT_ListadoGeneral("tbUsuarios", "Apellidos, Nombres");
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

        public E_Usuario BuscarUsuarioPorEmail(string pEmail)
        {
            return (from User in LstUsuario() where User.Email == pEmail select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorUsuario(string pUsuaruio)
        {
            return (from User in LstUsuario() where User.Usuario == pUsuaruio select User).FirstOrDefault();
        }

        public int ValidaLogin(string pUsuario, string pPassword)
        {
            if ((from User in LstUsuario() where User.Usuario == pUsuario && User.PasswordUsuario == pPassword select User).FirstOrDefault() != null) /*&&
                (from User in LstUsuario() where User.PasswordUsuario == pPassword select User).FirstOrDefault() != null)*/
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
            return ObjLst.DT_ListadoGeneral("tbRoles", "NombreRol");
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
        private string Sp = "IBM_UsuarioRol";

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
            return ObjLst.DT_ListadoGeneral("tbUsuarioRol", "IdRol");
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
