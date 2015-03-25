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
        public static string baseDatos = "", servidor = "", usuario = "", pass = "";
        public static string correoOrigenInterno = "", contraseñaOrigenInterno, 
            correoOrigenExterno = "", contraseñaOrigenExterno = "", puerto = "", host = "";
        #region Sonidos
        public static string rutaSonidoObturador = Application.StartupPath + "\\Sonidos\\obturador.wav";
        #endregion
    }
}
