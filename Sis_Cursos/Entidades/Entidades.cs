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
        private string _Nombres;
        private string _Apellidos;
        private string _Email;
        private string _PasswordUsuario;
        #endregion

        #region Constructor
        public E_Usuario()
        {
            _Accion = string.Empty;
            _IdUsuario = 0;
            _Usuario = string.Empty;
            _Nombres = string.Empty;
            _Apellidos = string.Empty;
            _Email = string.Empty;
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
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
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
}
