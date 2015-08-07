using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmPrivilegios : Form
    {
        Privilegios p;
        frmNuevoUsuario frmN = null;
        frmEditarUsuario frmE = null;

        public frmPrivilegios(frmNuevoUsuario frm)
        {
            InitializeComponent();
            this.frmN = frm;
            p = frm.P;
        }

        public frmPrivilegios(frmEditarUsuario frm)
        {
            InitializeComponent();
            this.frmE = frm;
            p = frm.P;
        }

        private void CargarDatos()
        {
            chbCrearApartado.Checked = p.CrearApartado;
            chbEstadoApartado.Checked = p.EstadoApartado;
            chbCaja.Checked = p.Caja;
            chbBanco.Checked = p.Banco;
            chbMovimientoCaja.Checked = p.MovimientoCaja;
            chbMovimientoBanco.Checked = p.MovimientoBanco;
            chbAbrirCerrarCaja.Checked = p.AbrirCerrarCaja;
            chbCortesCaja.Checked = p.CortesCaja;
            chbCrearCliente.Checked = p.CrearCliente;
            chbModificarCliente.Checked = p.ModificarCliente;
            chbEliminarCliente.Checked = p.EliminarCliente;
            chbCrearCompra.Checked = p.CrearCompra;
            chbVisualizarCompra.Checked = p.VisualizarCompra;
            chbCancelarCompra.Checked = p.CancelarCompra;
            chbDevolucionCompra.Checked = p.DevolucionCompra;
            chbConfigGeneral.Checked = p.ConfigGeneral;
            chbConfigCorreo.Checked = p.ConfigCorreo;
            chbConfigBaseDatos.Checked = p.ConfigBaseDatos;
            chbConfigImpresion.Checked = p.ConfigImpresion;
            chbCrearCotizacion.Checked = p.CrearCotizacion;
            chbCrearSucursal.Checked = p.CrearSucursal;
            chbModificarSucursal.Checked = p.ModificarSucursal;
            chbEliminarSucursal.Checked = p.EliminarSucursal;
            chbCambiarSucursal.Checked = p.CambiarSucursal;
            chbCrearProducto.Checked = p.CrearProducto;
            chbModificarProducto.Checked = p.ModificarProducto;
            chbEliminarProducto.Checked = p.EliminarProducto;
            chbTicketProducto.Checked = p.ImprimirTicket;
            chbModificarCantProducto.Checked = p.ModificarCantProducto;
            chbCrearPromocion.Checked = p.CrearPromocion;
            chbModificarPromocion.Checked = p.ModificarPromocion;
            chbEliminarPromocion.Checked = p.EliminarPromocion;
            chbCrearProveedor.Checked = p.CrearProveedor;
            chbModificarProveedor.Checked = p.ModificarProveedor;
            chbEliminarProveedor.Checked = p.EliminarProveedor;
            chbAdministrarHorarioTrabajador.Checked = p.AdministrarHorarioTrabajador;
            chbAdministrarPagosTrabajador.Checked = p.AdministrarPagoTrabajador;
            chbCrearTrabajador.Checked = p.CrearTrabajador;
            chbModificarTrabajador.Checked = p.ModificarTrabajador;
            chbEliminarTrabajador.Checked = p.EliminarTrabajador;
            chbCrearTraspaso.Checked = p.CrearTraspaso;
            chbEstadoTraspaso.Checked = p.EstadoTraspaso;
            chbCrearUsuario.Checked = p.CrearUsuario;
            chbModificarUsuario.Checked = p.ModificarUsuario;
            chbEliminarUsuario.Checked = p.EliminarUsuario;
            chbReestablecerUsuario.Checked = p.ReestablecerUsuario;
            chbAdministrarPrivilegios.Checked = p.AdministrarPermisos;
            chbCrearVenta.Checked = p.CrearVenta;
            chbCancelarVenta.Checked = p.CancelarVenta;
            chbDevolucionVenta.Checked = p.DevolucionVenta;
        }

        private void GuardarDatos()
        {
            p.CrearApartado = chbCrearApartado.Checked;
            p.EstadoApartado = chbEstadoApartado.Checked;
            p.Caja = chbCaja.Checked;
            p.Banco = chbBanco.Checked;
            p.MovimientoCaja = chbMovimientoCaja.Checked;
            p.MovimientoBanco = chbMovimientoBanco.Checked;
            p.AbrirCerrarCaja = chbAbrirCerrarCaja.Checked;
            p.CortesCaja = chbCortesCaja.Checked;
            p.CrearCliente = chbCrearCliente.Checked;
            p.ModificarCliente = chbModificarCliente.Checked;
            p.EliminarCliente = chbEliminarCliente.Checked;
            p.CrearCompra = chbCrearCompra.Checked;
            p.VisualizarCompra = chbVisualizarCompra.Checked;
            p.CancelarCompra = chbCancelarCompra.Checked;
            p.DevolucionCompra = chbDevolucionCompra.Checked;
            p.ConfigGeneral = chbConfigGeneral.Checked;
            p.ConfigCorreo = chbConfigCorreo.Checked;
            p.ConfigBaseDatos = chbConfigBaseDatos.Checked;
            p.ConfigImpresion = chbConfigImpresion.Checked;
            p.CrearSucursal = chbCrearSucursal.Checked;
            p.ModificarSucursal = chbModificarSucursal.Checked;
            p.EliminarSucursal = chbEliminarSucursal.Checked;
            p.CambiarSucursal = chbCambiarSucursal.Checked;
            p.CrearCotizacion = chbCrearCotizacion.Checked;
            p.CrearProducto = chbCrearProducto.Checked;
            p.ModificarProducto = chbModificarProducto.Checked;
            p.EliminarProducto = chbEliminarProducto.Checked;
            p.ImprimirTicket = chbTicketProducto.Checked;
            p.ModificarCantProducto = chbModificarCantProducto.Checked;
            p.CrearPromocion = chbCrearPromocion.Checked;
            p.ModificarPromocion = chbModificarPromocion.Checked;
            p.EliminarPromocion = chbEliminarPromocion.Checked;
            p.CrearProveedor = chbCrearProveedor.Checked;
            p.ModificarProveedor = chbModificarProveedor.Checked;
            p.EliminarProveedor = chbEliminarProveedor.Checked;
            p.AdministrarHorarioTrabajador = chbAdministrarHorarioTrabajador.Checked;
            p.AdministrarPagoTrabajador = chbAdministrarPagosTrabajador.Checked;
            p.CrearTrabajador = chbCrearTrabajador.Checked;
            p.ModificarTrabajador = chbModificarTrabajador.Checked;
            p.EliminarTrabajador = chbEliminarTrabajador.Checked;
            p.CrearTraspaso = chbCrearTraspaso.Checked;
            p.EstadoTraspaso = chbEstadoTraspaso.Checked;
            p.CrearUsuario = chbCrearUsuario.Checked;
            p.ModificarUsuario = chbModificarUsuario.Checked;
            p.EliminarUsuario = chbEliminarUsuario.Checked;
            p.ReestablecerUsuario = chbReestablecerUsuario.Checked;
            p.AdministrarPermisos = chbAdministrarPrivilegios.Checked;
            p.CrearVenta = chbCrearVenta.Checked;
            p.CancelarVenta = chbCancelarVenta.Checked;
            p.DevolucionVenta = chbDevolucionVenta.Checked;
            if (frmN != null)
                frmN.P = p;
            else if (frmE != null)
                frmE.P = p;
        }

        private void frmPrivilegios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            this.Close();
        }
    }
}
