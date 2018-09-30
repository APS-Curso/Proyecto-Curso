using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private string _Usuario;
        private string _Nombre;
        private string _Apellido;
        private string _Correo;
        private string _PasswordUsuario;
        #endregion

        #region Constructor
        public E_Usuario()
        {
            _Accion = string.Empty;
            _IdUsuario = 0;
            _Usuario = string.Empty;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _Correo = string.Empty;
            _PasswordUsuario = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        public string PasswordUsuario
        {
            get { return _PasswordUsuario; }
            set { _PasswordUsuario = value; }
        }
        #endregion
    }

    public class E_Rol
    {
        #region Atributos
        private int _IdRol;
        private string _Accion;
        private string _NombreRol;
        private string _Descripcion;
        #endregion

        #region Constructor
        public E_Rol()
        {
            _IdRol = 0;
            _Accion = string.Empty;
            _NombreRol = string.Empty;
            _Descripcion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public int IdRol
        {
            get { return _IdRol; }
            set { _IdRol = value; }
        }

        public string Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public string NombreRol
        {
            get { return _NombreRol; }
            set { _NombreRol = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        #endregion
    }

    public class E_UsuarioRol
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private int _IdRol;
        #endregion

        #region Constructor
        public E_UsuarioRol()
        {
            _Accion = string.Empty;
            _IdUsuario = 0;
            _IdRol = 0;
        }
        #endregion

        #region Encampsulamiento

        public string Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public int IdRol
        {
            get { return _IdRol; }
            set { _IdRol = value; }
        }
        #endregion
    }

    public class E_Curso
    {
        #region Atributos
        private string _Accion;
        private int _IdCurso;
        private string _Nombre;
        private string _Descripcion;
        private string _FechaInicio;
        private string _FechaFin;
        #endregion

        #region Constructor
        public E_Curso()
        {
            _Accion = string.Empty;
            _IdCurso = 0;
            _Nombre = string.Empty;
            _Descripcion = string.Empty;
            _FechaInicio = string.Empty;
            _FechaFin = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        public string FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        public string FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
        #endregion
    }

    public class E_UsuarioCurso
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private int _IdCurso;
        #endregion

        #region Constructor
        public E_UsuarioCurso()
        {
            _Accion = string.Empty;
            _IdUsuario = 0;
            _IdCurso = 0;
        }
        #endregion

        #region Encampsulamiento

        public string Accion
        {
            get { return _Accion; }
            set { _Accion = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
        #endregion
    }

    public class E_Email
    {
        #region Atributos
        private string _From;
        private string _Password;
        private string _To;
        private string _Msn;
        #endregion

        #region Constructor
        public E_Email()
        {
            _From = string.Empty;
            _Password = string.Empty;
            _To = string.Empty;
            _Msn = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string From
        {
            get { return _From; }
            set { _From = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string To
        {
            get { return _To; }
            set { _To = value; }
        }
        public string Msn
        {
            get { return _Msn; }
            set { _Msn = value; }
        }
        #endregion

    }
}
