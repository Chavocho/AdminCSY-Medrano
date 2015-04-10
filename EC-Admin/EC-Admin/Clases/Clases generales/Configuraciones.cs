using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public class Config
    {
        public static decimal iva = 0M;

        #region Base de datos
        public static string baseDatos = "", servidor = "", usuario = "", pass = "";
        #endregion

        #region Correo
        public static string correoOrigenInterno = "", contraseñaOrigenInterno, correoOrigenExterno = "", contraseñaOrigenExterno = "", puerto = "", host = "";
        #endregion

        #region Sonidos
        public static string rutaSonidoObturador = Application.StartupPath + "\\Sonidos\\obturador.wav";
        #endregion

        #region Sucursal
        public static int idSucursal = 0;
        public static string nombreSucursal = "";
        #endregion
    }
}
